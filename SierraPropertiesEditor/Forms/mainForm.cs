using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO; 

namespace SierraPropertiesEditor
{
	public partial class  mainForm : Form
	{
		internal string gamePath = "";
		internal string internalGame = "";
		internal string difficulty = "";
		internal string position = "";
		internal bool pharaohimg = false;
		internal bool Caesar3img = false;
		internal bool zeusimg = false;
		//internal string[] gameName = {"Ceasar 3","Pharaoh","Zeus"};

		public mainForm()
		{
		var	f = new IoFunctions();

		if (!f.CheckDllExistsance()) { MessageBox.Show("Missing SPE.DLL. \n\r Exiting.."); Environment.Exit(1); }
		if (f.CheckDllExistsance("Pharaoh")) { pharaohimg = true; }
		if (f.CheckDllExistsance("Zeus")) { zeusimg = true; }
		if (f.CheckDllExistsance("Caesar3")) { Caesar3img = true; }
			this.Icon = SPE.Properties.Resources.setup;
			InitializeComponent();
			SetMarginImageAndCheck();
			FillRecentMenu(recentToolStripMenuItem);
			MessageBox.Show(pharaohimg.ToString()+zeusimg.ToString()+Caesar3img.ToString());
			if(this.gamePath == "")
			{
				selectDifficultyToolStripMenuItem.Enabled = false;
			}
		}
//functions
		internal void FillRecentMenu(ToolStripMenuItem recentMenu)
		{
			ToolStripMenuItem pharaohBtn = new ToolStripMenuItem();
			pharaohBtn.Text = "Pharaoh";
			pharaohBtn.Click += new EventHandler(recentItem_Click);

			recentMenu.DropDown.Items.Add(pharaohBtn);
		}

		internal void SetMarginImageAndCheck()
		{
			foreach (ToolStripMenuItem menuItem in MainMenuStrip1.Items)
			{
				((ToolStripDropDownMenu)menuItem.DropDown).ShowImageMargin = false;
				((ToolStripDropDownMenu)menuItem.DropDown).ShowCheckMargin = false;
			}
			foreach (ToolStripMenuItem menuItem in selectDifficultyToolStripMenuItem.DropDown.Items)
			{
				((ToolStripDropDownMenu)menuItem.DropDown).ShowImageMargin = false;
				((ToolStripDropDownMenu)menuItem.DropDown).ShowCheckMargin = true;
			}
		}

		internal void resetMenuItems(bool menuOnly = true)
		{

			if(menuOnly == false)
			{
				this.internalGame = "";
				this.gamePath = "";
			}
			//reset checked difficulty menu items
			foreach (ToolStripMenuItem menuItem in selectDifficultyToolStripMenuItem.DropDownItems)
			{
				menuItem.Checked = false;
				menuItem.Enabled = false;
				menuItem.Visible = false;
			}
			button1.Enabled = false;
			return;
		}

		internal void UncheckOtherToolStripMenuItems(object selectedMenuItem)
		{
			ToolStripMenuItem parent = (ToolStripMenuItem)((ToolStripMenuItem)selectedMenuItem).OwnerItem;
			foreach (ToolStripMenuItem s in parent.DropDown.Items)
			{
				if (s.Name == ((ToolStripMenuItem)selectedMenuItem).Name)
				{
					s.Checked = true;
					s.CheckState = CheckState.Checked;
				}
				else
				{
					s.Checked = false;
					s.CheckState = CheckState.Unchecked;
				}
			}
		}

//onclick events
		internal void selectGamepathToolStripMenuItem_Click(object sender, EventArgs e)
		{
			IoFunctions f = new IoFunctions();
			string selpath = "";
			try
			{
				selpath = f.SelectGameFolder(); //selectgameFolder
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message,"Exception Error: 0x001");
			}
			
			if(selpath == "" || (selpath == this.gamePath))
			{
				//cancel
				return;
			}

			resetMenuItems(); //resetting items
			
