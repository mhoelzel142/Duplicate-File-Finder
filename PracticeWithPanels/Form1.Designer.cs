namespace PracticeWithPanels
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fileExtensionOptions = new System.Windows.Forms.GroupBox();
            this.ckbImageFiles = new System.Windows.Forms.CheckBox();
            this.ckbPdf = new System.Windows.Forms.CheckBox();
            this.ckbDocuments = new System.Windows.Forms.CheckBox();
            this.ckbVideo = new System.Windows.Forms.CheckBox();
            this.ckbCameraRaw = new System.Windows.Forms.CheckBox();
            this.ckbFilesAll = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSelectedFolder_2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChooseFolder_2 = new System.Windows.Forms.Button();
            this.lblSelectedFolder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.folder1TreeView = new System.Windows.Forms.TreeView();
            this.lblNumberFilesAnalyzed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExecutionTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumDuplicates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseThisSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNextStage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCurrentlyAnalyzing = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.fileExtensionOptions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 41);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fileExtensionOptions);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblNumberFilesAnalyzed);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.lblExecutionTime);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lblNumDuplicates);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart);
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(1486, 1039);
            this.splitContainer1.SplitterDistance = 727;
            this.splitContainer1.TabIndex = 0;
            // 
            // fileExtensionOptions
            // 
            this.fileExtensionOptions.Controls.Add(this.ckbImageFiles);
            this.fileExtensionOptions.Controls.Add(this.ckbPdf);
            this.fileExtensionOptions.Controls.Add(this.ckbDocuments);
            this.fileExtensionOptions.Controls.Add(this.ckbVideo);
            this.fileExtensionOptions.Controls.Add(this.ckbCameraRaw);
            this.fileExtensionOptions.Controls.Add(this.ckbFilesAll);
            this.fileExtensionOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileExtensionOptions.Location = new System.Drawing.Point(0, 775);
            this.fileExtensionOptions.Name = "fileExtensionOptions";
            this.fileExtensionOptions.Size = new System.Drawing.Size(727, 264);
            this.fileExtensionOptions.TabIndex = 1;
            this.fileExtensionOptions.TabStop = false;
            this.fileExtensionOptions.Text = "File Extensions to search for:";
            // 
            // ckbImageFiles
            // 
            this.ckbImageFiles.AutoSize = true;
            this.ckbImageFiles.Location = new System.Drawing.Point(12, 113);
            this.ckbImageFiles.Name = "ckbImageFiles";
            this.ckbImageFiles.Size = new System.Drawing.Size(300, 29);
            this.ckbImageFiles.TabIndex = 5;
            this.ckbImageFiles.Text = "Image files (.jpg, .gif, .png, etc)";
            this.ckbImageFiles.UseVisualStyleBackColor = true;
            // 
            // ckbPdf
            // 
            this.ckbPdf.AutoSize = true;
            this.ckbPdf.Location = new System.Drawing.Point(12, 218);
            this.ckbPdf.Name = "ckbPdf";
            this.ckbPdf.Size = new System.Drawing.Size(302, 29);
            this.ckbPdf.TabIndex = 4;
            this.ckbPdf.Text = "Other files (.pdf, .cbr, .exe, etc)";
            this.ckbPdf.UseVisualStyleBackColor = true;
            // 
            // ckbDocuments
            // 
            this.ckbDocuments.AutoSize = true;
            this.ckbDocuments.Location = new System.Drawing.Point(12, 183);
            this.ckbDocuments.Name = "ckbDocuments";
            this.ckbDocuments.Size = new System.Drawing.Size(321, 29);
            this.ckbDocuments.TabIndex = 3;
            this.ckbDocuments.Text = "Documents (.txt, .doc, .docx, etc)";
            this.ckbDocuments.UseVisualStyleBackColor = true;
            // 
            // ckbVideo
            // 
            this.ckbVideo.AutoSize = true;
            this.ckbVideo.Location = new System.Drawing.Point(12, 148);
            this.ckbVideo.Name = "ckbVideo";
            this.ckbVideo.Size = new System.Drawing.Size(339, 29);
            this.ckbVideo.TabIndex = 2;
            this.ckbVideo.Text = "Video files (.MOV, .MP4, .AVI, etc)";
            this.ckbVideo.UseVisualStyleBackColor = true;
            // 
            // ckbCameraRaw
            // 
            this.ckbCameraRaw.AutoSize = true;
            this.ckbCameraRaw.Location = new System.Drawing.Point(12, 78);
            this.ckbCameraRaw.Name = "ckbCameraRaw";
            this.ckbCameraRaw.Size = new System.Drawing.Size(472, 29);
            this.ckbCameraRaw.TabIndex = 1;
            this.ckbCameraRaw.Text = "Camera Raw image files (.NEF, .CRW, .ARW, etc)";
            this.ckbCameraRaw.UseVisualStyleBackColor = true;
            // 
            // ckbFilesAll
            // 
            this.ckbFilesAll.AutoSize = true;
            this.ckbFilesAll.Location = new System.Drawing.Point(12, 43);
            this.ckbFilesAll.Name = "ckbFilesAll";
            this.ckbFilesAll.Size = new System.Drawing.Size(133, 29);
            this.ckbFilesAll.TabIndex = 0;
            this.ckbFilesAll.Text = "All Files (*)";
            this.ckbFilesAll.UseVisualStyleBackColor = true;
            this.ckbFilesAll.CheckedChanged += new System.EventHandler(this.ckbFilesAll_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 775);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSelectedFolder_2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnChooseFolder_2);
            this.tabPage1.Controls.Add(this.lblSelectedFolder);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnChooseFolder);
            this.tabPage1.Controls.Add(this.folder1TreeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 738);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Folder 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSelectedFolder_2
            // 
            this.lblSelectedFolder_2.AutoSize = true;
            this.lblSelectedFolder_2.Location = new System.Drawing.Point(176, 236);
            this.lblSelectedFolder_2.Name = "lblSelectedFolder_2";
            this.lblSelectedFolder_2.Size = new System.Drawing.Size(0, 25);
            this.lblSelectedFolder_2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selected Folder: ";
            // 
            // btnChooseFolder_2
            // 
            this.btnChooseFolder_2.AutoSize = true;
            this.btnChooseFolder_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseFolder_2.Location = new System.Drawing.Point(19, 189);
            this.btnChooseFolder_2.Name = "btnChooseFolder_2";
            this.btnChooseFolder_2.Size = new System.Drawing.Size(166, 35);
            this.btnChooseFolder_2.TabIndex = 4;
            this.btnChooseFolder_2.Text = "Choose Folder...";
            this.btnChooseFolder_2.UseVisualStyleBackColor = true;
            this.btnChooseFolder_2.Click += new System.EventHandler(this.btnChooseFolder_2_Click_1);
            // 
            // lblSelectedFolder
            // 
            this.lblSelectedFolder.AutoSize = true;
            this.lblSelectedFolder.Location = new System.Drawing.Point(176, 95);
            this.lblSelectedFolder.Name = "lblSelectedFolder";
            this.lblSelectedFolder.Size = new System.Drawing.Size(0, 25);
            this.lblSelectedFolder.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected Folder: ";
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.AutoSize = true;
            this.btnChooseFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseFolder.Location = new System.Drawing.Point(19, 20);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(166, 35);
            this.btnChooseFolder.TabIndex = 1;
            this.btnChooseFolder.Text = "Choose Folder...";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // folder1TreeView
            // 
            this.folder1TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folder1TreeView.Location = new System.Drawing.Point(3, 3);
            this.folder1TreeView.Name = "folder1TreeView";
            this.folder1TreeView.Size = new System.Drawing.Size(713, 732);
            this.folder1TreeView.TabIndex = 0;
            // 
            // lblNumberFilesAnalyzed
            // 
            this.lblNumberFilesAnalyzed.AutoSize = true;
            this.lblNumberFilesAnalyzed.Location = new System.Drawing.Point(249, 856);
            this.lblNumberFilesAnalyzed.Name = "lblNumberFilesAnalyzed";
            this.lblNumberFilesAnalyzed.Size = new System.Drawing.Size(0, 25);
            this.lblNumberFilesAnalyzed.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 857);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of files Analyzed:";
            // 
            // lblExecutionTime
            // 
            this.lblExecutionTime.AutoSize = true;
            this.lblExecutionTime.Location = new System.Drawing.Point(175, 822);
            this.lblExecutionTime.Name = "lblExecutionTime";
            this.lblExecutionTime.Size = new System.Drawing.Size(0, 25);
            this.lblExecutionTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 822);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Execution Time:";
            // 
            // lblNumDuplicates
            // 
            this.lblNumDuplicates.AutoSize = true;
            this.lblNumDuplicates.Location = new System.Drawing.Point(226, 785);
            this.lblNumDuplicates.Name = "lblNumDuplicates";
            this.lblNumDuplicates.Size = new System.Drawing.Size(0, 25);
            this.lblNumDuplicates.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 785);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Duplicates:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(554, 975);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(179, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(357, 975);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 48);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(755, 767);
            this.treeView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1486, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.howToUseThisSoftwareToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.donateToolStripMenuItem.Text = "Donate";
            // 
            // howToUseThisSoftwareToolStripMenuItem
            // 
            this.howToUseThisSoftwareToolStripMenuItem.Name = "howToUseThisSoftwareToolStripMenuItem";
            this.howToUseThisSoftwareToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.howToUseThisSoftwareToolStripMenuItem.Text = "How to use this software";
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblNextStage,
            this.toolStripStatusLabel1,
            this.toolStripCurrentlyAnalyzing});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1091);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1486, 35);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 30);
            this.toolStripStatusLabel2.Text = "Stage:";
            // 
            // lblNextStage
            // 
            this.lblNextStage.Name = "lblNextStage";
            this.lblNextStage.Size = new System.Drawing.Size(0, 30);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(199, 30);
            this.toolStripStatusLabel1.Text = "Currently Analyzing:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripCurrentlyAnalyzing
            // 
            this.toolStripCurrentlyAnalyzing.Name = "toolStripCurrentlyAnalyzing";
            this.toolStripCurrentlyAnalyzing.Size = new System.Drawing.Size(0, 30);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 1126);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Duplicate File Finder";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.fileExtensionOptions.ResumeLayout(false);
            this.fileExtensionOptions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblNumDuplicates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExecutionTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox fileExtensionOptions;
        private System.Windows.Forms.CheckBox ckbImageFiles;
        private System.Windows.Forms.CheckBox ckbPdf;
        private System.Windows.Forms.CheckBox ckbDocuments;
        private System.Windows.Forms.CheckBox ckbVideo;
        private System.Windows.Forms.CheckBox ckbCameraRaw;
        private System.Windows.Forms.CheckBox ckbFilesAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseThisSoftwareToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label lblNumberFilesAnalyzed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblSelectedFolder_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChooseFolder_2;
        private System.Windows.Forms.Label lblSelectedFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TreeView folder1TreeView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCurrentlyAnalyzing;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblNextStage;
    }
}

