namespace updateform
{
    partial class display
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
            this.display_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // display_panel
            // 
            this.display_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.display_panel.Location = new System.Drawing.Point(1, 5);
            this.display_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(505, 320);
            this.display_panel.TabIndex = 0;
            this.display_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.display_panel_Paint);
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 328);
            this.Controls.Add(this.display_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "display";
            this.Load += new System.EventHandler(this.display_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel display_panel;
    }
}