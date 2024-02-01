namespace AutoRunApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            logBox = new TextBox();
            lblLogBox = new Label();
            lblChoose = new Label();
            txtFileName = new TextBox();
            btnOpen = new Button();
            btnStart = new Button();
            btnEnd = new Button();
            btnAutorun = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // logBox
            // 
            logBox.Location = new Point(12, 88);
            logBox.Multiline = true;
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.Size = new Size(350, 296);
            logBox.TabIndex = 0;
            // 
            // lblLogBox
            // 
            lblLogBox.AutoSize = true;
            lblLogBox.Location = new Point(12, 70);
            lblLogBox.Name = "lblLogBox";
            lblLogBox.Size = new Size(27, 15);
            lblLogBox.TabIndex = 1;
            lblLogBox.Text = "Log";
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Location = new Point(12, 14);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(118, 15);
            lblChoose.TabIndex = 2;
            lblChoose.Text = "Selected Application:";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(12, 32);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(269, 23);
            txtFileName.TabIndex = 3;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(287, 32);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 390);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 48);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(287, 390);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(75, 48);
            btnEnd.TabIndex = 6;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnAutorun
            // 
            btnAutorun.Location = new Point(150, 390);
            btnAutorun.Name = "btnAutorun";
            btnAutorun.Size = new Size(75, 48);
            btnAutorun.TabIndex = 7;
            btnAutorun.Text = "AutoRun";
            btnAutorun.UseVisualStyleBackColor = true;
            btnAutorun.Click += btnAutorun_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(btnAutorun);
            Controls.Add(btnEnd);
            Controls.Add(btnStart);
            Controls.Add(btnOpen);
            Controls.Add(txtFileName);
            Controls.Add(lblChoose);
            Controls.Add(lblLogBox);
            Controls.Add(logBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Auto Run App";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox logBox;
        private Label lblLogBox;
        private Label lblChoose;
        private TextBox txtFileName;
        private Button btnOpen;
        private Button btnStart;
        private Button btnEnd;
        private Button btnAutorun;
        private System.Windows.Forms.Timer timer1;
    }
}
