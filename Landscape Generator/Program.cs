using System;
using System.Windows.Forms;

namespace LandscapeGenerator
{
	/// <summary>
	/// Program
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// main entrance point of the application
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (AppForm appForm = new AppForm())
			{
				Application.Run(mainForm: appForm);
			}
		}
	}
}
