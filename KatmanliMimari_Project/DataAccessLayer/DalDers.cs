using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalDers
    {
        //Crud Metotları
        //ADD REMOVE UPDATE 
        public static int DersEkle(EntityDers entityDers)//bunu bağlamak için reference yaptık veriyi çekmek için
       {
            SqlCommand sqlCommand= new SqlCommand("insert into TblDersler(DersAdi) values(@p1)",Baglanti.sqlConnection);

            if (sqlCommand.Connection.State != ConnectionState.Open)//sql commandın bağlantı durumu kapalıysa 
            {
                sqlCommand.Connection.Open();
            }

            sqlCommand.Parameters.AddWithValue("@p1",entityDers.DersAdi);
            return sqlCommand.ExecuteNonQuery();
       }
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> entityDers = new List<EntityDers>();
            SqlCommand sqlCommand2 = new SqlCommand("select * from TblDersler",Baglanti.sqlConnection);
            if (sqlCommand2.Connection.State != ConnectionState.Open)//sql commandın bağlantı durumu kapalıysa 
            {
                sqlCommand2.Connection.Open();
            }
            SqlDataReader reader = sqlCommand2.ExecuteReader();
             while (reader.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DersID = byte.Parse(reader[0].ToString());
                ent.DersAdi = reader[1].ToString();
                entityDers.Add(ent);
            }
            reader.Close();
            return entityDers;
          
        }
        public static int DersSilme(byte x)
        {
            SqlCommand sqlCommand3 = new SqlCommand("DELETE from TblDersler where DersID=@p1",Baglanti.sqlConnection);
            if (sqlCommand3.Connection.State != ConnectionState.Open)//sql commandın bağlantı durumu kapalıysa 
            {
                sqlCommand3.Connection.Open();
            }
            sqlCommand3.Parameters.AddWithValue("@p1",x);
            return sqlCommand3.ExecuteNonQuery();
        }

        public static int DersGüncelle(EntityDers entityDers)
        {
            SqlCommand sqlCommand4 = new SqlCommand("update TblDersler set DersAdi=@p2 WHERE DersID=@p1 ", Baglanti.sqlConnection);
            if (sqlCommand4.Connection.State != ConnectionState.Open)//sql commandın bağlantı durumu kapalıysa 
            {
                sqlCommand4.Connection.Open();
            }
            sqlCommand4.Parameters.AddWithValue("@p1",entityDers.DersID);
            sqlCommand4.Parameters.AddWithValue("@p2",entityDers.DersAdi);
            return sqlCommand4.ExecuteNonQuery();

        }

      
    }
}
