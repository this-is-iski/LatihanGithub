namespace LatihanGithub
{
    partial class FormJurusan
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
            this.lblidjurusan = new System.Windows.Forms.Label();
            this.lbljurusan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtidjurusan = new System.Windows.Forms.TextBox();
            this.txtjurusan = new System.Windows.Forms.TextBox();
            this.dgjurusan = new System.Windows.Forms.DataGridView();
            this.btnhapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgjurusan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidjurusan
            // 
            this.lblidjurusan.AutoSize = true;
            this.lblidjurusan.Location = new System.Drawing.Point(103, 112);
            this.lblidjurusan.Name = "lblidjurusan";
            this.lblidjurusan.Size = new System.Drawing.Size(87, 20);
            this.lblidjurusan.TabIndex = 0;
            this.lblidjurusan.Text = "ID Jurusan";
            // 
            // lbljurusan
            // 
            this.lbljurusan.AutoSize = true;
            this.lbljurusan.Location = new System.Drawing.Point(124, 170);
            this.lbljurusan.Name = "lbljurusan";
            this.lbljurusan.Size = new System.Drawing.Size(66, 20);
            this.lbljurusan.TabIndex = 1;
            this.lbljurusan.Text = "Jurusan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(236, 468);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 42);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtidjurusan
            // 
            this.txtidjurusan.Location = new System.Drawing.Point(221, 109);
            this.txtidjurusan.Name = "txtidjurusan";
            this.txtidjurusan.Size = new System.Drawing.Size(221, 26);
            this.txtidjurusan.TabIndex = 4;
            // 
            // txtjurusan
            // 
            this.txtjurusan.Location = new System.Drawing.Point(221, 164);
            this.txtjurusan.Name = "txtjurusan";
            this.txtjurusan.Size = new System.Drawing.Size(221, 26);
            this.txtjurusan.TabIndex = 5;
            // 
            // dgjurusan
            // 
            this.dgjurusan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgjurusan.Location = new System.Drawing.Point(90, 247);
            this.dgjurusan.Name = "dgjurusan";
            this.dgjurusan.RowHeadersWidth = 62;
            this.dgjurusan.RowTemplate.Height = 28;
            this.dgjurusan.Size = new System.Drawing.Size(352, 150);
            this.dgjurusan.TabIndex = 6;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(367, 468);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 42);
            this.btnhapus.TabIndex = 7;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 620);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.dgjurusan);
            this.Controls.Add(this.txtjurusan);
            this.Controls.Add(this.txtidjurusan);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbljurusan);
            this.Controls.Add(this.lblidjurusan);
            this.Name = "FormJurusan";
            this.Text = "FormJurusan";
            ((System.ComponentModel.ISupportInitialize)(this.dgjurusan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidjurusan;
        private System.Windows.Forms.Label lbljurusan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txtidjurusan;
        private System.Windows.Forms.TextBox txtjurusan;
        private System.Windows.Forms.DataGridView dgjurusan;
        private System.Windows.Forms.Button btnhapus;
    }
}