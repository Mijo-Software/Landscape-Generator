namespace LandscapeGenerator
{
  partial class AppForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonSettings = new System.Windows.Forms.Button();
			this.buttonHelp = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonInformation = new System.Windows.Forms.Button();
			this.buttonExportAsScript = new System.Windows.Forms.Button();
			this.buttonExportAsImage = new System.Windows.Forms.Button();
			this.buttonExportAsModel = new System.Windows.Forms.Button();
			this.buttonEditTerrain = new System.Windows.Forms.Button();
			this.buttonCloseTerrain = new System.Windows.Forms.Button();
			this.buttonSaveTerrain = new System.Windows.Forms.Button();
			this.buttonLoadTerrain = new System.Windows.Forms.Button();
			this.buttonNewTerrain = new System.Windows.Forms.Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.contextMenuStripIconThemes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemFatcow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFugue = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSilk = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip.SuspendLayout();
			this.contextMenuStripIconThemes.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonSettings
			// 
			this.buttonSettings.Image = global::LandscapeGenerator.Properties.Resources.fatcow_wrench;
			this.buttonSettings.Location = new System.Drawing.Point(12, 255);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Size = new System.Drawing.Size(210, 40);
			this.buttonSettings.TabIndex = 10;
			this.buttonSettings.Text = "Einstellungen laden";
			this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonSettings, "Beendet das Programm");
			this.buttonSettings.UseCompatibleTextRendering = true;
			this.buttonSettings.UseVisualStyleBackColor = true;
			this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
			// 
			// buttonHelp
			// 
			this.buttonHelp.Image = global::LandscapeGenerator.Properties.Resources.fatcow_help;
			this.buttonHelp.Location = new System.Drawing.Point(233, 209);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(210, 40);
			this.buttonHelp.TabIndex = 9;
			this.buttonHelp.Text = "Hilfe anzeigen";
			this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonHelp, "Beendet das Programm");
			this.buttonHelp.UseCompatibleTextRendering = true;
			this.buttonHelp.UseVisualStyleBackColor = true;
			this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Image = global::LandscapeGenerator.Properties.Resources.fatcow_door;
			this.buttonExit.Location = new System.Drawing.Point(233, 255);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(210, 40);
			this.buttonExit.TabIndex = 11;
			this.buttonExit.Text = "Programm beenden";
			this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonExit, "Beendet das Programm");
			this.buttonExit.UseCompatibleTextRendering = true;
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			// 
			// buttonInformation
			// 
			this.buttonInformation.Image = global::LandscapeGenerator.Properties.Resources.fatcow_information;
			this.buttonInformation.Location = new System.Drawing.Point(12, 209);
			this.buttonInformation.Name = "buttonInformation";
			this.buttonInformation.Size = new System.Drawing.Size(210, 40);
			this.buttonInformation.TabIndex = 8;
			this.buttonInformation.Text = "Programminformationen anzeigen";
			this.buttonInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonInformation, "Zeigt Informationen zum Programm an");
			this.buttonInformation.UseCompatibleTextRendering = true;
			this.buttonInformation.UseVisualStyleBackColor = true;
			this.buttonInformation.Click += new System.EventHandler(this.ButtonInformation_Click);
			// 
			// buttonExportAsScript
			// 
			this.buttonExportAsScript.Image = global::LandscapeGenerator.Properties.Resources.fatcow_script;
			this.buttonExportAsScript.Location = new System.Drawing.Point(233, 150);
			this.buttonExportAsScript.Name = "buttonExportAsScript";
			this.buttonExportAsScript.Size = new System.Drawing.Size(210, 40);
			this.buttonExportAsScript.TabIndex = 7;
			this.buttonExportAsScript.Text = "Als SQL-Skript exportieren";
			this.buttonExportAsScript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExportAsScript.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonExportAsScript, "Exportiert ein Terrain als SQL-Skript");
			this.buttonExportAsScript.UseCompatibleTextRendering = true;
			this.buttonExportAsScript.UseVisualStyleBackColor = true;
			this.buttonExportAsScript.Click += new System.EventHandler(this.ButtonExportAsScript_Click);
			// 
			// buttonExportAsImage
			// 
			this.buttonExportAsImage.Image = global::LandscapeGenerator.Properties.Resources.fatcow_image;
			this.buttonExportAsImage.Location = new System.Drawing.Point(233, 104);
			this.buttonExportAsImage.Name = "buttonExportAsImage";
			this.buttonExportAsImage.Size = new System.Drawing.Size(210, 40);
			this.buttonExportAsImage.TabIndex = 5;
			this.buttonExportAsImage.Text = "Als Grafik exportieren";
			this.buttonExportAsImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExportAsImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonExportAsImage, "Exportiert ein Terrain als Grafik");
			this.buttonExportAsImage.UseCompatibleTextRendering = true;
			this.buttonExportAsImage.UseVisualStyleBackColor = true;
			this.buttonExportAsImage.Click += new System.EventHandler(this.ButtonExportAsImage_Click);
			// 
			// buttonExportAsModel
			// 
			this.buttonExportAsModel.Image = global::LandscapeGenerator.Properties.Resources.fatcow_shape_square;
			this.buttonExportAsModel.Location = new System.Drawing.Point(233, 58);
			this.buttonExportAsModel.Name = "buttonExportAsModel";
			this.buttonExportAsModel.Size = new System.Drawing.Size(210, 40);
			this.buttonExportAsModel.TabIndex = 3;
			this.buttonExportAsModel.Text = "Als Modell exportieren";
			this.buttonExportAsModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExportAsModel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonExportAsModel, "Exportiert ein Terrain als Modell");
			this.buttonExportAsModel.UseCompatibleTextRendering = true;
			this.buttonExportAsModel.UseVisualStyleBackColor = true;
			this.buttonExportAsModel.Click += new System.EventHandler(this.ButtonExportAsModel_Click);
			// 
			// buttonEditTerrain
			// 
			this.buttonEditTerrain.Image = global::LandscapeGenerator.Properties.Resources.fatcow_pencil;
			this.buttonEditTerrain.Location = new System.Drawing.Point(233, 12);
			this.buttonEditTerrain.Name = "buttonEditTerrain";
			this.buttonEditTerrain.Size = new System.Drawing.Size(210, 40);
			this.buttonEditTerrain.TabIndex = 1;
			this.buttonEditTerrain.Text = "Aktuelles Terrain bearbeiten";
			this.buttonEditTerrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonEditTerrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonEditTerrain, "Bearbeitet ein Terrain");
			this.buttonEditTerrain.UseCompatibleTextRendering = true;
			this.buttonEditTerrain.UseVisualStyleBackColor = true;
			this.buttonEditTerrain.Click += new System.EventHandler(this.ButtonEditTerrain_Click);
			// 
			// buttonCloseTerrain
			// 
			this.buttonCloseTerrain.Image = global::LandscapeGenerator.Properties.Resources.fatcow_cross;
			this.buttonCloseTerrain.Location = new System.Drawing.Point(12, 150);
			this.buttonCloseTerrain.Name = "buttonCloseTerrain";
			this.buttonCloseTerrain.Size = new System.Drawing.Size(210, 40);
			this.buttonCloseTerrain.TabIndex = 6;
			this.buttonCloseTerrain.Text = "Aktuelles Terrain schließen";
			this.buttonCloseTerrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCloseTerrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCloseTerrain, "Schließt das Terrain");
			this.buttonCloseTerrain.UseCompatibleTextRendering = true;
			this.buttonCloseTerrain.UseVisualStyleBackColor = true;
			this.buttonCloseTerrain.Click += new System.EventHandler(this.ButtonCloseTerrain_Click);
			// 
			// buttonSaveTerrain
			// 
			this.buttonSaveTerrain.Image = global::LandscapeGenerator.Properties.Resources.fatcow_disk;
			this.buttonSaveTerrain.Location = new System.Drawing.Point(12, 104);
			this.buttonSaveTerrain.Name = "buttonSaveTerrain";
			this.buttonSaveTerrain.Size = new System.Drawing.Size(210, 40);
			this.buttonSaveTerrain.TabIndex = 4;
			this.buttonSaveTerrain.Text = "Aktuelles Terrain speichern";
			this.buttonSaveTerrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSaveTerrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonSaveTerrain, "Speichert das Terrain");
			this.buttonSaveTerrain.UseCompatibleTextRendering = true;
			this.buttonSaveTerrain.UseVisualStyleBackColor = true;
			this.buttonSaveTerrain.Click += new System.EventHandler(this.ButtonSaveTerrain_Click);
			// 
			// buttonLoadTerrain
			// 
			this.buttonLoadTerrain.Image = global::LandscapeGenerator.Properties.Resources.fatcow_folder;
			this.buttonLoadTerrain.Location = new System.Drawing.Point(12, 58);
			this.buttonLoadTerrain.Name = "buttonLoadTerrain";
			this.buttonLoadTerrain.Size = new System.Drawing.Size(210, 40);
			this.buttonLoadTerrain.TabIndex = 2;
			this.buttonLoadTerrain.Text = "Terrain laden";
			this.buttonLoadTerrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonLoadTerrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonLoadTerrain, "Lädt ein Terrain");
			this.buttonLoadTerrain.UseCompatibleTextRendering = true;
			this.buttonLoadTerrain.UseVisualStyleBackColor = true;
			this.buttonLoadTerrain.Click += new System.EventHandler(this.ButtonLoadTerrain_Click);
			// 
			// buttonNewTerrain
			// 
			this.buttonNewTerrain.Image = global::LandscapeGenerator.Properties.Resources.fatcow_asterisk;
			this.buttonNewTerrain.Location = new System.Drawing.Point(12, 12);
			this.buttonNewTerrain.Name = "buttonNewTerrain";
			this.buttonNewTerrain.Size = new System.Drawing.Size(210, 40);
			this.buttonNewTerrain.TabIndex = 0;
			this.buttonNewTerrain.Text = "Neues Terrain erstellen";
			this.buttonNewTerrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonNewTerrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonNewTerrain, "Erstellt ein neues Terrain");
			this.buttonNewTerrain.UseCompatibleTextRendering = true;
			this.buttonNewTerrain.UseVisualStyleBackColor = true;
			this.buttonNewTerrain.Click += new System.EventHandler(this.ButtonNewTerrain_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.ContextMenuStrip = this.contextMenuStripIconThemes;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel2});
			this.statusStrip.Location = new System.Drawing.Point(0, 309);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(455, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 12;
			this.statusStrip.Text = "statusStripApp";
			// 
			// contextMenuStripIconThemes
			// 
			this.contextMenuStripIconThemes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFatcow,
            this.toolStripMenuItemFugue,
            this.toolStripMenuItemSilk});
			this.contextMenuStripIconThemes.Name = "contextMenuStripIconThemes";
			this.contextMenuStripIconThemes.Size = new System.Drawing.Size(113, 70);
			this.contextMenuStripIconThemes.TabStop = true;
			// 
			// toolStripMenuItemFatcow
			// 
			this.toolStripMenuItemFatcow.AutoToolTip = true;
			this.toolStripMenuItemFatcow.Name = "toolStripMenuItemFatcow";
			this.toolStripMenuItemFatcow.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItemFatcow.Text = "Fatcow";
			this.toolStripMenuItemFatcow.MouseEnter += new System.EventHandler(this.ToolStripMenuItemFatcowIcons_MouseEnter);
			// 
			// toolStripMenuItemFugue
			// 
			this.toolStripMenuItemFugue.AutoToolTip = true;
			this.toolStripMenuItemFugue.Name = "toolStripMenuItemFugue";
			this.toolStripMenuItemFugue.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItemFugue.Text = "Fugue";
			this.toolStripMenuItemFugue.MouseEnter += new System.EventHandler(this.ToolStripMenuItemFugueIcons_MouseEnter);
			// 
			// toolStripMenuItemSilk
			// 
			this.toolStripMenuItemSilk.AutoToolTip = true;
			this.toolStripMenuItemSilk.Name = "toolStripMenuItemSilk";
			this.toolStripMenuItemSilk.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItemSilk.Text = "Silk";
			this.toolStripMenuItemSilk.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSilkIcons_MouseEnter);
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.AutoToolTip = true;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(322, 17);
			this.toolStripStatusLabel2.Spring = true;
			this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AppForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 331);
			this.Controls.Add(this.buttonSettings);
			this.Controls.Add(this.buttonHelp);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonInformation);
			this.Controls.Add(this.buttonExportAsScript);
			this.Controls.Add(this.buttonExportAsImage);
			this.Controls.Add(this.buttonExportAsModel);
			this.Controls.Add(this.buttonEditTerrain);
			this.Controls.Add(this.buttonCloseTerrain);
			this.Controls.Add(this.buttonSaveTerrain);
			this.Controls.Add(this.buttonLoadTerrain);
			this.Controls.Add(this.buttonNewTerrain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AppForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Magrathea - Terrain Builder";
			this.Load += new System.EventHandler(this.AppForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.contextMenuStripIconThemes.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.Button buttonInformation;
    private System.Windows.Forms.Button buttonExportAsScript;
    private System.Windows.Forms.Button buttonExportAsImage;
    private System.Windows.Forms.Button buttonExportAsModel;
    private System.Windows.Forms.Button buttonEditTerrain;
    private System.Windows.Forms.Button buttonCloseTerrain;
    private System.Windows.Forms.Button buttonSaveTerrain;
    private System.Windows.Forms.Button buttonLoadTerrain;
    private System.Windows.Forms.Button buttonNewTerrain;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripIconThemes;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFatcow;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFugue;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSilk;
		private System.Windows.Forms.Button buttonHelp;
		private System.Windows.Forms.Button buttonSettings;
	}
}

