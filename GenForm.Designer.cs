namespace WindowsFormsApp4
{
    partial class DB
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
            this.genFormdll1 = new GenFormDBDll.GenFormdll();
            this.SuspendLayout();
            // 
            // genFormdll1
            // 
            this.genFormdll1.Location = new System.Drawing.Point(12, 65);
            this.genFormdll1.Name = "genFormdll1";
            this.genFormdll1.Size = new System.Drawing.Size(856, 534);
            this.genFormdll1.TabIndex = 0;
            this.genFormdll1.Load += new System.EventHandler(this.genFormdll1_Load_2);
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(896, 625);
            this.Controls.Add(this.genFormdll1);
            this.Name = "DB";
            this.Text = "DB";
            this.Load += new System.EventHandler(this.GenForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GenFormDBDll.GenFormdll genFormdll1;
    }
}