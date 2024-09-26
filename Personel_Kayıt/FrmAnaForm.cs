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

namespace Personel_Kayıt
{
	public partial class FrmAnaForm : Form
	{
		public FrmAnaForm()
		{
			InitializeComponent();
		}
		//global olarak atadık.
		SqlConnection baglanti = new SqlConnection("Data Source=Melekdmr\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

		void temizle()
		{
			txtid.Text = "";
			txtAd.Text = "";
			txtSoyad.Text = "";
			txtMeslek.Text = "";
			mskMaas.Text = "";
			CmbSehir.Text = "";
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			txtAd.Focus();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtid.Focus();
		}

		private void btnListele_Click(object sender, EventArgs e)
		{

			// TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table.
			// You can move, or remove it, as needed.
			this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad , PerSehir, PerMaas ,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
			komut.Parameters.AddWithValue("@p1", txtAd.Text); //atama
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
			komut.Parameters.AddWithValue("@p4", mskMaas.Text);
			komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
			komut.Parameters.AddWithValue("@p6", label8.Text);
			komut.ExecuteNonQuery(); //Sorguyu çalıştır  insert,update ve delete de kullanılır okuma (select) işlemlerinde kullanılmaz

			baglanti.Close();
			MessageBox.Show("Personel Eklendi");

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)

		{
			if (radioButton1.Checked == true)
			{
				label8.Text = "True";
			}
		
			
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked == true)
			{
				label8.Text = "False";
			}
		}

		private void btnTemizle_Click(object sender, EventArgs e)
		{
			temizle();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;

			txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
			mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
			txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

		
		}

		private void label8_TextChanged(object sender, EventArgs e)
		{
			if (label8.Text == "True")
			{
				radioButton1.Checked = true;
			}
			if (label8.Text == "False")
			{
				radioButton2.Checked = true;
				
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{     //her bir sql cümleciğinde bağlantı açılıp kapanmak zorunda!
			baglanti.Open();
			//SqlCommand nesnesi, oluşturulduğu metodun içinde yaşar
			SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", baglanti);
			komutsil.Parameters.AddWithValue("@k1", txtid.Text);
			komutsil.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kayıt Silindi");

		}

		private void btnGüncelle_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komutguncelle = new SqlCommand("Update  Tbl_Personel Set PerAd=@1,PerSoyad=@2,PerSehir=@3,PerMaas=@4,PerDurum=@5,PerMeslek=@6 Where Perid=@7", baglanti);
			komutguncelle.Parameters.AddWithValue("@1", txtAd.Text);
			komutguncelle.Parameters.AddWithValue("@2", txtSoyad.Text);
			komutguncelle.Parameters.AddWithValue("@3", CmbSehir.Text);
			komutguncelle.Parameters.AddWithValue("@4", mskMaas.Text);
			komutguncelle.Parameters.AddWithValue("@5", label8.Text);
			komutguncelle.Parameters.AddWithValue("@6", txtMeslek.Text);
			komutguncelle.Parameters.AddWithValue("@7", txtid.Text);
			komutguncelle.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Personel Bilgi Güncellendi");
		}

		private void btnistatistik_Click(object sender, EventArgs e)
		{
			Frmistatistik2 fr = new Frmistatistik2();
			fr.Show();
		}

		private void btnGrafik_Click(object sender, EventArgs e)
		{
			FrmGrafikler frg = new FrmGrafikler();
			frg.Show();
		}
	}
}
