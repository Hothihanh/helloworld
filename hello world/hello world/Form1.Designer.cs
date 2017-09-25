namespace hello_world
{
    partial class Frmhelloworld
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
            this.btnshow = new System.Windows.Forms.Button();
            this.lblhelloworld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.Red;
            this.btnshow.Location = new System.Drawing.Point(103, 322);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(163, 40);
            this.btnshow.TabIndex = 0;
            this.btnshow.Text = "show hello world";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // lblhelloworld
            // 
            this.lblhelloworld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhelloworld.AutoSize = true;
            this.lblhelloworld.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhelloworld.Location = new System.Drawing.Point(67, 116);
            this.lblhelloworld.Name = "lblhelloworld";
            this.lblhelloworld.Size = new System.Drawing.Size(0, 61);
            this.lblhelloworld.TabIndex = 1;
            this.lblhelloworld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frmhelloworld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 374);
            this.Controls.Add(this.lblhelloworld);
            this.Controls.Add(this.btnshow);
            this.MinimumSize = new System.Drawing.Size(400, 385);
            this.Name = "Frmhelloworld";
            this.Text = "hello world";
            this.Load += new System.EventHandler(this.Frmhelloworld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label lblhelloworld;
    }
}

