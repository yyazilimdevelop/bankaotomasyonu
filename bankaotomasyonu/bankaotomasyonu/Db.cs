using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaotomasyonu
{
    public class Db
    {
        private static string connStr = "(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

        public static BireyselMusteri DataReaderToMusteri(OracleDataReader dr)
        {
            var musteri = new BireyselMusteri();
            musteri.ID = dr["ID"].ToString();
            musteri.Ad = dr["Ad"].ToString();
            musteri.Soyad = dr["Soyad"].ToString();
            musteri.Sifre = dr["Sifre"].ToString();
            musteri.Tarih = Convert.ToDateTime(dr["Tarih"].ToString());
            musteri.musteriTipi = dr["musteriTipi"].ToString();

            return musteri;
        }

        public static List<BireyselMusteri> MusterileriGetir() {
            var list = new List<BireyselMusteri>();

            OracleConnection con = new OracleConnection(connStr);
            string commandText = "select * from Musteri";
            OracleCommand cmd = new OracleCommand(commandText, con);

            cmd.Connection.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var musteri = DataReaderToMusteri(dr);

                    list.Add(musteri);
                }
            }

            return list;
        }

        public static BireyselMusteri MusteriGetir(string id)
        { 
            OracleConnection con = new OracleConnection(connStr);
            string commandText = "select * from Musteri where ID=(:M_ID)";
            OracleCommand cmd = new OracleCommand(commandText, con);
            cmd.Parameters.Add(new OracleParameter("M_ID", id));
            var musteri = new BireyselMusteri();

            cmd.Connection.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    musteri = DataReaderToMusteri(dr); 
                }
            }

            return musteri;
        }

        public static void MusteriEkle(BireyselMusteri musteri)
        {
            OracleConnection con = new OracleConnection(connStr);
            string commandText = "insert into Musteri (ID,Ad,Soyad,Sifre,Tarih,musteriTipi) values(:M_ID, :M_AD, :M_SOYAD, :M_SIFRE, :M_TARIH, :M_MUSTERITIPI)";
            OracleCommand cmd = new OracleCommand(commandText, con);

            cmd.Parameters.Add(new OracleParameter("M_ID", musteri.ID)); 
            cmd.Parameters.Add(new OracleParameter("M_AD", musteri.Ad)); 
            cmd.Parameters.Add(new OracleParameter("M_SOYAD", musteri.Soyad)); 
            cmd.Parameters.Add(new OracleParameter("M_SIFRE", musteri.Sifre));
            cmd.Parameters.Add(new OracleParameter("M_TARIH", OracleDbType.Date)).Value = musteri.Tarih;
            cmd.Parameters.Add(new OracleParameter("M_MUSTERITIPI", musteri.musteriTipi));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void MusteriGuncelle(BireyselMusteri musteri)
        {
            OracleConnection con = new OracleConnection(connStr);
            string commandText = "update Musteri set Ad=(:M_AD), Soyad=(:M_SOYAD), Sifre=(:M_SIFRE), Tarih=(:M_TARIH), musteriTipi=(:M_MUSTERITIPI) where ID=(:M_ID)";
            OracleCommand cmd = new OracleCommand(commandText, con);

            cmd.Parameters.Add(new OracleParameter("M_ID", musteri.ID));
            cmd.Parameters.Add(new OracleParameter("M_AD", musteri.Ad));
            cmd.Parameters.Add(new OracleParameter("M_SOYAD", musteri.Soyad));
            cmd.Parameters.Add(new OracleParameter("M_SIFRE", musteri.Sifre));
            cmd.Parameters.Add(new OracleParameter("M_TARIH", OracleDbType.Date)).Value = musteri.Tarih;
            cmd.Parameters.Add(new OracleParameter("M_MUSTERITIPI", musteri.musteriTipi));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void MusteriSil(string id)
        {
            OracleConnection con = new OracleConnection(connStr);
            string commandText = "delete from Musteri  where ID=(:M_ID)";
            OracleCommand cmd = new OracleCommand(commandText, con);

            cmd.Parameters.Add(new OracleParameter("M_ID", id)); 

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


    }
}
