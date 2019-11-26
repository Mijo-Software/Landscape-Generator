using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Magrathea
{
  public partial class AppForm : Form
  {
    public AppForm()
    {
      InitializeComponent();
    }

    private void AppForm_Load(object sender, EventArgs e)
    {

    }

    private void btnNewTerrain_Click(object sender, EventArgs e)
    {
      CreateNewTerrainForm formCreateNewTerrain = new CreateNewTerrainForm();
      if (formCreateNewTerrain.ShowDialog() == DialogResult.OK)
      {
        //MessageBox.Show(formCreateNewTerrain.Name + " was entered into the database");
      }
    }

    private void btnLoadTerrain_Click(object sender, EventArgs e)
    {

    }

    private void btnSaveTerrain_Click(object sender, EventArgs e)
    {

    }

    private void btnCloseTerrain_Click(object sender, EventArgs e)
    {

    }

    private void btnInfoApp_Click(object sender, EventArgs e)
    {
      InfoAppForm formInfoApp = new InfoAppForm();
      if (formInfoApp.ShowDialog() == DialogResult.OK)
      {
        //MessageBox.Show(formInfoApp.Name + " was entered into the database");
      }
    }

    private void btnEditTerrain_Click(object sender, EventArgs e)
    {
      EditTerrainForm formEditTerrain = new EditTerrainForm();
      if (formEditTerrain.ShowDialog() == DialogResult.OK)
      {
        //MessageBox.Show(formEditTerrain.Name + " was entered into the database");
      }
    }

    private void btnExportAsModel_Click(object sender, EventArgs e)
    {

    }

    private void btnExportAsImage_Click(object sender, EventArgs e)
    {

    }

    private void btnExportAsScript_Click(object sender, EventArgs e)
    {

    }

    private void bnCloseApp_Click(object sender, EventArgs e)
    {
      string message = "Wollen Sie das Programm wirklich beenden?";
      string caption = "Programm beenden";
      MessageBoxButtons buttons = MessageBoxButtons.YesNo;
      DialogResult result;
      result = MessageBox.Show(message,caption,buttons);
      if (result == DialogResult.Yes)
      {
        this.Close();
      }
    }
  }
}
