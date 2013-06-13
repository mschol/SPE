using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace SierraPropertiesEditor
{
	class IoFunctions
	{
		
		internal string SearchGameFolder()
		{
			return "";
		}

		internal List<String> ReadGameItems(string path,string game, string difficulty)
		{
			var list = new List<string>();
			int i = 0;
			string str2;
			//MessageBox.Show(path + "\\Pharaoh_Model_"+difficulty+".txt");
			switch(game)
			{
				case "pharaoh":
					
					try
					{
						using (StreamReader reader = new StreamReader(path + "\\" + game + "_Model_" + difficulty + ".txt"))
						{
							while ((str2 = reader.ReadLine()) != null)
							{
								var regMatch = Regex.Match(str2, "^[0-9]{1,3},([a-z]{3,})", RegexOptions.IgnoreCase);
								if (regMatch.Success)
								{
									if (regMatch.Groups[1].Value != "nothing" && regMatch.Groups[1].Value != "Nothing")
									{
										//if (i == 20) { MessageBox.Show(str2.ToString()); }
										list.Add(regMatch.Groups[1].Value);
									}
								}
								i++;
							}
						}
					}
					catch(Exception exp)
					{
						throw exp;
					}
				break;

				case "zeus":
					try
					{
						using (StreamReader reader = new StreamReader(path + "\\model\\" + game + "_Model_" + difficulty + ".txt"))
						{
							while ((str2 = reader.ReadLine()) != null)
							{
								if(str2 != null)
								{
									Match regMatch = Regex.Match(str2, "^[0-9]{1,3},([a-z]{3,})", RegexOptions.IgnoreCase);
									if (regMatch.Success)
									{
										if (regMatch.Groups[1].Value != "nothing" && regMatch.Groups[1].Value != "Nothing")
										{
											//if (i == 20) { MessageBox.Show(str2.ToString()); }
											list.Add(regMatch.Groups[1].Value);
										}
									}
								}
								i++;
							}
						}
					}
					catch(Exception exp)
					{
						throw exp;
					}
				break;
				
				case "caesar3":
					try
					{
						using (StreamReader reader = new StreamReader(path + "\\C3_model.txt"))
						{
							list.Add("");
							while ((str2 = reader.ReadLine()) != null)
							{
								if(str2 != null)
								{
									Match regMatch = Regex.Match(str2, "^[0-9]{1,3},([a-z]{3,})", RegexOptions.IgnoreCase);
									if (regMatch.Success)
									{
										if (regMatch.Groups[1].Value != "nothing" && regMatch.Groups[1].Value != "Nothing")
										{
											//if (i == 20) { MessageBox.Show(str2.ToString()); }
											list.Add(regMatch.Groups[1].Value);
										}
									}
								}
								i++;
							}
						}
					}
					catch(Exception exp)
					{
						throw exp;
					}
				break;
			}
			//StreamReader reader = new StreamReader(path.ToString());
			return list;
		}

		internal bool CheckDllExistsance(string game = "")
		{
			MessageBox.Show(Directory.GetCurrentDirectory());
			if (game == "Pharaoh") { return File.Exists(Directory.GetCurrentDirectory() + "/add-on/PharaohImg.dll"); }
			if (game == "Zeus") { return File.Exists(Directory.GetCurrentDirectory() + "/add-on/ZeusImg.dll"); }
			if (game == "Caesar3") { return File.Exists(Directory.GetCurrentDirectory() + "/add-on/Caesar3Img.dll"); }
			try
			{
				return File.Exists(Directory.GetCurrentDirectory() + "/SPE.dll");
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.Message.ToString());
				throw;
			}
			
		}

		internal string SelectGameFolder()
		{
			var spef = new SierraPropertiesEditor.mainForm();
			var fbd = new FolderBrowserDialog
				{
					SelectedPath = spef.gamePath,
					RootFolder = Environment.SpecialFolder.MyComputer,
					ShowNewFolderButton = false
				};
			fbd.ShowDialog();
			return fbd.SelectedPath;
		}

		internal bool CheckGameExe(string selectedPath, mainForm fo)
		{
			string selpath = selectedPath;
			bool exitLoop = false;
			bool foundFile = false;
			var testPath = Directory.GetFiles(selpath, "*.exe", SearchOption.TopDirectoryOnly);
			if (testPath.Length == 0)
			{
				MessageBox.Show("No valid game found\n\rError: 0x0001", "No valid game found");
				return false;
			}
		
			foreach (string fi in testPath)
			{
				var file = Path.GetFileName(fi);
				if (file != null)
				{ 
					switch (file.ToLower())
					{
						case "pharaoh.exe":
							fo.internalGame = "pharaoh";
							fo.gamePath = selpath;
							fo.Icon = SPE.Properties.Resources.cleoicon;
							exitLoop = true;
							foundFile = true;
							break;
						case "zeus.exe":
							fo.internalGame = "zeus";
							fo.gamePath = selpath;
							fo.Icon = SPE.Properties.Resources.Poseidon;
							exitLoop = true;
							foundFile = true;
							break;
						case "c3.exe":
							fo.internalGame = "caesar3";
							fo.gamePath = selpath;
							fo.Icon = SPE.Properties.Resources.C3;
							exitLoop = true;
							foundFile = true;
							break;
						default:
							//additionel found exe's
							Console.Write(fi);
							break;
					}
				}

				if (exitLoop) break;
			}

			if(!foundFile) 
			{
			return false;
			}
		  return true;
		}

		internal bool CheckGameFiles(string selectedGame, mainForm fo)
		{			
			#region
			if (fo.internalGame == "pharaoh" || fo.internalGame == "zeus" || fo.internalGame == "caesar3")
			{

					//var testPath = Directory.GetFiles(fo.gamePath, "*.txt", SearchOption.TopDirectoryOnly);
				string[] difficulty = {"VeryEasy","Easy","Normal","Hard","Impossible"};

				foreach(string diff in difficulty)
				{
					string capInternalGame = char.ToUpper(selectedGame[0]) + selectedGame.Substring(1);
					
					if (File.Exists(fo.gamePath + "\\"+capInternalGame+"_Model_"+diff+".txt"))
					{
						if (!fo.selectDifficultyToolStripMenuItem.Enabled) { fo.selectDifficultyToolStripMenuItem.Enabled = true; }
						ToolStripItem itemName = fo.selectDifficultyToolStripMenuItem.DropDownItems.Find(diff + "ToolStripMenuItem", true).FirstOrDefault();
						itemName.Visible = true;
						itemName.Enabled = true;
						//foreach(ToolStripMenuItem)fo.selectDifficultyToolStripMenuItem.DropDown.Items;
						
						//fo.+diff+ToolStripMenuItem.Enabled = true;
						//fo.+diff+ToolStripMenuItem.Visible = true;
					}
					else if (File.Exists(fo.gamePath + "\\Model\\" + capInternalGame + "_Model_" + diff + ".txt"))
					{
						if (!fo.selectDifficultyToolStripMenuItem.Enabled) { fo.selectDifficultyToolStripMenuItem.Enabled = true; }
						ToolStripItem itemName = fo.selectDifficultyToolStripMenuItem.DropDownItems.Find(diff + "ToolStripMenuItem", true).FirstOrDefault();
						itemName.Visible = true;
						itemName.Enabled = true;
					}
					else if (File.Exists(fo.gamePath + "\\" + char.ToUpper(selectedGame[0]) + "3_Model.txt"))
					{
						if (!fo.selectDifficultyToolStripMenuItem.Enabled) { fo.selectDifficultyToolStripMenuItem.Enabled = true; }
						ToolStripItem itemName = fo.selectDifficultyToolStripMenuItem.DropDownItems.Find("NormalToolStripMenuItem", true).FirstOrDefault();
						itemName.Visible = true;
						itemName.Enabled = true;
					}
					else
					{
						MessageBox.Show("Files do not Excist");
					}
				}
			}
			else
			{
				MessageBox.Show("Wow, how did you do this?");
				return true;
			}
			#endregion
			return true;
			}		
	}
}
