using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;// Windows Forms bileşenleri için gerekli
using System.Data.SqlClient;// SQL veritabanı bağlantısı için gerekli

namespace GYM_DevExpress
{// Yeni Üye Formu
    public partial class frmPersonel : Form
    {
        // Yapıcı metod: Form açıldığında ilk çalışan metod.
        public frmPersonel()
        {
            InitializeComponent(); // Form bileşenlerini başlatır.
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        // SQL bağlantısı için bir nesne oluşturuluyor.
        sqlBaglantisi bgl = new sqlBaglantisi();
        // Personel listesini veritabanından çekip gridControl'e aktaran metod.
        void personelliste()
        {
            // DataTable: Verileri geçici olarak hafızada saklamak için kullanılır.
            DataTable dt = new DataTable();
            // SQL verilerini çekmek için bir SqlDataAdapter kullanıyoruz.
            SqlDataAdapter da = new SqlDataAdapter("Select* from TBL_PERSONELLER", bgl.baglanti());
            // SqlDataAdapter ile getirilen veriler DataTable'a dolduruluyor.
            da.Fill(dt);
            // gridControl1 bileşeninin veri kaynağı olarak DataTable atanıyor.
            gridControl1.DataSource = dt;

        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            
            // Eğer form yüklendiğinde personelliste() metodunu çalıştırmak isterseniz:
             personelliste();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER(AD,SOYAD,TC,MAIL,ADRES,GOREV,TELEFON)values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",  mskTc.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);          
            komut.Parameters.AddWithValue("@p5", rchAdres.Text);
            komut.Parameters.AddWithValue("@p6", txtGorev.Text);
            komut.Parameters.AddWithValue("@p7", mskTel.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgileri Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelliste();
        }

       
        private void btnSil_Click(object sender, EventArgs e)
        {
            // Personel silme işlemi
            SqlCommand komut = new SqlCommand("DELETE FROM TBL_PERSONELLER WHERE ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personelliste();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr != null)
            {
                // tıkladığım yerdeki bilgileri taşıyacak
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["SOYAD"].ToString();
                mskTel.Text = dr["TELEFON"].ToString();
                mskTc.Text = dr["TC"].ToString();
                txtMail.Text = dr["MAIL"].ToString();               
                rchAdres.Text = dr["ADRES"].ToString();
                txtGorev.Text = dr["GOREV"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
             txtAd.Text = "";
                txtGorev.Text = "";
                txtSoyad.Text = "";
                txtMail.Text = "";
                mskTc.Text = "";
                mskTel.Text = "";
              
        }
    }
}
