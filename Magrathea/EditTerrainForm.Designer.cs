namespace Magrathea
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
      this.gboxPlane = new System.Windows.Forms.GroupBox();
      this.nudPlaneStep = new System.Windows.Forms.NumericUpDown();
      this.labelPlaneStep = new System.Windows.Forms.Label();
      this.rbtnCanyonizeConst = new System.Windows.Forms.RadioButton();
      this.szComment = new System.Windows.Forms.TextBox();
      this.labelComment = new System.Windows.Forms.Label();
      this.szTerrainName = new System.Windows.Forms.TextBox();
      this.gboxPreviewOfTerrain = new System.Windows.Forms.GroupBox();
      this.gboxCanyonize = new System.Windows.Forms.GroupBox();
      this.gboxMirror = new System.Windows.Forms.GroupBox();
      this.gboxRotation = new System.Windows.Forms.GroupBox();
      this.toolTipEditTerrain = new System.Windows.Forms.ToolTip(this.components);
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnViewTerrainFull = new System.Windows.Forms.Button();
      this.btnSmooth = new System.Windows.Forms.Button();
      this.btnInvert = new System.Windows.Forms.Button();
      this.bntShiftTerrainSE = new System.Windows.Forms.Button();
      this.bntShiftTerrainS = new System.Windows.Forms.Button();
      this.bntShiftTerrainSW = new System.Windows.Forms.Button();
      this.bntShiftTerrainE = new System.Windows.Forms.Button();
      this.bntShiftTerrainBackward = new System.Windows.Forms.Button();
      this.bntShiftTerrainW = new System.Windows.Forms.Button();
      this.bntShiftTerrainNE = new System.Windows.Forms.Button();
      this.bntShiftTerrainN = new System.Windows.Forms.Button();
      this.bntShiftTerrainNW = new System.Windows.Forms.Button();
      this.btnDecreasePlane = new System.Windows.Forms.Button();
      this.btnIncreasePlane = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnCanyonize = new System.Windows.Forms.Button();
      this.btnMirrorVertical = new System.Windows.Forms.Button();
      this.btnMirrorHorizontal = new System.Windows.Forms.Button();
      this.btnRotateRight90 = new System.Windows.Forms.Button();
      this.btnRotateLeft90 = new System.Windows.Forms.Button();
      this.labelProgress = new System.Windows.Forms.Label();
      this.prgsbarEditTerrain = new System.Windows.Forms.ProgressBar();
      ((System.ComponentModel.ISupportInitialize)(this.nudShiftTerrainStep)).BeginInit();
      this.gboxShiftTerrain.SuspendLayout();
      this.gboxPlane.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudPlaneStep)).BeginInit();
      this.gboxPreviewOfTerrain.SuspendLayout();
      this.gboxCanyonize.SuspendLayout();
      this.gboxMirror.SuspendLayout();
      this.gboxRotation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // nudShiftTerrainStep
      // 
      this.nudShiftTerrainStep.Location = new System.Drawing.Point(47, 133);
      this.nudShiftTerrainStep.Name = "nudShiftTerrainStep";
      this.nudShiftTerrainStep.Size = new System.Drawing.Size(43, 20);
      this.nudShiftTerrainStep.TabIndex = 10;
      this.toolTipEditTerrain.SetToolTip(this.nudShiftTerrainStep, "Wählen der Schrittweite zur Verschiebung");
      // 
      // labelShiftTerrainStep
      // 
      this.labelShiftTerrainStep.AutoSize = true;
      this.labelShiftTerrainStep.Location = new System.Drawing.Point(7, 117);
      this.labelShiftTerrainStep.Name = "labelShiftTerrainStep";
      this.labelShiftTerrainStep.Size = new System.Drawing.Size(63, 17);
      this.labelShiftTerrainStep.TabIndex = 9;
      this.labelShiftTerrainStep.Text = "Schrittweite";
      this.labelShiftTerrainStep.UseCompatibleTextRendering = true;
      // 
      // rbtnCanyonizeVar
      // 
      this.rbtnCanyonizeVar.AutoSize = true;
      this.rbtnCanyonizeVar.Location = new System.Drawing.Point(18, 36);
      this.rbtnCanyonizeVar.Name = "rbtnCanyonizeVar";
      this.rbtnCanyonizeVar.Size = new System.Drawing.Size(97, 18);
      this.rbtnCanyonizeVar.TabIndex = 1;
      this.rbtnCanyonizeVar.TabStop = true;
      this.rbtnCanyonizeVar.Text = "Variabel (1-10)";
      this.toolTipEditTerrain.SetToolTip(this.rbtnCanyonizeVar, "Variables \"Canyonize\" des Terrains");
      this.rbtnCanyonizeVar.UseCompatibleTextRendering = true;
      this.rbtnCanyonizeVar.UseVisualStyleBackColor = true;
      // 
      // labelTerrainName
      // 
      this.labelTerrainName.AutoSize = true;
      this.labelTerrainName.Location = new System.Drawing.Point(12, 9);
      this.labelTerrainName.Name = "labelTerrainName";
      this.labelTerrainName.Size = new System.Drawing.Size(95, 17);
      this.labelTerrainName.TabIndex = 0;
      this.labelTerrainName.Text = "Name des Terrain";
      this.labelTerrainName.UseCompatibleTextRendering = true;
      // 
      // gboxShiftTerrain
      // 
      this.gboxShiftTerrain.Controls.Add(this.nudShiftTerrainStep);
      this.gboxShiftTerrain.Controls.Add(this.labelShiftTerrainStep);
      this.gboxShiftTerrain.Controls.Add(this.bntShiftTerrainSE);
      this.gboxShiftTerrain.Controls.Add(this.bntShiftTerrainS);
      this.gboxShiftTerrain.Controls.Add(this.bntShiftTerrainSW);
      this.gboxShiftTerrain.Controls.Add(this.bntShiftTerrainE);
      this.gboxShiftTerrain.Controls.Add(this.bntShiftTerrainBackward);
      this.gboxShiftTerrain.Controls.Add(this.bntShiftTerrainW);
      this.gboxShiftTerrain.Controls.Add(this.bntShiftTerrainNE);
      this.gboxShiftTerrain.Controls.Add(this.bntShiftTerrainN);
      this.gboxShiftTerrain.Controls.Add(this.bntShiftTerrainNW);
      this.gboxShiftTerrain.Location = new System.Drawing.Point(254, 175);
      this.gboxShiftTerrain.Name = "gboxShiftTerrain";
      this.gboxShiftTerrain.Size = new System.Drawing.Size(96, 170);
      this.gboxShiftTerrain.TabIndex = 12;
      this.gboxShiftTerrain.TabStop = false;
      this.gboxShiftTerrain.Text = "Verschiebung";
      this.gboxShiftTerrain.UseCompatibleTextRendering = true;
      // 
      // gboxPlane
      // 
      this.gboxPlane.Controls.Add(this.nudPlaneStep);
      this.gboxPlane.Controls.Add(this.btnDecreasePlane);
      this.gboxPlane.Controls.Add(this.labelPlaneStep);
      this.gboxPlane.Controls.Add(this.btnIncreasePlane);
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
      this.nudPlaneStep.Location = new System.Drawing.Point(49, 92);
      this.nudPlaneStep.Name = "nudPlaneStep";
      this.nudPlaneStep.Size = new System.Drawing.Size(43, 20);
      this.nudPlaneStep.TabIndex = 3;
      this.toolTipEditTerrain.SetToolTip(this.nudPlaneStep, "Wählen der Schrittweite für die Ebene");
      // 
      // labelPlaneStep
      // 
      this.labelPlaneStep.AutoSize = true;
      this.labelPlaneStep.Location = new System.Drawing.Point(9, 76);
      this.labelPlaneStep.Name = "labelPlaneStep";
      this.labelPlaneStep.Size = new System.Drawing.Size(63, 17);
      this.labelPlaneStep.TabIndex = 2;
      this.labelPlaneStep.Text = "Schrittweite";
      this.labelPlaneStep.UseCompatibleTextRendering = true;
      // 
      // rbtnCanyonizeConst
      // 
      this.rbtnCanyonizeConst.AutoSize = true;
      this.rbtnCanyonizeConst.Location = new System.Drawing.Point(18, 19);
      this.rbtnCanyonizeConst.Name = "rbtnCanyonizeConst";
      this.rbtnCanyonizeConst.Size = new System.Drawing.Size(67, 18);
      this.rbtnCanyonizeConst.TabIndex = 0;
      this.rbtnCanyonizeConst.TabStop = true;
      this.rbtnCanyonizeConst.Text = "Konstant";
      this.toolTipEditTerrain.SetToolTip(this.rbtnCanyonizeConst, "Konstantes \"Canyonize\" des Terrains");
      this.rbtnCanyonizeConst.UseCompatibleTextRendering = true;
      this.rbtnCanyonizeConst.UseVisualStyleBackColor = true;
      // 
      // szComment
      // 
      this.szComment.Location = new System.Drawing.Point(15, 66);
      this.szComment.Name = "szComment";
      this.szComment.Size = new System.Drawing.Size(224, 20);
      this.szComment.TabIndex = 3;
      this.toolTipEditTerrain.SetToolTip(this.szComment, "Eingabe eines Kommentars");
      // 
      // labelComment
      // 
      this.labelComment.AutoSize = true;
      this.labelComment.Location = new System.Drawing.Point(12, 49);
      this.labelComment.Name = "labelComment";
      this.labelComment.Size = new System.Drawing.Size(63, 17);
      this.labelComment.TabIndex = 2;
      this.labelComment.Text = "Kommentar";
      this.labelComment.UseCompatibleTextRendering = true;
      // 
      // szTerrainName
      // 
      this.szTerrainName.Location = new System.Drawing.Point(15, 26);
      this.szTerrainName.Name = "szTerrainName";
      this.szTerrainName.Size = new System.Drawing.Size(224, 20);
      this.szTerrainName.TabIndex = 1;
      this.toolTipEditTerrain.SetToolTip(this.szTerrainName, "Eingabe der Name des Terrains");
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
      this.gboxPreviewOfTerrain.UseCompatibleTextRendering = true;
      // 
      // gboxCanyonize
      // 
      this.gboxCanyonize.Controls.Add(this.btnCanyonize);
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
      // gboxMirror
      // 
      this.gboxMirror.Controls.Add(this.btnMirrorVertical);
      this.gboxMirror.Controls.Add(this.btnMirrorHorizontal);
      this.gboxMirror.Location = new System.Drawing.Point(3, 216);
      this.gboxMirror.Name = "gboxMirror";
      this.gboxMirror.Size = new System.Drawing.Size(100, 82);
      this.gboxMirror.TabIndex = 6;
      this.gboxMirror.TabStop = false;
      this.gboxMirror.Text = "Spiegelung";
      this.gboxMirror.UseCompatibleTextRendering = true;
      // 
      // gboxRotation
      // 
      this.gboxRotation.Controls.Add(this.btnRotateRight90);
      this.gboxRotation.Controls.Add(this.btnRotateLeft90);
      this.gboxRotation.Location = new System.Drawing.Point(109, 93);
      this.gboxRotation.Name = "gboxRotation";
      this.gboxRotation.Size = new System.Drawing.Size(130, 82);
      this.gboxRotation.TabIndex = 5;
      this.gboxRotation.TabStop = false;
      this.gboxRotation.Text = "Drehung";
      this.gboxRotation.UseCompatibleTextRendering = true;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
      this.btnCancel.Location = new System.Drawing.Point(188, 391);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(81, 23);
      this.btnCancel.TabIndex = 16;
      this.btnCancel.Text = "&Abbruch";
      this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnCancel, "Abbruch");
      this.btnCancel.UseCompatibleTextRendering = true;
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
      this.btnOK.Location = new System.Drawing.Point(107, 391);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 15;
      this.btnOK.Text = "&OK";
      this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnOK, "OK");
      this.btnOK.UseCompatibleTextRendering = true;
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnViewTerrainFull
      // 
      this.btnViewTerrainFull.Image = ((System.Drawing.Image)(resources.GetObject("btnViewTerrainFull.Image")));
      this.btnViewTerrainFull.Location = new System.Drawing.Point(254, 143);
      this.btnViewTerrainFull.Name = "btnViewTerrainFull";
      this.btnViewTerrainFull.Size = new System.Drawing.Size(108, 26);
      this.btnViewTerrainFull.TabIndex = 11;
      this.btnViewTerrainFull.Text = "Gesam&tansicht";
      this.btnViewTerrainFull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnViewTerrainFull, "Öffnen der Gesamtansicht als Fenster");
      this.btnViewTerrainFull.UseCompatibleTextRendering = true;
      this.btnViewTerrainFull.UseVisualStyleBackColor = true;
      this.btnViewTerrainFull.Click += new System.EventHandler(this.btnViewTerrainFull_Click);
      // 
      // btnSmooth
      // 
      this.btnSmooth.Image = ((System.Drawing.Image)(resources.GetObject("btnSmooth.Image")));
      this.btnSmooth.Location = new System.Drawing.Point(127, 319);
      this.btnSmooth.Name = "btnSmooth";
      this.btnSmooth.Size = new System.Drawing.Size(75, 23);
      this.btnSmooth.TabIndex = 9;
      this.btnSmooth.Text = "&Glätten";
      this.btnSmooth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnSmooth, "Glätten des Terrains");
      this.btnSmooth.UseCompatibleTextRendering = true;
      this.btnSmooth.UseVisualStyleBackColor = true;
      this.btnSmooth.Click += new System.EventHandler(this.btnSmooth_Click);
      // 
      // btnInvert
      // 
      this.btnInvert.Image = ((System.Drawing.Image)(resources.GetObject("btnInvert.Image")));
      this.btnInvert.Location = new System.Drawing.Point(10, 319);
      this.btnInvert.Name = "btnInvert";
      this.btnInvert.Size = new System.Drawing.Size(83, 23);
      this.btnInvert.TabIndex = 8;
      this.btnInvert.Text = "&Invertieren";
      this.btnInvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnInvert, "Invertieren des Terrains");
      this.btnInvert.UseCompatibleTextRendering = true;
      this.btnInvert.UseVisualStyleBackColor = true;
      this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
      // 
      // bntShiftTerrainSE
      // 
      this.bntShiftTerrainSE.Image = ((System.Drawing.Image)(resources.GetObject("bntShiftTerrainSE.Image")));
      this.bntShiftTerrainSE.Location = new System.Drawing.Point(65, 78);
      this.bntShiftTerrainSE.Name = "bntShiftTerrainSE";
      this.bntShiftTerrainSE.Size = new System.Drawing.Size(23, 23);
      this.bntShiftTerrainSE.TabIndex = 8;
      this.toolTipEditTerrain.SetToolTip(this.bntShiftTerrainSE, "Verschieben des Terrain nach rechts unten");
      this.bntShiftTerrainSE.UseVisualStyleBackColor = true;
      this.bntShiftTerrainSE.Click += new System.EventHandler(this.bntShiftTerrainSE_Click);
      // 
      // bntShiftTerrainS
      // 
      this.bntShiftTerrainS.Image = ((System.Drawing.Image)(resources.GetObject("bntShiftTerrainS.Image")));
      this.bntShiftTerrainS.Location = new System.Drawing.Point(36, 78);
      this.bntShiftTerrainS.Name = "bntShiftTerrainS";
      this.bntShiftTerrainS.Size = new System.Drawing.Size(23, 23);
      this.bntShiftTerrainS.TabIndex = 7;
      this.toolTipEditTerrain.SetToolTip(this.bntShiftTerrainS, "Verschieben des Terrain nach unten");
      this.bntShiftTerrainS.UseVisualStyleBackColor = true;
      this.bntShiftTerrainS.Click += new System.EventHandler(this.bntShiftTerrainS_Click);
      // 
      // bntShiftTerrainSW
      // 
      this.bntShiftTerrainSW.Image = ((System.Drawing.Image)(resources.GetObject("bntShiftTerrainSW.Image")));
      this.bntShiftTerrainSW.Location = new System.Drawing.Point(7, 78);
      this.bntShiftTerrainSW.Name = "bntShiftTerrainSW";
      this.bntShiftTerrainSW.Size = new System.Drawing.Size(23, 23);
      this.bntShiftTerrainSW.TabIndex = 6;
      this.toolTipEditTerrain.SetToolTip(this.bntShiftTerrainSW, "Verschieben des Terrain nach links unten");
      this.bntShiftTerrainSW.UseVisualStyleBackColor = true;
      this.bntShiftTerrainSW.Click += new System.EventHandler(this.bntShiftTerrainSW_Click);
      // 
      // bntShiftTerrainE
      // 
      this.bntShiftTerrainE.Image = ((System.Drawing.Image)(resources.GetObject("bntShiftTerrainE.Image")));
      this.bntShiftTerrainE.Location = new System.Drawing.Point(65, 49);
      this.bntShiftTerrainE.Name = "bntShiftTerrainE";
      this.bntShiftTerrainE.Size = new System.Drawing.Size(23, 23);
      this.bntShiftTerrainE.TabIndex = 5;
      this.toolTipEditTerrain.SetToolTip(this.bntShiftTerrainE, "Verschieben des Terrain nach rechts");
      this.bntShiftTerrainE.UseVisualStyleBackColor = true;
      this.bntShiftTerrainE.Click += new System.EventHandler(this.bntShiftTerrainE_Click);
      // 
      // bntShiftTerrainBackward
      // 
      this.bntShiftTerrainBackward.Image = ((System.Drawing.Image)(resources.GetObject("bntShiftTerrainBackward.Image")));
      this.bntShiftTerrainBackward.Location = new System.Drawing.Point(36, 49);
      this.bntShiftTerrainBackward.Name = "bntShiftTerrainBackward";
      this.bntShiftTerrainBackward.Size = new System.Drawing.Size(23, 23);
      this.bntShiftTerrainBackward.TabIndex = 4;
      this.toolTipEditTerrain.SetToolTip(this.bntShiftTerrainBackward, "Zurücksetzen der Verschiebung");
      this.bntShiftTerrainBackward.UseVisualStyleBackColor = true;
      this.bntShiftTerrainBackward.Click += new System.EventHandler(this.bntShiftTerrainBackward_Click);
      // 
      // bntShiftTerrainW
      // 
      this.bntShiftTerrainW.Image = ((System.Drawing.Image)(resources.GetObject("bntShiftTerrainW.Image")));
      this.bntShiftTerrainW.Location = new System.Drawing.Point(7, 49);
      this.bntShiftTerrainW.Name = "bntShiftTerrainW";
      this.bntShiftTerrainW.Size = new System.Drawing.Size(23, 23);
      this.bntShiftTerrainW.TabIndex = 3;
      this.toolTipEditTerrain.SetToolTip(this.bntShiftTerrainW, "Verschieben des Terrain nach links");
      this.bntShiftTerrainW.UseVisualStyleBackColor = true;
      this.bntShiftTerrainW.Click += new System.EventHandler(this.bntShiftTerrainW_Click);
      // 
      // bntShiftTerrainNE
      // 
      this.bntShiftTerrainNE.Image = ((System.Drawing.Image)(resources.GetObject("bntShiftTerrainNE.Image")));
      this.bntShiftTerrainNE.ImageAlign = System.Drawing.ContentAlignment.TopRight;
      this.bntShiftTerrainNE.Location = new System.Drawing.Point(65, 20);
      this.bntShiftTerrainNE.Name = "bntShiftTerrainNE";
      this.bntShiftTerrainNE.Size = new System.Drawing.Size(23, 23);
      this.bntShiftTerrainNE.TabIndex = 2;
      this.toolTipEditTerrain.SetToolTip(this.bntShiftTerrainNE, "Verschieben des Terrain nach rechts oben");
      this.bntShiftTerrainNE.UseVisualStyleBackColor = true;
      this.bntShiftTerrainNE.Click += new System.EventHandler(this.bntShiftTerrainNE_Click);
      // 
      // bntShiftTerrainN
      // 
      this.bntShiftTerrainN.Image = ((System.Drawing.Image)(resources.GetObject("bntShiftTerrainN.Image")));
      this.bntShiftTerrainN.Location = new System.Drawing.Point(36, 20);
      this.bntShiftTerrainN.Name = "bntShiftTerrainN";
      this.bntShiftTerrainN.Size = new System.Drawing.Size(23, 23);
      this.bntShiftTerrainN.TabIndex = 1;
      this.toolTipEditTerrain.SetToolTip(this.bntShiftTerrainN, "Verschieben des Terrain nach oben");
      this.bntShiftTerrainN.UseVisualStyleBackColor = true;
      this.bntShiftTerrainN.Click += new System.EventHandler(this.bntShiftTerrainN_Click);
      // 
      // bntShiftTerrainNW
      // 
      this.bntShiftTerrainNW.Image = ((System.Drawing.Image)(resources.GetObject("bntShiftTerrainNW.Image")));
      this.bntShiftTerrainNW.Location = new System.Drawing.Point(7, 20);
      this.bntShiftTerrainNW.Name = "bntShiftTerrainNW";
      this.bntShiftTerrainNW.Size = new System.Drawing.Size(23, 23);
      this.bntShiftTerrainNW.TabIndex = 0;
      this.toolTipEditTerrain.SetToolTip(this.bntShiftTerrainNW, "Verschieben des Terrain nach links oben");
      this.bntShiftTerrainNW.UseVisualStyleBackColor = true;
      this.bntShiftTerrainNW.Click += new System.EventHandler(this.bntShiftTerrainNW_Click);
      // 
      // btnDecreasePlane
      // 
      this.btnDecreasePlane.Image = ((System.Drawing.Image)(resources.GetObject("btnDecreasePlane.Image")));
      this.btnDecreasePlane.Location = new System.Drawing.Point(12, 50);
      this.btnDecreasePlane.Name = "btnDecreasePlane";
      this.btnDecreasePlane.Size = new System.Drawing.Size(75, 23);
      this.btnDecreasePlane.TabIndex = 1;
      this.btnDecreasePlane.Text = "&Senken";
      this.btnDecreasePlane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnDecreasePlane, "Senken der Ebene");
      this.btnDecreasePlane.UseCompatibleTextRendering = true;
      this.btnDecreasePlane.UseVisualStyleBackColor = true;
      this.btnDecreasePlane.Click += new System.EventHandler(this.btnDecreasePlane_Click);
      // 
      // btnIncreasePlane
      // 
      this.btnIncreasePlane.Image = ((System.Drawing.Image)(resources.GetObject("btnIncreasePlane.Image")));
      this.btnIncreasePlane.Location = new System.Drawing.Point(12, 19);
      this.btnIncreasePlane.Name = "btnIncreasePlane";
      this.btnIncreasePlane.Size = new System.Drawing.Size(75, 23);
      this.btnIncreasePlane.TabIndex = 0;
      this.btnIncreasePlane.Text = "&Erhöhen";
      this.btnIncreasePlane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnIncreasePlane, "Erhöhen der Ebene");
      this.btnIncreasePlane.UseCompatibleTextRendering = true;
      this.btnIncreasePlane.UseVisualStyleBackColor = true;
      this.btnIncreasePlane.Click += new System.EventHandler(this.btnIncreasePlane_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Magrathea.Properties.Resources.terrain_test2;
      this.pictureBox1.Location = new System.Drawing.Point(9, 14);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 100);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // btnCanyonize
      // 
      this.btnCanyonize.Image = ((System.Drawing.Image)(resources.GetObject("btnCanyonize.Image")));
      this.btnCanyonize.Location = new System.Drawing.Point(18, 59);
      this.btnCanyonize.Name = "btnCanyonize";
      this.btnCanyonize.Size = new System.Drawing.Size(93, 23);
      this.btnCanyonize.TabIndex = 2;
      this.btnCanyonize.Text = "&Canyonize";
      this.btnCanyonize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnCanyonize, "\"Canyonize\" des Terrains");
      this.btnCanyonize.UseVisualStyleBackColor = true;
      this.btnCanyonize.Click += new System.EventHandler(this.btnCanyonize_Click);
      // 
      // btnMirrorVertical
      // 
      this.btnMirrorVertical.Image = ((System.Drawing.Image)(resources.GetObject("btnMirrorVertical.Image")));
      this.btnMirrorVertical.Location = new System.Drawing.Point(7, 50);
      this.btnMirrorVertical.Name = "btnMirrorVertical";
      this.btnMirrorVertical.Size = new System.Drawing.Size(87, 23);
      this.btnMirrorVertical.TabIndex = 1;
      this.btnMirrorVertical.Text = "&Vertikal";
      this.btnMirrorVertical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnMirrorVertical, "Vertikal spiegeln");
      this.btnMirrorVertical.UseCompatibleTextRendering = true;
      this.btnMirrorVertical.UseVisualStyleBackColor = true;
      this.btnMirrorVertical.Click += new System.EventHandler(this.btnMirrorVertical_Click);
      // 
      // btnMirrorHorizontal
      // 
      this.btnMirrorHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("btnMirrorHorizontal.Image")));
      this.btnMirrorHorizontal.Location = new System.Drawing.Point(7, 20);
      this.btnMirrorHorizontal.Name = "btnMirrorHorizontal";
      this.btnMirrorHorizontal.Size = new System.Drawing.Size(87, 23);
      this.btnMirrorHorizontal.TabIndex = 0;
      this.btnMirrorHorizontal.Text = "&Horizontal";
      this.btnMirrorHorizontal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnMirrorHorizontal, "Horizontal spiegeln");
      this.btnMirrorHorizontal.UseCompatibleTextRendering = true;
      this.btnMirrorHorizontal.UseVisualStyleBackColor = true;
      this.btnMirrorHorizontal.Click += new System.EventHandler(this.btnMirrorHorizontal_Click);
      // 
      // btnRotateRight90
      // 
      this.btnRotateRight90.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateRight90.Image")));
      this.btnRotateRight90.Location = new System.Drawing.Point(7, 50);
      this.btnRotateRight90.Name = "btnRotateRight90";
      this.btnRotateRight90.Size = new System.Drawing.Size(117, 23);
      this.btnRotateRight90.TabIndex = 1;
      this.btnRotateRight90.Text = "90° nach &rechts";
      this.btnRotateRight90.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnRotateRight90, "Drehen des Terrains um 90° nach rechts");
      this.btnRotateRight90.UseCompatibleTextRendering = true;
      this.btnRotateRight90.UseVisualStyleBackColor = true;
      this.btnRotateRight90.Click += new System.EventHandler(this.btnRotateRight90_Click);
      // 
      // btnRotateLeft90
      // 
      this.btnRotateLeft90.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateLeft90.Image")));
      this.btnRotateLeft90.Location = new System.Drawing.Point(7, 20);
      this.btnRotateLeft90.Name = "btnRotateLeft90";
      this.btnRotateLeft90.Size = new System.Drawing.Size(117, 23);
      this.btnRotateLeft90.TabIndex = 0;
      this.btnRotateLeft90.Text = "90° nach &links";
      this.btnRotateLeft90.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipEditTerrain.SetToolTip(this.btnRotateLeft90, "Drehen des Terrains um 90° nach links");
      this.btnRotateLeft90.UseCompatibleTextRendering = true;
      this.btnRotateLeft90.UseVisualStyleBackColor = true;
      this.btnRotateLeft90.Click += new System.EventHandler(this.btnRotateLeft90_Click);
      // 
      // labelProgress
      // 
      this.labelProgress.AutoSize = true;
      this.labelProgress.Location = new System.Drawing.Point(31, 364);
      this.labelProgress.Name = "labelProgress";
      this.labelProgress.Size = new System.Drawing.Size(45, 17);
      this.labelProgress.TabIndex = 13;
      this.labelProgress.Text = "Prozess";
      this.labelProgress.UseCompatibleTextRendering = true;
      // 
      // prgsbarEditTerrain
      // 
      this.prgsbarEditTerrain.Location = new System.Drawing.Point(82, 364);
      this.prgsbarEditTerrain.Name = "prgsbarEditTerrain";
      this.prgsbarEditTerrain.Size = new System.Drawing.Size(231, 17);
      this.prgsbarEditTerrain.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.prgsbarEditTerrain.TabIndex = 14;
      // 
      // EditTerrainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(386, 426);
      this.Controls.Add(this.prgsbarEditTerrain);
      this.Controls.Add(this.labelProgress);
      this.Controls.Add(this.labelTerrainName);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.btnViewTerrainFull);
      this.Controls.Add(this.btnSmooth);
      this.Controls.Add(this.btnInvert);
      this.Controls.Add(this.gboxShiftTerrain);
      this.Controls.Add(this.gboxPlane);
      this.Controls.Add(this.szComment);
      this.Controls.Add(this.labelComment);
      this.Controls.Add(this.szTerrainName);
      this.Controls.Add(this.gboxPreviewOfTerrain);
      this.Controls.Add(this.gboxCanyonize);
      this.Controls.Add(this.gboxMirror);
      this.Controls.Add(this.gboxRotation);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditTerrainForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Aktuelles Terrain ändern";
      ((System.ComponentModel.ISupportInitialize)(this.nudShiftTerrainStep)).EndInit();
      this.gboxShiftTerrain.ResumeLayout(false);
      this.gboxShiftTerrain.PerformLayout();
      this.gboxPlane.ResumeLayout(false);
      this.gboxPlane.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudPlaneStep)).EndInit();
      this.gboxPreviewOfTerrain.ResumeLayout(false);
      this.gboxPreviewOfTerrain.PerformLayout();
      this.gboxCanyonize.ResumeLayout(false);
      this.gboxCanyonize.PerformLayout();
      this.gboxMirror.ResumeLayout(false);
      this.gboxRotation.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown nudShiftTerrainStep;
    private System.Windows.Forms.Label labelShiftTerrainStep;
    private System.Windows.Forms.Button btnCanyonize;
    private System.Windows.Forms.Button bntShiftTerrainSE;
    private System.Windows.Forms.Button bntShiftTerrainS;
    private System.Windows.Forms.RadioButton rbtnCanyonizeVar;
    private System.Windows.Forms.Button bntShiftTerrainSW;
    private System.Windows.Forms.Button bntShiftTerrainE;
    private System.Windows.Forms.Label labelTerrainName;
    private System.Windows.Forms.Button bntShiftTerrainBackward;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnViewTerrainFull;
    private System.Windows.Forms.Button btnSmooth;
    private System.Windows.Forms.Button bntShiftTerrainW;
    private System.Windows.Forms.Button bntShiftTerrainNE;
    private System.Windows.Forms.Button btnInvert;
    private System.Windows.Forms.Button bntShiftTerrainN;
    private System.Windows.Forms.Button bntShiftTerrainNW;
    private System.Windows.Forms.GroupBox gboxShiftTerrain;
    private System.Windows.Forms.GroupBox gboxPlane;
    private System.Windows.Forms.NumericUpDown nudPlaneStep;
    private System.Windows.Forms.Button btnDecreasePlane;
    private System.Windows.Forms.Label labelPlaneStep;
    private System.Windows.Forms.Button btnIncreasePlane;
    private System.Windows.Forms.RadioButton rbtnCanyonizeConst;
    private System.Windows.Forms.TextBox szComment;
    private System.Windows.Forms.Label labelComment;
    private System.Windows.Forms.TextBox szTerrainName;
    private System.Windows.Forms.Button btnMirrorHorizontal;
    private System.Windows.Forms.GroupBox gboxPreviewOfTerrain;
    private System.Windows.Forms.GroupBox gboxCanyonize;
    private System.Windows.Forms.Button btnMirrorVertical;
    private System.Windows.Forms.Button btnRotateRight90;
    private System.Windows.Forms.GroupBox gboxMirror;
    private System.Windows.Forms.GroupBox gboxRotation;
    private System.Windows.Forms.Button btnRotateLeft90;
    private System.Windows.Forms.ToolTip toolTipEditTerrain;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label labelProgress;
    private System.Windows.Forms.ProgressBar prgsbarEditTerrain;
  }
}