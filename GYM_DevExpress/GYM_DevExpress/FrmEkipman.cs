using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GYM_DevExpress
{
    public partial class FrmEkipman : Form
    {
        public FrmEkipman()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From TBL_EKIPMAN", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void FrmEkipman_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // verileri kaydetme
            // Verileri kaydetme
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_EKIPMAN (ID, ADI, DURUM, TARIH, ADET, MARKA, MODEL, ACIKLAMA, TURU)" +
                " VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", bgl.baglanti());

            // Parametreleri ekleme
            komut.Parameters.AddWithValue("@p1", txtID.Text);       // ID
            komut.Parameters.AddWithValue("@p2", txtAd.Text);       // ADI
            komut.Parameters.AddWithValue("@p3", txtDurum.Text);    // DURUM
            komut.Parameters.AddWithValue("@p4", DateTime.Parse(maskedTarih.Text)); // TARIH
            komut.Parameters.AddWithValue("@p5", decimal.Parse(nudAdet.Value.ToString())); // ADET
            komut.Parameters.AddWithValue("@p6", txtMarka.Text);    // MARKA
            komut.Parameters.AddWithValue("@p7", txtModel.Text);    // MODEL
            komut.Parameters.AddWithValue("@p8", rchDetay.Text);    // ACIKLAMA
            komut.Parameters.AddWithValue("@p9", txtTur.Text);     // TURU




            // Komutu çalıştırma
            komut.ExecuteNonQuery();

            // Bağlantıyı kapatma
            bgl.baglanti().Close();

            // Kullanıcıya bilgi verme
            MessageBox.Show("Ekipman başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_EKIPMAN where ID=@p1",
            bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

    }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // satırın verisini alır
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {


                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["ADI"].ToString();
                txtDurum.Text = dr["DURUM"].ToString();
                txtMarka.Text = dr["TARIH"].ToString();
                txtModel.Text = dr["MODEL"].ToString();
                rchDetay.Text = dr["ACIKLAMA"].ToString();
                txtTur.Text = dr["TURU"].ToString();
                nudAdet.Value = decimal.Parse(dr["ADET"].ToString());
                maskedTarih.Text = dr["TARIH"].ToString();
            }
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DateTime tarih;
            if (string.IsNullOrWhiteSpace(maskedTarih.Text) || !DateTime.TryParse(maskedTarih.Text, out tarih))
            {
                MessageBox.Show("Lütfen geçerli bir tarih giriniz. (Örn: 01/01/2024)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlemi durdur
            }

            SqlCommand komut = new SqlCommand("update TBL_EKIPMAN set ID=@p1, ADI=@p2, DURUM=@p3, TARIH=@p4," +
                " ADET=@p5, MARKA=@p6, MODEL=@p7, ACIKLAMA=@p8, TURU=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);       // ID
            komut.Parameters.AddWithValue("@p2", txtAd.Text);       // ADI
            komut.Parameters.AddWithValue("@p3", txtDurum.Text);    // DURUM
            komut.Parameters.AddWithValue("@p4", DateTime.Parse(maskedTarih.Text)); // TARIH
            komut.Parameters.AddWithValue("@p5", decimal.Parse(nudAdet.Value.ToString())); // ADET
            komut.Parameters.AddWithValue("@p6", txtMarka.Text);    // MARKA
            komut.Parameters.AddWithValue("@p7", txtModel.Text);    // MODEL
            komut.Parameters.AddWithValue("@p8", rchDetay.Text);    // ACIKLAMA
            komut.Parameters.AddWithValue("@p9", txtTur.Text);     // TURu;
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürün bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

