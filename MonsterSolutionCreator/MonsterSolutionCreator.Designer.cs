namespace MonsterSolutionCreator
{
    partial class frmMonsterSolutionCreator
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
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            label9 = new Label();
            lblslnCreationProgress = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtMonsterFilePath = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtMonsterFileName = new TextBox();
            btnCreateMonsterSolutionFile = new Button();
            lblLoadProjectsStatus = new Label();
            lblProjectCount = new Label();
            label8 = new Label();
            btnLoadSelectedProjects = new Button();
            btnSelectAll = new Button();
            checkedListBoxProjects = new CheckedListBox();
            btnGetProjects = new Button();
            label3 = new Label();
            txtProjectsPath = new TextBox();
            lblProjectsToLoadPath = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 963);
            panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(lblslnCreationProgress);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtMonsterFilePath);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtMonsterFileName);
            splitContainer1.Panel1.Controls.Add(btnCreateMonsterSolutionFile);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblLoadProjectsStatus);
            splitContainer1.Panel2.Controls.Add(lblProjectCount);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(btnLoadSelectedProjects);
            splitContainer1.Panel2.Controls.Add(btnSelectAll);
            splitContainer1.Panel2.Controls.Add(checkedListBoxProjects);
            splitContainer1.Panel2.Controls.Add(btnGetProjects);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(txtProjectsPath);
            splitContainer1.Panel2.Controls.Add(lblProjectsToLoadPath);
            splitContainer1.Size = new Size(1235, 963);
            splitContainer1.SplitterDistance = 285;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(20, 8);
            label9.Name = "label9";
            label9.Size = new Size(738, 15);
            label9.TabIndex = 18;
            label9.Text = "Note: This tool uses dotnet.exe CLI tool which is bundled with .NET SDK.So .NET SDK must be already installed before using the tool.";
            // 
            // lblslnCreationProgress
            // 
            lblslnCreationProgress.AutoSize = true;
            lblslnCreationProgress.Location = new Point(19, 118);
            lblslnCreationProgress.Name = "lblslnCreationProgress";
            lblslnCreationProgress.Size = new Size(0, 15);
            lblslnCreationProgress.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(492, 174);
            label7.Name = "label7";
            label7.Size = new Size(26, 17);
            label7.TabIndex = 16;
            label7.Text = "OR";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(398, 246);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(820, 23);
            textBox1.TabIndex = 14;
            textBox1.Text = "double click to select the path...";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.MouseDoubleClick += textBox1_MouseDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 246);
            label6.Name = "label6";
            label6.Size = new Size(256, 15);
            label6.TabIndex = 13;
            label6.Text = "Select the path containing the solution(.sln) file";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 215);
            label5.Name = "label5";
            label5.Size = new Size(156, 17);
            label5.TabIndex = 12;
            label5.Text = "Solution File Already Exists";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 38);
            label4.Name = "label4";
            label4.Size = new Size(146, 17);
            label4.TabIndex = 11;
            label4.Text = "Create New Solution File";
            // 
            // txtMonsterFilePath
            // 
            txtMonsterFilePath.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMonsterFilePath.Location = new Point(398, 108);
            txtMonsterFilePath.Name = "txtMonsterFilePath";
            txtMonsterFilePath.ReadOnly = true;
            txtMonsterFilePath.Size = new Size(820, 23);
            txtMonsterFilePath.TabIndex = 4;
            txtMonsterFilePath.Text = "double click to select the path...";
            txtMonsterFilePath.MouseDoubleClick += txtMonsterFilePath_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 108);
            label2.Name = "label2";
            label2.Size = new Size(270, 15);
            label2.TabIndex = 3;
            label2.Text = "Select the path of the monster solution to create : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 78);
            label1.Name = "label1";
            label1.Size = new Size(378, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter the name of the monster solution to create (without extension) : ";
            // 
            // txtMonsterFileName
            // 
            txtMonsterFileName.Location = new Point(398, 78);
            txtMonsterFileName.Name = "txtMonsterFileName";
            txtMonsterFileName.Size = new Size(820, 23);
            txtMonsterFileName.TabIndex = 1;
            // 
            // btnCreateMonsterSolutionFile
            // 
            btnCreateMonsterSolutionFile.BackColor = Color.DodgerBlue;
            btnCreateMonsterSolutionFile.FlatAppearance.BorderSize = 0;
            btnCreateMonsterSolutionFile.FlatStyle = FlatStyle.Flat;
            btnCreateMonsterSolutionFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateMonsterSolutionFile.ForeColor = Color.White;
            btnCreateMonsterSolutionFile.Location = new Point(937, 137);
            btnCreateMonsterSolutionFile.Name = "btnCreateMonsterSolutionFile";
            btnCreateMonsterSolutionFile.Size = new Size(281, 37);
            btnCreateMonsterSolutionFile.TabIndex = 0;
            btnCreateMonsterSolutionFile.Text = "Create Monster Solution File";
            btnCreateMonsterSolutionFile.UseVisualStyleBackColor = false;
            btnCreateMonsterSolutionFile.Click += btnCreateMonsterSolutionFile_Click;
            // 
            // lblLoadProjectsStatus
            // 
            lblLoadProjectsStatus.AutoSize = true;
            lblLoadProjectsStatus.Location = new Point(19, 607);
            lblLoadProjectsStatus.Name = "lblLoadProjectsStatus";
            lblLoadProjectsStatus.Size = new Size(0, 15);
            lblLoadProjectsStatus.TabIndex = 14;
            // 
            // lblProjectCount
            // 
            lblProjectCount.AutoSize = true;
            lblProjectCount.Location = new Point(284, 101);
            lblProjectCount.Name = "lblProjectCount";
            lblProjectCount.Size = new Size(13, 15);
            lblProjectCount.TabIndex = 11;
            lblProjectCount.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(156, 101);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 10;
            label8.Text = "Total projects loaded: ";
            label8.Click += label8_Click;
            // 
            // btnLoadSelectedProjects
            // 
            btnLoadSelectedProjects.BackColor = Color.DodgerBlue;
            btnLoadSelectedProjects.FlatAppearance.BorderSize = 0;
            btnLoadSelectedProjects.FlatStyle = FlatStyle.Flat;
            btnLoadSelectedProjects.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadSelectedProjects.ForeColor = Color.White;
            btnLoadSelectedProjects.Location = new Point(937, 624);
            btnLoadSelectedProjects.Name = "btnLoadSelectedProjects";
            btnLoadSelectedProjects.Size = new Size(281, 37);
            btnLoadSelectedProjects.TabIndex = 9;
            btnLoadSelectedProjects.Text = "Load Selected Projects To Monster Solution";
            btnLoadSelectedProjects.UseVisualStyleBackColor = false;
            btnLoadSelectedProjects.Click += btnLoadSelectedProjects_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.BackColor = Color.DodgerBlue;
            btnSelectAll.FlatAppearance.BorderSize = 0;
            btnSelectAll.FlatStyle = FlatStyle.Flat;
            btnSelectAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectAll.ForeColor = Color.White;
            btnSelectAll.Location = new Point(19, 96);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(131, 25);
            btnSelectAll.TabIndex = 7;
            btnSelectAll.Text = "Select All";
            btnSelectAll.UseVisualStyleBackColor = false;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // checkedListBoxProjects
            // 
            checkedListBoxProjects.BackColor = Color.White;
            checkedListBoxProjects.CheckOnClick = true;
            checkedListBoxProjects.FormattingEnabled = true;
            checkedListBoxProjects.Location = new Point(17, 127);
            checkedListBoxProjects.Name = "checkedListBoxProjects";
            checkedListBoxProjects.Size = new Size(1201, 472);
            checkedListBoxProjects.TabIndex = 6;
            // 
            // btnGetProjects
            // 
            btnGetProjects.BackColor = Color.DodgerBlue;
            btnGetProjects.FlatAppearance.BorderSize = 0;
            btnGetProjects.FlatStyle = FlatStyle.Flat;
            btnGetProjects.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetProjects.ForeColor = Color.White;
            btnGetProjects.Location = new Point(937, 52);
            btnGetProjects.Name = "btnGetProjects";
            btnGetProjects.Size = new Size(281, 37);
            btnGetProjects.TabIndex = 5;
            btnGetProjects.Text = "Get Projects";
            btnGetProjects.UseVisualStyleBackColor = false;
            btnGetProjects.Click += btnGetProjects_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 47);
            label3.Name = "label3";
            label3.Size = new Size(200, 15);
            label3.TabIndex = 5;
            label3.Text = "(only .csproj file format supported)";
            // 
            // txtProjectsPath
            // 
            txtProjectsPath.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtProjectsPath.Location = new Point(398, 23);
            txtProjectsPath.Name = "txtProjectsPath";
            txtProjectsPath.ReadOnly = true;
            txtProjectsPath.Size = new Size(820, 23);
            txtProjectsPath.TabIndex = 4;
            txtProjectsPath.Text = "double click to select the path...";
            txtProjectsPath.MouseDoubleClick += txtProjectsPath_MouseDoubleClick;
            // 
            // lblProjectsToLoadPath
            // 
            lblProjectsToLoadPath.AutoSize = true;
            lblProjectsToLoadPath.Location = new Point(17, 23);
            lblProjectsToLoadPath.Name = "lblProjectsToLoadPath";
            lblProjectsToLoadPath.Size = new Size(293, 15);
            lblProjectsToLoadPath.TabIndex = 3;
            lblProjectsToLoadPath.Text = "Enter the path from where projects should be loaded : ";
            // 
            // frmMonsterSolutionCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1235, 963);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMonsterSolutionCreator";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monster Solution Creator";
            Load += frmMonsterSolutionCreator_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox txtMonsterFileName;
        private Button btnCreateMonsterSolutionFile;
        private TextBox txtMonsterFilePath;
        private Label label2;
        private TextBox txtProjectsPath;
        private Label lblProjectsToLoadPath;
        private Label label3;
        private CheckedListBox checkedListBoxProjects;
        private Button btnGetProjects;
        private Button btnSelectAll;
        private Button btnLoadSelectedProjects;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblProjectCount;
        private Label lblslnCreationProgress;
        private Label lblLoadProjectsStatus;
        private Label label9;
    }
}