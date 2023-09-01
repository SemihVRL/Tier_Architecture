using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=DbKatmanlıMimari;Integrated Security=True");
        //baglantı sınıfımıza static ile eklememizin sebebi başka bir sınıfta bir daha açılmaması için static ekleyerek yapıyoruz.
        

    }
}
