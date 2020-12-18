namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textint1 = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnUrut = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input :";
            // 
            // textint1
            // 
            this.textint1.Location = new System.Drawing.Point(15, 30);
            this.textint1.Name = "textint1";
            this.textint1.Size = new System.Drawing.Size(220, 22);
            this.textint1.TabIndex = 1;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(12, 90);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(128, 52);
            this.btnReverse.TabIndex = 2;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnUrut
            // 
            this.btnUrut.Location = new System.Drawing.Point(15, 163);
            this.btnUrut.Name = "btnUrut";
            this.btnUrut.Size = new System.Drawing.Size(125, 47);
            this.btnUrut.TabIndex = 3;
            this.btnUrut.Text = "Urutkan";
            this.btnUrut.UseVisualStyleBackColor = true;
            this.btnUrut.Click += new System.EventHandler(this.btnUrut_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 273);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 17);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnUrut);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.textint1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textint1;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnUrut;
        private System.Windows.Forms.Label lbl1;
    }
}

