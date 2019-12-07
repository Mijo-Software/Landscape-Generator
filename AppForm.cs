using System;
using System.Windows.Forms;

namespace LandscapeGenerator
{
  /// <summary>
  /// AppForm
  /// </summary>
  public partial class AppForm : Form
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public AppForm() => InitializeComponent();

    /// <summary>
    /// Load the main window
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void AppForm_Load(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Create a new terrain
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonNewTerrain_Click(object sender, EventArgs e)
    {
      using (CreateNewTerrainForm formCreateNewTerrain = new CreateNewTerrainForm())
      {
        if (formCreateNewTerrain.ShowDialog() == DialogResult.OK)
        {
          //MessageBox.Show(formCreateNewTerrain.Name + " was entered into the database");
        }
      }
    }

    /// <summary>
    /// Load a terrain
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonLoadTerrain_Click(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Save a terrain
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonSaveTerrain_Click(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Close a terrain
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonCloseTerrain_Click(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Open the Info form
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonInfoApp_Click(object sender, EventArgs e)
    {
      using (InfoAppForm formInfoApp = new InfoAppForm())
      {
        if (formInfoApp.ShowDialog() == DialogResult.OK)
        {
          //MessageBox.Show(formInfoApp.Name + " was entered into the database");
        }
      }
    }

    /// <summary>
    /// Edit a terrain
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonEditTerrain_Click(object sender, EventArgs e)
    {
      using (EditTerrainForm formEditTerrain = new EditTerrainForm())
      {
        if (formEditTerrain.ShowDialog() == DialogResult.OK)
        {
          //MessageBox.Show(formEditTerrain.Name + " was entered into the database");
        }
      }
    }

    /// <summary>
    /// Export the terrain as model
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonExportAsModel_Click(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Export a terrain as image
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonExportAsImage_Click(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Export a terrain as script
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonExportAsScript_Click(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Close the application
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonCloseApp_Click(object sender, EventArgs e)
    {
      const string message = "Wollen Sie das Programm wirklich beenden?";
      const string caption = "Programm beenden";
      const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
      DialogResult result = MessageBox.Show(message, caption, buttons);
      if (result == DialogResult.Yes)
      {
        Close();
      }
    }

    /// <summary>
    /// Select the Fatcow icon theme
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ToolStripMenuItemFatcow_MouseEnter(object sender, EventArgs e)
    {
      toolStripMenuItemFatcow.Checked = true;
      toolStripMenuItemFugue.Checked = false;
      toolStripMenuItemSilk.Checked = false;
    }

    /// <summary>
    /// Select the Fugue icon theme
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ToolStripMenuItemFugue_MouseEnter(object sender, EventArgs e)
    {
      toolStripMenuItemFatcow.Checked = false;
      toolStripMenuItemFugue.Checked = true;
      toolStripMenuItemSilk.Checked = false;
    }

    /// <summary>
    /// Select the Silk icon theme
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ToolStripMenuItemSilk_MouseEnter(object sender, EventArgs e)
    {
      toolStripMenuItemFatcow.Checked = false;
      toolStripMenuItemFugue.Checked = false;
      toolStripMenuItemSilk.Checked = true;
    }
  }
}