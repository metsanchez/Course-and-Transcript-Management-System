using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _200601078_Metehan_Yanik
{
    public partial class GuncellemeEkrani : Form
    {
        public GuncellemeEkrani()
        {
            InitializeComponent();
            DataBaseGoster("select * from \"DERSLER\"");
        }
        NpgsqlConnection conn = new NpgsqlConnection("server = localHost; port=5432;Database=BakircayDB; user Id=postgres; Password=123");

        public void DataBaseGoster(string txt)
        {
            conn.Open();
            NpgsqlCommand dbManage = new NpgsqlCommand();
            dbManage.Connection = conn;
            dbManage.CommandType = CommandType.Text;
            dbManage.CommandText = txt;
            NpgsqlDataReader dr = dbManage.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dersDataGrid.DataSource = dt;
            }
            dbManage.Dispose();
            conn.Close();
        }

        private void GuncellemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void dersKoduTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dersiBulBtn_Click(object sender, EventArgs e)
        {
            bool dersBulundu = false;
            conn.Open();
            NpgsqlCommand dersAra = new NpgsqlCommand();
            dersAra.Connection = conn;
            dersAra.Parameters.AddWithValue("@dersKodu", dersKoduTxtBox.Text);
            dersAra.CommandType = CommandType.Text;
            dersAra.CommandText = "select * from \"DERSLER\" where \"DersKodu\" = @dersKodu";
            NpgsqlDataReader dr = dersAra.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dersDataGrid.DataSource = dt;
                dersBulundu = true;
            }
            conn.Close();
            if (dersBulundu == false)
            {
                MessageBox.Show("BU KODA SAHIP DERS BULUNMAMAKTADIR!");
            }          
        }

        private void dersGuncelleBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand dersGuncelle = new NpgsqlCommand();
            dersGuncelle.Connection = conn;
            dersGuncelle.Parameters.AddWithValue("@DersiGuncelle", dersKoduTxtBox.Text);
            dersGuncelle.Parameters.AddWithValue("@DersKodu", dersKoduTxt.Text);
            dersGuncelle.Parameters.AddWithValue("@DersAdi", dersAdiTxt.Text);
            dersGuncelle.Parameters.AddWithValue("@DersKredisi", Convert.ToInt32(dersKredisiTxt.Text));
            dersGuncelle.Parameters.AddWithValue("@DersAKT", Convert.ToInt32(dersAktTxt.Text));
            dersGuncelle.Parameters.AddWithValue("@DersOgretimGorevlisi", ogretimGorevlisiTxt.Text);
            dersGuncelle.Parameters.AddWithValue("@DersDonemi", dersDonemTxt.Text);
            dersGuncelle.Parameters.AddWithValue("@DersNotu", dersNotuTxt.Text);


            dersGuncelle.CommandType = CommandType.Text;
            dersGuncelle.CommandText = "update \"DERSLER\" set \"DersKodu\"=@DersKodu, \"DersAdi\"=@DersAdi, \"DersKredisi\"=@DersKredisi, \"DersAKT\"=@DersAKT, \"DersOgretimGorevlisi\"=@DersOgretimGorevlisi, \"DersDonemi\"=@DersDonemi,\"DersNotu\"=@DersNotu where \"DersKodu\"=@DersiGuncelle";

            NpgsqlDataReader dr = dersGuncelle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dersDataGrid.DataSource = dt;
            }
            dersGuncelle.Dispose();
            conn.Close();
            MessageBox.Show("Ders Başarıyla Güncellendi!");
            DataBaseGoster("select * from \"DERSLER\"");
        }

        private void anaSayfaBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
