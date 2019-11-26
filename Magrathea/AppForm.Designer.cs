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
      this.bnCloseApp = new System.Windows.Forms.Button();
      this.labelInfoApp = new System.Windows.Forms.Label();
      this.btnInfoApp = new System.Windows.Forms.Button();
      this.labelExportAsScript = new System.Windows.Forms.Label();
      this.btnExportAsScript = new System.Windows.Forms.Button();
      this.labelExportAsImage = new System.Windows.Forms.Label();
      this.btnExportAsImage = new System.Windows.Forms.Button();
      this.labelExportAsModel = new System.Windows.Forms.Label();
      this.btnExportAsModel = new System.Windows.Forms.Button();
      this.labelEditTerrain = new System.Windows.Forms.Label();
      this.btnEditTerrain = new System.Windows.Forms.Button();
      this.labelCloseTerrain = new System.Windows.Forms.Label();
      this.btnCloseTerrain = new System.Windows.Forms.Button();
      this.labelSaveTerrain = new System.Windows.Forms.Label();
      this.btnSaveTerrain = new System.Windows.Forms.Button();
      this.labelLoadTerrain = new System.Windows.Forms.Label();
      this.btnLoadTerrain = new System.Windows.Forms.Button();
      this.labelCreateNewTerrain = new System.Windows.Forms.Label();
      this.btnNewTerrain = new System.Windows.Forms.Button();
      this.toolTipApp = new System.Windows.Forms.ToolTip(this.components);
      this.statusStripApp = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusStripApp.SuspendLayout();
      this.SuspendLayout();
      // 
      // labelCloseApp
      // 
      this.labelCloseApp.AutoSize = true;
      this.labelCloseApp.Location = new System.Drawing.Point(303, 283);
      this.labelCloseApp.Name = "labelCloseApp";
      this.labelCloseApp.Size = new System.Drawing.Size(104, 17);
      this.labelCloseApp.TabIndex = 39;
      this.labelCloseApp.Text = "Programm beenden";
      this.labelCloseApp.UseCompatibleTextRendering = true;
      // 
      // bnCloseApp
      // 
      this.bnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("bnCloseApp.Image")));
      this.bnCloseApp.Location = new System.Drawing.Point(256, 271);
      this.bnCloseApp.Name = "bnCloseApp";
      this.bnCloseApp.Size = new System.Drawing.Size(40, 40);
      this.bnCloseApp.TabIndex = 38;
      this.toolTipApp.SetToolTip(this.bnCloseApp, "Beendet das Programm");
      this.bnCloseApp.UseCompatibleTextRendering = true;
      this.bnCloseApp.UseVisualStyleBackColor = true;
      this.bnCloseApp.Click += new System.EventHandler(this.bnCloseApp_Click);
      // 
      // labelInfoApp
      // 
      this.labelInfoApp.AutoSize = true;
      this.labelInfoApp.Location = new System.Drawing.Point(59, 283);
      this.labelInfoApp.Name = "labelInfoApp";
      this.labelInfoApp.Size = new System.Drawing.Size(175, 17);
      this.labelInfoApp.TabIndex = 37;
      this.labelInfoApp.Text = "Programminformationen anzeigen";
      this.labelInfoApp.UseCompatibleTextRendering = true;
      // 
      // btnInfoApp
      // 
      this.btnInfoApp.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoApp.Image")));
      this.btnInfoApp.Location = new System.Drawing.Point(12, 271);
      this.btnInfoApp.Name = "btnInfoApp";
      this.btnInfoApp.Size = new System.Drawing.Size(40, 40);
      this.btnInfoApp.TabIndex = 36;
      this.toolTipApp.SetToolTip(this.btnInfoApp, "Zeigt Informationen zum Programm an");
      this.btnInfoApp.UseCompatibleTextRendering = true;
      this.btnInfoApp.UseVisualStyleBackColor = true;
      this.btnInfoApp.Click += new System.EventHandler(this.btnInfoApp_Click);
      // 
      // labelExportAsScript
      // 
      this.labelExportAsScript.AutoSize = true;
      this.labelExportAsScript.Location = new System.Drawing.Point(303, 202);
      this.labelExportAsScript.Name = "labelExportAsScript";
      this.labelExportAsScript.Size = new System.Drawing.Size(138, 17);
      this.labelExportAsScript.TabIndex = 35;
      this.labelExportAsScript.Text = "Als SQL-Skript exportieren";
      this.labelExportAsScript.UseCompatibleTextRendering = true;
      // 
      // btnExportAsScript
      // 
      this.btnExportAsScript.Image = ((System.Drawing.Image)(resources.GetObject("btnExportAsScript.Image")));
      this.btnExportAsScript.Location = new System.Drawing.Point(256, 190);
      this.btnExportAsScript.Name = "btnExportAsScript";
      this.btnExportAsScript.Size = new System.Drawing.Size(40, 40);
      this.btnExportAsScript.TabIndex = 34;
      this.toolTipApp.SetToolTip(this.btnExportAsScript, "Exportiert ein Terrain als SQL-Skript");
      this.btnExportAsScript.UseCompatibleTextRendering = true;
      this.btnExportAsScript.UseVisualStyleBackColor = true;
      this.btnExportAsScript.Click += new System.EventHandler(this.btnExportAsScript_Click);
      // 
      // labelExportAsImage
      // 
      this.labelExportAsImage.AutoSize = true;
      this.labelExportAsImage.Location = new System.Drawing.Point(303, 141);
      this.labelExportAsImage.Name = "labelExportAsImage";
      this.labelExportAsImage.Size = new System.Drawing.Size(113, 17);
      this.labelExportAsImage.TabIndex = 33;
      this.labelExportAsImage.Text = "Als Grafik exportieren";
      this.labelExportAsImage.UseCompatibleTextRendering = true;
      // 
      // btnExportAsImage
      // 
      this.btnExportAsImage.Image = ((System.Drawing.Image)(resources.GetObject("btnExportAsImage.Image")));
      this.btnExportAsImage.Location = new System.Drawing.Point(256, 129);
      this.btnExportAsImage.Name = "btnExportAsImage";
      this.btnExportAsImage.Size = new System.Drawing.Size(40, 40);
      this.btnExportAsImage.TabIndex = 32;
      this.toolTipApp.SetToolTip(this.btnExportAsImage, "Exportiert ein Terrain als Grafik");
      this.btnExportAsImage.UseCompatibleTextRendering = true;
      this.btnExportAsImage.UseVisualStyleBackColor = true;
      this.btnExportAsImage.Click += new System.EventHandler(this.btnExportAsImage_Click);
      // 
      // labelExportAsModel
      // 
      this.labelExportAsModel.AutoSize = true;
      this.labelExportAsModel.Location = new System.Drawing.Point(303, 81);
      this.labelExportAsModel.Name = "labelExportAsModel";
      this.labelExportAsModel.Size = new System.Drawing.Size(116, 17);
      this.labelExportAsModel.TabIndex = 11;
      this.labelExportAsModel.Text = "Als Modell exportieren";
      this.labelExportAsModel.UseCompatibleTextRendering = true;
      // 
      // btnExportAsModel
      // 
      this.btnExportAsModel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportAsModel.Image")));
      this.btnExportAsModel.Location = new System.Drawing.Point(256, 69);
      this.btnExportAsModel.Name = "btnExportAsModel";
      this.btnExportAsModel.Size = new System.Drawing.Size(40, 40);
      this.btnExportAsModel.TabIndex = 10;
      this.toolTipApp.SetToolTip(this.btnExportAsModel, "Exportiert ein Terrain als Modell");
      this.btnExportAsModel.UseCompatibleTextRendering = true;
      this.btnExportAsModel.UseVisualStyleBackColor = true;
      this.btnExportAsModel.Click += new System.EventHandler(this.btnExportAsModel_Click);
      // 
      // labelEditTerrain
      // 
      this.labelEditTerrain.AutoSize = true;
      this.labelEditTerrain.Location = new System.Drawing.Point(303, 24);
      this.labelEditTerrain.Name = "labelEditTerrain";
      this.labelEditTerrain.Size = new System.Drawing.Size(146, 17);
      this.labelEditTerrain.TabIndex = 9;
      this.labelEditTerrain.Text = "Aktuelles Terrain bearbeiten";
      this.labelEditTerrain.UseCompatibleTextRendering = true;
      // 
      // btnEditTerrain
      // 
      this.btnEditTerrain.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTerrain.Image")));
      this.btnEditTerrain.Location = new System.Drawing.Point(256, 12);
      this.btnEditTerrain.Name = "btnEditTerrain";
      this.btnEditTerrain.Size = new System.Drawing.Size(40, 40);
      this.btnEditTerrain.TabIndex = 8;
      this.toolTipApp.SetToolTip(this.btnEditTerrain, "Bearbeitet ein Terrain");
      this.btnEditTerrain.UseCompatibleTextRendering = true;
      this.btnEditTerrain.UseVisualStyleBackColor = true;
      this.btnEditTerrain.Click += new System.EventHandler(this.btnEditTerrain_Click);
      // 
      // labelCloseTerrain
      // 
      this.labelCloseTerrain.AutoSize = true;
      this.labelCloseTerrain.Location = new System.Drawing.Point(59, 202);
      this.labelCloseTerrain.Name = "labelCloseTerrain";
      this.labelCloseTerrain.Size = new System.Drawing.Size(141, 17);
      this.labelCloseTerrain.TabIndex = 7;
      this.labelCloseTerrain.Text = "Aktuelles Terrain schließen";
      this.labelCloseTerrain.UseCompatibleTextRendering = true;
      // 
      // btnCloseTerrain
      // 
      this.btnCloseTerrain.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseTerrain.Image")));
      this.btnCloseTerrain.Location = new System.Drawing.Point(12, 190);
      this.btnCloseTerrain.Name = "btnCloseTerrain";
      this.btnCloseTerrain.Size = new System.Drawing.Size(40, 40);
      this.btnCloseTerrain.TabIndex = 6;
      this.toolTipApp.SetToolTip(this.btnCloseTerrain, "Schließt das Terrain");
      this.btnCloseTerrain.UseCompatibleTextRendering = true;
      this.btnCloseTerrain.UseVisualStyleBackColor = true;
      this.btnCloseTerrain.Click += new System.EventHandler(this.btnCloseTerrain_Click);
      // 
      // labelSaveTerrain
      // 
      this.labelSaveTerrain.AutoSize = true;
      this.labelSaveTerrain.Location = new System.Drawing.Point(59, 141);
      this.labelSaveTerrain.Name = "labelSaveTerrain";
      this.labelSaveTerrain.Size = new System.Drawing.Size(141, 17);
      this.labelSaveTerrain.TabIndex = 5;
      this.labelSaveTerrain.Text = "Aktuelles Terrain speichern";
      this.labelSaveTerrain.UseCompatibleTextRendering = true;
      // 
      // btnSaveTerrain
      // 
      this.btnSaveTerrain.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveTerrain.Image")));
      this.btnSaveTerrain.Location = new System.Drawing.Point(12, 129);
      this.btnSaveTerrain.Name = "btnSaveTerrain";
      this.btnSaveTerrain.Size = new System.Drawing.Size(40, 40);
      this.btnSaveTerrain.TabIndex = 4;
      this.toolTipApp.SetToolTip(this.btnSaveTerrain, "Speichert das Terrain");
      this.btnSaveTerrain.UseCompatibleTextRendering = true;
      this.btnSaveTerrain.UseVisualStyleBackColor = true;
      this.btnSaveTerrain.Click += new System.EventHandler(this.btnSaveTerrain_Click);
      // 
      // labelLoadTerrain
      // 
      this.labelLoadTerrain.AutoSize = true;
      this.labelLoadTerrain.Location = new System.Drawing.Point(59, 81);
      this.labelLoadTerrain.Name = "labelLoadTerrain";
      this.labelLoadTerrain.Size = new System.Drawing.Size(71, 17);
      this.labelLoadTerrain.TabIndex = 3;
      this.labelLoadTerrain.Text = "Terrain laden";
      this.labelLoadTerrain.UseCompatibleTextRendering = true;
      // 
      // btnLoadTerrain
      // 
      this.btnLoadTerrain.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadTerrain.Image")));
      this.btnLoadTerrain.Location = new System.Drawing.Point(12, 69);
      this.btnLoadTerrain.Name = "btnLoadTerrain";
      this.btnLoadTerrain.Size = new System.Drawing.Size(40, 40);
      this.btnLoadTerrain.TabIndex = 2;
      this.toolTipApp.SetToolTip(this.btnLoadTerrain, "Lädt ein Terrain");
      this.btnLoadTerrain.UseCompatibleTextRendering = true;
      this.btnLoadTerrain.UseVisualStyleBackColor = true;
      this.btnLoadTerrain.Click += new System.EventHandler(this.btnLoadTerrain_Click);
      // 
      // labelCreateNewTerrain
      // 
      this.labelCreateNewTerrain.AutoSize = true;
      this.labelCreateNewTerrain.Location = new System.Drawing.Point(59, 24);
      this.labelCreateNewTerrain.Name = "labelCreateNewTerrain";
      this.labelCreateNewTerrain.Size = new System.Drawing.Size(122, 17);
      this.labelCreateNewTerrain.TabIndex = 1;
      this.labelCreateNewTerrain.Text = "Neues Terrain erstellen";
      this.labelCreateNewTerrain.UseCompatibleTextRendering = true;
      // 
      // btnNewTerrain
      // 
      this.btnNewTerrain.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTerrain.Image")));
      this.btnNewTerrain.Location = new System.Drawing.Point(12, 12);
      this.btnNewTerrain.Name = "btnNewTerrain";
      this.btnNewTerrain.Size = new System.Drawing.Size(40, 40);
      this.btnNewTerrain.TabIndex = 0;
      this.toolTipApp.SetToolTip(this.btnNewTerrain, "Erstellt ein neues Terrain");
      this.btnNewTerrain.UseCompatibleTextRendering = true;
      this.btnNewTerrain.UseVisualStyleBackColor = true;
      this.btnNewTerrain.Click += new System.EventHandler(this.btnNewTerrain_Click);
      // 
      // statusStripApp
      // 
      this.statusStripApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
      this.statusStripApp.Location = new System.Drawing.Point(0, 320);
      this.statusStripApp.Name = "statusStripApp";
      this.statusStripApp.Size = new System.Drawing.Size(455, 22);
      this.statusStripApp.SizingGrip = false;
      this.statusStripApp.TabIndex = 40;
      this.statusStripApp.Text = "statusStripApp";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
      this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
      // 
      // toolStripStatusLabel2
      // 
      this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
      this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
      this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
      // 
      // AppForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(455, 342);
      this.Controls.Add(this.statusStripApp);
      this.Controls.Add(this.labelCloseApp);
      this.Controls.Add(this.bnCloseApp);
      this.Controls.Add(this.labelInfoApp);
      this.Controls.Add(this.btnInfoApp);
      this.Controls.Add(this.labelExportAsScript);
      this.Controls.Add(this.btnExportAsScript);
      this.Controls.Add(this.labelExportAsImage);
      this.Controls.Add(this.btnExportAsImage);
      this.Controls.Add(this.labelExportAsModel);
      this.Controls.Add(this.btnExportAsModel);
      this.Controls.Add(this.labelEditTerrain);
      this.Controls.Add(this.btnEditTerrain);
      this.Controls.Add(this.labelCloseTerrain);
      this.Controls.Add(this.btnCloseTerrain);
      this.Controls.Add(this.labelSaveTerrain);
      this.Controls.Add(this.btnSaveTerrain);
      this.Controls.Add(this.labelLoadTerrain);
      this.Controls.Add(this.btnLoadTerrain);
      this.Controls.Add(this.labelCreateNewTerrain);
      this.Controls.Add(this.btnNewTerrain);
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
    private System.Windows.Forms.Button bnCloseApp;
    private System.Windows.Forms.Label labelInfoApp;
    private System.Windows.Forms.Button btnInfoApp;
    private System.Windows.Forms.Label labelExportAsScript;
    private System.Windows.Forms.Button btnExportAsScript;
    private System.Windows.Forms.Label labelExportAsImage;
    private System.Windows.Forms.Button btnExportAsImage;
    private System.Windows.Forms.Label labelExportAsModel;
    private System.Windows.Forms.Button btnExportAsModel;
    private System.Windows.Forms.Label labelEditTerrain;
    private System.Windows.Forms.Button btnEditTerrain;
    private System.Windows.Forms.Label labelCloseTerrain;
    private System.Windows.Forms.Button btnCloseTerrain;
    private System.Windows.Forms.Label labelSaveTerrain;
    private System.Windows.Forms.Button btnSaveTerrain;
    private System.Windows.Forms.Label labelLoadTerrain;
    private System.Windows.Forms.Button btnLoadTerrain;
    private System.Windows.Forms.Label labelCreateNewTerrain;
    private System.Windows.Forms.Button btnNewTerrain;
    private System.Windows.Forms.ToolTip toolTipApp;
    private System.Windows.Forms.StatusStrip statusStripApp;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
  }
}

