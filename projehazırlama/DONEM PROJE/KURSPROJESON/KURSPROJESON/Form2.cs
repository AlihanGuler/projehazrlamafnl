using KURSPROJESON.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSPROJESON
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.AdSoyad = txtAdSoyad.Text;
            c.TelNo = int.Parse(txtTelNo.Text);
            c.MailAdres = txtMailAdres.Text;
            c.Adres = txtAdres.Text;
            bool success = c.Insert(c);
            if (success== true)
            {
                MessageBox.Show("YENI KAYIT OLUŞTURULDU");
            }
            else
            {
                MessageBox.Show("YENI KAYIT OLUŞTURULAMADI");
            }
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.AdSoyad = txtAdSoyad.Text;
            c.TelNo = int.Parse(txtTelNo.Text);
            c.MailAdres = txtMailAdres.Text;
            c.Adres = txtAdres.Text;
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("GÜNCELLEME BAŞARILI");
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("GÜNCELLEME BAŞARISIZ");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            ;
            txtAdSoyad.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtTelNo.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtMailAdres.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
