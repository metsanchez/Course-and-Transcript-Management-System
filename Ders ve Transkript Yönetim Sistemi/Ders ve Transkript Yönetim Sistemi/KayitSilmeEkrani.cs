using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200601078_Metehan_Yanik
{
    public partial class KayitSilmeEkrani : Form
    {
        public KayitSilmeEkrani()
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

        private void KayitSilmeEkrani_Load(object sender, EventArgs e)
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

        private void dersSilBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand dersSil = new NpgsqlCommand();
            dersSil.Connection = conn;
            dersSil.Parameters.AddWithValue("@DersKodu", dersKoduTxtBox.Text);
            dersSil.CommandType = CommandType.Text;
            dersSil.CommandText = "delete from \"DERSLER\" where \"DersKodu\" = @DersKodu";

            NpgsqlDataReader dr = dersSil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dersDataGrid.DataSource = dt;
            }
            dersSil.Dispose();
            conn.Close();

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
