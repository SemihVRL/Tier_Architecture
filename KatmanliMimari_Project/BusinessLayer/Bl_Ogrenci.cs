using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class Bl_Ogrenci
    {
        public static int OgrenciEkle_BL(EntityOgrenci ogrenci)
        {
            if (ogrenci.OgrenciAdi != null && ogrenci.OgrenciSoyadi != null && ogrenci.OgrenciNumara != null && ogrenci.OgrenciBolum != null)
            {
                return DalOgrenci.OgrenciEkle(ogrenci);
            }
            return -1;
        }
        public static List<EntityOgrenci> OgrenciListesi_BL()
        {
            return DalOgrenci.OgrenciListesi(); 
        }
        public static int OgrenciSilme_BL(int x)
        {
            if (x>=1)
            {
                return DalOgrenci.OgrenciSilme(x);
            }
            else
            {
                return -1;
            }
        }

        public static int OgrenciGüncelle_BL(EntityOgrenci entityOgrenci)
        {
            if (entityOgrenci.OgrenciAdi != null)
            {
                return DalOgrenci.OgrenciGüncelle(entityOgrenci);
            }
            return -1;
        }
        
    }
}
