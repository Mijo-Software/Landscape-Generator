namespace LandscapeGenerator
{
  partial class EditTerrainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTerrainForm));
			this.nudShiftTerrainStep = new System.Windows.Forms.NumericUpDown();
			this.labelShiftTerrainStep = new System.Windows.Forms.Label();
			this.rbtnCanyonizeVar = new System.Windows.Forms.RadioButton();
			this.labelTerrainName = new System.Windows.Forms.Label();
			this.gboxShiftTerrain = new System.Windows.Forms.GroupBox();
			this.buttonShiftTerrainSE = new System.Windows.Forms.Button();
			this.buttonShiftTerrainS = new System.Windows.Forms.Button();
			this.buttonShiftTerrainSW = new System.Windows.Forms.Button();
			this.buttonShiftTerrainE = new System.Windows.Forms.Button();
			this.buttonShiftTerrainBackward = new System.Windows.Forms.Button();
			this.buttonShiftTerrainW = new System.Windows.Forms.Button();
			this.buttonShiftTerrainNE = new System.Windows.Forms.Button();
			this.buttonShiftTerrainN = new System.Windows.Forms.Button();
			this.buttonShiftTerrainNW = new System.Windows.Forms.Button();
			this.gboxPlane = new System.Windows.Forms.GroupBox();
			this.nudPlaneStep = new System.Windows.Forms.NumericUpDown();
			this.buttonDecreasePlane = new System.Windows.Forms.Button();
			this.labelPlaneStep = new System.Windows.Forms.Label();
			this.buttonIncreasePlane = new System.Windows.Forms.Button();
			this.rbtnCanyonizeConst = new System.Windows.Forms.RadioButton();
			this.szComment = new System.Windows.Forms.TextBox();
			this.labelComment = new System.Windows.Forms.Label();
			this.szTerrainName = new System.Windows.Forms.TextBox();
			this.gboxPreviewOfTerrain = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gboxCanyonize = new System.Windows.Forms.GroupBox();
			this.buttonCanyonize = new System.Windows.Forms.Button();
			this.gboxMirror = new System.Windows.Forms.GroupBox();
			this.buttonMirrorVertical = new System.Windows.Forms.Button();
			this.buttonMirrorHorizontal = new System.Windows.Forms.Button();
			this.gboxRotation = new System.Windows.Forms.GroupBox();
			this.buttonRotateRight90 = new System.Windows.Forms.Button();
			this.buttonRotateLeft90 = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonViewTerrainFull = new System.Windows.Forms.Button();
			this.buttonSmooth = new System.Windows.Forms.Button();
			this.buttonInvert = new System.Windows.Forms.Button();
			this.labelProgress = new System.Windows.Forms.Label();
			this.prgsbarEditTerrain = new System.Windows.Forms.ProgressBar();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.nudShiftTerrainStep)).BeginInit();
			this.gboxShiftTerrain.SuspendLayout();
			this.gboxPlane.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPlaneStep)).BeginInit();
			this.gboxPreviewOfTerrain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gboxCanyonize.SuspendLayout();
			this.gboxMirror.SuspendLayout();
			this.gboxRotation.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// nudShiftTerrainStep
			// 
			this.nudShiftTerrainStep.Location = new System.Drawing.Point(26, 133);
			this.nudShiftTerrainStep.Name = "nudShiftTerrainStep";
			this.nudShiftTerrainStep.Size = new System.Drawing.Size(43, 20);
			this.nudShiftTerrainStep.TabIndex = 10;
			this.toolTip.SetToolTip(this.nudShiftTerrainStep, "Wählen der Schrittweite zur Verschiebung");
			// 
			// labelShiftTerrainStep
			// 
			this.labelShiftTerrainStep.AutoSize = true;
			this.labelShiftTerrainStep.Location = new System.Drawing.Point(7, 117);
			this.labelShiftTerrainStep.Name = "labelShiftTerrainStep";
			this.labelShiftTerrainStep.Size = new System.Drawing.Size(62, 13);
			this.labelShiftTerrainStep.TabIndex = 9;
			this.labelShiftTerrainStep.Text = "Schrittweite";
			// 
			// rbtnCanyonizeVar
			// 
			this.rbtnCanyonizeVar.AutoSize = true;
			this.rbtnCanyonizeVar.Location = new System.Drawing.Point(18, 36);
			this.rbtnCanyonizeVar.Name = "rbtnCanyonizeVar";
			this.rbtnCanyonizeVar.Size = new System.Drawing.Size(93, 17);
			this.rbtnCanyonizeVar.TabIndex = 1;
			this.rbtnCanyonizeVar.TabStop = true;
			this.rbtnCanyonizeVar.Text = "Variabel (1-10)";
			this.toolTip.SetToolTip(this.rbtnCanyonizeVar, "Variables \"Canyonize\" des Terrains");
			this.rbtnCanyonizeVar.UseVisualStyleBackColor = true;
			// 
			// labelTerrainName
			// 
			this.labelTerrainName.AutoSize = true;
			this.labelTerrainName.Location = new System.Drawing.Point(12, 9);
			this.labelTerrainName.Name = "labelTerrainName";
			this.labelTerrainName.Size = new System.Drawing.Size(91, 13);
			this.labelTerrainName.TabIndex = 0;
			this.labelTerrainName.Text = "Name des Terrain";
			// 
			// gboxShiftTerrain
			// 
			this.gboxShiftTerrain.Controls.Add(this.nudShiftTerrainStep);
			this.gboxShiftTerrain.Controls.Add(this.labelShiftTerrainStep);
			this.gboxShiftTerrain.Controls.Add(this.buttonShiftTerrainSE);
			this.gboxShiftTerrain.Controls.Add(this.buttonShiftTerrainS);
			this.gboxShiftTerrain.Controls.Add(this.buttonShiftTerrainSW);
			this.gboxShiftTerrain.Controls.Add(this.buttonShiftTerrainE);
			this.gboxShiftTerrain.Controls.Add(this.buttonShiftTerrainBackward);
			this.gboxShiftTerrain.Controls.Add(this.buttonShiftTerrainW);
			this.gboxShiftTerrain.Controls.Add(this.buttonShiftTerrainNE);
			this.gboxShiftTerrain.Controls.Add(this.buttonShiftTerrainN);
			this.gboxShiftTerrain.Controls.Add(this.buttonShiftTerrainNW);
			this.gboxShiftTerrain.Location = new System.Drawing.Point(254, 175);
			this.gboxShiftTerrain.Name = "gboxShiftTerrain";
			this.gboxShiftTerrain.Size = new System.Drawing.Size(96, 170);
			this.gboxShiftTerrain.TabIndex = 12;
			this.gboxShiftTerrain.TabStop = false;
			this.gboxShiftTerrain.Text = "Verschiebung";
			// 
			// buttonShiftTerrainSE
			// 
			this.buttonShiftTerrainSE.Image = ((System.Drawing.Image)(resources.GetObject("buttonShiftTerrainSE.Image")));
			this.buttonShiftTerrainSE.Location = new System.Drawing.Point(65, 78);
			this.buttonShiftTerrainSE.Name = "buttonShiftTerrainSE";
			this.buttonShiftTerrainSE.Size = new System.Drawing.Size(23, 23);
			this.buttonShiftTerrainSE.TabIndex = 8;
			this.toolTip.SetToolTip(this.buttonShiftTerrainSE, "Verschieben des Terrain nach rechts unten");
			this.buttonShiftTerrainSE.UseVisualStyleBackColor = true;
			this.buttonShiftTerrainSE.Click += new System.EventHandler(this.ButtonShiftTerrainSE_Click);
			// 
			// buttonShiftTerrainS
			// 
			this.buttonShiftTerrainS.Image = ((System.Drawing.Image)(resources.GetObject("buttonShiftTerrainS.Image")));
			this.buttonShiftTerrainS.Location = new System.Drawing.Point(36, 78);
			this.buttonShiftTerrainS.Name = "buttonShiftTerrainS";
			this.buttonShiftTerrainS.Size = new System.Drawing.Size(23, 23);
			this.buttonShiftTerrainS.TabIndex = 7;
			this.toolTip.SetToolTip(this.buttonShiftTerrainS, "Verschieben des Terrain nach unten");
			this.buttonShiftTerrainS.UseVisualStyleBackColor = true;
			this.buttonShiftTerrainS.Click += new System.EventHandler(this.ButtonShiftTerrainS_Click);
			// 
			// buttonShiftTerrainSW
			// 
			this.buttonShiftTerrainSW.Image = ((System.Drawing.Image)(resources.GetObject("buttonShiftTerrainSW.Image")));
			this.buttonShiftTerrainSW.Location = new System.Drawing.Point(7, 78);
			this.buttonShiftTerrainSW.Name = "buttonShiftTerrainSW";
			this.buttonShiftTerrainSW.Size = new System.Drawing.Size(23, 23);
			this.buttonShiftTerrainSW.TabIndex = 6;
			this.toolTip.SetToolTip(this.buttonShiftTerrainSW, "Verschieben des Terrain nach links unten");
			this.buttonShiftTerrainSW.UseVisualStyleBackColor = true;
			this.buttonShiftTerrainSW.Click += new System.EventHandler(this.ButtonShiftTerrainSW_Click);
			// 
			// buttonShiftTerrainE
			// 
			this.buttonShiftTerrainE.Image = ((System.Drawing.Image)(resources.GetObject("buttonShiftTerrainE.Image")));
			this.buttonShiftTerrainE.Location = new System.Drawing.Point(65, 49);
			this.buttonShiftTerrainE.Name = "buttonShiftTerrainE";
			this.buttonShiftTerrainE.Size = new System.Drawing.Size(23, 23);
			this.buttonShiftTerrainE.TabIndex = 5;
			this.toolTip.SetToolTip(this.buttonShiftTerrainE, "Verschieben des Terrain nach rechts");
			this.buttonShiftTerrainE.UseVisualStyleBackColor = true;
			this.buttonShiftTerrainE.Click += new System.EventHandler(this.ButtonShiftTerrainE_Click);
			// 
			// buttonShiftTerrainBackward
			// 
			this.buttonShiftTerrainBackward.Image = ((System.Drawing.Image)(resources.GetObject("buttonShiftTerrainBackward.Image")));
			this.buttonShiftTerrainBackward.Location = new System.Drawing.Point(36, 49);
			this.buttonShiftTerrainBackward.Name = "buttonShiftTerrainBackward";
			this.buttonShiftTerrainBackward.Size = new System.Drawing.Size(23, 23);
			this.buttonShiftTerrainBackward.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonShiftTerrainBackward, "Zurücksetzen der Verschiebung");
			this.buttonShiftTerrainBackward.UseVisualStyleBackColor = true;
			this.buttonShiftTerrainBackward.Click += new System.EventHandler(this.ButtonShiftTerrainBackward_Click);
			// 
			// buttonShiftTerrainW
			// 
			this.buttonShiftTerrainW.Image = ((System.Drawing.Image)(resources.GetObject("buttonShiftTerrainW.Image")));
			this.buttonShiftTerrainW.Location = new System.Drawing.Point(7, 49);
			this.buttonShiftTerrainW.Name = "buttonShiftTerrainW";
			this.buttonShiftTerrainW.Size = new System.Drawing.Size(23, 23);
			this.buttonShiftTerrainW.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonShiftTerrainW, "Verschieben des Terrain nach links");
			this.buttonShiftTerrainW.UseVisualStyleBackColor = true;
			this.buttonShiftTerrainW.Click += new System.EventHandler(this.ButtonShiftTerrainW_Click);
			// 
			// buttonShiftTerrainNE
			// 
			this.buttonShiftTerrainNE.Image = ((System.Drawing.Image)(resources.GetObject("buttonShiftTerrainNE.Image")));
			this.buttonShiftTerrainNE.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.buttonShiftTerrainNE.Location = new System.Drawing.Point(65, 20);
			this.buttonShiftTerrainNE.Name = "buttonShiftTerrainNE";
			this.buttonShiftTerrainNE.Size = new System.Drawing.Size(23, 23);
			this.buttonShiftTerrainNE.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonShiftTerrainNE, "Verschieben des Terrain nach rechts oben");
			this.buttonShiftTerrainNE.UseVisualStyleBackColor = true;
			this.buttonShiftTerrainNE.Click += new System.EventHandler(this.ButtonShiftTerrainNE_Click);
			// 
			// buttonShiftTerrainN
			// 
			this.buttonShiftTerrainN.Image = ((System.Drawing.Image)(resources.GetObject("buttonShiftTerrainN.Image")));
			this.buttonShiftTerrainN.Location = new System.Drawing.Point(36, 20);
			this.buttonShiftTerrainN.Name = "buttonShiftTerrainN";
			this.buttonShiftTerrainN.Size = new System.Drawing.Size(23, 23);
			this.buttonShiftTerrainN.TabIndex = 1;
			this.toolTip.SetToolTip(this.buttonShiftTerrainN, "Verschieben des Terrain nach oben");
			this.buttonShiftTerrainN.UseVisualStyleBackColor = true;
			this.buttonShiftTerrainN.Click += new System.EventHandler(this.ButtonShiftTerrainN_Click);
			// 
			// buttonShiftTerrainNW
			// 
			this.buttonShiftTerrainNW.Image = ((System.Drawing.Image)(resources.GetObject("buttonShiftTerrainNW.Image")));
			this.buttonShiftTerrainNW.Location = new System.Drawing.Point(7, 20);
			this.buttonShiftTerrainNW.Name = "buttonShiftTerrainNW";
			this.buttonShiftTerrainNW.Size = new System.Drawing.Size(23, 23);
			this.buttonShiftTerrainNW.TabIndex = 0;
			this.toolTip.SetToolTip(this.buttonShiftTerrainNW, "Verschieben des Terrain nach links oben");
			this.buttonShiftTerrainNW.UseVisualStyleBackColor = true;
			this.buttonShiftTerrainNW.Click += new System.EventHandler(this.ButtonShiftTerrainNW_Click);
			// 
			// gboxPlane
			// 
			this.gboxPlane.Controls.Add(this.nudPlaneStep);
			this.gboxPlane.Controls.Add(this.buttonDecreasePlane);
			this.gboxPlane.Controls.Add(this.labelPlaneStep);
			this.gboxPlane.Controls.Add(this.buttonIncreasePlane);
			this.gboxPlane.Location = new System.Drawing.Point(3, 93);
			this.gboxPlane.Name = "gboxPlane";
			this.gboxPlane.Size = new System.Drawing.Size(100, 117);
			this.gboxPlane.TabIndex = 4;
			this.gboxPlane.TabStop = false;
			this.gboxPlane.Text = "Ebene";
			this.gboxPlane.UseCompatibleTextRendering = true;
			// 
			// nudPlaneStep
			// 
			this.nudPlaneStep.Location = new System.Drawing.Point(26, 92);
			this.nudPlaneStep.Name = "nudPlaneStep";
			this.nudPlaneStep.Size = new System.Drawing.Size(43, 20);
			this.nudPlaneStep.TabIndex = 3;
			this.toolTip.SetToolTip(this.nudPlaneStep, "Wählen der Schrittweite für die Ebene");
			// 
			// buttonDecreasePlane
			// 
			this.buttonDecreasePlane.Image = ((System.Drawing.Image)(resources.GetObject("buttonDecreasePlane.Image")));
			this.buttonDecreasePlane.Location = new System.Drawing.Point(12, 50);
			this.buttonDecreasePlane.Name = "buttonDecreasePlane";
			this.buttonDecreasePlane.Size = new System.Drawing.Size(75, 23);
			this.buttonDecreasePlane.TabIndex = 1;
			this.buttonDecreasePlane.Text = "&Senken";
			this.buttonDecreasePlane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonDecreasePlane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonDecreasePlane, "Senken der Ebene");
			this.buttonDecreasePlane.UseVisualStyleBackColor = true;
			this.buttonDecreasePlane.Click += new System.EventHandler(this.ButtonDecreasePlane_Click);
			// 
			// labelPlaneStep
			// 
			this.labelPlaneStep.AutoSize = true;
			this.labelPlaneStep.Location = new System.Drawing.Point(9, 76);
			this.labelPlaneStep.Name = "labelPlaneStep";
			this.labelPlaneStep.Size = new System.Drawing.Size(62, 13);
			this.labelPlaneStep.TabIndex = 2;
			this.labelPlaneStep.Text = "Schrittweite";
			// 
			// buttonIncreasePlane
			// 
			this.buttonIncreasePlane.Image = ((System.Drawing.Image)(resources.GetObject("buttonIncreasePlane.Image")));
			this.buttonIncreasePlane.Location = new System.Drawing.Point(12, 19);
			this.buttonIncreasePlane.Name = "buttonIncreasePlane";
			this.buttonIncreasePlane.Size = new System.Drawing.Size(75, 23);
			this.buttonIncreasePlane.TabIndex = 0;
			this.buttonIncreasePlane.Text = "&Erhöhen";
			this.buttonIncreasePlane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonIncreasePlane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonIncreasePlane, "Erhöhen der Ebene");
			this.buttonIncreasePlane.UseVisualStyleBackColor = true;
			this.buttonIncreasePlane.Click += new System.EventHandler(this.ButtonIncreasePlane_Click);
			// 
			// rbtnCanyonizeConst
			// 
			this.rbtnCanyonizeConst.AutoSize = true;
			this.rbtnCanyonizeConst.Location = new System.Drawing.Point(18, 19);
			this.rbtnCanyonizeConst.Name = "rbtnCanyonizeConst";
			this.rbtnCanyonizeConst.Size = new System.Drawing.Size(67, 17);
			this.rbtnCanyonizeConst.TabIndex = 0;
			this.rbtnCanyonizeConst.TabStop = true;
			this.rbtnCanyonizeConst.Text = "Konstant";
			this.toolTip.SetToolTip(this.rbtnCanyonizeConst, "Konstantes \"Canyonize\" des Terrains");
			this.rbtnCanyonizeConst.UseVisualStyleBackColor = true;
			// 
			// szComment
			// 
			this.szComment.Location = new System.Drawing.Point(15, 66);
			this.szComment.Name = "szComment";
			this.szComment.Size = new System.Drawing.Size(224, 20);
			this.szComment.TabIndex = 3;
			this.toolTip.SetToolTip(this.szComment, "Eingabe eines Kommentars");
			// 
			// labelComment
			// 
			this.labelComment.AutoSize = true;
			this.labelComment.Location = new System.Drawing.Point(12, 49);
			this.labelComment.Name = "labelComment";
			this.labelComment.Size = new System.Drawing.Size(60, 13);
			this.labelComment.TabIndex = 2;
			this.labelComment.Text = "Kommentar";
			// 
			// szTerrainName
			// 
			this.szTerrainName.Location = new System.Drawing.Point(15, 26);
			this.szTerrainName.Name = "szTerrainName";
			this.szTerrainName.Size = new System.Drawing.Size(224, 20);
			this.szTerrainName.TabIndex = 1;
			this.toolTip.SetToolTip(this.szTerrainName, "Eingabe der Name des Terrains");
			// 
			// gboxPreviewOfTerrain
			// 
			this.gboxPreviewOfTerrain.Controls.Add(this.pictureBox1);
			this.gboxPreviewOfTerrain.Location = new System.Drawing.Point(245, 12);
			this.gboxPreviewOfTerrain.Name = "gboxPreviewOfTerrain";
			this.gboxPreviewOfTerrain.Size = new System.Drawing.Size(125, 127);
			this.gboxPreviewOfTerrain.TabIndex = 10;
			this.gboxPreviewOfTerrain.TabStop = false;
			this.gboxPreviewOfTerrain.Text = "Vorschau";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LandscapeGenerator.Properties.Resources.terrain_test2;
			this.pictureBox1.Location = new System.Drawing.Point(9, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// gboxCanyonize
			// 
			this.gboxCanyonize.Controls.Add(this.buttonCanyonize);
			this.gboxCanyonize.Controls.Add(this.rbtnCanyonizeVar);
			this.gboxCanyonize.Controls.Add(this.rbtnCanyonizeConst);
			this.gboxCanyonize.Location = new System.Drawing.Point(109, 205);
			this.gboxCanyonize.Name = "gboxCanyonize";
			this.gboxCanyonize.Size = new System.Drawing.Size(130, 93);
			this.gboxCanyonize.TabIndex = 7;
			this.gboxCanyonize.TabStop = false;
			this.gboxCanyonize.Text = "Canyonize";
			this.gboxCanyonize.UseCompatibleTextRendering = true;
			// 
			// buttonCanyonize
			// 
			this.buttonCanyonize.Image = ((System.Drawing.Image)(resources.GetObject("buttonCanyonize.Image")));
			this.buttonCanyonize.Location = new System.Drawing.Point(18, 59);
			this.buttonCanyonize.Name = "buttonCanyonize";
			this.buttonCanyonize.Size = new System.Drawing.Size(93, 23);
			this.buttonCanyonize.TabIndex = 2;
			this.buttonCanyonize.Text = "&Canyonize";
			this.buttonCanyonize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCanyonize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCanyonize, "\"Canyonize\" des Terrains");
			this.buttonCanyonize.UseVisualStyleBackColor = true;
			this.buttonCanyonize.Click += new System.EventHandler(this.ButtonCanyonize_Click);
			// 
			// gboxMirror
			// 
			this.gboxMirror.Controls.Add(this.buttonMirrorVertical);
			this.gboxMirror.Controls.Add(this.buttonMirrorHorizontal);
			this.gboxMirror.Location = new System.Drawing.Point(3, 216);
			this.gboxMirror.Name = "gboxMirror";
			this.gboxMirror.Size = new System.Drawing.Size(100, 82);
			this.gboxMirror.TabIndex = 6;
			this.gboxMirror.TabStop = false;
			this.gboxMirror.Text = "Spiegelung";
			// 
			// buttonMirrorVertical
			// 
			this.buttonMirrorVertical.Image = ((System.Drawing.Image)(resources.GetObject("buttonMirrorVertical.Image")));
			this.buttonMirrorVertical.Location = new System.Drawing.Point(7, 50);
			this.buttonMirrorVertical.Name = "buttonMirrorVertical";
			this.buttonMirrorVertical.Size = new System.Drawing.Size(87, 23);
			this.buttonMirrorVertical.TabIndex = 1;
			this.buttonMirrorVertical.Text = "&Vertikal";
			this.buttonMirrorVertical.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMirrorVertical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonMirrorVertical, "Vertikal spiegeln");
			this.buttonMirrorVertical.UseVisualStyleBackColor = true;
			this.buttonMirrorVertical.Click += new System.EventHandler(this.ButtonMirrorVertical_Click);
			// 
			// buttonMirrorHorizontal
			// 
			this.buttonMirrorHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("buttonMirrorHorizontal.Image")));
			this.buttonMirrorHorizontal.Location = new System.Drawing.Point(7, 20);
			this.buttonMirrorHorizontal.Name = "buttonMirrorHorizontal";
			this.buttonMirrorHorizontal.Size = new System.Drawing.Size(87, 23);
			this.buttonMirrorHorizontal.TabIndex = 0;
			this.buttonMirrorHorizontal.Text = "&Horizontal";
			this.buttonMirrorHorizontal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMirrorHorizontal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonMirrorHorizontal, "Horizontal spiegeln");
			this.buttonMirrorHorizontal.UseVisualStyleBackColor = true;
			this.buttonMirrorHorizontal.Click += new System.EventHandler(this.ButtonMirrorHorizontal_Click);
			// 
			// gboxRotation
			// 
			this.gboxRotation.Controls.Add(this.buttonRotateRight90);
			this.gboxRotation.Controls.Add(this.buttonRotateLeft90);
			this.gboxRotation.Location = new System.Drawing.Point(109, 93);
			this.gboxRotation.Name = "gboxRotation";
			this.gboxRotation.Size = new System.Drawing.Size(130, 82);
			this.gboxRotation.TabIndex = 5;
			this.gboxRotation.TabStop = false;
			this.gboxRotation.Text = "Drehung";
			this.gboxRotation.UseCompatibleTextRendering = true;
			// 
			// buttonRotateRight90
			// 
			this.buttonRotateRight90.Image = ((System.Drawing.Image)(resources.GetObject("buttonRotateRight90.Image")));
			this.buttonRotateRight90.Location = new System.Drawing.Point(7, 50);
			this.buttonRotateRight90.Name = "buttonRotateRight90";
			this.buttonRotateRight90.Size = new System.Drawing.Size(117, 23);
			this.buttonRotateRight90.TabIndex = 1;
			this.buttonRotateRight90.Text = "90° nach &rechts";
			this.buttonRotateRight90.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonRotateRight90.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonRotateRight90, "Drehen des Terrains um 90° nach rechts");
			this.buttonRotateRight90.UseVisualStyleBackColor = true;
			this.buttonRotateRight90.Click += new System.EventHandler(this.ButtonRotateRight90_Click);
			// 
			// buttonRotateLeft90
			// 
			this.buttonRotateLeft90.Image = ((System.Drawing.Image)(resources.GetObject("buttonRotateLeft90.Image")));
			this.buttonRotateLeft90.Location = new System.Drawing.Point(7, 20);
			this.buttonRotateLeft90.Name = "buttonRotateLeft90";
			this.buttonRotateLeft90.Size = new System.Drawing.Size(117, 23);
			this.buttonRotateLeft90.TabIndex = 0;
			this.buttonRotateLeft90.Text = "90° nach &links";
			this.buttonRotateLeft90.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonRotateLeft90.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonRotateLeft90, "Drehen des Terrains um 90° nach links");
			this.buttonRotateLeft90.UseVisualStyleBackColor = true;
			this.buttonRotateLeft90.Click += new System.EventHandler(this.ButtonRotateLeft90_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.Location = new System.Drawing.Point(188, 391);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(81, 23);
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "&Abbruch";
			this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCancel, "Abbruch");
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
			this.buttonOK.Location = new System.Drawing.Point(107, 391);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 15;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "OK");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// buttonViewTerrainFull
			// 
			this.buttonViewTerrainFull.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewTerrainFull.Image")));
			this.buttonViewTerrainFull.Location = new System.Drawing.Point(254, 143);
			this.buttonViewTerrainFull.Name = "buttonViewTerrainFull";
			this.buttonViewTerrainFull.Size = new System.Drawing.Size(108, 26);
			this.buttonViewTerrainFull.TabIndex = 11;
			this.buttonViewTerrainFull.Text = "Gesam&tansicht";
			this.buttonViewTerrainFull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonViewTerrainFull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonViewTerrainFull, "Öffnen der Gesamtansicht als Fenster");
			this.buttonViewTerrainFull.UseVisualStyleBackColor = true;
			this.buttonViewTerrainFull.Click += new System.EventHandler(this.ButtonViewTerrainFull_Click);
			// 
			// buttonSmooth
			// 
			this.buttonSmooth.Image = ((System.Drawing.Image)(resources.GetObject("buttonSmooth.Image")));
			this.buttonSmooth.Location = new System.Drawing.Point(127, 319);
			this.buttonSmooth.Name = "buttonSmooth";
			this.buttonSmooth.Size = new System.Drawing.Size(75, 23);
			this.buttonSmooth.TabIndex = 9;
			this.buttonSmooth.Text = "&Glätten";
			this.buttonSmooth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSmooth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonSmooth, "Glätten des Terrains");
			this.buttonSmooth.UseVisualStyleBackColor = true;
			this.buttonSmooth.Click += new System.EventHandler(this.ButtonSmooth_Click);
			// 
			// buttonInvert
			// 
			this.buttonInvert.Image = ((System.Drawing.Image)(resources.GetObject("buttonInvert.Image")));
			this.buttonInvert.Location = new System.Drawing.Point(10, 319);
			this.buttonInvert.Name = "buttonInvert";
			this.buttonInvert.Size = new System.Drawing.Size(83, 23);
			this.buttonInvert.TabIndex = 8;
			this.buttonInvert.Text = "&Invertieren";
			this.buttonInvert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonInvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonInvert, "Invertieren des Terrains");
			this.buttonInvert.UseVisualStyleBackColor = true;
			this.buttonInvert.Click += new System.EventHandler(this.ButtonInvert_Click);
			// 
			// labelProgress
			// 
			this.labelProgress.AutoSize = true;
			this.labelProgress.Location = new System.Drawing.Point(31, 364);
			this.labelProgress.Name = "labelProgress";
			this.labelProgress.Size = new System.Drawing.Size(44, 13);
			this.labelProgress.TabIndex = 13;
			this.labelProgress.Text = "Prozess";
			// 
			// prgsbarEditTerrain
			// 
			this.prgsbarEditTerrain.Location = new System.Drawing.Point(82, 364);
			this.prgsbarEditTerrain.Name = "prgsbarEditTerrain";
			this.prgsbarEditTerrain.Size = new System.Drawing.Size(231, 17);
			this.prgsbarEditTerrain.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prgsbarEditTerrain.TabIndex = 14;
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(386, 22);
			this.statusStrip.TabIndex = 17;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.AutoToolTip = true;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(93, 17);
			this.toolStripStatusLabel.Text = "information text";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.prgsbarEditTerrain);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.labelProgress);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.labelTerrainName);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonCancel);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonOK);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonViewTerrainFull);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonSmooth);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonInvert);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.gboxShiftTerrain);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.gboxPlane);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.szComment);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.labelComment);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.szTerrainName);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.gboxPreviewOfTerrain);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.gboxCanyonize);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.gboxMirror);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.gboxRotation);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(386, 394);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(386, 441);
			this.toolStripContainer1.TabIndex = 18;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// EditTerrainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 441);
			this.Controls.Add(this.toolStripContainer1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditTerrainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Aktuelles Terrain ändern";
			this.Load += new System.EventHandler(this.EditTerrainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudShiftTerrainStep)).EndInit();
			this.gboxShiftTerrain.ResumeLayout(false);
			this.gboxShiftTerrain.PerformLayout();
			this.gboxPlane.ResumeLayout(false);
			this.gboxPlane.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPlaneStep)).EndInit();
			this.gboxPreviewOfTerrain.ResumeLayout(false);
			this.gboxPreviewOfTerrain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.gboxCanyonize.ResumeLayout(false);
			this.gboxCanyonize.PerformLayout();
			this.gboxMirror.ResumeLayout(false);
			this.gboxRotation.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NumericUpDown nudShiftTerrainStep;
    private System.Windows.Forms.Label labelShiftTerrainStep;
    private System.Windows.Forms.Button buttonCanyonize;
    private System.Windows.Forms.Button buttonShiftTerrainSE;
    private System.Windows.Forms.Button buttonShiftTerrainS;
    private System.Windows.Forms.RadioButton rbtnCanyonizeVar;
    private System.Windows.Forms.Button buttonShiftTerrainSW;
    private System.Windows.Forms.Button buttonShiftTerrainE;
    private System.Windows.Forms.Label labelTerrainName;
    private System.Windows.Forms.Button buttonShiftTerrainBackward;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonViewTerrainFull;
    private System.Windows.Forms.Button buttonSmooth;
    private System.Windows.Forms.Button buttonShiftTerrainW;
    private System.Windows.Forms.Button buttonShiftTerrainNE;
    private System.Windows.Forms.Button buttonInvert;
    private System.Windows.Forms.Button buttonShiftTerrainN;
    private System.Windows.Forms.Button buttonShiftTerrainNW;
    private System.Windows.Forms.GroupBox gboxShiftTerrain;
    private System.Windows.Forms.GroupBox gboxPlane;
    private System.Windows.Forms.NumericUpDown nudPlaneStep;
    private System.Windows.Forms.Button buttonDecreasePlane;
    private System.Windows.Forms.Label labelPlaneStep;
    private System.Windows.Forms.Button buttonIncreasePlane;
    private System.Windows.Forms.RadioButton rbtnCanyonizeConst;
    private System.Windows.Forms.TextBox szComment;
    private System.Windows.Forms.Label labelComment;
    private System.Windows.Forms.TextBox szTerrainName;
    private System.Windows.Forms.Button buttonMirrorHorizontal;
    private System.Windows.Forms.GroupBox gboxPreviewOfTerrain;
    private System.Windows.Forms.GroupBox gboxCanyonize;
    private System.Windows.Forms.Button buttonMirrorVertical;
    private System.Windows.Forms.Button buttonRotateRight90;
    private System.Windows.Forms.GroupBox gboxMirror;
    private System.Windows.Forms.GroupBox gboxRotation;
    private System.Windows.Forms.Button buttonRotateLeft90;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label labelProgress;
    private System.Windows.Forms.ProgressBar prgsbarEditTerrain;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	}
}