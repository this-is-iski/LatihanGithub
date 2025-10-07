using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LatihanGithub
{
    public partial class FormSiswa1 : Form
    {
        public FormSiswa1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Siswa_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Lu yakin nih mau tutup gua!?",
                                 "Konfirmasi",
                                 MessageBoxButtons.YesNo);

            if (hasil == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Tuh kan, gak mau tutup gua juga ujung-ujungnya! -_-");
            }

        }

        private void btnKirim_Click(object sender, EventArgs e)
        {

            DialogResult hasil = MessageBox.Show("Lu yakin nih mau simpan data lo ke gua!?",
                                "Konfirmasi",
                                MessageBoxButtons.YesNo); 

            if (hasil == DialogResult.Yes)
            {
                string[] inputdata = { tbNis.Text, tbNama.Text, tbAlamat.Text, cmbJurusan.Text };
                if (string.IsNullOrWhiteSpace(tbNis.Text) || string.IsNullOrWhiteSpace(tbNama.Text) || string.IsNullOrWhiteSpace(tbAlamat.Text) || string.IsNullOrWhiteSpace(cmbJurusan.Text))
                {
                    MessageBox.Show("Yahh, ada yang kosong bro. Lengkapin dulu datanya!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgSiswa.Rows.Add(inputdata);
                MessageBox.Show("Simpan berhasil. Sip");
                tbNis.Clear();
                tbNama.Clear();
                tbAlamat.Clear();
                cmbJurusan.SelectedIndex = -1;
                tbNis.Focus();
            }
            else
            {
                MessageBox.Show("Tuh kan, gak mau juga ujung-ujungnya! -_-");
            }
        }
        private void dgSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblKelas_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Lu yakin datanya mau dihapus!?",
                               "Konfirmasi",
                               MessageBoxButtons.YesNo);

            if (hasil == DialogResult.Yes)
            {
                int index = dgSiswa.CurrentCell.RowIndex;
                dgSiswa.Rows.RemoveAt(index);
                MessageBox.Show("Hapus berhasil. Yey!");
                {
                    MessageBox.Show("Pilih barisnya dulu dong, -_-");
                }
            }
            else
            {
                MessageBox.Show("Hapus dibatalkan...");
            }
        }
    }
}
