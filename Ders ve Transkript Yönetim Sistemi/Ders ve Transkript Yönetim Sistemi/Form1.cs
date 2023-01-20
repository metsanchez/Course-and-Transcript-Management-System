using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace _200601078_Metehan_Yanik
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dersEkleBtn_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            NpgsqlCommand dersEkle = new NpgsqlCommand();
            dersEkle.Connection = conn;

            dersEkle.Parameters.AddWithValue("@DersKodu", dersKoduTxt.Text);
            dersEkle.Parameters.AddWithValue("@DersAdi", dersAdiTxt.Text);
            dersEkle.Parameters.AddWithValue("@DersKredisi", Convert.ToInt32(dersKredisiTxt.Text));
            dersEkle.Parameters.AddWithValue("@DersAKT", Convert.ToInt32(dersAktTxt.Text));
            dersEkle.Parameters.AddWithValue("@DersOgretimGorevlisi", dersOgretimTxt.Text);
            dersEkle.Parameters.AddWithValue("@DersDonemi", dersDonemiTxt.Text);
            dersEkle.Parameters.AddWithValue("@DersNotu", dersNotuTxt.Text);

            dersEkle.CommandType = CommandType.Text;
            dersEkle.CommandText = "insert into \"DERSLER\" (\"DersKodu\", \"DersAdi\", \"DersKredisi\", \"DersAKT\", \"DersOgretimGorevlisi\", \"DersDonemi\", \"DersNotu\") values (@DersKodu, @DersAdi, @DersKredisi, @DersAKT, @DersOgretimGorevlisi, @DersDonemi, @DersNotu)";

            NpgsqlDataReader dr = dersEkle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dersDataGrid.DataSource = dt;
            }
            dersEkle.Dispose();
            conn.Close();
            MessageBox.Show("Ders Kaydı Başarıyla Eklendi!");
            DataBaseGoster("select * from \"DERSLER\"");
        }

        private void kayitlariGosterBtn_Click(object sender, EventArgs e)
        {
            DataBaseGoster("select * from \"DERSLER\"");
        }
        
        private void araBtn_Click(object sender, EventArgs e)
        {
            bool dersBulundu = false;
            conn.Open();
            NpgsqlCommand dersAra = new NpgsqlCommand();
            dersAra.Connection = conn;
            dersAra.Parameters.AddWithValue("@dersKodu", araTxt.Text);
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

        private void guncellemeEkraniBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuncellemeEkrani guncellemeEkrani = new GuncellemeEkrani();
            guncellemeEkrani.Show();
        }

        private void silmeEkraniBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitSilmeEkrani silmeEkrani = new KayitSilmeEkrani();
            silmeEkrani.Show();
        }

        private void transkriptEkraniBtn_Click(object sender, EventArgs e)
        {
            TranskriptEkrani te = new TranskriptEkrani();
            te.Show();
            this.Hide();
        }
    }
}