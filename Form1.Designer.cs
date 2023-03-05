
namespace Ai_Project___N_queen
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
            this.title = new System.Windows.Forms.Label();
            this.nValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(5, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(665, 82);
            this.title.TabIndex = 0;
            this.title.Text = "N QUEEN Problem";
            // 
            // nValue
            // 
            this.nValue.Location = new System.Drawing.Point(186, 138);
            this.nValue.Multiline = true;
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(113, 37);
            this.nValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value of N";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(19, 214);
            this.startBtn.Name = "startBtn";
            this.startBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.startBtn.Size = new System.Drawing.Size(204, 96);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "solve";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(683, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 1440);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1679, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nValue);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox nValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

