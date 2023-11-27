
namespace Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.NumericUpDown();
            this.txtnum2 = new System.Windows.Forms.NumericUpDown();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnzarb = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btntaghsim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد اول :";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "عدد دوم :";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(187, 36);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(163, 21);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(187, 99);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(163, 21);
            this.txtnum2.TabIndex = 3;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(23, 52);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(57, 23);
            this.btnplus.TabIndex = 4;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnzarb
            // 
            this.btnzarb.Location = new System.Drawing.Point(23, 90);
            this.btnzarb.Name = "btnzarb";
            this.btnzarb.Size = new System.Drawing.Size(57, 23);
            this.btnzarb.TabIndex = 5;
            this.btnzarb.Text = "X";
            this.btnzarb.UseVisualStyleBackColor = true;
            this.btnzarb.Click += new System.EventHandler(this.btnzarb_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(86, 52);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(59, 23);
            this.btnminus.TabIndex = 6;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // btntaghsim
            // 
            this.btntaghsim.Location = new System.Drawing.Point(86, 90);
            this.btntaghsim.Name = "btntaghsim";
            this.btntaghsim.Size = new System.Drawing.Size(59, 23);
            this.btntaghsim.TabIndex = 7;
            this.btntaghsim.Text = "/";
            this.btntaghsim.UseVisualStyleBackColor = true;
            this.btntaghsim.Click += new System.EventHandler(this.btntaghsim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 137);
            this.Controls.Add(this.btntaghsim);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnzarb);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب";
            ((System.ComponentModel.ISupportInitialize)(this.txtnum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtnum1;
        private System.Windows.Forms.NumericUpDown txtnum2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnzarb;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btntaghsim;
    }
}

