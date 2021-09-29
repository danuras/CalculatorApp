
namespace CalculatorWindowsFormApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.btnHasil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai B";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(93, 46);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(130, 23);
            this.txtNilaiA.TabIndex = 3;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(93, 75);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(130, 23);
            this.txtNilaiB.TabIndex = 4;
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(93, 115);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(130, 26);
            this.btnHasil.TabIndex = 5;
            this.btnHasil.Text = "Hasil";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstHasil);
            this.groupBox1.Location = new System.Drawing.Point(30, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 264);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Hasil]";
            // 
            // lstHasil
            // 
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.ItemHeight = 15;
            this.lstHasil.Location = new System.Drawing.Point(6, 29);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(258, 229);
            this.lstHasil.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Calculator Versi Windows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Button Hasil;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstHasil;
    }
}

