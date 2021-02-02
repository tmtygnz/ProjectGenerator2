
namespace ProjectGenerator_V2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.darkDropdownList1 = new DarkUI.Controls.DarkDropdownList();
			this.pathBox = new System.Windows.Forms.TextBox();
			this.selectPathBtn = new DarkUI.Controls.DarkButton();
			this.langText = new DarkUI.Controls.DarkLabel();
			this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generatorPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openCmdCB = new System.Windows.Forms.CheckBox();
			this.openExpCB = new System.Windows.Forms.CheckBox();
			this.generateProj = new DarkUI.Controls.DarkButton();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.packagesUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yamlDotNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// darkDropdownList1
			// 
			this.darkDropdownList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.darkDropdownList1.Location = new System.Drawing.Point(10, 72);
			this.darkDropdownList1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.darkDropdownList1.Name = "darkDropdownList1";
			this.darkDropdownList1.Size = new System.Drawing.Size(198, 34);
			this.darkDropdownList1.TabIndex = 0;
			this.darkDropdownList1.Text = "darkDropdownList1";
			// 
			// pathBox
			// 
			this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pathBox.Location = new System.Drawing.Point(14, 35);
			this.pathBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pathBox.Name = "pathBox";
			this.pathBox.Size = new System.Drawing.Size(194, 25);
			this.pathBox.TabIndex = 1;
			// 
			// selectPathBtn
			// 
			this.selectPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectPathBtn.Location = new System.Drawing.Point(217, 35);
			this.selectPathBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.selectPathBtn.Name = "selectPathBtn";
			this.selectPathBtn.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.selectPathBtn.Size = new System.Drawing.Size(86, 29);
			this.selectPathBtn.TabIndex = 2;
			this.selectPathBtn.Text = "Path";
			this.selectPathBtn.Click += new System.EventHandler(this.selectPathBtn_Click);
			// 
			// langText
			// 
			this.langText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.langText.AutoSize = true;
			this.langText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.langText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.langText.Location = new System.Drawing.Point(220, 78);
			this.langText.Name = "langText";
			this.langText.Size = new System.Drawing.Size(65, 17);
			this.langText.TabIndex = 3;
			this.langText.Text = "Language";
			// 
			// darkMenuStrip1
			// 
			this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.darkMenuStrip1.Name = "darkMenuStrip1";
			this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.darkMenuStrip1.Size = new System.Drawing.Size(317, 25);
			this.darkMenuStrip1.TabIndex = 4;
			this.darkMenuStrip1.Text = "darkMenuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatorPreferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// generatorPreferencesToolStripMenuItem
			// 
			this.generatorPreferencesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.generatorPreferencesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.generatorPreferencesToolStripMenuItem.Name = "generatorPreferencesToolStripMenuItem";
			this.generatorPreferencesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.generatorPreferencesToolStripMenuItem.Text = "Generator Preferences";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// openCmdCB
			// 
			this.openCmdCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.openCmdCB.AutoSize = true;
			this.openCmdCB.ForeColor = System.Drawing.Color.White;
			this.openCmdCB.Location = new System.Drawing.Point(14, 114);
			this.openCmdCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.openCmdCB.Name = "openCmdCB";
			this.openCmdCB.Size = new System.Drawing.Size(112, 21);
			this.openCmdCB.TabIndex = 5;
			this.openCmdCB.Text = "Open Terminal";
			this.openCmdCB.UseVisualStyleBackColor = true;
			// 
			// openExpCB
			// 
			this.openExpCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.openExpCB.AutoSize = true;
			this.openExpCB.ForeColor = System.Drawing.Color.White;
			this.openExpCB.Location = new System.Drawing.Point(14, 143);
			this.openExpCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.openExpCB.Name = "openExpCB";
			this.openExpCB.Size = new System.Drawing.Size(112, 21);
			this.openExpCB.TabIndex = 6;
			this.openExpCB.Text = "Open Explorer";
			this.openExpCB.UseVisualStyleBackColor = true;
			// 
			// generateProj
			// 
			this.generateProj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.generateProj.Location = new System.Drawing.Point(132, 111);
			this.generateProj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.generateProj.Name = "generateProj";
			this.generateProj.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.generateProj.Size = new System.Drawing.Size(173, 53);
			this.generateProj.TabIndex = 7;
			this.generateProj.Text = "Generate Project";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packagesUsedToolStripMenuItem,
            this.versionToolStripMenuItem});
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// packagesUsedToolStripMenuItem
			// 
			this.packagesUsedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.packagesUsedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkUIToolStripMenuItem,
            this.yamlDotNetToolStripMenuItem});
			this.packagesUsedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.packagesUsedToolStripMenuItem.Name = "packagesUsedToolStripMenuItem";
			this.packagesUsedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.packagesUsedToolStripMenuItem.Text = "Packages Used";
			// 
			// versionToolStripMenuItem
			// 
			this.versionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.versionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
			this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.versionToolStripMenuItem.Text = "Version";
			// 
			// darkUIToolStripMenuItem
			// 
			this.darkUIToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkUIToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkUIToolStripMenuItem.Name = "darkUIToolStripMenuItem";
			this.darkUIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.darkUIToolStripMenuItem.Text = "Dark UI";
			this.darkUIToolStripMenuItem.Click += new System.EventHandler(this.darkUIToolStripMenuItem_Click);
			// 
			// yamlDotNetToolStripMenuItem
			// 
			this.yamlDotNetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.yamlDotNetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.yamlDotNetToolStripMenuItem.Name = "yamlDotNetToolStripMenuItem";
			this.yamlDotNetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.yamlDotNetToolStripMenuItem.Text = "YamlDotNet";
			this.yamlDotNetToolStripMenuItem.Click += new System.EventHandler(this.yamlDotNetToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(317, 175);
			this.Controls.Add(this.generateProj);
			this.Controls.Add(this.openExpCB);
			this.Controls.Add(this.openCmdCB);
			this.Controls.Add(this.langText);
			this.Controls.Add(this.selectPathBtn);
			this.Controls.Add(this.pathBox);
			this.Controls.Add(this.darkDropdownList1);
			this.Controls.Add(this.darkMenuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.darkMenuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(449, 348);
			this.MinimumSize = new System.Drawing.Size(333, 214);
			this.Name = "Form1";
			this.Text = "Form1";
			this.darkMenuStrip1.ResumeLayout(false);
			this.darkMenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DarkUI.Controls.DarkDropdownList darkDropdownList1;
		private System.Windows.Forms.TextBox pathBox;
		private DarkUI.Controls.DarkButton selectPathBtn;
		private DarkUI.Controls.DarkLabel langText;
		private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generatorPreferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.CheckBox openCmdCB;
		private System.Windows.Forms.CheckBox openExpCB;
		private DarkUI.Controls.DarkButton generateProj;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem packagesUsedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem darkUIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yamlDotNetToolStripMenuItem;
	}
}

