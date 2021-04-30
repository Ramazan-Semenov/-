
namespace WindowsFormsApp4
{
    partial class Box_office
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.ofbox1 = new WindowsFormsApp4.ofbox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(143, 50);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(645, 423);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged_1);
            this.elementHost1.Child = this.ofbox1;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(3, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 23);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Продать товар";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            this.metroButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroButton1_MouseMove);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(3, 65);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(114, 23);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Добавить путёвку";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            this.metroButton2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroButton2_MouseMove);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(3, 118);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(114, 23);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Открыть таблицы";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            this.metroButton3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroButton3_MouseMove);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(3, 171);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(114, 23);
            this.metroButton4.TabIndex = 8;
            this.metroButton4.Text = "Остаток";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            this.metroButton4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroButton4_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroButton4);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Location = new System.Drawing.Point(11, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 423);
            this.panel1.TabIndex = 9;
            // 
            // Box_office
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.elementHost1);
            this.Name = "Box_office";
            this.Text = "Box_office";
            this.Load += new System.EventHandler(this.Box_office_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private ofbox ofbox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.Panel panel1;
    }
}