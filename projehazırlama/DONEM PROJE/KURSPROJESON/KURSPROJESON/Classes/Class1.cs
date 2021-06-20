using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSPROJESON.Classes
{
    class Class1
    {
        public string AdSoyad { get; set; }
        public int TelNo { get; set; }
        public string MailAdres { get; set; }
        public string Adres { get; set; }
        static string kursstrng = ConfigurationManager.ConnectionStrings["KURSPROJESON.Properties.Settings.Ayar"].ConnectionString;
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(kursstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM ogrencilertbl";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert (Class1 c)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(kursstrng);
            try
            {
                string sql = "INSERT INTO ogrencilertbl(AdSoyad, TelNo, MailAdres, Adres) VALUES(@AdSoyad, @TelNo, @MailAdres, @Adres)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@AdSoyad", c.AdSoyad);
                cmd.Parameters.AddWithValue("@TelNo", c.TelNo);
                cmd.Parameters.AddWithValue("@MailAdres", c.MailAdres);
                cmd.Parameters.AddWithValue("@Adres", c.Adres);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSucces;
        }
        public bool Delete(Class1 c)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(kursstrng);
            try
            {
                string sql = "DELETE FROM ogrencilertbl WHERE AdSoyad=@AdSoyad";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@AdSoyad", c.AdSoyad);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch(Exception ex)
            { 

            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        public bool Update(Class1 c)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(kursstrng);
            try
            {
                string sql = "UPDATE ogrencilertbl SET AdSoyad=@AdSoyad, @TelNo=TelNo, @MailAdres=MailAdres, @Adres=Adres";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@AdSoyad", c.AdSoyad);
                cmd.Parameters.AddWithValue("@TelNo", c.TelNo);
                cmd.Parameters.AddWithValue("@MailAdres", c.MailAdres);
                cmd.Parameters.AddWithValue("@Adres", c.Adres);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
    }

}
