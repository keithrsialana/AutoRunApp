using System.Diagnostics;

namespace AutoRunApp
{
    public partial class MainForm : Form
    {

        private ProcessManipulation pm;
        private Process selectedProcess;
        private string processFileName;
        private string processFilePath;
        private bool autoRun;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "C:\\";
                ofd.Filter = "Executiables (*.exe)|*.exe|Batch Script (*.bat)|*.bat";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    processFileName = ofd.SafeFileName;
                    processFilePath = ofd.FileName;
                    txtFileName.Text = ofd.FileName;
                    logBox.Text += $"FILE SELECTED: \t{ofd.SafeFileName} AT {ofd.FileName} \r\n";
                    selectedProcess = new Process();
                    selectedProcess.StartInfo.FileName = txtFileName.Text;
                    pm = new ProcessManipulation(selectedProcess);
                    btnStart.Enabled = true;
                    btnAutorun.Enabled = true;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnAutorun.Enabled = false;
            btnEnd.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (pm.StartProcess())
            {
                logBox.Text += $"PROCESS STARTED: \t{processFileName}\r\nWATCHING PROCESS...\r\n";
            }
            timer1.Start();
            btnStart.Enabled = false;
            btnEnd.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!pm.CheckProcess())
            {
                logBox.Text += $"PROCESS CLOSED: \t{processFileName}\r\n";
                if (autoRun)
                {
                    logBox.Text += $"PROCESS RESTARTING: \t{processFileName} restarting...\r\n";
                    if (pm.StartProcess())
                    {
                        logBox.Text += $"PROCESS STARTED: \t{processFileName}\r\nWATCHING PROCESS...\r\n";
                    }
                }
                else
                {
                    timer1.Stop();
                    btnEnd.Enabled = false;
                    btnStart.Enabled = true;
                }
            }
        }

        private void btnAutorun_Click(object sender, EventArgs e)
        {
            if (!autoRun)
            {
                autoRun = true;
                btnAutorun.BackColor = Color.LawnGreen;
            }
            else
            {
                autoRun = false;
                btnAutorun.BackColor = SystemColors.Control;
            }

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (pm.EndProcess())
            {
                logBox.Text += $"PROCESS STOPPED: \t{processFileName}\r\n";
            }
            timer1.Stop();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
        }
    }
}
