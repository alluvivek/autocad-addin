using System;
using System.Windows.Forms;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Colors;

namespace ProsoftAcPlugin
{
    public partial class PluginForm : Form
    {
        private int _circleColorCount = 0;
        private System.Drawing.Color[] _colors = new System.Drawing.Color[3];
        private const int _circleCount = 3;
        private const string _defaultBloackName = "Concentric Circles";
        private readonly Point3d _basePointCenter = new Point3d(5, 5, 0);
        private readonly double _baseRadius = 3;

        public PluginForm()
        {
            InitializeComponent();
        }



        private void PluginForm_Load(object sender, EventArgs e)
        {
            txtBlockName.Text = _defaultBloackName;
            btnSubmitCircle.Enabled = false;
        }


        private void btnCircle1Color_Click(object sender, EventArgs e)
        {
            setLabelCircleColor(0);
        }

        private void btnCircle2Color_Click(object sender, EventArgs e)
        {
            setLabelCircleColor(1);
        }

        private void btnCircle3Color_Click(object sender, EventArgs e)
        {
            setLabelCircleColor(2);
        }

        private void btnSubmitCircle_Click(object sender, EventArgs e)
        {
            // get the manager and current document
            var documentManager = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager;
            var currentDocument = documentManager.CurrentDocument;
            var database = currentDocument.Database;

            // Lock the current document
            using (DocumentLock docLock = currentDocument.LockDocument())
            {
                // Start a new transaction
                using (var transaction = database.TransactionManager.StartTransaction())
                {
                    // get a table
                    var table = transaction.GetObject(database.BlockTableId,
                                                 OpenMode.ForRead) as BlockTable;
                    //get the blockname to create if not exists
                    var blockname = getBLockname();

                    //add the circles to the current record
                    using (var currentRecord = transaction.GetObject(table[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord)
                    {

                        // Create circles
                        for (var i = _circleCount; i > 0; i--)
                        {
                            var radius = _baseRadius * (i + 1);
                            var circle = makeCircle(_basePointCenter, radius, _colors[i - 1]);

                            // Add circle to the record 

                            currentRecord.AppendEntity(circle);
                            transaction.AddNewlyCreatedDBObject(circle, true);

                            if (i == _circleCount)
                            {
                                var circleCollection = new ObjectIdCollection();
                                circleCollection.Add(circle.ObjectId);

                                using (var circleHatch = new Hatch())
                                {
                                    currentRecord.AppendEntity(circleHatch);
                                    transaction.AddNewlyCreatedDBObject(circleHatch, true);

                                    circleHatch.SetHatchPattern(HatchPatternType.PreDefined, "ANSI32");
                                    circleHatch.Associative = true;
                                    circleHatch.HatchStyle = HatchStyle.Outer;
                                    circleHatch.AppendLoop(HatchLoopTypes.Outermost, circleCollection);
                                    circleHatch.EvaluateHatch(true);
                                }
                            }

                            if (!table.Has(blockname))
                            {

                                using (BlockReference blockRef = new BlockReference(new Point3d(5, 5, 0), currentRecord.Id))
                                {
                                    var record = new BlockTableRecord();//transaction.GetObject(database.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;
                                    record.Name = blockname;
                                    record.AppendEntity(blockRef);
                                    table.UpgradeOpen();
                                    //
                                    table.Add(record);
                                    transaction.AddNewlyCreatedDBObject(record, true);
                                    Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("Concentric Circles has been created.");
                                }
                            }
                        }
                    }
                    // save to the database
                    transaction.Commit();
                }

                // Unlocked the document and disposed transaction
            }

            // Set the new document current
            documentManager.MdiActiveDocument = currentDocument;
        }

        private void txtBlockName_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Set a label color and color for circles
        /// </summary>
        /// <param name="color"></param>
        private void setLabelCircleColor(int indexCircle)
        {
            DialogResult result = circleColorDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var color = circleColorDialog.Color;
                _circleColorCount++;
                switch (indexCircle)
                {
                    case 0:
                        lblCircle1Color.BackColor = color;
                        _colors[indexCircle] = color;
                        break;
                    case 1:
                        lblCircle2Color.BackColor = color;
                        _colors[indexCircle] = color;
                        break;
                    case 2:
                        lblCircle3Color.BackColor = color;
                        _colors[indexCircle] = color;
                        break;
                    default:

                        break;
                }

                if (_circleColorCount >= _circleCount)
                {
                    btnSubmitCircle.Enabled = true;
                }
            }
            else
            {
                if (_circleColorCount < _circleCount)
                {
                    btnSubmitCircle.Enabled = false;
                }
            }


        }

        /// <summary>
        /// Get a circle with the center and radius sent
        /// </summary>
        /// <param name="center"></param>
        /// <param name="radius"></param>
        /// <param name="index"></param>
        /// <returns>Autodesk.AutoCAD.DatabaseServices.Circle</returns>
        private Circle makeCircle(Point3d center, double radius, System.Drawing.Color color)
        {
            Circle circle = new Circle();
            circle.SetDatabaseDefaults();
            circle.Center = center;
            circle.Radius = radius;
            circle.Color = Color.FromColor(color);
            return circle;
        }

        /// <summary>
        /// Get the block name if is set in the text field
        /// </summary>
        /// <returns>string</returns>
        private string getBLockname()
        {
            if (!string.IsNullOrEmpty(txtBlockName.Text))
            {
                return txtBlockName.Text.Trim();
            }

            return _defaultBloackName;
        }
    }
}

