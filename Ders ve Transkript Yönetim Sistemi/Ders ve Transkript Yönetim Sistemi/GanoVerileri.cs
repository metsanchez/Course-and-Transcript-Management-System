using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace _200601078_Metehan_Yanik
{
    public class GanoVerileri
    {
        NpgsqlConnection conn = new NpgsqlConnection("server = localHost; port=5432;Database=BakircayDB; user Id=postgres; Password=123");


        public string DersNotu { get; set; }
        public double HarfPuani { get; set; }
        public double DersKredi { get; set; }
        public double ToplamKredi { get; set; }
        public double Toplam { get; set; }
        public double GenelToplam { get; set; }
        public double Sonuc;

        public void GanoHesapla()
        {
            switch (DersNotu)
            {
                case "AA":
                    HarfPuani = 4.00;
                    break;

                case "BA":
                    HarfPuani = 3.50;
                    break;

                case "BB":
                    HarfPuani = 3.00;
                    break;

                case "CB":
                    HarfPuani = 2.50;
                    break;

                case "CC":
                    HarfPuani = 2.00;
                    break;

                case "DC":
                    HarfPuani = 1.50;
                    break;

                case "DD":
                    HarfPuani = 1.00;
                    break;

                case "FD":
                    HarfPuani = 0.50;
                    break;

                case "FF":
                    HarfPuani = 0.00;
                    break;

            }
        }

        public void GanoDB()
        {
            conn.Open();

            // Veritabanına sorgu göndermek için bir komut oluşturun
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT \"DersNotu\", \"DersKredisi\" FROM \"DERSLER\"";

                // Sorguyu çalıştırın ve sonucu bir okuyucuya atayın
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            DersNotu = reader["DersNotu"].ToString();
                            DersKredi = Convert.ToDouble(reader["DersKredisi"]);
                            GanoHesapla();
                            Toplam += HarfPuani * DersKredi;
                            ToplamKredi += DersKredi;
                        }
                        
                    }
                }
            }

            Sonuc = Toplam / ToplamKredi;
        }

        public double ganos()
        {
            return Sonuc;
        }
        
        
    }
}

