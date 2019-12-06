using System;
using System.Windows.Forms;

namespace Magrathea
{
	public partial class EditTerrainForm : Form
	{
		public EditTerrainForm() => InitializeComponent();

		private void ButtonIncreasePlane_Click(object sender, EventArgs e)
		{
		}

		private void ButtonDecreasePlane_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRotateLeft90_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRotateRight90_Click(object sender, EventArgs e)
		{
		}

		private void ButtonMirrorHorizontal_Click(object sender, EventArgs e)
		{
		}

		private void ButtonMirrorVertical_Click(object sender, EventArgs e)
		{
		}

		private void ButtonCanyonize_Click(object sender, EventArgs e)
		{
		}

		private void ButtonInvert_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSmooth_Click(object sender, EventArgs e)
		{
		}

		private void ButtonViewTerrainFull_Click(object sender, EventArgs e)
		{
			ViewTerrainForm formViewTerrain = new ViewTerrainForm();
			if (formViewTerrain.ShowDialog() == DialogResult.OK)
			{
				//MessageBox.Show(formViewTerrain.Name + " was entered into the database");
			}
		}

		private void ButtonShiftTerrainBackward_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftTerrainN_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftTerrainNE_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftTerrainE_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftTerrainSE_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftTerrainS_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftTerrainSW_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftTerrainW_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftTerrainNW_Click(object sender, EventArgs e)
		{
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
		}
	}
}