using LandscapeGenerator.Properties;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace LandscapeGenerator
{
  /// <summary>
  /// AppForm
  /// </summary>
  public partial class MainForm : Form
  {
    /// <summary>
		/// Settings
		/// </summary>
		private readonly Settings settings = new Settings();

    /// <summary>
		/// culture info for the date
		/// </summary>
		private readonly CultureInfo culture = CultureInfo.CurrentUICulture;

    /// <summary>
    /// Constructor
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Load the main window
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void AppForm_Load(object sender, EventArgs e)
    {
      switch (settings.userIconSet)
      {
        default: ToolStripMenuItemFatcowIcons_MouseEnter(sender: null, e: EventArgs.Empty); break;
        case "fugue": ToolStripMenuItemFugueIcons_MouseEnter(sender: null, e: EventArgs.Empty); break;
        case "silk": ToolStripMenuItemSilkIcons_MouseEnter(sender: null, e: EventArgs.Empty); break;
      }
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
    private void ButtonInformation_Click(object sender, EventArgs e)
    {
      using (AboutBoxForm aboutBoxForm = new AboutBoxForm())
      {
        if (aboutBoxForm.ShowDialog() == DialogResult.OK)
        {
          //MessageBox.Show(formInfoApp.Name + " was entered into the database");
        }
      }
    }

    /// <summary>
    /// Open the help
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonHelp_Click(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Load the settings
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonSettings_Click(object sender, EventArgs e)
    {
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
    private void ButtonExit_Click(object sender, EventArgs e)
    {
      DialogResult dialogResult = MessageBox.Show(text: Localization.exitTheAppQuestion, caption: Localization.exitTheAppTitle, buttons: MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.Yes)
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
    private void ToolStripMenuItemFatcowIcons_MouseEnter(object sender, EventArgs e)
    {
      toolStripMenuItemFatcow.Checked = true;
      toolStripMenuItemFugue.Checked = false;
      toolStripMenuItemSilk.Checked = false;
      Icon = Resources.fatcow_world_16;
      buttonNewTerrain.Image = Resources.fatcow_asterisk;
      buttonEditTerrain.Image = Resources.fatcow_pencil;
      buttonLoadTerrain.Image = Resources.fatcow_folder;
      buttonExportAsModel.Image = Resources.fatcow_shape_square;
      buttonSaveTerrain.Image = Resources.fatcow_disk;
      buttonExportAsImage.Image = Resources.fatcow_image;
      buttonCloseTerrain.Image = Resources.fatcow_cross;
      buttonExportAsScript.Image = Resources.fatcow_script;
      buttonInformation.Image = Resources.fatcow_information;
      buttonHelp.Image = Resources.fatcow_help;
      buttonSettings.Image = Resources.fatcow_wrench;
      buttonExit.Image = Resources.fatcow_door;
      toolStripDropDownButtonIconTheme.Image = Resources.fatcow_palette;
      settings.userIconSet = Resources.iconNameFatcow;
      settings.Save();
    }

    /// <summary>
    /// Select the Fugue icon theme
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ToolStripMenuItemFugueIcons_MouseEnter(object sender, EventArgs e)
    {
      toolStripMenuItemFatcow.Checked = false;
      toolStripMenuItemFugue.Checked = true;
      toolStripMenuItemSilk.Checked = false;
      Icon = Resources.fugue_world_16;
      buttonNewTerrain.Image = Resources.fugue_asterisk;
      buttonEditTerrain.Image = Resources.fugue_pencil;
      buttonLoadTerrain.Image = Resources.fugue_folder;
      buttonExportAsModel.Image = Resources.fugue_shape_square;
      buttonSaveTerrain.Image = Resources.fugue_disk;
      buttonExportAsImage.Image = Resources.fugue_image;
      buttonCloseTerrain.Image = Resources.fugue_cross;
      buttonExportAsScript.Image = Resources.fugue_script;
      buttonInformation.Image = Resources.fugue_information;
      buttonHelp.Image = Resources.fugue_help;
      buttonSettings.Image = Resources.fugue_wrench;
      buttonExit.Image = Resources.fugue_door;
      settings.userIconSet = Resources.iconNameFugue;
      toolStripDropDownButtonIconTheme.Image = Resources.fugue_palette;
      settings.Save();
    }

    /// <summary>
    /// Select the Silk icon theme
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ToolStripMenuItemSilkIcons_MouseEnter(object sender, EventArgs e)
    {
      toolStripMenuItemFatcow.Checked = false;
      toolStripMenuItemFugue.Checked = false;
      toolStripMenuItemSilk.Checked = true;
      Icon = Resources.silk_world_16;
      buttonNewTerrain.Image = Resources.silk_asterisk;
      buttonEditTerrain.Image = Resources.silk_pencil;
      buttonLoadTerrain.Image = Resources.silk_folder;
      buttonExportAsModel.Image = Resources.silk_shape_square;
      buttonSaveTerrain.Image = Resources.silk_disk;
      buttonExportAsImage.Image = Resources.silk_image;
      buttonCloseTerrain.Image = Resources.silk_cross;
      buttonExportAsScript.Image = Resources.silk_script;
      buttonInformation.Image = Resources.silk_information;
      buttonHelp.Image = Resources.silk_help;
      buttonSettings.Image = Resources.silk_wrench;
      buttonExit.Image = Resources.silk_door;
      toolStripDropDownButtonIconTheme.Image = Resources.silk_palette;
      settings.userIconSet = Resources.iconNameSilk;
      settings.Save();
    }
  }
}