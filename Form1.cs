using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace ProjectGenerator_V2
{
	public partial class Form1 : Form
	{
		string folderPath = @"";
		string configPath = "./.config/config.yml";
		public Form1()
		{
			InitializeComponent();
		}

		private void selectPathBtn_Click(object sender, EventArgs e)
		{
			try
			{
				using (FolderBrowserDialog fb = new FolderBrowserDialog())
				{
					DialogResult result = fb.ShowDialog();
					if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fb.SelectedPath))
					{
						pathBox.Text = fb.SelectedPath;
					}
				}
			}
			catch
			{
				MessageBox.Show("Cant select folder");
			}
		}

		private void darkUIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/RobinPerris/DarkUI");
		}

		private void yamlDotNetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/aaubry/YamlDotNet");
		}
		private void refreshDropDown()
		{
			try
			{
				StreamReader reader = new StreamReader(configPath);
				string genFileStr = reader.ReadToEnd();
				var deserializer = new DeserializerBuilder().Build();
				var obj = deserializer.Deserialize<dynamic>(genFileStr);
				for (int i = 0; i != obj["languages"].Count; i++)
				{
					langSelect.Items.Add(obj["languages"][i]["langName"]);
				}
				reader.Close();
			}
			catch
			{
				MessageBox.Show("Cant show template in drop down");
			}
		}
		private void createFolders()
		{
			try
			{
				StreamReader reader = new StreamReader(configPath);
				string genFileStr = reader.ReadToEnd();
				var deserializer = new DeserializerBuilder().Build();
				var obj = deserializer.Deserialize<dynamic>(genFileStr);
				int selectedLang = langSelect.SelectedIndex;
				for (int i = 0; i != obj["languages"][selectedLang]["folders"].Count; i++)
				{
					Directory.CreateDirectory(folderPath + "/" + obj["languages"][selectedLang]["folders"][i]["folderName"]);
				}
				reader.Close();
			}
			catch
			{
				MessageBox.Show("Cant create folder");
			}
		}
		private void createAndWriteFiles()
		{
			try
			{
				StreamReader reader = new StreamReader(configPath);
				string genFileStr = reader.ReadToEnd();
				var deserializer = new DeserializerBuilder().Build();
				var obj = deserializer.Deserialize<dynamic>(genFileStr);
				int selectedLang = langSelect.SelectedIndex;
				for (int i = 0; i != obj["languages"][selectedLang]["files"].Count; i++)
				{
					string fileDestination = folderPath + "/" + obj["languages"][selectedLang]["files"][i]["filePath"] +
						"/" + obj["languages"][selectedLang]["files"][i]["fileName"];
					FileStream fs = File.Create(fileDestination);
					fs.Close();
					StreamWriter writer = new StreamWriter(fileDestination);
					writer.Write(obj["languages"][selectedLang]["files"][i]["fileContent"]);
					writer.Flush();
					writer.Close();
				}
				reader.Close();
			}
			catch
			{
				MessageBox.Show("Cant create file");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			refreshDropDown();
			langSelect.SelectedIndex = 0;
			StreamReader reader = new StreamReader(configPath);
			string genFileStr = reader.ReadToEnd();
			var deserializer = new DeserializerBuilder().Build();
			var obj = deserializer.Deserialize<dynamic>(genFileStr);
			int selectedLang = langSelect.SelectedIndex;
			if (Int64.Parse(obj["languages"][selectedLang]["openTerminal"]) == 0)
			{
				
				openCmdCB.Checked = false;
			}
			if (Int64.Parse(obj["languages"][selectedLang]["openTerminal"]) == 1)
			{
				openCmdCB.Checked = true;
			}
			if (Int64.Parse(obj["languages"][selectedLang]["openExplorer"]) == 0)
			{
				openExpCB.Checked = false;
			}
			if (Int64.Parse(obj["languages"][selectedLang]["openExplorer"]) == 1)
			{
				openExpCB.Checked = true;
			}
			if (Int64.Parse(obj["languages"][selectedLang]["pushToGit"]) == 0)
			{
				gitUrlBar.Enabled = false;
				pushToGitCB.Checked = false;
			}
			if (Int64.Parse(obj["languages"][selectedLang]["pushToGit"]) == 1)
			{
				gitUrlBar.Enabled = true;
				pushToGitCB.Checked = true;
			}
			reader.Close();
		}

		private void generateProj_Click(object sender, EventArgs e)
		{
			StreamReader reader = new StreamReader(configPath);
			string genFileStr = reader.ReadToEnd();
			var deserializer = new DeserializerBuilder().Build();
			var obj = deserializer.Deserialize<dynamic>(genFileStr);
			int selectedLang = langSelect.SelectedIndex;

			folderPath = pathBox.Text;
			if(pushToGitCB.Checked == true && gitUrlBar.Text == "")
			{
				MessageBox.Show("You need to add your git url");
			}
			else
			{
				if (folderPath == "")
				{
					try
					{
						using (FolderBrowserDialog fb = new FolderBrowserDialog())
						{
							DialogResult result = fb.ShowDialog();
							if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fb.SelectedPath))
							{
								pathBox.Text = fb.SelectedPath;
							}
						}
						createFolders();
						createAndWriteFiles();
						if (openExpCB.Checked == true)
						{
							openFolderIn(folderPath);
						}
						if (openCmdCB.Checked == true)
						{
							openTerminalIn(folderPath);
						}
						if (pushToGitCB.Checked == true)
						{
							gitPush();
						}
					}
					catch
					{
						MessageBox.Show("No Folder Selected");
					}
				}
				else
				{
					createFolders();
					createAndWriteFiles();
					if (openExpCB.Checked == true)
					{
						openFolderIn(folderPath);
					}
					if (openCmdCB.Checked == true)
					{
						openTerminalIn(folderPath);
					}
					if (pushToGitCB.Checked == true)
					{
						Thread.Sleep(2000);
						gitPush();
					}
				}
			}
			
			reader.Close();
		}
		private void openFolderIn(string path)
		{
			try
			{
				Process.Start(path);
			}
			catch
			{
				MessageBox.Show("Cant open folder");
			}
		}
		private void openTerminalIn(string path)
		{
			try
			{
				Process proc = new Process();
				ProcessStartInfo startInfo = new ProcessStartInfo();
				startInfo.WorkingDirectory = path;
				startInfo.FileName = "cmd.exe";
				proc.StartInfo = startInfo;
				proc.Start();
			}
			catch
			{
				MessageBox.Show("Cant Open Terminal");
			}
		}
		private void langSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				StreamReader reader = new StreamReader(configPath);
				string genFileStr = reader.ReadToEnd();
				var deserializer = new DeserializerBuilder().Build();
				var obj = deserializer.Deserialize<dynamic>(genFileStr);
				int selectedLang = langSelect.SelectedIndex;
				if (Int64.Parse(obj["languages"][selectedLang]["openTerminal"]) == 0)
				{
					openCmdCB.Checked = false;
				}
				if (Int64.Parse(obj["languages"][selectedLang]["openTerminal"]) == 1)
				{
					openCmdCB.Checked = true;
				}
				if (Int64.Parse(obj["languages"][selectedLang]["openExplorer"]) == 0)
				{
					openExpCB.Checked = false;
				}
				if (Int64.Parse(obj["languages"][selectedLang]["openExplorer"]) == 1)
				{
					openExpCB.Checked = true;
				}
				if (Int64.Parse(obj["languages"][selectedLang]["pushToGit"]) == 0)
				{
					gitUrlBar.Enabled = false;
					pushToGitCB.Checked = false;
				}
				if (Int64.Parse(obj["languages"][selectedLang]["pushToGit"]) == 1)
				{
					gitUrlBar.Enabled = true;
					pushToGitCB.Checked = true;
				}
				reader.Close();
			}
			catch
			{
				MessageBox.Show("Cant Update Dropdown");
			}
		}
		private void gitPush()
		{
			MessageBox.Show("Empty folders will not be added in your VCS provider if you add files inside that folder it will automaticaly show after you manualy push your project in your VCS provider");
			StreamWriter writer = new StreamWriter(Application.StartupPath +"/push.bat");
			writer.WriteLine("cd " + folderPath);
			writer.WriteLine("git init");
			writer.WriteLine("git add --all");
			writer.WriteLine("git commit -m \"initial commit\"");
			writer.WriteLine("git branch -M main");
			writer.WriteLine("git remote add origin " + gitUrlBar.Text); ;
			writer.WriteLine("git push -u origin main");
			writer.Flush();
			writer.Close();
			System.Diagnostics.Process.Start(Application.StartupPath+"/push.bat");
		}
		private void versionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Version 2");
		}

		private void generatorPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(Application.StartupPath + "\\.config");
			}
			catch
			{
				MessageBox.Show("Cant Open Folder");
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