            /*          
            // Lock the current document
            using (DocumentLock docLock = currentDocument.LockDocument())
            {
                // Start a new transaction
                using (var transaction = database.TransactionManager.StartTransaction())
                {
                    // get a table
                    var table = transaction.GetObject(database.BlockTableId,
                                                 OpenMode.ForRead) as BlockTable;


                    //create a block if not exists
                    var blockname = getBLockname();
                    if (!table.Has(blockname))
                    {
                       
                        using (BlockTableRecord record = new BlockTableRecord())
                        {
                            record.Name = blockname;
                            record.Origin = new Point3d(5, 5, 0);


                           
                            // Create circles
                            for (var i = 0; i < _circleCount; i++)
                            {
                                var radius = _baseRadius * (i + 1);
                                var circle = makeCircle(_basePointCenter, radius, _colors[i]);

                                // Add circle to the record 
                                record.AppendEntity(circle);
                            }

                            table.UpgradeOpen();
                            table.Add(record);
                            transaction.AddNewlyCreatedDBObject(record, true);
                            
                            foreach(ObjectId asObjId in record)
                            {
                                // Create the hatch object and append it to the block table record
                                using (Hatch circleHatch = new Hatch())
                                {
                                    var circleCollection = new ObjectIdCollection();
                                    circleCollection.Add(asObjId);
                                    circleHatch.SetDatabaseDefaults();


                                    circleHatch.SetHatchPattern(HatchPatternType.PreDefined, "ANSI31");
                                    record.AppendEntity(circleHatch);
                                    transaction.AddNewlyCreatedDBObject(circleHatch, true);

                                    // Set the properties of the hatch object
                                    // Associative must be set after the hatch object is appended to the 
                                    // block table record and before AppendLoop
                                    circleHatch.Associative = false;
                                    circleHatch.AppendLoop(HatchLoopTypes.DEFA, circleCollection);
                                    circleHatch.EvaluateHatch(true);
                                }
                            }
                            // Insert the created block
                            using (BlockReference blockRef = new BlockReference(new Point3d(5, 5, 0), record.Id))
                            {
                                var existingRecord = transaction.GetObject(database.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;
                                existingRecord.AppendEntity(blockRef);
                                transaction.AddNewlyCreatedDBObject(blockRef, true);
                                Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("Concentric Circles has been created.");
                     */      