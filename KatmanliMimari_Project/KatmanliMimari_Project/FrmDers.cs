using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using BusinessLayer;

namespace KatmanliMimari_Project
{
    public partial class FrmDers : Form
    {
        public FrmDers()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityDers ent=new EntityDers();
            ent.DersAdi = tbxDersAdi.Text;

            BL_Ders.DersEkleBl(ent);
           
        }

       

        private void btnListe_Click(object sender, EventArgs e)
        {
            List<EntityDers> list = BL_Ders.DersListesiBL();
            dataGridView1.DataSource = list;
        }

     
        private void btnSil_Click(object sender, EventArgs e)
        {
            byte deger = byte.Parse(tbxDersID.Text);
            EntityDers ders = new EntityDers();
            ders.DersID=byte.Parse(deger.ToString());
            BL_Ders.DersSilme_BL(ders.DersID);

            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            EntityDers entityDers = new EntityDers();
            entityDers.DersID = byte.Parse(tbxDersID.Text);
            entityDers.DersAdi = tbxDersAdi.Text;
            BL_Ders.DersGüncelle_Bl(entityDers);
        }
    }
}
