namespace LatihanGithub
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formSiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromJurusanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formMenuToolStripMenuItem
            // 
            this.formMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formSiswaToolStripMenuItem,
            this.fromJurusanToolStripMenuItem});
            this.formMenuToolStripMenuItem.Name = "formMenuToolStripMenuItem";
            this.formMenuToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.formMenuToolStripMenuItem.Text = "Form Menu";
            // 
            // formSiswaToolStripMenuItem
            // 
            this.formSiswaToolStripMenuItem.Name = "formSiswaToolStripMenuItem";
            this.formSiswaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formSiswaToolStripMenuItem.Text = "Form Siswa";
            this.formSiswaToolStripMenuItem.Click += new System.EventHandler(this.formSiswaToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // fromJurusanToolStripMenuItem
            // 
            this.fromJurusanToolStripMenuItem.Name = "fromJurusanToolStripMenuItem";
            this.fromJurusanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fromJurusanToolStripMenuItem.Text = "From Jurusan";
            this.fromJurusanToolStripMenuItem.Click += new System.EventHandler(this.fromJurusanToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formSiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromJurusanToolStripMenuItem;
    }
}