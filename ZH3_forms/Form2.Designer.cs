namespace ZH3_forms
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
            this.control1_btn = new System.Windows.Forms.Button();
            this.control2_btn = new System.Windows.Forms.Button();
            this.control3_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // control1_btn
            // 
            this.control1_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.control1_btn.Location = new System.Drawing.Point(40, 43);
            this.control1_btn.Name = "control1_btn";
            this.control1_btn.Size = new System.Drawing.Size(112, 84);
            this.control1_btn.TabIndex = 0;
            this.control1_btn.Text = "Control1";
            this.control1_btn.UseVisualStyleBackColor = true;
            this.control1_btn.Click += new System.EventHandler(this.control1_btn_Click);
            // 
            // control2_btn
            // 
            this.control2_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.control2_btn.Location = new System.Drawing.Point(40, 171);
            this.control2_btn.Name = "control2_btn";
            this.control2_btn.Size = new System.Drawing.Size(112, 84);
            this.control2_btn.TabIndex = 1;
            this.control2_btn.Text = "Control2";
            this.control2_btn.UseVisualStyleBackColor = true;
            this.control2_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // control3_btn
            // 
            this.control3_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.control3_btn.Location = new System.Drawing.Point(40, 310);
            this.control3_btn.Name = "control3_btn";
            this.control3_btn.Size = new System.Drawing.Size(112, 84);
            this.control3_btn.TabIndex = 2;
            this.control3_btn.Text = "Control3";
            this.control3_btn.UseVisualStyleBackColor = true;
            this.control3_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(200, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 351);
            this.panel1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.control3_btn);
            this.Controls.Add(this.control2_btn);
            this.Controls.Add(this.control1_btn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button control1_btn;
        private Button control2_btn;
        private Button control3_btn;
        private Panel panel1;
    }
}