using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SierraPropertiesEditor
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			#if (DEBUG)
			{ 
				MessageBox.Show("You are using pre-release software, \n\rsome functions might not work!"); 
			}
			#endif
			Application.Run(new mainForm());
		}
	}
}
