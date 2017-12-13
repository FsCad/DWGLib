using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using System.Windows.Forms;
using System.IO;

namespace DWGLib.Class
{
   
    public class MyDropTarget : Autodesk.AutoCAD.Windows.DropTarget
    {
        public string filePath;
        public static int InstanceNum = 0;
        public MyDropTarget(string filePath) : base()
        {
            this.filePath = filePath;
        }
        public void Dispose() {

        }
        //鼠标移开的时候
        public override void OnDragLeave()
        {
            this.Dispose(); 
            base.OnDragLeave();
        }
        //鼠标悬停在上空的时候
        public override void OnDragOver(DragEventArgs e)
        {
            base.OnDragOver(e);
        }
        //鼠标松开的时候插入CAD文件，并终止trans，以及析构trans，同时接触文件的锁定。
        public override void OnDrop(DragEventArgs e)
        {
            

            System.Drawing.Point TempPt = new System.Drawing.Point(e.X, e.Y);
            //单纯使用this.Ed.PointToWord(Pt),会出现问题
            
            ErrorStatus Stat = this.InsertDWGFile(TempPt);
            switch (Stat)
            {
                case ErrorStatus.InvalidDwgVersion:
                    Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("待引入的DWG文件版本过高，引入失败,请将图库文件转换成更低的版本");
                    break;
                case ErrorStatus.CantOpenFile:
                    Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("异常，插入图库失败");
                    break;
                case ErrorStatus.UnsupportedFileFormat:
                    Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("错误，不支持的文件格式");
                    break;
                case ErrorStatus.FileNotFound:
                    Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("错误，未找到相应文件");
                    break;
                default:
                    break;
            }
            this.Dispose();
        }
        private ErrorStatus InsertDWGFile(System.Drawing.Point TempPt)
        {
            Editor Ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            DocumentLock DocLock = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.LockDocument();
            Database CurrentDwg = Ed.Document.Database;
            Point3d Position = Ed.PointToWorld(TempPt, Ed.GetViewportNumber(TempPt));
            using (Transaction Trans = CurrentDwg.TransactionManager.StartTransaction())
            {
                if (!File.Exists(this.filePath))
                {
                    Ed.WriteMessage("插入失败，文件" + this.filePath + "未找到" + "\n");
                    return ErrorStatus.FileNotFound;
                }
                string EntinityName = Path.GetFileNameWithoutExtension(this.filePath);
                BlockTable TargetBlockTable = Trans.GetObject(CurrentDwg.BlockTableId, OpenMode.ForWrite) as BlockTable;
                BlockTableRecord ModelSpace = (BlockTableRecord)SymbolUtilityServices.GetBlockModelSpaceId(CurrentDwg).GetObject(OpenMode.ForWrite);
                Database SourceDB = new Database(false, false);
                ErrorStatus stat = this.GetInsertDwgFile(ref SourceDB);
                string FileName = Path.GetFileNameWithoutExtension(this.filePath);
                if (stat != ErrorStatus.OK) return stat;
                try
                {
                    ObjectId BlockId;
                    BlockReference BlockRef;
                    if (!TargetBlockTable.Has(FileName + "_^_" + InstanceNum))
                    {
                        try
                        {
                            InstanceNum++;
                            BlockId = CurrentDwg.Insert(FileName + "_^_" + InstanceNum, SourceDB, true);
                        }catch(Autodesk.AutoCAD.Runtime.Exception Ex)
                        {
                            Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog(Ex.Message);
                            return ErrorStatus.CantOpenFile;
                        }
                       
                    }else
                    {
                        BlockId = TargetBlockTable[FileName + "_^_" + InstanceNum];
                    }
                   
                    BlockRef = new BlockReference(Position, BlockId);

                    if(BlockRef.Bounds != null)
                    {
                        Point3d MinPt1 = BlockRef.Bounds.Value.MinPoint;
                        Point3d MaxPt2 = BlockRef.Bounds.Value.MaxPoint;

                        Point3d CenterPt = new Point3d((MaxPt2.X + MinPt1.X) * 0.5, (MaxPt2.Y + MinPt1.Y) * 0.5, (MaxPt2.Z + MinPt1.Z) * 0.5);
                        BlockRef.TransformBy(Matrix3d.Displacement(Position - CenterPt));
                    }

                    ModelSpace.AppendEntity(BlockRef);
                   
                    Trans.AddNewlyCreatedDBObject(BlockRef, true);
                    Trans.Commit();

                    if (DocLock != null) DocLock.Dispose();
                    if (CurrentDwg != null) CurrentDwg.Dispose();
                    SourceDB.Dispose();
                    return ErrorStatus.OK;

                }
                catch (Autodesk.AutoCAD.Runtime.Exception ex)
                {
                    Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog(ex.Message);
                    Trans.Commit();

                    if (DocLock != null) DocLock.Dispose();
                    if (CurrentDwg != null) CurrentDwg.Dispose();
                    SourceDB.Dispose();
                    return ErrorStatus.CantOpenFile;
                }
            }

        }
        private void CloneBlockFromSourceToTarget(Database SourceDB, Database TargetDB)
        {
            ObjectIdCollection ObjIds = new ObjectIdCollection();
            using (Transaction SourceTran = SourceDB.TransactionManager.StartTransaction())
            {
                BlockTable SourceBlockTable = SourceTran.GetObject(SourceDB.BlockTableId, OpenMode.ForRead) as BlockTable;
                
                using (Transaction TargetTran = TargetDB.TransactionManager.StartTransaction())
                {

                    BlockTable TargetBlockTable = SourceTran.GetObject(SourceDB.BlockTableId, OpenMode.ForRead) as BlockTable;
                    foreach(ObjectId item in SourceBlockTable)
                    {
                        if (!TargetBlockTable.Has(item))
                        {
                            ObjIds.Add(item);
                        }
                        TargetDB.WblockCloneObjects(ObjIds, TargetDB.BlockTableId, new IdMapping(), DuplicateRecordCloning.Ignore, true);
                        TargetTran.Commit();
                    }
                }
            }
        }
        private void CloneModelSpaceDataFromSourceToTarget(Database SourceDB, Database TargetDB)
        {
            using(Transaction SourceTran = SourceDB.TransactionManager.StartTransaction())
            {
                BlockTableRecord SourceModelSpace = (BlockTableRecord)SymbolUtilityServices.GetBlockModelSpaceId(SourceDB).GetObject(OpenMode.ForRead);
                BlockTable SourceBlockTable = SourceTran.GetObject(SourceDB.BlockTableId, OpenMode.ForRead) as BlockTable;
                using (Transaction TargetTran = TargetDB.TransactionManager.StartTransaction())
                {
                    BlockTable TargetBlockTable = TargetTran.GetObject(TargetDB.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord TargetModelSpace = (BlockTableRecord)SymbolUtilityServices.GetBlockModelSpaceId(TargetDB).GetObject(OpenMode.ForRead);
                    foreach(ObjectId item in SourceModelSpace)
                    {
                        DBObject Rec = SourceTran.GetObject(item, OpenMode.ForRead);
                        System.Diagnostics.Debug.WriteLine(Rec.GetType());
                        Entity Ent = Rec as Entity;
                        if (Ent != null)
                        {
                            if (!TargetBlockTable.Has(Ent.BlockName)){
                                TargetModelSpace.AppendEntity(Ent);
                                TargetTran.AddNewlyCreatedDBObject(Rec, true);
                            }
                        }
                    }
                    TargetTran.Commit();
                }
            }
        }
        private void CurrentDwg_InsertAborted(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CurrentDwg_InsertEnded(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private ErrorStatus GetInsertDwgFile(ref Database db)
        {
            if (!File.Exists(filePath))
            {
                return ErrorStatus.FileNotFound;
            }
            if (Path.GetExtension(filePath).ToLower() == ".dwg")
            {
                try
                {
                    db.ReadDwgFile(filePath, FileOpenMode.OpenForReadAndReadShare, true, "");
                    db.CloseInput(true);
                    return ErrorStatus.OK;
                }
                catch(System.NotImplementedException)
                {
                    return ErrorStatus.InvalidDwgVersion;
                }
                catch
                {
                    return ErrorStatus.CantOpenFile;

                }
            }else
            {
                return ErrorStatus.UnsupportedFileFormat;
            }
        }
        public override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);
        }
    }
}

