namespace ZH3_forms
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
            this.form2_btn = new System.Windows.Forms.Button();
            this.form3_btn = new System.Windows.Forms.Button();
            this.form4_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form2_btn
            // 
            this.form2_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form2_btn.Location = new System.Drawing.Point(44, 55);
            this.form2_btn.Name = "form2_btn";
            this.form2_btn.Size = new System.Drawing.Size(75, 23);
            this.form2_btn.TabIndex = 0;
            this.form2_btn.Text = "Form2";
            this.form2_btn.UseVisualStyleBackColor = true;
            this.form2_btn.Click += new System.EventHandler(this.form2_btn_Click);
            // 
            // form3_btn
            // 
            this.form3_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form3_btn.Location = new System.Drawing.Point(47, 103);
            this.form3_btn.Name = "form3_btn";
            this.form3_btn.Size = new System.Drawing.Size(75, 23);
            this.form3_btn.TabIndex = 1;
            this.form3_btn.Text = "Form3";
            this.form3_btn.UseVisualStyleBackColor = true;
            this.form3_btn.Click += new System.EventHandler(this.form3_btn_Click);
            // 
            // form4_btn
            // 
            this.form4_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form4_btn.Location = new System.Drawing.Point(47, 152);
            this.form4_btn.Name = "form4_btn";
            this.form4_btn.Size = new System.Drawing.Size(75, 23);
            this.form4_btn.TabIndex = 2;
            this.form4_btn.Text = "Form4";
            this.form4_btn.UseVisualStyleBackColor = true;
            this.form4_btn.Click += new System.EventHandler(this.form4_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Javítózni fogok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form4_btn);
            this.Controls.Add(this.form3_btn);
            this.Controls.Add(this.form2_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button form2_btn;
        private Button form3_btn;
        private Button form4_btn;
        private Label label1;
    }
}