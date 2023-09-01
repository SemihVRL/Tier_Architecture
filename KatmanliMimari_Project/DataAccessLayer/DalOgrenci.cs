using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci entityOgrenci)//entityogrenci classımdan veri çekmek için kullandım
        {
            SqlCommand sqlCommand = new SqlCommand("insert into TblOgrenci(OgrenciAdi,OgrenciSoyadi,OgrenciNumara,OgrenciBolum) values(@p1,@p2,@p3,@p4)", Baglanti.sqlConnection);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            sqlCommand.Parameters.AddWithValue("@p1", entityOgrenci.OgrenciAdi);
            sqlCommand.Parameters.AddWithValue("@p2", entityOgrenci.OgrenciSoyadi);
            sqlCommand.Parameters.AddWithValue("@p3", entityOgrenci.OgrenciNumara);
            sqlCommand.Parameters.AddWithValue("@p4", entityOgrenci.OgrenciBolum);

            return sqlCommand.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> entityOgr = new List<EntityOgrenci>();
            SqlCommand sqlCommand = new SqlCommand("Select * from TblOgrenci", Baglanti.sqlConnection);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OgrenciID = int.Parse(reader[0].ToString());
                ent.OgrenciAdi = reader[1].ToString();
                ent.OgrenciSoyadi = reader[2].ToString();
                ent.OgrenciNumara = reader[3].ToString();
                ent.OgrenciBolum = reader[4].ToString();
                entityOgr.Add(ent);

            }
            reader.Close();
            return entityOgr;
        }
        public static int OgrenciSilme(int x)
        {
            SqlCommand sqlCommand = new SqlCommand("delete from TblOgrenci where OgrenciID=@p1", Baglanti.sqlConnection);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            sqlCommand.Parameters.AddWithValue("@p1", x);
            return sqlCommand.ExecuteNonQuery();
        }
        public static int OgrenciGüncelle(EntityOgrenci entityOgrenci)
        {
            SqlCommand sqlCommand1 = new SqlCommand("update TblOgrenci set OgrenciAdi=@p2, OgrenciSoyadi=@p3 , OgrenciNumara=@p4,OgrenciBolum=@p5 where OgrenciID=@p1", Baglanti.sqlConnection);
            if (sqlCommand1.Connection.State != ConnectionState.Open)
            {
                sqlCommand1.Connection.Open();
            }
            sqlCommand1.Parameters.AddWithValue("@p1",entityOgrenci.OgrenciID);
            sqlCommand1.Parameters.AddWithValue("@p2",entityOgrenci.OgrenciAdi);
            sqlCommand1.Parameters.AddWithValue("@p3", entityOgrenci.OgrenciSoyadi);
            sqlCommand1.Parameters.AddWithValue("@p4",entityOgrenci.OgrenciNumara);
            sqlCommand1.Parameters.AddWithValue("@p5", entityOgrenci.OgrenciBolum);

            return sqlCommand1.ExecuteNonQuery();
        }
    }
}
