using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class BL_Ders
    {
        public static int DersEkleBl(EntityDers entityDers1)
        {
            if(entityDers1.DersAdi!=null && entityDers1.DersAdi.Length>=3 && entityDers1.DersAdi.Length<=30)
            {
                return DalDers.DersEkle(entityDers1);
            }
            return -1;
        }  

        public static List<EntityDers> DersListesiBL()
        {
            return DalDers.DersListesi();

        }
        public static int DersSilme_BL(byte x)
        {
            if (x>=1)
            {
                return DalDers.DersSilme(x);
            }
            else
            {
                return -1;
            }
        }

        public static int DersGüncelle_Bl(EntityDers entityDers)
        {
            if (entityDers.DersAdi != null)
            {
                return DalDers.DersGüncelle(entityDers);
            }
            return -1;
        }

    }
}
