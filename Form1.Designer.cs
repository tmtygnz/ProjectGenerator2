
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
			this.pathBox = new System.Windows.Forms.TextBox();
			this.selectPathBtn = new DarkUI.Controls.DarkButton();
			this.langText = new DarkUI.Controls.DarkLabel();
			this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generatorPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.packagesUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yamlDotNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openCmdCB = new System.Windows.Forms.CheckBox();
			this.openExpCB = new System.Windows.Forms.CheckBox();
			this.generateProj = new DarkUI.Controls.DarkButton();
			this.langSelect = new DarkUI.Controls.DarkComboBox();
			this.pushToGitCB = new System.Windows.Forms.CheckBox();
			this.gitUrlBar = new System.Windows.Forms.TextBox();
			this.darkLabel1 = new DarkUI.Controls.DarkLabel();
			this.darkMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pathBox
			// 
			this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pathBox.Location = new System.Drawing.Point(14, 43);
			this.pathBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pathBox.Name = "pathBox";
			this.pathBox.Size = new System.Drawing.Size(194, 25);
			this.pathBox.TabIndex = 1;
			// 
			// selectPathBtn
			// 
			this.selectPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectPathBtn.Location = new System.Drawing.Point(214, 40);
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
			this.langText.Location = new System.Drawing.Point(214, 78);
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
			this.generatorPreferencesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.generatorPreferencesToolStripMenuItem.Text = "Edit Generator Preferences";
			this.generatorPreferencesToolStripMenuItem.Click += new System.EventHandler(this.generatorPreferencesToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
			this.packagesUsedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.packagesUsedToolStripMenuItem.Text = "Packages Used";
			// 
			// darkUIToolStripMenuItem
			// 
			this.darkUIToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkUIToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkUIToolStripMenuItem.Name = "darkUIToolStripMenuItem";
			this.darkUIToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.darkUIToolStripMenuItem.Text = "Dark UI";
			this.darkUIToolStripMenuItem.Click += new System.EventHandler(this.darkUIToolStripMenuItem_Click);
			// 
			// yamlDotNetToolStripMenuItem
			// 
			this.yamlDotNetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.yamlDotNetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.yamlDotNetToolStripMenuItem.Name = "yamlDotNetToolStripMenuItem";
			this.yamlDotNetToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.yamlDotNetToolStripMenuItem.Text = "YamlDotNet";
			this.yamlDotNetToolStripMenuItem.Click += new System.EventHandler(this.yamlDotNetToolStripMenuItem_Click);
			// 
			// versionToolStripMenuItem
			// 
			this.versionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.versionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
			this.versionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.versionToolStripMenuItem.Text = "Version";
			this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
			// 
			// openCmdCB
			// 
			this.openCmdCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.openCmdCB.AutoSize = true;
			this.openCmdCB.ForeColor = System.Drawing.Color.White;
			this.openCmdCB.Location = new System.Drawing.Point(14, 153);
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
			this.openExpCB.Location = new System.Drawing.Point(14, 182);
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
			this.generateProj.Location = new System.Drawing.Point(132, 153);
			this.generateProj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.generateProj.Name = "generateProj";
			this.generateProj.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.generateProj.Size = new System.Drawing.Size(173, 85);
			this.generateProj.TabIndex = 7;
			this.generateProj.Text = "Generate Project";
			this.generateProj.Click += new System.EventHandler(this.generateProj_Click);
			// 
			// langSelect
			// 
			this.langSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.langSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.langSelect.FormattingEnabled = true;
			this.langSelect.Location = new System.Drawing.Point(12, 75);
			this.langSelect.Name = "langSelect";
			this.langSelect.Size = new System.Drawing.Size(196, 26);
			this.langSelect.TabIndex = 8;
			this.langSelect.SelectedIndexChanged += new System.EventHandler(this.langSelect_SelectedIndexChanged);
			// 
			// pushToGitCB
			// 
			this.pushToGitCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pushToGitCB.AutoSize = true;
			this.pushToGitCB.ForeColor = System.Drawing.Color.White;
			this.pushToGitCB.Location = new System.Drawing.Point(14, 211);
			this.pushToGitCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pushToGitCB.Name = "pushToGitCB";
			this.pushToGitCB.Size = new System.Drawing.Size(92, 21);
			this.pushToGitCB.TabIndex = 9;
			this.pushToGitCB.Text = "Push To Git";
			this.pushToGitCB.UseVisualStyleBackColor = true;
			// 
			// gitUrlBar
			// 
			this.gitUrlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gitUrlBar.Location = new System.Drawing.Point(14, 108);
			this.gitUrlBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gitUrlBar.Name = "gitUrlBar";
			this.gitUrlBar.Size = new System.Drawing.Size(194, 25);
			this.gitUrlBar.TabIndex = 10;
			// 
			// darkLabel1
			// 
			this.darkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.darkLabel1.AutoSize = true;
			this.darkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel1.Location = new System.Drawing.Point(214, 111);
			this.darkLabel1.Name = "darkLabel1";
			this.darkLabel1.Size = new System.Drawing.Size(86, 17);
			this.darkLabel1.TabIndex = 11;
			this.darkLabel1.Text = "Git Repo URL";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(317, 249);
			this.Controls.Add(this.darkLabel1);
			this.Controls.Add(this.gitUrlBar);
			this.Controls.Add(this.pushToGitCB);
			this.Controls.Add(this.langSelect);
			this.Controls.Add(this.generateProj);
			this.Controls.Add(this.openExpCB);
			this.Controls.Add(this.openCmdCB);
			this.Controls.Add(this.langText);
			this.Controls.Add(this.selectPathBtn);
			this.Controls.Add(this.pathBox);
			this.Controls.Add(this.darkMenuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.darkMenuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(449, 348);
			this.MinimumSize = new System.Drawing.Size(333, 214);
			this.Name = "Form1";
			this.Text = "Project Generator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.darkMenuStrip1.ResumeLayout(false);
			this.darkMenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
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
		private DarkUI.Controls.DarkComboBox langSelect;
		private System.Windows.Forms.CheckBox pushToGitCB;
		private System.Windows.Forms.TextBox gitUrlBar;
		private DarkUI.Controls.DarkLabel darkLabel1;
	}
}

