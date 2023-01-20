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
    public partial class TranskriptEkrani : Form
    {
        public TranskriptEkrani()
        {
            InitializeComponent();
            DataBaseGoster("SELECT * FROM \"DERSLER\" WHERE (\"DersNotu\" !=  'NULL') ORDER BY \"DersNotu\" ASC;");
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

        private void ganoHesaplaBtn_Click(object sender, EventArgs e)
        {
            GanoVerileri gano = new GanoVerileri();
            gano.GanoDB();
            
            ganoTxt.Text = Convert.ToString(gano.ganos());
        }

        private void anaSayfaBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
