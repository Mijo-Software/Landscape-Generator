﻿namespace LandscapeGenerator
{
  partial class AboutBoxForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
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
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.toolTipAboutBox = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.02932F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.97068F));
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.46341F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.5122F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(314, 184);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logoPictureBox.Image = global::LandscapeGenerator.Properties.Resources.LscGen;
			this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.Size = new System.Drawing.Size(34, 178);
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			this.toolTipAboutBox.SetToolTip(this.logoPictureBox, "Programm-Icon");
			// 
			// labelProductName
			// 
			this.labelProductName.BackColor = System.Drawing.Color.Transparent;
			this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Location = new System.Drawing.Point(46, 0);
			this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(265, 17);
			this.labelProductName.TabIndex = 0;
			this.labelProductName.Text = "Produktname";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTipAboutBox.SetToolTip(this.labelProductName, "Zeigt den Produktnamen an");
			// 
			// labelVersion
			// 
			this.labelVersion.BackColor = System.Drawing.Color.Transparent;
			this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Location = new System.Drawing.Point(46, 18);
			this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(265, 17);
			this.labelVersion.TabIndex = 1;
			this.labelVersion.Text = "Version";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTipAboutBox.SetToolTip(this.labelVersion, "Zeigt die Version des Programms an");
			// 
			// labelCopyright
			// 
			this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
			this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCopyright.Location = new System.Drawing.Point(46, 36);
			this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(265, 17);
			this.labelCopyright.TabIndex = 2;
			this.labelCopyright.Text = "Copyright";
			this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTipAboutBox.SetToolTip(this.labelCopyright, "Zeigt den Copyright-Vermerk an");
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.BackColor = System.Drawing.Color.Transparent;
			this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCompanyName.Location = new System.Drawing.Point(46, 54);
			this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(265, 17);
			this.labelCompanyName.TabIndex = 3;
			this.labelCompanyName.Text = "Firmenname";
			this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTipAboutBox.SetToolTip(this.labelCompanyName, "Zeigt den Firmenname an");
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDescription.Location = new System.Drawing.Point(46, 75);
			this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxDescription.Size = new System.Drawing.Size(265, 69);
			this.textBoxDescription.TabIndex = 4;
			this.textBoxDescription.TabStop = false;
			this.textBoxDescription.Text = "Beschreibung";
			this.toolTipAboutBox.SetToolTip(this.textBoxDescription, "Zeigt die Beschreibung des Programm an");
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Image = global::LandscapeGenerator.Properties.Resources.fatcow_tick;
			this.okButton.Location = new System.Drawing.Point(252, 158);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(59, 23);
			this.okButton.TabIndex = 5;
			this.okButton.Text = "&OK";
			this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTipAboutBox.SetToolTip(this.okButton, "OK");
			this.okButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// AboutBoxForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(314, 184);
			this.Controls.Add(this.tableLayoutPanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBoxForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Programmminformationen";
			this.Load += new System.EventHandler(this.AboutBoxForm_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.PictureBox logoPictureBox;
    private System.Windows.Forms.Label labelProductName;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.Label labelCompanyName;
    private System.Windows.Forms.TextBox textBoxDescription;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.ToolTip toolTipAboutBox;
  }
}
