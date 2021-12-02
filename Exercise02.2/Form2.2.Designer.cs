
namespace Exercise02._2
{
    partial class Form2
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
            this.bt_Start = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.testTimer1 = new Exercise02._2.ExamTimer();
            this.quesCtrl = new Exercise02._2.QuestionControl();
            this.lbNumQues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(295, 26);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(122, 28);
            this.bt_Start.TabIndex = 2;
            this.bt_Start.Text = "Start your test";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(295, 297);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(81, 34);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(393, 297);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 34);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(490, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 34);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // testTimer1
            // 
            this.testTimer1._mm = 10;
            this.testTimer1._ss = 0;
            this.testTimer1.Location = new System.Drawing.Point(12, 12);
            this.testTimer1.Name = "testTimer1";
            this.testTimer1.Size = new System.Drawing.Size(266, 53);
            this.testTimer1.TabIndex = 1;
            this.testTimer1.uscEClock_Exit += new Exercise02._2.ExamTimer.uscEClock_ExitHandle(this.uscClock1_uscEClock_Exit);
            // 
            // quesCtrl
            // 
            this.quesCtrl.Answer1 = "Answer1";
            this.quesCtrl.Answer2 = "Answer2";
            this.quesCtrl.Answer3 = "Answer3";
            this.quesCtrl.Answer4 = "Answer4";
            this.quesCtrl.CorrectAnswer = "";
            this.quesCtrl.Location = new System.Drawing.Point(10, 71);
            this.quesCtrl.Name = "quesCtrl";
            this.quesCtrl.Question = "Question";
            this.quesCtrl.QuestionScore = 0;
            this.quesCtrl.Size = new System.Drawing.Size(587, 220);
            this.quesCtrl.TabIndex = 0;
            this.quesCtrl.YourAnswer = "";
            // 
            // lbNumQues
            // 
            this.lbNumQues.AutoSize = true;
            this.lbNumQues.Location = new System.Drawing.Point(31, 68);
            this.lbNumQues.Name = "lbNumQues";
            this.lbNumQues.Size = new System.Drawing.Size(117, 17);
            this.lbNumQues.TabIndex = 6;
            this.lbNumQues.Text = "Question number";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 343);
            this.Controls.Add(this.lbNumQues);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.testTimer1);
            this.Controls.Add(this.quesCtrl);
            this.Name = "Form2";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExamTimer testTimer1;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbNumQues;
    }
}

