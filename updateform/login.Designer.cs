namespace updateform
{
    partial class login
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
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.Add_bttn = new System.Windows.Forms.Button();
            this.cancel_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(216, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(322, 116);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(203, 23);
            this.tb2.TabIndex = 2;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(322, 54);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(203, 23);
            this.tb1.TabIndex = 3;
            // 
            // Add_bttn
            // 
            this.Add_bttn.Location = new System.Drawing.Point(322, 199);
            this.Add_bttn.Name = "Add_bttn";
            this.Add_bttn.Size = new System.Drawing.Size(75, 23);
            this.Add_bttn.TabIndex = 4;
            this.Add_bttn.Text = "add";
            this.Add_bttn.UseVisualStyleBackColor = true;
            this.Add_bttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_bttn
            // 
            this.cancel_bttn.Location = new System.Drawing.Point(467, 199);
            this.cancel_bttn.Name = "cancel_bttn";
            this.cancel_bttn.Size = new System.Drawing.Size(75, 23);
            this.cancel_bttn.TabIndex = 5;
            this.cancel_bttn.Text = "cancel";
            this.cancel_bttn.UseVisualStyleBackColor = true;
            this.cancel_bttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_bttn);
            this.Controls.Add(this.Add_bttn);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb2;
        private TextBox tb1;
        private Button Add_bttn;
        private Button cancel_bttn;
    }
}