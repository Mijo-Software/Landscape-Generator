namespace Magrathea
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
			this.labelCloseApp = new System.Windows.Forms.Label();
			this.buttonCloseApp = new System.Windows.Forms.Button();
			this.labelInfoApp = new System.Windows.Forms.Label();
			this.buttonInfoApp = new System.Windows.Forms.Button();
			this.labelExportAsScript = new System.Windows.Forms.Label();
			this.buttonExportAsScript = new System.Windows.Forms.Button();
			this.labelExportAsImage = new System.Windows.Forms.Label();
			this.buttonExportAsImage = new System.Windows.Forms.Button();
			this.labelExportAsModel = new System.Windows.Forms.Label();
			this.buttonExportAsModel = new System.Windows.Forms.Button();
			this.labelEditTerrain = new System.Windows.Forms.Label();
			this.buttonEditTerrain = new System.Windows.Forms.Button();
			this.labelCloseTerrain = new System.Windows.Forms.Label();
			this.buttonCloseTerrain = new System.Windows.Forms.Button();
			this.labelSaveTerrain = new System.Windows.Forms.Label();
			this.buttonSaveTerrain = new System.Windows.Forms.Button();
			this.labelLoadTerrain = new System.Windows.Forms.Label();
			this.buttonLoadTerrain = new System.Windows.Forms.Button();
			this.labelCreateNewTerrain = new System.Windows.Forms.Label();
			this.buttonNewTerrain = new System.Windows.Forms.Button();
			this.toolTipApp = new System.Windows.Forms.ToolTip(this.components);
			this.statusStripApp = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStripApp.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelCloseApp
			// 
			this.labelCloseApp.AutoSize = true;
			this.labelCloseApp.BackColor = System.Drawing.Color.Transparent;
			this.labelCloseApp.Location = new System.Drawing.Point(302, 285);
			this.labelCloseApp.Name = "labelCloseApp";
			this.labelCloseApp.Size = new System.Drawing.Size(99, 13);
			this.labelCloseApp.TabIndex = 19;
			this.labelCloseApp.Text = "Programm beenden";
			// 
			// buttonCloseApp
			// 
			this.buttonCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseApp.Image")));
			this.buttonCloseApp.Location = new System.Drawing.Point(256, 271);
			this.buttonCloseApp.Name = "buttonCloseApp";
			this.buttonCloseApp.Size = new System.Drawing.Size(40, 40);
			this.buttonCloseApp.TabIndex = 18;
			this.toolTipApp.SetToolTip(this.buttonCloseApp, "Beendet das Programm");
			this.buttonCloseApp.UseCompatibleTextRendering = true;
			this.buttonCloseApp.UseVisualStyleBackColor = true;
			this.buttonCloseApp.Click += new System.EventHandler(this.ButtonCloseApp_Click);
			// 
			// labelInfoApp
			// 
			this.labelInfoApp.AutoSize = true;
			this.labelInfoApp.BackColor = System.Drawing.Color.Transparent;
			this.labelInfoApp.Location = new System.Drawing.Point(59, 283);
			this.labelInfoApp.Name = "labelInfoApp";
			this.labelInfoApp.Size = new System.Drawing.Size(163, 13);
			this.labelInfoApp.TabIndex = 17;
			this.labelInfoApp.Text = "Programminformationen anzeigen";
			// 
			// buttonInfoApp
			// 
			this.buttonInfoApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoApp.Image")));
			this.buttonInfoApp.Location = new System.Drawing.Point(12, 271);
			this.buttonInfoApp.Name = "buttonInfoApp";
			this.buttonInfoApp.Size = new System.Drawing.Size(40, 40);
			this.buttonInfoApp.TabIndex = 16;
			this.toolTipApp.SetToolTip(this.buttonInfoApp, "Zeigt Informationen zum Programm an");
			this.buttonInfoApp.UseCompatibleTextRendering = true;
			this.buttonInfoApp.UseVisualStyleBackColor = true;
			this.buttonInfoApp.Click += new System.EventHandler(this.ButtonInfoApp_Click);
			// 
			// labelExportAsScript
			// 
			this.labelExportAsScript.AutoSize = true;
			this.labelExportAsScript.BackColor = System.Drawing.Color.Transparent;
			this.labelExportAsScript.Location = new System.Drawing.Point(303, 202);
			this.labelExportAsScript.Name = "labelExportAsScript";
			this.labelExportAsScript.Size = new System.Drawing.Size(130, 13);
			this.labelExportAsScript.TabIndex = 15;
			this.labelExportAsScript.Text = "Als SQL-Skript exportieren";
			// 
			// buttonExportAsScript
			// 
			this.buttonExportAsScript.Image = ((System.Drawing.Image)(resources.GetObject("buttonExportAsScript.Image")));
			this.buttonExportAsScript.Location = new System.Drawing.Point(256, 190);
			this.buttonExportAsScript.Name = "buttonExportAsScript";
			this.buttonExportAsScript.Size = new System.Drawing.Size(40, 40);
			this.buttonExportAsScript.TabIndex = 14;
			this.toolTipApp.SetToolTip(this.buttonExportAsScript, "Exportiert ein Terrain als SQL-Skript");
			this.buttonExportAsScript.UseCompatibleTextRendering = true;
			this.buttonExportAsScript.UseVisualStyleBackColor = true;
			this.buttonExportAsScript.Click += new System.EventHandler(this.ButtonExportAsScript_Click);
			// 
			// labelExportAsImage
			// 
			this.labelExportAsImage.AutoSize = true;
			this.labelExportAsImage.BackColor = System.Drawing.Color.Transparent;
			this.labelExportAsImage.Location = new System.Drawing.Point(303, 141);
			this.labelExportAsImage.Name = "labelExportAsImage";
			this.labelExportAsImage.Size = new System.Drawing.Size(107, 13);
			this.labelExportAsImage.TabIndex = 13;
			this.labelExportAsImage.Text = "Als Grafik exportieren";
			// 
			// buttonExportAsImage
			// 
			this.buttonExportAsImage.Image = ((System.Drawing.Image)(resources.GetObject("buttonExportAsImage.Image")));
			this.buttonExportAsImage.Location = new System.Drawing.Point(256, 129);
			this.buttonExportAsImage.Name = "buttonExportAsImage";
			this.buttonExportAsImage.Size = new System.Drawing.Size(40, 40);
			this.buttonExportAsImage.TabIndex = 12;
			this.toolTipApp.SetToolTip(this.buttonExportAsImage, "Exportiert ein Terrain als Grafik");
			this.buttonExportAsImage.UseCompatibleTextRendering = true;
			this.buttonExportAsImage.UseVisualStyleBackColor = true;
			this.buttonExportAsImage.Click += new System.EventHandler(this.ButtonExportAsImage_Click);
			// 
			// labelExportAsModel
			// 
			this.labelExportAsModel.AutoSize = true;
			this.labelExportAsModel.BackColor = System.Drawing.Color.Transparent;
			this.labelExportAsModel.Location = new System.Drawing.Point(303, 81);
			this.labelExportAsModel.Name = "labelExportAsModel";
			this.labelExportAsModel.Size = new System.Drawing.Size(110, 13);
			this.labelExportAsModel.TabIndex = 11;
			this.labelExportAsModel.Text = "Als Modell exportieren";
			// 
			// buttonExportAsModel
			// 
			this.buttonExportAsModel.Image = ((System.Drawing.Image)(resources.GetObject("buttonExportAsModel.Image")));
			this.buttonExportAsModel.Location = new System.Drawing.Point(256, 69);
			this.buttonExportAsModel.Name = "buttonExportAsModel";
			this.buttonExportAsModel.Size = new System.Drawing.Size(40, 40);
			this.buttonExportAsModel.TabIndex = 10;
			this.toolTipApp.SetToolTip(this.buttonExportAsModel, "Exportiert ein Terrain als Modell");
			this.buttonExportAsModel.UseCompatibleTextRendering = true;
			this.buttonExportAsModel.UseVisualStyleBackColor = true;
			this.buttonExportAsModel.Click += new System.EventHandler(this.ButtonExportAsModel_Click);
			// 
			// labelEditTerrain
			// 
			this.labelEditTerrain.AutoSize = true;
			this.labelEditTerrain.BackColor = System.Drawing.Color.Transparent;
			this.labelEditTerrain.Location = new System.Drawing.Point(303, 24);
			this.labelEditTerrain.Name = "labelEditTerrain";
			this.labelEditTerrain.Size = new System.Drawing.Size(139, 13);
			this.labelEditTerrain.TabIndex = 9;
			this.labelEditTerrain.Text = "Aktuelles Terrain bearbeiten";
			// 
			// buttonEditTerrain
			// 
			this.buttonEditTerrain.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditTerrain.Image")));
			this.buttonEditTerrain.Location = new System.Drawing.Point(256, 12);
			this.buttonEditTerrain.Name = "buttonEditTerrain";
			this.buttonEditTerrain.Size = new System.Drawing.Size(40, 40);
			this.buttonEditTerrain.TabIndex = 8;
			this.toolTipApp.SetToolTip(this.buttonEditTerrain, "Bearbeitet ein Terrain");
			this.buttonEditTerrain.UseCompatibleTextRendering = true;
			this.buttonEditTerrain.UseVisualStyleBackColor = true;
			this.buttonEditTerrain.Click += new System.EventHandler(this.ButtonEditTerrain_Click);
			// 
			// labelCloseTerrain
			// 
			this.labelCloseTerrain.AutoSize = true;
			this.labelCloseTerrain.BackColor = System.Drawing.Color.Transparent;
			this.labelCloseTerrain.Location = new System.Drawing.Point(59, 202);
			this.labelCloseTerrain.Name = "labelCloseTerrain";
			this.labelCloseTerrain.Size = new System.Drawing.Size(134, 13);
			this.labelCloseTerrain.TabIndex = 7;
			this.labelCloseTerrain.Text = "Aktuelles Terrain schließen";
			// 
			// buttonCloseTerrain
			// 
			this.buttonCloseTerrain.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseTerrain.Image")));
			this.buttonCloseTerrain.Location = new System.Drawing.Point(12, 190);
			this.buttonCloseTerrain.Name = "buttonCloseTerrain";
			this.buttonCloseTerrain.Size = new System.Drawing.Size(40, 40);
			this.buttonCloseTerrain.TabIndex = 6;
			this.toolTipApp.SetToolTip(this.buttonCloseTerrain, "Schließt das Terrain");
			this.buttonCloseTerrain.UseCompatibleTextRendering = true;
			this.buttonCloseTerrain.UseVisualStyleBackColor = true;
			this.buttonCloseTerrain.Click += new System.EventHandler(this.ButtonCloseTerrain_Click);
			// 
			// labelSaveTerrain
			// 
			this.labelSaveTerrain.AutoSize = true;
			this.labelSaveTerrain.BackColor = System.Drawing.Color.Transparent;
			this.labelSaveTerrain.Location = new System.Drawing.Point(59, 141);
			this.labelSaveTerrain.Name = "labelSaveTerrain";
			this.labelSaveTerrain.Size = new System.Drawing.Size(135, 13);
			this.labelSaveTerrain.TabIndex = 5;
			this.labelSaveTerrain.Text = "Aktuelles Terrain speichern";
			// 
			// buttonSaveTerrain
			// 
			this.buttonSaveTerrain.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveTerrain.Image")));
			this.buttonSaveTerrain.Location = new System.Drawing.Point(12, 129);
			this.buttonSaveTerrain.Name = "buttonSaveTerrain";
			this.buttonSaveTerrain.Size = new System.Drawing.Size(40, 40);
			this.buttonSaveTerrain.TabIndex = 4;
			this.toolTipApp.SetToolTip(this.buttonSaveTerrain, "Speichert das Terrain");
			this.buttonSaveTerrain.UseCompatibleTextRendering = true;
			this.buttonSaveTerrain.UseVisualStyleBackColor = true;
			this.buttonSaveTerrain.Click += new System.EventHandler(this.ButtonSaveTerrain_Click);
			// 
			// labelLoadTerrain
			// 
			this.labelLoadTerrain.AutoSize = true;
			this.labelLoadTerrain.BackColor = System.Drawing.Color.Transparent;
			this.labelLoadTerrain.Location = new System.Drawing.Point(59, 81);
			this.labelLoadTerrain.Name = "labelLoadTerrain";
			this.labelLoadTerrain.Size = new System.Drawing.Size(69, 13);
			this.labelLoadTerrain.TabIndex = 3;
			this.labelLoadTerrain.Text = "Terrain laden";
			// 
			// buttonLoadTerrain
			// 
			this.buttonLoadTerrain.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadTerrain.Image")));
			this.buttonLoadTerrain.Location = new System.Drawing.Point(12, 69);
			this.buttonLoadTerrain.Name = "buttonLoadTerrain";
			this.buttonLoadTerrain.Size = new System.Drawing.Size(40, 40);
			this.buttonLoadTerrain.TabIndex = 2;
			this.toolTipApp.SetToolTip(this.buttonLoadTerrain, "Lädt ein Terrain");
			this.buttonLoadTerrain.UseCompatibleTextRendering = true;
			this.buttonLoadTerrain.UseVisualStyleBackColor = true;
			this.buttonLoadTerrain.Click += new System.EventHandler(this.ButtonLoadTerrain_Click);
			// 
			// labelCreateNewTerrain
			// 
			this.labelCreateNewTerrain.AutoSize = true;
			this.labelCreateNewTerrain.BackColor = System.Drawing.Color.Transparent;
			this.labelCreateNewTerrain.Location = new System.Drawing.Point(59, 24);
			this.labelCreateNewTerrain.Name = "labelCreateNewTerrain";
			this.labelCreateNewTerrain.Size = new System.Drawing.Size(116, 13);
			this.labelCreateNewTerrain.TabIndex = 1;
			this.labelCreateNewTerrain.Text = "Neues Terrain erstellen";
			// 
			// buttonNewTerrain
			// 
			this.buttonNewTerrain.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewTerrain.Image")));
			this.buttonNewTerrain.Location = new System.Drawing.Point(12, 12);
			this.buttonNewTerrain.Name = "buttonNewTerrain";
			this.buttonNewTerrain.Size = new System.Drawing.Size(40, 40);
			this.buttonNewTerrain.TabIndex = 0;
			this.toolTipApp.SetToolTip(this.buttonNewTerrain, "Erstellt ein neues Terrain");
			this.buttonNewTerrain.UseCompatibleTextRendering = true;
			this.buttonNewTerrain.UseVisualStyleBackColor = true;
			this.buttonNewTerrain.Click += new System.EventHandler(this.ButtonNewTerrain_Click);
			// 
			// statusStripApp
			// 
			this.statusStripApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel2});
			this.statusStripApp.Location = new System.Drawing.Point(0, 320);
			this.statusStripApp.Name = "statusStripApp";
			this.statusStripApp.Size = new System.Drawing.Size(455, 22);
			this.statusStripApp.SizingGrip = false;
			this.statusStripApp.TabIndex = 20;
			this.statusStripApp.Text = "statusStripApp";
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
			this.ClientSize = new System.Drawing.Size(455, 342);
			this.Controls.Add(this.statusStripApp);
			this.Controls.Add(this.labelCloseApp);
			this.Controls.Add(this.buttonCloseApp);
			this.Controls.Add(this.labelInfoApp);
			this.Controls.Add(this.buttonInfoApp);
			this.Controls.Add(this.labelExportAsScript);
			this.Controls.Add(this.buttonExportAsScript);
			this.Controls.Add(this.labelExportAsImage);
			this.Controls.Add(this.buttonExportAsImage);
			this.Controls.Add(this.labelExportAsModel);
			this.Controls.Add(this.buttonExportAsModel);
			this.Controls.Add(this.labelEditTerrain);
			this.Controls.Add(this.buttonEditTerrain);
			this.Controls.Add(this.labelCloseTerrain);
			this.Controls.Add(this.buttonCloseTerrain);
			this.Controls.Add(this.labelSaveTerrain);
			this.Controls.Add(this.buttonSaveTerrain);
			this.Controls.Add(this.labelLoadTerrain);
			this.Controls.Add(this.buttonLoadTerrain);
			this.Controls.Add(this.labelCreateNewTerrain);
			this.Controls.Add(this.buttonNewTerrain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AppForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Magrathea - Terrain Builder";
			this.Load += new System.EventHandler(this.AppForm_Load);
			this.statusStripApp.ResumeLayout(false);
			this.statusStripApp.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelCloseApp;
    private System.Windows.Forms.Button buttonCloseApp;
    private System.Windows.Forms.Label labelInfoApp;
    private System.Windows.Forms.Button buttonInfoApp;
    private System.Windows.Forms.Label labelExportAsScript;
    private System.Windows.Forms.Button buttonExportAsScript;
    private System.Windows.Forms.Label labelExportAsImage;
    private System.Windows.Forms.Button buttonExportAsImage;
    private System.Windows.Forms.Label labelExportAsModel;
    private System.Windows.Forms.Button buttonExportAsModel;
    private System.Windows.Forms.Label labelEditTerrain;
    private System.Windows.Forms.Button buttonEditTerrain;
    private System.Windows.Forms.Label labelCloseTerrain;
    private System.Windows.Forms.Button buttonCloseTerrain;
    private System.Windows.Forms.Label labelSaveTerrain;
    private System.Windows.Forms.Button buttonSaveTerrain;
    private System.Windows.Forms.Label labelLoadTerrain;
    private System.Windows.Forms.Button buttonLoadTerrain;
    private System.Windows.Forms.Label labelCreateNewTerrain;
    private System.Windows.Forms.Button buttonNewTerrain;
    private System.Windows.Forms.ToolTip toolTipApp;
    private System.Windows.Forms.StatusStrip statusStripApp;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
  }
}

