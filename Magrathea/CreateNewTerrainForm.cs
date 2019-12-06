using System;
using System.Windows.Forms;

namespace Magrathea
{
	public partial class CreateNewTerrainForm : Form
	{
		public CreateNewTerrainForm()
		{
			InitializeComponent();
		}

		private void ButtonViewTerrainPreview_Click(object sender, EventArgs e)
		{
			using (ViewTerrainForm formViewTerrainPreview = new ViewTerrainForm())
			{
				formViewTerrainPreview.ShowDialog();
			}
		}

		private void ButtonCreateTerrain_Click(object sender, EventArgs e)
		{
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
		}

		private void CreateNewTerrainForm_Load(object sender, EventArgs e)
		{
		}
	}
}