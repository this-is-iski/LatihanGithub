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
            this.lblformjurusan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgjurusan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidjurusan
            // 
            this.lblidjurusan.AutoSize = true;
            this.lblidjurusan.Location = new System.Drawing.Point(92, 90);
            this.lblidjurusan.Name = "lblidjurusan";
            this.lblidjurusan.Size = new System.Drawing.Size(70, 16);
            this.lblidjurusan.TabIndex = 0;
            this.lblidjurusan.Text = "ID Jurusan";
            // 
            // lbljurusan
            // 
            this.lbljurusan.AutoSize = true;
            this.lbljurusan.Location = new System.Drawing.Point(110, 136);
            this.lbljurusan.Name = "lbljurusan";
            this.lbljurusan.Size = new System.Drawing.Size(54, 16);
            this.lbljurusan.TabIndex = 1;
            this.lbljurusan.Text = "Jurusan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(196, 325);
            this.btnedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(67, 34);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtidjurusan
            // 
            this.txtidjurusan.Location = new System.Drawing.Point(196, 87);
            this.txtidjurusan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidjurusan.Name = "txtidjurusan";
            this.txtidjurusan.Size = new System.Drawing.Size(197, 22);
            this.txtidjurusan.TabIndex = 4;
            // 
            // txtjurusan
            // 
            this.txtjurusan.Location = new System.Drawing.Point(196, 131);
            this.txtjurusan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtjurusan.Name = "txtjurusan";
            this.txtjurusan.Size = new System.Drawing.Size(197, 22);
            this.txtjurusan.TabIndex = 5;
            // 
            // dgjurusan
            // 
            this.dgjurusan.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgjurusan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgjurusan.Location = new System.Drawing.Point(80, 177);
            this.dgjurusan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgjurusan.Name = "dgjurusan";
            this.dgjurusan.RowHeadersWidth = 62;
            this.dgjurusan.RowTemplate.Height = 28;
            this.dgjurusan.Size = new System.Drawing.Size(313, 120);
            this.dgjurusan.TabIndex = 6;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(326, 325);
            this.btnhapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(67, 34);
            this.btnhapus.TabIndex = 7;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            // 
            // lblformjurusan
            // 
            this.lblformjurusan.AutoSize = true;
            this.lblformjurusan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblformjurusan.Location = new System.Drawing.Point(163, 30);
            this.lblformjurusan.Name = "lblformjurusan";
            this.lblformjurusan.Size = new System.Drawing.Size(158, 26);
            this.lblformjurusan.TabIndex = 8;
            this.lblformjurusan.Text = "Form Jurusan";
            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 404);
            this.Controls.Add(this.lblformjurusan);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.dgjurusan);
            this.Controls.Add(this.txtjurusan);
            this.Controls.Add(this.txtidjurusan);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbljurusan);
            this.Controls.Add(this.lblidjurusan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblformjurusan;
    }
}