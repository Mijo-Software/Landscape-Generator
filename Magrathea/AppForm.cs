using System;
using System.Windows.Forms;

namespace Magrathea
{
  public partial class AppForm : Form
  {
    public AppForm() => InitializeComponent();

    private void AppForm_Load(object sender, EventArgs e)
    {
    }

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

    private void ButtonLoadTerrain_Click(object sender, EventArgs e)
    {
    }

    private void ButtonSaveTerrain_Click(object sender, EventArgs e)
    {
    }

    private void ButtonCloseTerrain_Click(object sender, EventArgs e)
    {
    }

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

    private void ButtonExportAsModel_Click(object sender, EventArgs e)
    {
    }

    private void ButtonExportAsImage_Click(object sender, EventArgs e)
    {
    }

    private void ButtonExportAsScript_Click(object sender, EventArgs e)
    {
    }

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
  }
}