﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace SierraPropertiesEditor
{
	partial class About : Form
	{
		public About()
		{
			InitializeComponent();
			Text = String.Format("About {0}", AssemblyTitle);
			labelProductName.Text = AssemblyProduct;
			this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
			this.labelCopyright.Text = AssemblyCopyright;
			this.labelCompanyName.Text = AssemblyCompany;
			this.textBoxDescription.Text = AssemblyDescription;
			mainForm f = new mainForm();
			if (f.zeusimg) { pictureBox1.Image = SPE.Properties.Resources.Ok.ToBitmap(); } else { pictureBox1.Image = SPE.Properties.Resources.Error.ToBitmap(); }
			if (f.pharaohimg) { pictureBox2.Image = SPE.Properties.Resources.Ok.ToBitmap(); } else { pictureBox2.Image = SPE.Properties.Resources.Error.ToBitmap(); }
			if (f.Caesar3img) { pictureBox3.Image = SPE.Properties.Resources.Ok.ToBitmap(); } else { pictureBox3.Image = SPE.Properties.Resources.Error.ToBitmap(); }
		}

		public override sealed string Text
		{
			get { return base.Text; }
			set { base.Text = value; }
		}

		#region Assembly Attribute Accessors

		public string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		public string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion


	}
}
