using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Magrathea
{
  public partial class EditTerrainForm : Form
  {
    public EditTerrainForm()
    {
      InitializeComponent();
    }

    private void btnIncreasePlane_Click(object sender, EventArgs e)
    {

    }

    private void btnDecreasePlane_Click(object sender, EventArgs e)
    {

    }

    private void btnRotateLeft90_Click(object sender, EventArgs e)
    {

    }

    private void btnRotateRight90_Click(object sender, EventArgs e)
    {

    }

    private void btnMirrorHorizontal_Click(object sender, EventArgs e)
    {

    }

    private void btnMirrorVertical_Click(object sender, EventArgs e)
    {

    }

    private void btnCanyonize_Click(object sender, EventArgs e)
    {

    }

    private void btnInvert_Click(object sender, EventArgs e)
    {

    }

    private void btnSmooth_Click(object sender, EventArgs e)
    {

    }

    private void btnViewTerrainFull_Click(object sender, EventArgs e)
    {
      ViewTerrainForm formViewTerrain = new ViewTerrainForm();
      if (formViewTerrain.ShowDialog() == DialogResult.OK)
      {
        //MessageBox.Show(formViewTerrain.Name + " was entered into the database");
      }
    }

    private void bntShiftTerrainBackward_Click(object sender, EventArgs e)
    {

    }

    private void bntShiftTerrainN_Click(object sender, EventArgs e)
    {

    }

    private void bntShiftTerrainNE_Click(object sender, EventArgs e)
    {

    }

    private void bntShiftTerrainE_Click(object sender, EventArgs e)
    {

    }

    private void bntShiftTerrainSE_Click(object sender, EventArgs e)
    {

    }

    private void bntShiftTerrainS_Click(object sender, EventArgs e)
    {

    }

    private void bntShiftTerrainSW_Click(object sender, EventArgs e)
    {

    }

    private void bntShiftTerrainW_Click(object sender, EventArgs e)
    {

    }

    private void bntShiftTerrainNW_Click(object sender, EventArgs e)
    {

    }

    private void btnOK_Click(object sender, EventArgs e)
    {

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {

    }

  }
}
