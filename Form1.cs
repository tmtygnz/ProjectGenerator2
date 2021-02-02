using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGenerator_V2
{
	public partial class Form1 : Form
	{
		string filePath = @"";
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
	}
}
