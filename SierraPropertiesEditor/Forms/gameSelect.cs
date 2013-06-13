using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SierraPropertiesEditor
{
	public partial class gameSelect : Form
	{
		internal string clickedon = "";

		public gameSelect()
		{
			InitializeComponent();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pBp.Image = SPE.Properties.Resources.Pharaoh_logo;
			pBc3.Image = SPE.Properties.Resources.C3_logo;
			pBz.Image = SPE.Properties.Resources.Zeus_logo;
		}

		private void pBp_Click(object sender, EventArgs e)
		{
			this.clickedon = "Pharaoh";
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void pBc3_Click(object sender, System.EventArgs e)
		{
			this.clickedon = "caesar3";
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void pBz_Click(object sender, System.EventArgs e)
		{
			this.clickedon = "zeus";
			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
