using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGithub
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void fromJurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormJurusan formJurusan = new FormJurusan();
            formJurusan.ShowDialog();
            this.Show();
        }

        private void formSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSiswa1 formSiswa1 = new FormSiswa1();
            formSiswa1.ShowDialog();
            this.Show();
        }
    }
}
