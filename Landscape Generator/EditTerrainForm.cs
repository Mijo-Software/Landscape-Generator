using System;
using System.Windows.Forms;

namespace LandscapeGenerator
{
	/// <summary>
	/// EditTerrainFrom
	/// </summary>
	public partial class EditTerrainForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public EditTerrainForm() => InitializeComponent();

		/// <summary>
		/// Increase the height of the terrain
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonIncreasePlane_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Decrease the height of the terrain
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonDecreasePlane_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Rotate the terrain to left
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonRotateLeft90_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Rotate the terrain to right
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonRotateRight90_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Mirror the platerrainne horizontally
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonMirrorHorizontal_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Mirror the terrain vertically
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonMirrorVertical_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Canyonize the terrain
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCanyonize_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Invert the terrain
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonInvert_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Smooth the terrain
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSmooth_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// View the terrain
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonViewTerrainFull_Click(object sender, EventArgs e)
		{
			using (ViewTerrainForm formViewTerrain = new ViewTerrainForm())
			{
				if (formViewTerrain.ShowDialog() == DialogResult.OK)
				{
					//MessageBox.Show(formViewTerrain.Name + " was entered into the database");
				}
			}
		}

		/// <summary>
		/// Shift the terrain backward
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonShiftTerrainBackward_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Shift the terrain to north
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonShiftTerrainN_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Shift the terrain to north-east
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonShiftTerrainNE_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Shift the terrain to east
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonShiftTerrainE_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Shift the terrain to south-east
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonShiftTerrainSE_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Shift the terrain to south
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonShiftTerrainS_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Shift the terrain to south-west
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonShiftTerrainSW_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Shift the terrain to west
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonShiftTerrainW_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Shift the terrain to north-west
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonShiftTerrainNW_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// OK
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonOK_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Cancel
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCancel_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Edit the terrain
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void EditTerrainForm_Load(object sender, EventArgs e)
		{
		}
	}
}