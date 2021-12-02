
namespace Exercise01
{
    partial class EClockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EClockForm));
            this.bt_Start = new System.Windows.Forms.Button();
            this.bt_Pause = new System.Windows.Forms.Button();
            this.bt_Resume = new System.Windows.Forms.Button();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.btnSysTime = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.uscClock1 = new Exercise01.uscClock();
            this.useSetClock1 = new Exercise01.useSetClock();
            this.SuspendLayout();
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(12, 106);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(75, 23);
            this.bt_Start.TabIndex = 1;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // bt_Pause
            // 
            this.bt_Pause.Location = new System.Drawing.Point(114, 106);
            this.bt_Pause.Name = "bt_Pause";
            this.bt_Pause.Size = new System.Drawing.Size(75, 23);
            this.bt_Pause.TabIndex = 2;
            this.bt_Pause.Text = "Pause";
            this.bt_Pause.UseVisualStyleBackColor = true;
            this.bt_Pause.Click += new System.EventHandler(this.bt_Pause_Click);
            // 
            // bt_Resume
            // 
            this.bt_Resume.Location = new System.Drawing.Point(214, 106);
            this.bt_Resume.Name = "bt_Resume";
            this.bt_Resume.Size = new System.Drawing.Size(75, 23);
            this.bt_Resume.TabIndex = 3;
            this.bt_Resume.Text = "Resume";
            this.bt_Resume.UseVisualStyleBackColor = true;
            this.bt_Resume.Click += new System.EventHandler(this.bt_Resume_Click);
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(316, 106);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(75, 23);
            this.bt_Stop.TabIndex = 4;
            this.bt_Stop.Text = "Stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // btnSysTime
            // 
            this.btnSysTime.Location = new System.Drawing.Point(44, 252);
            this.btnSysTime.Name = "btnSysTime";
            this.btnSysTime.Size = new System.Drawing.Size(75, 23);
            this.btnSysTime.TabIndex = 8;
            this.btnSysTime.Text = "System Time";
            this.btnSysTime.UseVisualStyleBackColor = true;
            this.btnSysTime.Click += new System.EventHandler(this.btnSysTime_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(155, 252);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(275, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // uscClock1
            // 
            this.uscClock1._mm = 0;
            this.uscClock1._ss = 0;
            this.uscClock1.Location = new System.Drawing.Point(62, 25);
            this.uscClock1.Margin = new System.Windows.Forms.Padding(0);
            this.uscClock1.Name = "uscClock1";
            this.uscClock1.Size = new System.Drawing.Size(269, 58);
            this.uscClock1.TabIndex = 7;
            // 
            // useSetClock1
            // 
            this.useSetClock1._mm = 0;
            this.useSetClock1._ss = 0;
            this.useSetClock1.Location = new System.Drawing.Point(44, 160);
            this.useSetClock1.Name = "useSetClock1";
            this.useSetClock1.Size = new System.Drawing.Size(315, 48);
            this.useSetClock1.TabIndex = 6;
            // 
            // EClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(403, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSysTime);
            this.Controls.Add(this.uscClock1);
            this.Controls.Add(this.useSetClock1);
            this.Controls.Add(this.bt_Stop);
            this.Controls.Add(this.bt_Resume);
            this.Controls.Add(this.bt_Pause);
            this.Controls.Add(this.bt_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EClockForm";
            this.Text = "EClock";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Button bt_Pause;
        private System.Windows.Forms.Button bt_Resume;
        private System.Windows.Forms.Button bt_Stop;
        private useSetClock useSetClock1;
        private uscClock uscClock1;
        private System.Windows.Forms.Button btnSysTime;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
    }
}

