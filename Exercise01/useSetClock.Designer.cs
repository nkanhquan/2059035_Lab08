
namespace Exercise01
{
    partial class useSetClock
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.NumericUpDown();
            this.second = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second";
            // 
            // minute
            // 
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.Location = new System.Drawing.Point(77, 11);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(51, 26);
            this.minute.TabIndex = 2;
            this.minute.ValueChanged += new System.EventHandler(this.minute_ValueChanged);
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(238, 11);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(51, 26);
            this.second.TabIndex = 3;
            this.second.ValueChanged += new System.EventHandler(this.second_ValueChanged);
            // 
            // useSetClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.second);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "useSetClock";
            this.Size = new System.Drawing.Size(315, 48);
            ((System.ComponentModel.ISupportInitialize)(this.minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minute;
        private System.Windows.Forms.NumericUpDown second;
    }
}
