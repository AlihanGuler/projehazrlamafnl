using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KURSPROJESON
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
       SqlCommand com = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = ALI\SQLEXPRESS; Initial Catalog = yazılımproje; Integrated Security = True";
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals(@"Kullanıcı Adı"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Kullanıcı Adı";
            }

        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals("Şifre"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Şifre";
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from gırıstbb ";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if(txtUsername.Text.Equals(dr["ID"].ToString()) && txtPassword.Text.Equals(dr["Sifre"].ToString()))
                {
                    MessageBox.Show("Giriş Başarılı", "Doğru", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Yanlış ID Veya Şifre", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Form2 a = new Form2();
                this.Hide();
                a.Show();
                con.Close();
               
            }
        }
    }
}
