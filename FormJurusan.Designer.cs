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
            this.btnkembali = new System.Windows.Forms.Button();
            this.txtidjurusan = new System.Windows.Forms.TextBox();
            this.txtjurusan = new System.Windows.Forms.TextBox();
            this.dgjurusan = new System.Windows.Forms.DataGridView();
            this.btnhapus = new System.Windows.Forms.Button();
            this.lblformjurusan = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(90, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkembali
            // 
            this.btnkembali.Location = new System.Drawing.Point(221, 406);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(75, 42);
            this.btnkembali.TabIndex = 3;
            this.btnkembali.Text = "Kembali";
            this.btnkembali.UseVisualStyleBackColor = true;
            this.btnkembali.Click += new System.EventHandler(this.button2_Click);
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
            this.dgjurusan.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgjurusan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgjurusan.Location = new System.Drawing.Point(90, 221);
            this.dgjurusan.Name = "dgjurusan";
            this.dgjurusan.RowHeadersWidth = 62;
            this.dgjurusan.RowTemplate.Height = 28;
            this.dgjurusan.Size = new System.Drawing.Size(352, 150);
            this.dgjurusan.TabIndex = 6;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(367, 406);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 42);
            this.btnhapus.TabIndex = 7;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // lblformjurusan
            // 
            this.lblformjurusan.AutoSize = true;
            this.lblformjurusan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblformjurusan.Location = new System.Drawing.Point(183, 37);
            this.lblformjurusan.Name = "lblformjurusan";
            this.lblformjurusan.Size = new System.Drawing.Size(186, 32);
            this.lblformjurusan.TabIndex = 8;
            this.lblformjurusan.Text = "Form Jurusan";
            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 505);
            this.Controls.Add(this.lblformjurusan);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.dgjurusan);
            this.Controls.Add(this.txtjurusan);
            this.Controls.Add(this.txtidjurusan);
            this.Controls.Add(this.btnkembali);
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
        private System.Windows.Forms.Button btnkembali;
        private System.Windows.Forms.TextBox txtidjurusan;
        private System.Windows.Forms.TextBox txtjurusan;
        private System.Windows.Forms.DataGridView dgjurusan;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Label lblformjurusan;
    }
}