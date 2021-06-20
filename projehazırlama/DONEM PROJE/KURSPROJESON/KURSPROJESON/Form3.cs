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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Class1 a = new Class1();


        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        static string kursstrng = ConfigurationManager.ConnectionStrings["KURSPROJESON.Properties.Settings.Ayar"].ConnectionString;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;      
            SqlDataAdapter sda = new SqlDataAdapter("Select * from ogrencilertbl Where AdSoyad LIKE '%" +keyword+ "%' OR TelNo LIKE'%"+keyword+"%'", kursstrng);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

  
    }
}
