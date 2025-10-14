using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanGithub
{
    public partial class FormJurusan : Form
    {
        string koneksi = "server=localhost;database=db_jurusan;uid=root;pwd=;";

        private void Clear()
        {
            txtidjurusan.Focus();
            txtjurusan.Clear();
            txtidjurusan.Clear();
        }

        private void Select()
        {
            MySqlConnection connect = new MySqlConnection(koneksi);
            try
            {
                connect.Open();
                string query = "SELECT * FROM jurusan";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgjurusan.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Error dengan Info : " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        public FormJurusan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.Owner = this;
            formMenu.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server=localhost;database=db_jurusan;uid=root;pwd;");
            try
            {
                connect.Open();
                string query = "INSERT INTO jurusan(id_jurusan,jurusan)" +
                    "VALUES(@id_jurusan,@jurusan)";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id_jurusan", txtidjurusan.Text);
                cmd.Parameters.AddWithValue("@jurusan", txtjurusan.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                Clear();
                Select();

            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Eror dengan Info : " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (dgjurusan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris yang mau di hapus");
                return;
            }
            MySqlConnection connect = new MySqlConnection(koneksi);
            try
            {
                connect.Open();
                string query = "DELETE FROM jurusan WHERE id_jurusan = @id_jurusan";
                string iddelete = dgjurusan.SelectedRows[0].Cells["id_jurusan"].Value.ToString();
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id_jurusan", iddelete);
                cmd.ExecuteNonQuery();
                Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Error dengan Info : " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
