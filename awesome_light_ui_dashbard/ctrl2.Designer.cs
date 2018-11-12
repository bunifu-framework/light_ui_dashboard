namespace awesome_light_ui_dashbard
{
    partial class ctrl2
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
            this.lblmain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblmain.Location = new System.Drawing.Point(32, 37);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(75, 29);
            this.lblmain.TabIndex = 4;
            this.lblmain.Text = "Tab 2";
            this.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.lblmain);
            this.Name = "ctrl2";
            this.Size = new System.Drawing.Size(1079, 787);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmain;
    }
}
