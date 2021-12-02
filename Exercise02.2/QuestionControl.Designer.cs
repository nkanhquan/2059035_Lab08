
namespace Exercise02._2
{
    partial class QuestionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbQuestion = new System.Windows.Forms.Label();
            this.rbtnAns4 = new System.Windows.Forms.RadioButton();
            this.rbtnAns3 = new System.Windows.Forms.RadioButton();
            this.rbtnAns2 = new System.Windows.Forms.RadioButton();
            this.rbtnAns1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(21, 23);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(65, 17);
            this.lbQuestion.TabIndex = 14;
            this.lbQuestion.Text = "Question";
            // 
            // rbtnAns4
            // 
            this.rbtnAns4.AutoSize = true;
            this.rbtnAns4.Location = new System.Drawing.Point(24, 177);
            this.rbtnAns4.Name = "rbtnAns4";
            this.rbtnAns4.Size = new System.Drawing.Size(83, 21);
            this.rbtnAns4.TabIndex = 13;
            this.rbtnAns4.TabStop = true;
            this.rbtnAns4.Text = "Answer4";
            this.rbtnAns4.UseVisualStyleBackColor = true;
            // 
            // rbtnAns3
            // 
            this.rbtnAns3.AutoSize = true;
            this.rbtnAns3.Location = new System.Drawing.Point(24, 137);
            this.rbtnAns3.Name = "rbtnAns3";
            this.rbtnAns3.Size = new System.Drawing.Size(83, 21);
            this.rbtnAns3.TabIndex = 12;
            this.rbtnAns3.TabStop = true;
            this.rbtnAns3.Text = "Answer3";
            this.rbtnAns3.UseVisualStyleBackColor = true;
            // 
            // rbtnAns2
            // 
            this.rbtnAns2.AutoSize = true;
            this.rbtnAns2.Location = new System.Drawing.Point(24, 99);
            this.rbtnAns2.Name = "rbtnAns2";
            this.rbtnAns2.Size = new System.Drawing.Size(83, 21);
            this.rbtnAns2.TabIndex = 11;
            this.rbtnAns2.TabStop = true;
            this.rbtnAns2.Text = "Answer2";
            this.rbtnAns2.UseVisualStyleBackColor = true;
            // 
            // rbtnAns1
            // 
            this.rbtnAns1.AutoSize = true;
            this.rbtnAns1.Location = new System.Drawing.Point(24, 63);
            this.rbtnAns1.Name = "rbtnAns1";
            this.rbtnAns1.Size = new System.Drawing.Size(83, 21);
            this.rbtnAns1.TabIndex = 10;
            this.rbtnAns1.TabStop = true;
            this.rbtnAns1.Text = "Answer1";
            this.rbtnAns1.UseVisualStyleBackColor = true;
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.rbtnAns4);
            this.Controls.Add(this.rbtnAns3);
            this.Controls.Add(this.rbtnAns2);
            this.Controls.Add(this.rbtnAns1);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(252, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.RadioButton rbtnAns4;
        private System.Windows.Forms.RadioButton rbtnAns3;
        private System.Windows.Forms.RadioButton rbtnAns2;
        private System.Windows.Forms.RadioButton rbtnAns1;
    }
}
