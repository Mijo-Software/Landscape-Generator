namespace LandscapeGenerator
{
  partial class CreateNewTerrainForm
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
			this.rbtnStartValueRandom = new System.Windows.Forms.RadioButton();
			this.labelTerrainName = new System.Windows.Forms.Label();
			this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
			this.labelStartYValue = new System.Windows.Forms.Label();
			this.rbtnStartValueMidOfTer = new System.Windows.Forms.RadioButton();
			this.mtboxSizeYAxis = new System.Windows.Forms.MaskedTextBox();
			this.labelSizeYAxis = new System.Windows.Forms.Label();
			this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCreateTerrain = new System.Windows.Forms.Button();
			this.buttonViewTerrainPreview = new System.Windows.Forms.Button();
			this.prgsbarGenProgress = new System.Windows.Forms.ProgressBar();
			this.labelStartXValue = new System.Windows.Forms.Label();
			this.labelGenProgress = new System.Windows.Forms.Label();
			this.rbtnStartValueFixed = new System.Windows.Forms.RadioButton();
			this.gboxStartValue = new System.Windows.Forms.GroupBox();
			this.labelSizeXAxis = new System.Windows.Forms.Label();
			this.mtboxMethodToNumber = new System.Windows.Forms.MaskedTextBox();
			this.gboxGenerateTerrain = new System.Windows.Forms.GroupBox();
			this.rbtnMethodToNumber = new System.Windows.Forms.RadioButton();
			this.mtboxMethodToHeightPoint = new System.Windows.Forms.MaskedTextBox();
			this.rbtnMethodToHeightPoint = new System.Windows.Forms.RadioButton();
			this.cboxGenMethod = new System.Windows.Forms.ComboBox();
			this.labelGenMethod = new System.Windows.Forms.Label();
			this.szComment = new System.Windows.Forms.TextBox();
			this.labelComment = new System.Windows.Forms.Label();
			this.szTerrainName = new System.Windows.Forms.TextBox();
			this.mtboxSizeXAxis = new System.Windows.Forms.MaskedTextBox();
			this.gboxTerrainSize = new System.Windows.Forms.GroupBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.gboxStartValue.SuspendLayout();
			this.gboxGenerateTerrain.SuspendLayout();
			this.gboxTerrainSize.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rbtnStartValueRandom
			// 
			this.rbtnStartValueRandom.AutoSize = true;
			this.rbtnStartValueRandom.Location = new System.Drawing.Point(6, 42);
			this.rbtnStartValueRandom.Name = "rbtnStartValueRandom";
			this.rbtnStartValueRandom.Size = new System.Drawing.Size(100, 17);
			this.rbtnStartValueRandom.TabIndex = 5;
			this.rbtnStartValueRandom.TabStop = true;
			this.rbtnStartValueRandom.Text = "&zufallsbasierend";
			this.toolTip.SetToolTip(this.rbtnStartValueRandom, "einen zufallbasierenden Startpunkt auswählen");
			this.rbtnStartValueRandom.UseVisualStyleBackColor = true;
			// 
			// labelTerrainName
			// 
			this.labelTerrainName.AutoSize = true;
			this.labelTerrainName.Location = new System.Drawing.Point(12, 9);
			this.labelTerrainName.Name = "labelTerrainName";
			this.labelTerrainName.Size = new System.Drawing.Size(91, 13);
			this.labelTerrainName.TabIndex = 0;
			this.labelTerrainName.Text = "&Name des Terrain";
			// 
			// maskedTextBox5
			// 
			this.maskedTextBox5.Location = new System.Drawing.Point(270, 19);
			this.maskedTextBox5.Name = "maskedTextBox5";
			this.maskedTextBox5.Size = new System.Drawing.Size(51, 20);
			this.maskedTextBox5.TabIndex = 4;
			this.toolTip.SetToolTip(this.maskedTextBox5, "Eingabe der Y-Wert im Startpunkt");
			// 
			// labelStartYValue
			// 
			this.labelStartYValue.AutoSize = true;
			this.labelStartYValue.Location = new System.Drawing.Point(224, 22);
			this.labelStartYValue.Name = "labelStartYValue";
			this.labelStartYValue.Size = new System.Drawing.Size(40, 13);
			this.labelStartYValue.TabIndex = 3;
			this.labelStartYValue.Text = "Y-Wert";
			// 
			// rbtnStartValueMidOfTer
			// 
			this.rbtnStartValueMidOfTer.AutoSize = true;
			this.rbtnStartValueMidOfTer.Location = new System.Drawing.Point(6, 65);
			this.rbtnStartValueMidOfTer.Name = "rbtnStartValueMidOfTer";
			this.rbtnStartValueMidOfTer.Size = new System.Drawing.Size(109, 17);
			this.rbtnStartValueMidOfTer.TabIndex = 6;
			this.rbtnStartValueMidOfTer.TabStop = true;
			this.rbtnStartValueMidOfTer.Text = "Mitte des &Terrains";
			this.toolTip.SetToolTip(this.rbtnStartValueMidOfTer, "einen Startpunkt in der Mitte des Terrains auswählen");
			this.rbtnStartValueMidOfTer.UseVisualStyleBackColor = true;
			// 
			// mtboxSizeYAxis
			// 
			this.mtboxSizeYAxis.Location = new System.Drawing.Point(212, 19);
			this.mtboxSizeYAxis.Name = "mtboxSizeYAxis";
			this.mtboxSizeYAxis.Size = new System.Drawing.Size(51, 20);
			this.mtboxSizeYAxis.TabIndex = 3;
			this.toolTip.SetToolTip(this.mtboxSizeYAxis, "Eingabe der Größe der Y-Achse des Terrains");
			// 
			// labelSizeYAxis
			// 
			this.labelSizeYAxis.AutoSize = true;
			this.labelSizeYAxis.Location = new System.Drawing.Point(159, 22);
			this.labelSizeYAxis.Name = "labelSizeYAxis";
			this.labelSizeYAxis.Size = new System.Drawing.Size(47, 13);
			this.labelSizeYAxis.TabIndex = 2;
			this.labelSizeYAxis.Text = "&Y-Achse";
			// 
			// maskedTextBox6
			// 
			this.maskedTextBox6.Location = new System.Drawing.Point(162, 19);
			this.maskedTextBox6.Name = "maskedTextBox6";
			this.maskedTextBox6.Size = new System.Drawing.Size(51, 20);
			this.maskedTextBox6.TabIndex = 2;
			this.toolTip.SetToolTip(this.maskedTextBox6, "Eingabe der X-Wert im Startpunkt");
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Image = global::LandscapeGenerator.Properties.Resources.fatcow_tick;
			this.buttonOK.Location = new System.Drawing.Point(130, 376);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "&OK";
			this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonOK, "OK");
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// buttonCreateTerrain
			// 
			this.buttonCreateTerrain.Image = global::LandscapeGenerator.Properties.Resources.fatcow_cog;
			this.buttonCreateTerrain.Location = new System.Drawing.Point(21, 376);
			this.buttonCreateTerrain.Name = "buttonCreateTerrain";
			this.buttonCreateTerrain.Size = new System.Drawing.Size(75, 23);
			this.buttonCreateTerrain.TabIndex = 10;
			this.buttonCreateTerrain.Text = "&Erstellen";
			this.buttonCreateTerrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCreateTerrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCreateTerrain, "Erstellen des Terrains");
			this.buttonCreateTerrain.UseVisualStyleBackColor = true;
			this.buttonCreateTerrain.Click += new System.EventHandler(this.ButtonCreateTerrain_Click);
			// 
			// buttonViewTerrainPreview
			// 
			this.buttonViewTerrainPreview.Image = global::LandscapeGenerator.Properties.Resources.fatcow_image;
			this.buttonViewTerrainPreview.Location = new System.Drawing.Point(238, 334);
			this.buttonViewTerrainPreview.Name = "buttonViewTerrainPreview";
			this.buttonViewTerrainPreview.Size = new System.Drawing.Size(81, 26);
			this.buttonViewTerrainPreview.TabIndex = 9;
			this.buttonViewTerrainPreview.Text = "&Vorschau";
			this.buttonViewTerrainPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonViewTerrainPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonViewTerrainPreview, "Öffnen eines Vorschaufensters");
			this.buttonViewTerrainPreview.UseVisualStyleBackColor = true;
			this.buttonViewTerrainPreview.Click += new System.EventHandler(this.ButtonViewTerrainPreview_Click);
			// 
			// prgsbarGenProgress
			// 
			this.prgsbarGenProgress.Location = new System.Drawing.Point(61, 342);
			this.prgsbarGenProgress.Name = "prgsbarGenProgress";
			this.prgsbarGenProgress.Size = new System.Drawing.Size(140, 13);
			this.prgsbarGenProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prgsbarGenProgress.TabIndex = 8;
			// 
			// labelStartXValue
			// 
			this.labelStartXValue.AutoSize = true;
			this.labelStartXValue.Location = new System.Drawing.Point(116, 22);
			this.labelStartXValue.Name = "labelStartXValue";
			this.labelStartXValue.Size = new System.Drawing.Size(40, 13);
			this.labelStartXValue.TabIndex = 1;
			this.labelStartXValue.Text = "X-Wert";
			// 
			// labelGenProgress
			// 
			this.labelGenProgress.AutoSize = true;
			this.labelGenProgress.Location = new System.Drawing.Point(11, 342);
			this.labelGenProgress.Name = "labelGenProgress";
			this.labelGenProgress.Size = new System.Drawing.Size(44, 13);
			this.labelGenProgress.TabIndex = 7;
			this.labelGenProgress.Text = "Prozess";
			// 
			// rbtnStartValueFixed
			// 
			this.rbtnStartValueFixed.AutoSize = true;
			this.rbtnStartValueFixed.Location = new System.Drawing.Point(6, 19);
			this.rbtnStartValueFixed.Name = "rbtnStartValueFixed";
			this.rbtnStartValueFixed.Size = new System.Drawing.Size(74, 17);
			this.rbtnStartValueFixed.TabIndex = 0;
			this.rbtnStartValueFixed.TabStop = true;
			this.rbtnStartValueFixed.Text = "&festlegend";
			this.toolTip.SetToolTip(this.rbtnStartValueFixed, "einen festgelegten Startpunkt auswählen");
			this.rbtnStartValueFixed.UseVisualStyleBackColor = true;
			// 
			// gboxStartValue
			// 
			this.gboxStartValue.Controls.Add(this.rbtnStartValueMidOfTer);
			this.gboxStartValue.Controls.Add(this.rbtnStartValueRandom);
			this.gboxStartValue.Controls.Add(this.maskedTextBox5);
			this.gboxStartValue.Controls.Add(this.labelStartYValue);
			this.gboxStartValue.Controls.Add(this.maskedTextBox6);
			this.gboxStartValue.Controls.Add(this.labelStartXValue);
			this.gboxStartValue.Controls.Add(this.rbtnStartValueFixed);
			this.gboxStartValue.Location = new System.Drawing.Point(11, 226);
			this.gboxStartValue.Name = "gboxStartValue";
			this.gboxStartValue.Size = new System.Drawing.Size(327, 91);
			this.gboxStartValue.TabIndex = 6;
			this.gboxStartValue.TabStop = false;
			this.gboxStartValue.Text = "Startwert";
			// 
			// labelSizeXAxis
			// 
			this.labelSizeXAxis.AutoSize = true;
			this.labelSizeXAxis.Location = new System.Drawing.Point(13, 22);
			this.labelSizeXAxis.Name = "labelSizeXAxis";
			this.labelSizeXAxis.Size = new System.Drawing.Size(47, 13);
			this.labelSizeXAxis.TabIndex = 0;
			this.labelSizeXAxis.Text = "&X-Achse";
			// 
			// mtboxMethodToNumber
			// 
			this.mtboxMethodToNumber.Location = new System.Drawing.Point(233, 74);
			this.mtboxMethodToNumber.Name = "mtboxMethodToNumber";
			this.mtboxMethodToNumber.Size = new System.Drawing.Size(88, 20);
			this.mtboxMethodToNumber.TabIndex = 5;
			this.toolTip.SetToolTip(this.mtboxMethodToNumber, "Eingabe der maximalen Anzahl");
			// 
			// gboxGenerateTerrain
			// 
			this.gboxGenerateTerrain.Controls.Add(this.mtboxMethodToNumber);
			this.gboxGenerateTerrain.Controls.Add(this.rbtnMethodToNumber);
			this.gboxGenerateTerrain.Controls.Add(this.mtboxMethodToHeightPoint);
			this.gboxGenerateTerrain.Controls.Add(this.rbtnMethodToHeightPoint);
			this.gboxGenerateTerrain.Controls.Add(this.cboxGenMethod);
			this.gboxGenerateTerrain.Controls.Add(this.labelGenMethod);
			this.gboxGenerateTerrain.Location = new System.Drawing.Point(11, 58);
			this.gboxGenerateTerrain.Name = "gboxGenerateTerrain";
			this.gboxGenerateTerrain.Size = new System.Drawing.Size(327, 109);
			this.gboxGenerateTerrain.TabIndex = 4;
			this.gboxGenerateTerrain.TabStop = false;
			this.gboxGenerateTerrain.Text = "Generierungsmethode";
			// 
			// rbtnMethodToNumber
			// 
			this.rbtnMethodToNumber.AutoSize = true;
			this.rbtnMethodToNumber.Location = new System.Drawing.Point(7, 77);
			this.rbtnMethodToNumber.Name = "rbtnMethodToNumber";
			this.rbtnMethodToNumber.Size = new System.Drawing.Size(220, 17);
			this.rbtnMethodToNumber.TabIndex = 4;
			this.rbtnMethodToNumber.TabStop = true;
			this.rbtnMethodToNumber.Text = "Ausführen bis zu einer &bestimmten Anzahl";
			this.toolTip.SetToolTip(this.rbtnMethodToNumber, "Ausführen bis zu einer bestimmten Anzahl");
			this.rbtnMethodToNumber.UseVisualStyleBackColor = true;
			// 
			// mtboxMethodToHeightPoint
			// 
			this.mtboxMethodToHeightPoint.Location = new System.Drawing.Point(270, 51);
			this.mtboxMethodToHeightPoint.Name = "mtboxMethodToHeightPoint";
			this.mtboxMethodToHeightPoint.Size = new System.Drawing.Size(51, 20);
			this.mtboxMethodToHeightPoint.TabIndex = 3;
			this.toolTip.SetToolTip(this.mtboxMethodToHeightPoint, "Eingabe des maximalen Höhenpunkts");
			// 
			// rbtnMethodToHeightPoint
			// 
			this.rbtnMethodToHeightPoint.AutoSize = true;
			this.rbtnMethodToHeightPoint.Cursor = System.Windows.Forms.Cursors.Default;
			this.rbtnMethodToHeightPoint.Location = new System.Drawing.Point(7, 54);
			this.rbtnMethodToHeightPoint.Name = "rbtnMethodToHeightPoint";
			this.rbtnMethodToHeightPoint.Size = new System.Drawing.Size(256, 17);
			this.rbtnMethodToHeightPoint.TabIndex = 2;
			this.rbtnMethodToHeightPoint.TabStop = true;
			this.rbtnMethodToHeightPoint.Text = "Ausführen bis zum einem maximalen Höhenpunkt";
			this.toolTip.SetToolTip(this.rbtnMethodToHeightPoint, "Ausführen bis zum einem &maximalen Höhenpunkt");
			this.rbtnMethodToHeightPoint.UseVisualStyleBackColor = true;
			// 
			// cboxGenMethod
			// 
			this.cboxGenMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxGenMethod.FormattingEnabled = true;
			this.cboxGenMethod.Items.AddRange(new object[] {
            "zufällige Platzierung",
            "fraktale Braunsche Bewegung",
            "*Subdivision",
            "*Midpoint Displacement",
            "*Diamond-Square"});
			this.cboxGenMethod.Location = new System.Drawing.Point(74, 20);
			this.cboxGenMethod.Name = "cboxGenMethod";
			this.cboxGenMethod.Size = new System.Drawing.Size(247, 21);
			this.cboxGenMethod.TabIndex = 1;
			this.toolTip.SetToolTip(this.cboxGenMethod, "Auswählen der Methode zu Erstellen des Terrain");
			// 
			// labelGenMethod
			// 
			this.labelGenMethod.AutoSize = true;
			this.labelGenMethod.Location = new System.Drawing.Point(7, 20);
			this.labelGenMethod.Name = "labelGenMethod";
			this.labelGenMethod.Size = new System.Drawing.Size(61, 13);
			this.labelGenMethod.TabIndex = 0;
			this.labelGenMethod.Text = "Al&gorithmus";
			// 
			// szComment
			// 
			this.szComment.Location = new System.Drawing.Point(127, 32);
			this.szComment.Name = "szComment";
			this.szComment.Size = new System.Drawing.Size(192, 20);
			this.szComment.TabIndex = 3;
			this.toolTip.SetToolTip(this.szComment, "einen Kommentar bzw. Beschreibung eingeben");
			// 
			// labelComment
			// 
			this.labelComment.AutoSize = true;
			this.labelComment.Location = new System.Drawing.Point(12, 35);
			this.labelComment.Name = "labelComment";
			this.labelComment.Size = new System.Drawing.Size(60, 13);
			this.labelComment.TabIndex = 2;
			this.labelComment.Text = "&Kommentar";
			// 
			// szTerrainName
			// 
			this.szTerrainName.Location = new System.Drawing.Point(127, 6);
			this.szTerrainName.Name = "szTerrainName";
			this.szTerrainName.Size = new System.Drawing.Size(192, 20);
			this.szTerrainName.TabIndex = 1;
			this.toolTip.SetToolTip(this.szTerrainName, "Name des Terrain eingeben");
			// 
			// mtboxSizeXAxis
			// 
			this.mtboxSizeXAxis.Location = new System.Drawing.Point(66, 19);
			this.mtboxSizeXAxis.Name = "mtboxSizeXAxis";
			this.mtboxSizeXAxis.Size = new System.Drawing.Size(51, 20);
			this.mtboxSizeXAxis.TabIndex = 1;
			this.toolTip.SetToolTip(this.mtboxSizeXAxis, "Eingabe der Größe der X-Achse des Terrains");
			// 
			// gboxTerrainSize
			// 
			this.gboxTerrainSize.Controls.Add(this.mtboxSizeYAxis);
			this.gboxTerrainSize.Controls.Add(this.labelSizeYAxis);
			this.gboxTerrainSize.Controls.Add(this.mtboxSizeXAxis);
			this.gboxTerrainSize.Controls.Add(this.labelSizeXAxis);
			this.gboxTerrainSize.Location = new System.Drawing.Point(11, 173);
			this.gboxTerrainSize.Name = "gboxTerrainSize";
			this.gboxTerrainSize.Size = new System.Drawing.Size(327, 47);
			this.gboxTerrainSize.TabIndex = 5;
			this.gboxTerrainSize.TabStop = false;
			this.gboxTerrainSize.Text = "Größe des Terrains";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Image = global::LandscapeGenerator.Properties.Resources.fatcow_cross;
			this.buttonCancel.Location = new System.Drawing.Point(238, 376);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(81, 23);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.Text = "&Abbruch";
			this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCancel, "Abbruch");
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
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
			this.statusStrip.Size = new System.Drawing.Size(350, 22);
			this.statusStrip.TabIndex = 13;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(104, 17);
			this.toolStripStatusLabel.Text = "infoformation text";
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
			this.toolStripContainer1.ContentPanel.Controls.Add(this.labelTerrainName);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonOK);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonCreateTerrain);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonViewTerrainPreview);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.prgsbarGenProgress);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.labelGenProgress);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.gboxStartValue);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.gboxGenerateTerrain);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.szComment);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.labelComment);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.szTerrainName);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.gboxTerrainSize);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonCancel);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(350, 411);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(350, 433);
			this.toolStripContainer1.TabIndex = 14;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// CreateNewTerrainForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(350, 433);
			this.Controls.Add(this.toolStripContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateNewTerrainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Neues Terrain erstellen";
			this.Load += new System.EventHandler(this.CreateNewTerrainForm_Load);
			this.gboxStartValue.ResumeLayout(false);
			this.gboxStartValue.PerformLayout();
			this.gboxGenerateTerrain.ResumeLayout(false);
			this.gboxGenerateTerrain.PerformLayout();
			this.gboxTerrainSize.ResumeLayout(false);
			this.gboxTerrainSize.PerformLayout();
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

    private System.Windows.Forms.RadioButton rbtnStartValueRandom;
    private System.Windows.Forms.Label labelTerrainName;
    private System.Windows.Forms.MaskedTextBox maskedTextBox5;
    private System.Windows.Forms.Label labelStartYValue;
    private System.Windows.Forms.RadioButton rbtnStartValueMidOfTer;
    private System.Windows.Forms.MaskedTextBox mtboxSizeYAxis;
    private System.Windows.Forms.Label labelSizeYAxis;
    private System.Windows.Forms.MaskedTextBox maskedTextBox6;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonCreateTerrain;
    private System.Windows.Forms.Button buttonViewTerrainPreview;
    private System.Windows.Forms.ProgressBar prgsbarGenProgress;
    private System.Windows.Forms.Label labelStartXValue;
    private System.Windows.Forms.Label labelGenProgress;
    private System.Windows.Forms.RadioButton rbtnStartValueFixed;
    private System.Windows.Forms.GroupBox gboxStartValue;
    private System.Windows.Forms.Label labelSizeXAxis;
    private System.Windows.Forms.MaskedTextBox mtboxMethodToNumber;
    private System.Windows.Forms.GroupBox gboxGenerateTerrain;
    private System.Windows.Forms.RadioButton rbtnMethodToNumber;
    private System.Windows.Forms.MaskedTextBox mtboxMethodToHeightPoint;
    private System.Windows.Forms.RadioButton rbtnMethodToHeightPoint;
    private System.Windows.Forms.ComboBox cboxGenMethod;
    private System.Windows.Forms.Label labelGenMethod;
    private System.Windows.Forms.TextBox szComment;
    private System.Windows.Forms.Label labelComment;
    private System.Windows.Forms.TextBox szTerrainName;
    private System.Windows.Forms.MaskedTextBox mtboxSizeXAxis;
    private System.Windows.Forms.GroupBox gboxTerrainSize;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
	}
}