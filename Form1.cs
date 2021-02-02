using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
			using (FolderBrowserDialog fb = new FolderBrowserDialog())
			{
				DialogResult result = fb.ShowDialog();
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fb.SelectedPath))
				{
					pathBox.Text = fb.SelectedPath;
				}
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
		private void createFolders()
		{
			StreamReader reader = new StreamReader(configPath);
			string genFileStr = reader.ReadToEnd();
			var deserializer = new DeserializerBuilder().Build();
			var obj = deserializer.Deserialize<dynamic>(genFileStr);
			int selectedLang = langSelect.SelectedIndex;
			for(int i = 0; i != obj["languages"][selectedLang]["folders"].Count; i++)
			{
				Directory.CreateDirectory(folderPath + "/" + obj["languages"][selectedLang]["folders"][i]["folderName"]);
			}
			reader.Close();
		}
		private void createAndWriteFiles()
		{
			StreamReader reader = new StreamReader(configPath);
			string genFileStr = reader.ReadToEnd();
			var deserializer = new DeserializerBuilder().Build();
			var obj = deserializer.Deserialize<dynamic>(genFileStr);
			int selectedLang = langSelect.SelectedIndex;
			for(int i = 0; i != obj["languages"][selectedLang]["files"].Count; i++)
			{
				string fileDestination = folderPath + "/" + obj["languages"][selectedLang]["files"][i]["filePath"]+
					"/" + obj["languages"][selectedLang]["files"][i]["fileName"];
				FileStream fs = File.Create(fileDestination);
				fs.Close();
				StreamWriter writer = new StreamWriter(fileDestination);
				writer.Write(obj["languages"][selectedLang]["files"][i]["fileContent"]);
				writer.Flush();
				writer.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			refreshDropDown();
		}

		private void generateProj_Click(object sender, EventArgs e)
		{
			StreamReader reader = new StreamReader(configPath);
			string genFileStr = reader.ReadToEnd();
			var deserializer = new DeserializerBuilder().Build();
			var obj = deserializer.Deserialize<dynamic>(genFileStr);
			int selectedLang = langSelect.SelectedIndex;

			folderPath = pathBox.Text;
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
					openTerminalIn(folderPath);
					if (Int64.Parse(obj["languages"][selectedLang]["openExplorer"]) == 1)
					{
						openFolderIn(folderPath);
					}
					if (Int64.Parse(obj["languages"][selectedLang]["openTerminal"]) == 1)
					{
						openTerminalIn(folderPath);
					}
				}
				catch (Exception err)
				{
					MessageBox.Show("No Folder Selected");
				}
			}
			else
			{
				createFolders();
				createAndWriteFiles();
				if (Int64.Parse(obj["languages"][selectedLang]["openExplorer"]) == 1)
				{
					openFolderIn(folderPath);
				}
				if (Int64.Parse(obj["languages"][selectedLang]["openTerminal"]) == 1)
				{
					openTerminalIn(folderPath);
				}
			}
		}
		private void openFolderIn(string path)
		{
			Process.Start(path);
		}
		private void openTerminalIn(string path)
		{
			Process proc = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.WorkingDirectory = path;
			startInfo.FileName = "cmd.exe";
			proc.StartInfo = startInfo;
			proc.Start();
		}
		private void langSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			StreamReader reader = new StreamReader(configPath);
			string genFileStr = reader.ReadToEnd();
			var deserializer = new DeserializerBuilder().Build();
			var obj = deserializer.Deserialize<dynamic>(genFileStr);
			int selectedLang = langSelect.SelectedIndex;
			if(Int64.Parse(obj["languages"][selectedLang]["openTerminal"]) == 0)
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
		}

		private void versionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Version 0.3");
		}

		private void generatorPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start(Application.StartupPath + "\\.config");
		}
	}
}