			if (Environment.GetCommandLineArgs().Length <= 1)
			#region check zonder argumenten
			{
				 
				if (f.CheckGameExe(selpath, this))
				{
					if(!f.CheckGameFiles(this.internalGame, this))
					{
						return;
					}
					else
					{			
						textBox1.Text = this.internalGame;
						textBox2.Text = this.gamePath;
						return;
					}
				}
				else
				{
					MessageBox.Show("Alas, game not found, try debug mode", "Game not found");
					return;
				}
			}
			#endregion
			else 
			#region check met argumenten
			{
				if (Environment.GetCommandLineArgs()[1] == "--skip-game-check" || Environment.GetCommandLineArgs()[1] == "-sgc")
				{
					this.gamePath = selpath;
					gameSelect g = new gameSelect();
					g.ShowDialog();
					if(g.DialogResult == DialogResult.OK)
					{
						//MessageBox.Show(g.clickedon);
						this.internalGame = g.clickedon;
					}
				}
				else
				{
					if (!f.CheckGameExe(selpath, this))
					{
						MessageBox.Show("Alas, game not found, try debug mode\n\r0x0002", "Error 0x0002");
						return;
					}
				}
			}
			#endregion

			if (this.gamePath == "" || this.internalGame == "")
			{
				MessageBox.Show("Something went wrong","Var assoc");
				return;
			}

			textBox1.Text = this.internalGame;
			textBox2.Text = this.gamePath;
			return;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void veryEasyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UncheckOtherToolStripMenuItems(sender);
			this.difficulty = "veryEasy";
			button1.Enabled = true;
		}

		private void easyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UncheckOtherToolStripMenuItems(sender);
			this.difficulty = "easy";
			button1.Enabled = true;
		}

		private void normalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UncheckOtherToolStripMenuItems(sender);
			this.difficulty = "normal";
			button1.Enabled = true;
		}

		private void hardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UncheckOtherToolStripMenuItems(sender);
			this.difficulty = "hard";
			button1.Enabled = true;
		}

		private void impossibleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UncheckOtherToolStripMenuItems(sender);
			this.difficulty = "impossible";
			button1.Enabled = true;
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About abox = new About();
			abox.ShowDialog();
		}

//Onclick for dynamically created items 
		private void recentItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem s = (ToolStripMenuItem)sender;
			string[] data = new string[]{"pharaoh","D:\\Games\\GOG Games\\Pharaoh"};
			this.position = "recent";
			selectGamepathToolStripMenuItem_Click(sender, e);
			this.internalGame = data[0];
			this.gamePath = data[1];
			textBox1.Text = this.internalGame;
			textBox2.Text = this.gamePath;
		}

		internal void button1_Click(object sender, EventArgs e)
		{
			IoFunctions f = new IoFunctions();
			List<string> y = f.ReadGameItems(this.gamePath,this.internalGame,this.difficulty);
			//MessageBox.Show(y[0]);
			editableItems.DataSource = y;
				//MessageBox.Show("woepwoep");
			editableItems.Enabled = true;
		}

		private void editableItems_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox) sender;

		string str2;
			try
			{
				using (StreamReader reader = new StreamReader(gamePath + "\\" + internalGame + "_Model_" + difficulty + ".txt"))
				{
					while ((str2 = reader.ReadLine()) != null)
					{
						var regMatch = Regex.Match(str2, "^[0-9]{1,3},("+comboBox.SelectedText+")", RegexOptions.IgnoreCase);
						if (regMatch.Success)
						{
							MessageBox.Show((regMatch.ToString()));
						}

					}
				}
			}
			catch (Exception)
			{
				
				throw;
			}
			//string() == "Zoo" && internalGame == "pharaoh")
			//{
			//	pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			//}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form f = new gameSelect();
			f.ShowDialog();
		}

		private void mainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				DialogResult butpress = MessageBox.Show("","",MessageBoxButtons.YesNo);

				if(butpress == DialogResult.Yes)
				{
					this.Close();	
				}				
			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SettingsForm s = new SettingsForm();
			s.ShowIcon = false;
			s.ShowInTaskbar = false;
			s.ShowDialog();
		}
	}
}
