namespace LandscapeGenerator
{
  partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripDropDownButtonIconTheme = new System.Windows.Forms.ToolStripDropDownButton();
			this.contextMenuStripIconThemes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemFatcow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFugue = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSilk = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.statusStrip.SuspendLayout();
			this.contextMenuStripIconThemes.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonSettings
			// 
			this.buttonSettings.Image = global::LandscapeGenerator.Properties.Resources.fatcow_wrench;
			this.buttonSettings.Location = new System.Drawing.Point(12, 40);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Size = new System.Drawing.Size(30, 30);
			this.buttonSettings.TabIndex = 2;
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
			this.buttonHelp.Location = new System.Drawing.Point(222, 4);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(30, 30);
			this.buttonHelp.TabIndex = 4;
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
			this.buttonExit.Location = new System.Drawing.Point(222, 40);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(30, 30);
			this.buttonExit.TabIndex = 6;
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
			this.buttonInformation.Location = new System.Drawing.Point(12, 4);
			this.buttonInformation.Name = "buttonInformation";
			this.buttonInformation.Size = new System.Drawing.Size(30, 30);
			this.buttonInformation.TabIndex = 0;
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
			this.buttonExportAsScript.Location = new System.Drawing.Point(222, 120);
			this.buttonExportAsScript.Name = "buttonExportAsScript";
			this.buttonExportAsScript.Size = new System.Drawing.Size(30, 30);
			this.buttonExportAsScript.TabIndex = 14;
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
			this.buttonExportAsImage.Location = new System.Drawing.Point(222, 84);
			this.buttonExportAsImage.Name = "buttonExportAsImage";
			this.buttonExportAsImage.Size = new System.Drawing.Size(30, 30);
			this.buttonExportAsImage.TabIndex = 12;
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
			this.buttonExportAsModel.Location = new System.Drawing.Point(222, 48);
			this.buttonExportAsModel.Name = "buttonExportAsModel";
			this.buttonExportAsModel.Size = new System.Drawing.Size(30, 30);
			this.buttonExportAsModel.TabIndex = 10;
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
			this.buttonEditTerrain.Location = new System.Drawing.Point(222, 12);
			this.buttonEditTerrain.Name = "buttonEditTerrain";
			this.buttonEditTerrain.Size = new System.Drawing.Size(30, 30);
			this.buttonEditTerrain.TabIndex = 8;
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
			this.buttonCloseTerrain.Location = new System.Drawing.Point(12, 120);
			this.buttonCloseTerrain.Name = "buttonCloseTerrain";
			this.buttonCloseTerrain.Size = new System.Drawing.Size(30, 30);
			this.buttonCloseTerrain.TabIndex = 6;
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
			this.buttonSaveTerrain.Location = new System.Drawing.Point(12, 84);
			this.buttonSaveTerrain.Name = "buttonSaveTerrain";
			this.buttonSaveTerrain.Size = new System.Drawing.Size(30, 30);
			this.buttonSaveTerrain.TabIndex = 4;
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
			this.buttonLoadTerrain.Location = new System.Drawing.Point(12, 48);
			this.buttonLoadTerrain.Name = "buttonLoadTerrain";
			this.buttonLoadTerrain.Size = new System.Drawing.Size(30, 30);
			this.buttonLoadTerrain.TabIndex = 2;
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
			this.buttonNewTerrain.Size = new System.Drawing.Size(30, 30);
			this.buttonNewTerrain.TabIndex = 0;
			this.buttonNewTerrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonNewTerrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonNewTerrain, "Erstellt ein neues Terrain");
			this.buttonNewTerrain.UseCompatibleTextRendering = true;
			this.buttonNewTerrain.UseVisualStyleBackColor = true;
			this.buttonNewTerrain.Click += new System.EventHandler(this.ButtonNewTerrain_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.toolStripDropDownButtonIconTheme});
			this.statusStrip.Location = new System.Drawing.Point(0, 234);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(424, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 17;
			this.statusStrip.Text = "statusStripApp";
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
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(262, 17);
			this.toolStripStatusLabel2.Spring = true;
			this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// toolStripDropDownButtonIconTheme
			// 
			this.toolStripDropDownButtonIconTheme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButtonIconTheme.DropDown = this.contextMenuStripIconThemes;
			this.toolStripDropDownButtonIconTheme.Image = global::LandscapeGenerator.Properties.Resources.fatcow_palette;
			this.toolStripDropDownButtonIconTheme.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButtonIconTheme.Name = "toolStripDropDownButtonIconTheme";
			this.toolStripDropDownButtonIconTheme.Size = new System.Drawing.Size(29, 20);
			this.toolStripDropDownButtonIconTheme.Text = "Icon theme";
			// 
			// contextMenuStripIconThemes
			// 
			this.contextMenuStripIconThemes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFatcow,
            this.toolStripMenuItemFugue,
            this.toolStripMenuItemSilk});
			this.contextMenuStripIconThemes.Name = "contextMenuStripIconThemes";
			this.contextMenuStripIconThemes.OwnerItem = this.toolStripDropDownButtonIconTheme;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Neues Terrain erstellen";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Terrain laden";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Aktuelles Terrain speichern";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Aktuelles Terrain schließen";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(258, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Aktuelles Terrain bearbeiten";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(258, 57);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Als Modell exportieren";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(258, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Als Grafik exportieren";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(258, 129);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(130, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Als SQL-Skript exportieren";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(48, 13);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(163, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Programminformationen anzeigen";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(258, 13);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Hilfe anzeigen";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(48, 49);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(99, 13);
			this.label11.TabIndex = 3;
			this.label11.Text = "Einstellungen laden";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(258, 49);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(99, 13);
			this.label12.TabIndex = 7;
			this.label12.Text = "Programm beenden";
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel.Controls.Add(this.buttonInformation);
			this.panel.Controls.Add(this.label12);
			this.panel.Controls.Add(this.buttonSettings);
			this.panel.Controls.Add(this.label10);
			this.panel.Controls.Add(this.label11);
			this.panel.Controls.Add(this.label9);
			this.panel.Controls.Add(this.buttonHelp);
			this.panel.Controls.Add(this.buttonExit);
			this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel.Location = new System.Drawing.Point(0, 157);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(424, 77);
			this.panel.TabIndex = 16;
			this.panel.TabStop = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 256);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.buttonExportAsScript);
			this.Controls.Add(this.buttonExportAsImage);
			this.Controls.Add(this.buttonExportAsModel);
			this.Controls.Add(this.buttonEditTerrain);
			this.Controls.Add(this.buttonCloseTerrain);
			this.Controls.Add(this.buttonSaveTerrain);
			this.Controls.Add(this.buttonLoadTerrain);
			this.Controls.Add(this.buttonNewTerrain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Landscape Generator";
			this.Load += new System.EventHandler(this.AppForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.contextMenuStripIconThemes.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
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
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonIconTheme;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel;
	}
}

