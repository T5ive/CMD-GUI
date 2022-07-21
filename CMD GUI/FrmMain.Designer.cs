namespace CMD_GUI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtAddOption = new System.Windows.Forms.TextBox();
            this.txtArgurments = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnBrowseTarget = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWorkDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOptions = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAsAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkPause = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOption
            // 
            this.cbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Location = new System.Drawing.Point(88, 81);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(263, 23);
            this.cbOption.TabIndex = 0;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(357, 22);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 1;
            this.btnBrowseSource.Text = "Browse..";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // txtSource
            // 
            this.txtSource.AllowDrop = true;
            this.txtSource.Location = new System.Drawing.Point(88, 23);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(263, 23);
            this.txtSource.TabIndex = 2;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            this.txtSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtSource_DragDrop);
            this.txtSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterAll);
            // 
            // txtAddOption
            // 
            this.txtAddOption.Location = new System.Drawing.Point(88, 52);
            this.txtAddOption.Name = "txtAddOption";
            this.txtAddOption.Size = new System.Drawing.Size(263, 23);
            this.txtAddOption.TabIndex = 3;
            // 
            // txtArgurments
            // 
            this.txtArgurments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArgurments.Location = new System.Drawing.Point(3, 19);
            this.txtArgurments.Multiline = true;
            this.txtArgurments.Name = "txtArgurments";
            this.txtArgurments.ReadOnly = true;
            this.txtArgurments.Size = new System.Drawing.Size(438, 83);
            this.txtArgurments.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(357, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRun.Location = new System.Drawing.Point(3, 102);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(438, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Source Exe: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Options: ";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(357, 81);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArgurments);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Target Exe: ";
            // 
            // txtTarget
            // 
            this.txtTarget.AllowDrop = true;
            this.txtTarget.Location = new System.Drawing.Point(88, 23);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(263, 23);
            this.txtTarget.TabIndex = 13;
            this.txtTarget.TextChanged += new System.EventHandler(this.txtTarget_TextChanged);
            this.txtTarget.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtTarget_DragDrop);
            this.txtTarget.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterAll);
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.Location = new System.Drawing.Point(357, 22);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTarget.TabIndex = 12;
            this.btnBrowseTarget.Text = "Browse..";
            this.btnBrowseTarget.UseVisualStyleBackColor = true;
            this.btnBrowseTarget.Click += new System.EventHandler(this.btnBrowseTarget_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWorkDir);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbOptions);
            this.groupBox2.Controls.Add(this.cbOption);
            this.groupBox2.Controls.Add(this.btnBrowseSource);
            this.groupBox2.Controls.Add(this.txtSource);
            this.groupBox2.Controls.Add(this.txtAddOption);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 147);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source";
            // 
            // txtWorkDir
            // 
            this.txtWorkDir.AllowDrop = true;
            this.txtWorkDir.Location = new System.Drawing.Point(127, 110);
            this.txtWorkDir.Name = "txtWorkDir";
            this.txtWorkDir.Size = new System.Drawing.Size(305, 23);
            this.txtWorkDir.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Working Directory: ";
            // 
            // lbOptions
            // 
            this.lbOptions.Location = new System.Drawing.Point(12, 81);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(70, 23);
            this.lbOptions.TabIndex = 11;
            this.lbOptions.Text = "Count: 0";
            this.lbOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBrowseTarget);
            this.groupBox3.Controls.Add(this.txtTarget);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 62);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runAsAdminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.recentFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // recentFileToolStripMenuItem
            // 
            this.recentFileToolStripMenuItem.Name = "recentFileToolStripMenuItem";
            this.recentFileToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.recentFileToolStripMenuItem.Text = "Recent File";
            // 
            // runAsAdminToolStripMenuItem
            // 
            this.runAsAdminToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.runAsAdminToolStripMenuItem.Enabled = false;
            this.runAsAdminToolStripMenuItem.Name = "runAsAdminToolStripMenuItem";
            this.runAsAdminToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.runAsAdminToolStripMenuItem.Text = "Run as Admin";
            this.runAsAdminToolStripMenuItem.Click += new System.EventHandler(this.runAsAdminToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkPause);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 56);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // chkPause
            // 
            this.chkPause.AutoSize = true;
            this.chkPause.Checked = true;
            this.chkPause.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPause.Location = new System.Drawing.Point(16, 22);
            this.chkPause.Name = "chkPause";
            this.chkPause.Size = new System.Drawing.Size(57, 19);
            this.chkPause.TabIndex = 10;
            this.chkPause.Text = "Pause";
            this.chkPause.UseVisualStyleBackColor = true;
            this.chkPause.CheckedChanged += new System.EventHandler(this.chkPause_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 417);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMD GUI";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterAll);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbOption;
        private Button btnBrowseSource;
        private TextBox txtSource;
        private TextBox txtAddOption;
        private TextBox txtArgurments;
        private Button btnAdd;
        private Button btnRun;
        private Label label1;
        private Label label2;
        private Button btnRemove;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtTarget;
        private Button btnBrowseTarget;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private Label lbOptions;
        private TextBox txtWorkDir;
        private Label label4;
        private GroupBox groupBox4;
        private CheckBox chkPause;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem recentFileToolStripMenuItem;
        private ToolStripMenuItem runAsAdminToolStripMenuItem;
    }
}