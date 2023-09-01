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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci entityOgrenci = new EntityOgrenci();
            entityOgrenci.OgrenciAdi = tbxAd.Text;
            entityOgrenci.OgrenciSoyadi=tbxSoyad.Text;
            entityOgrenci.OgrenciNumara = tbxNumara.Text;
            entityOgrenci.OgrenciBolum = tbxBolum.Text;
            Bl_Ogrenci.OgrenciEkle_BL(entityOgrenci);
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            List<EntityOgrenci> list = Bl_Ogrenci.OgrenciListesi_BL();
            dataGridView1.DataSource = list;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(tbxID.Text);
            EntityOgrenci ent=new EntityOgrenci();
            ent.OgrenciID = int.Parse(deger.ToString());
            Bl_Ogrenci.OgrenciSilme_BL(ent.OgrenciID);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci entityOgrenci = new EntityOgrenci();
            entityOgrenci.OgrenciAdi = tbxAd.Text;
            entityOgrenci.OgrenciSoyadi = tbxSoyad.Text;
            entityOgrenci.OgrenciNumara = tbxNumara.Text;
            entityOgrenci.OgrenciBolum = tbxBolum.Text;
            entityOgrenci.OgrenciID = int.Parse(tbxID.Text);
            Bl_Ogrenci.OgrenciGüncelle_BL(entityOgrenci);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbxAd.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxSoyad.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxNumara.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxBolum.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
