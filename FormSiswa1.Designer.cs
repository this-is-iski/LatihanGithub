namespace LatihanGithub
{
    partial class FormSiswa1
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
            this.lblNis = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblJurusan = new System.Windows.Forms.Label();
            this.tbNis = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnKirim = new System.Windows.Forms.Button();
            this.cmbJurusan = new System.Windows.Forms.ComboBox();
            this.dgSiswa = new System.Windows.Forms.DataGridView();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNis
            // 
            this.lblNis.AutoSize = true;
            this.lblNis.Location = new System.Drawing.Point(19, 16);
            this.lblNis.Name = "lblNis";
            this.lblNis.Size = new System.Drawing.Size(36, 20);
            this.lblNis.TabIndex = 0;
            this.lblNis.Text = "NIS";
            this.lblNis.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(19, 72);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(19, 129);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(59, 20);
            this.lblAlamat.TabIndex = 2;
            this.lblAlamat.Text = "Alamat";
            this.lblAlamat.Click += new System.EventHandler(this.lblKelas_Click);
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new System.Drawing.Point(19, 181);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(66, 20);
            this.lblJurusan.TabIndex = 3;
            this.lblJurusan.Text = "Jurusan";
            // 
            // tbNis
            // 
            this.tbNis.Location = new System.Drawing.Point(159, 16);
            this.tbNis.Name = "tbNis";
            this.tbNis.Size = new System.Drawing.Size(239, 26);
            this.tbNis.TabIndex = 1;
            this.tbNis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbAlamat
            // 
            this.tbAlamat.AcceptsReturn = true;
            this.tbAlamat.Location = new System.Drawing.Point(159, 126);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(239, 26);
            this.tbAlamat.TabIndex = 3;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(159, 66);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(239, 26);
            this.tbNama.TabIndex = 2;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(424, 93);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(99, 41);
            this.btnKembali.TabIndex = 9;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(584, 93);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(99, 41);
            this.btnKirim.TabIndex = 5;
            this.btnKirim.Text = "KIRIM";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // cmbJurusan
            // 
            this.cmbJurusan.FormattingEnabled = true;
            this.cmbJurusan.Items.AddRange(new object[] {
            "RPL",
            "AKL",
            "ULW"});
            this.cmbJurusan.Location = new System.Drawing.Point(159, 184);
            this.cmbJurusan.Name = "cmbJurusan";
            this.cmbJurusan.Size = new System.Drawing.Size(239, 28);
            this.cmbJurusan.TabIndex = 4;
            // 
            // dgSiswa
            // 
            this.dgSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSiswa.Location = new System.Drawing.Point(12, 227);
            this.dgSiswa.Name = "dgSiswa";
            this.dgSiswa.RowHeadersWidth = 62;
            this.dgSiswa.RowTemplate.Height = 28;
            this.dgSiswa.Size = new System.Drawing.Size(653, 304);
            this.dgSiswa.TabIndex = 12;
            this.dgSiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSiswa_CellContentClick);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(502, 160);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(99, 41);
            this.btnHapus.TabIndex = 13;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // FormSiswa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 543);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dgSiswa);
            this.Controls.Add(this.cmbJurusan);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNis);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNis);
            this.Name = "FormSiswa1";
            this.Text = "Siswa";
            this.Load += new System.EventHandler(this.Siswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNis;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.TextBox tbNis;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.ComboBox cmbJurusan;
        private System.Windows.Forms.DataGridView dgSiswa;
        private System.Windows.Forms.Button btnHapus;
    }
}