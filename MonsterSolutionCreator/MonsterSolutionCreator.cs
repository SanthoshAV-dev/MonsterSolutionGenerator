using System;
using System.Diagnostics;
using System.Text;

namespace MonsterSolutionCreator
{
    public partial class frmMonsterSolutionCreator : Form
    {
        private string m_SolutionPath = string.Empty;
        public frmMonsterSolutionCreator()
        {
            InitializeComponent();

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (checkedListBoxProjects.Items.Count == 0)
            {
                MessageBox.Show("No projects loaded in the below list box to check or uncheck.", "Select / Deselect All", MessageBoxButtons.OK);
                return;

            }
            if (btnSelectAll.Text == "Select All")
            {
                for (var i = 0; i < checkedListBoxProjects.Items.Count; i++)
                {
                    checkedListBoxProjects.SetItemChecked(i, true);
                }

                btnSelectAll.Text = "Deselect All";
            }
            else
            {
                for (var i = 0; i < checkedListBoxProjects.Items.Count; i++)
                {
                    checkedListBoxProjects.SetItemChecked(i, false);
                }

                btnSelectAll.Text = "Select All";
            }
        }

        private void btnGetProjects_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProjectsPath.Text) || txtProjectsPath.Text == "double click to select the path...")
            {
                MessageBox.Show("Select a valid path from where projects could be loaded.", "Projects load",
                    MessageBoxButtons.OK);
                return;
            }
            var projectFilePaths = Directory.GetFiles(txtProjectsPath.Text, "*.csproj", SearchOption.AllDirectories);
            foreach (var projectFilePath in projectFilePaths)
            {
                checkedListBoxProjects.Items.Add(projectFilePath);
            }

            lblProjectCount.Text = projectFilePaths.Length.ToString();
            lblProjectCount.ForeColor = Color.DarkGreen;
        }

        private void btnCreateMonsterSolutionFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMonsterFileName.Text))
            {
                MessageBox.Show("Enter a valid name for monster solution file.", "Monster file name",
                    MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMonsterFilePath.Text) || txtMonsterFilePath.Text == "double click to select the path...")
            {
                MessageBox.Show("Select a valid path for monster solution file.", "Monster file path",
                    MessageBoxButtons.OK);
                return;
            }

            try
            {
                lblslnCreationProgress.Text = "Solution file creation started..";
                var processStartInfo = new ProcessStartInfo
                {
                    Arguments = $"/c dotnet.exe new sln --name {txtMonsterFileName.Text}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    FileName = "cmd.exe",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Verb = "runas",
                    WorkingDirectory = txtMonsterFilePath.Text
                };
                using var process = System.Diagnostics.Process.Start(processStartInfo);
                process?.WaitForExit();

                m_SolutionPath = Path.Combine(txtMonsterFilePath.Text, txtMonsterFileName.Text + ".sln");
                lblslnCreationProgress.Text = $"Solution file creation successfully done. {Path.Combine(txtMonsterFilePath.Text, txtMonsterFileName.Text)}.";
                lblslnCreationProgress.ForeColor = Color.RoyalBlue;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnLoadSelectedProjects_Click(object sender, EventArgs e)
        {
            if (checkedListBoxProjects.Items.Count == 0)
            {
                MessageBox.Show("No projects loaded in the above list box to load in to the monster solution file.", "Monster file projects load",
                    MessageBoxButtons.OK);
                return;
            }
            if (checkedListBoxProjects.SelectedItems.Count == 0)
            {
                MessageBox.Show("No projects selected from the loaded projects in the above list box to load in to the monster solution file.", "Monster file projects load",
                    MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(m_SolutionPath))
            {
                MessageBox.Show("No solution file path is created or selected.", "Monster file Solution path",
                    MessageBoxButtons.OK);
                return;
            }

            try
            {
                lblLoadProjectsStatus.Text = "Loading of the selected projects started.This might take 2-5 minutes to complete depending on number of projects.Please wait or you can have cup of coffee and come back..";
                lblLoadProjectsStatus.ForeColor = Color.RoyalBlue;
                foreach (var item in checkedListBoxProjects.CheckedItems)
                {
                    var processStartInfo = new ProcessStartInfo
                    {
                        Arguments = $"/c dotnet.exe sln {m_SolutionPath} add {item}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        FileName = "cmd.exe",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        Verb = "runas",
                        WorkingDirectory = txtMonsterFilePath.Text
                    };
                    using var process = Process.Start(processStartInfo);
                    process.ErrorDataReceived += Process_ErrorDataReceived;
                    process?.WaitForExit();
                }

                lblLoadProjectsStatus.Text = "All projects loaded successfully";
                if (logFileName != string.Empty)
                    lblLoadProjectsStatus.Text += $"See the loges here {logFileName}";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private string logFileName = string.Empty;
        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (logFileName == string.Empty)
            {
                logFileName = Guid.NewGuid().ToString();
                logFileName = Path.Combine(Path.GetTempPath(), logFileName);
                using var file = File.Create(logFileName);
                file.Write(Encoding.ASCII.GetBytes(e.Data));
            }
            else
            {
                File.WriteAllText(logFileName, e.Data);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using var folderBrowserDialog = new OpenFileDialog();
            folderBrowserDialog.Filter = "Solution files (*.sln)|*.sln";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog.FileName;
                m_SolutionPath = folderBrowserDialog.FileName;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtMonsterFilePath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtMonsterFilePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using var folderBrowserDialog = new OpenFileDialog();
            folderBrowserDialog.Filter = "Solution files (*.sln)|*.sln";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog.FileName;
                m_SolutionPath = folderBrowserDialog.FileName;
            }
        }

        private void txtProjectsPath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtProjectsPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMonsterSolutionCreator_Load(object sender, EventArgs e)
        {

        }
    }
}