using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Magrathea
{
  public partial class CreateNewTerrainForm : Form
  {
    public CreateNewTerrainForm()
    {
      InitializeComponent();
    }

    private void btnViewTerrainPreview_Click(object sender, EventArgs e)
    {
      ViewTerrainForm formViewTerrainPreview = new ViewTerrainForm();
      formViewTerrainPreview.ShowDialog();
    }

    private void btnCreateTerrain_Click(object sender, EventArgs e)
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
