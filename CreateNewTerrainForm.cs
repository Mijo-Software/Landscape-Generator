using System;
using System.Windows.Forms;

namespace LandscapeGenerator
{
	/// <summary>
	/// CreateNewTerrainForm
	/// </summary>
	public partial class CreateNewTerrainForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public CreateNewTerrainForm() => InitializeComponent();

		/// <summary>
		/// Show the terrain preview
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonViewTerrainPreview_Click(object sender, EventArgs e)
		{
			using (ViewTerrainForm formViewTerrainPreview = new ViewTerrainForm())
			{
				formViewTerrainPreview.ShowDialog();
			}
		}

		/// <summary>
		/// Create a new terrain
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCreateTerrain_Click(object sender, EventArgs e)
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
		/// Cancel the form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCancel_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Load the form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void CreateNewTerrainForm_Load(object sender, EventArgs e)
		{
		}
	}
}