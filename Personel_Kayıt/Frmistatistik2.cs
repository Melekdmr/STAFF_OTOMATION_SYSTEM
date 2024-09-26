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
	public partial class Frmistatistik2 : Form
	{
		public Frmistatistik2()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=Melekdmr\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

		private void Frmistatistik2_Load(object sender, EventArgs e)
		{
			//toplam personel sayısı
			baglanti.Open();
			SqlCommand komut1 = new SqlCommand("select count (*)From Tbl_Personel", baglanti);
			//SqlDataReader dr1: Bu nesne, veritabanından gelen veriyi satır satır okur.
			//Sadece okuma işlemi yapar, yazma veya güncelleme işlemi gerçekleştiremez.
			//Veritabanından dönen her satırı Read() metodu ile ilerleterek işleyebiliriz.
			SqlDataReader dr1 = komut1.ExecuteReader(); //Executereader select için sorguyu çalıştırır.
			while (dr1.Read())  //dr1 komutu okuma işlemi yaptığı müddetçe
			{
				lblToplamPer.Text = dr1[0].ToString();
			}


			baglanti.Close();

			//Evli personel sayısı
			baglanti.Open();
			SqlCommand komut2 = new SqlCommand("select count (*) from Tbl_Personel where PerDurum=1", baglanti);
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				lblevliper2.Text = dr2[0].ToString();
			}
			
			baglanti.Close();

			//bekar personel sayısı
			baglanti.Open();
			SqlCommand komut3 = new SqlCommand("select count (*) from Tbl_Personel where PerDurum=0", baglanti);
			SqlDataReader dr3 = komut3.ExecuteReader();//sorgu sonucunda birden fazla satır dönecekse kullanılır.
													   //Bu, sonucu belleğe yüklemeden, satır satır okuma yapmamıza olanak tanır.
			while (dr3.Read())
			{
				lblbekarper.Text = dr3[0].ToString();
			}

			baglanti.Close();

			//şehir sayısı
			baglanti.Open();
			SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_Personel", baglanti);
			SqlDataReader dr4 = komut4.ExecuteReader();
			while (dr4.Read())
			{
				Lblsehirsayısı.Text = dr4[0].ToString();
			}

			baglanti.Close();

			//toplam maas
			baglanti.Open();
			SqlCommand komut5 = new SqlCommand("select sum(PerMaas) from Tbl_Personel", baglanti);
			SqlDataReader dr5 = komut5.ExecuteReader();
			while (dr5.Read())
			{
				LblTopMaas.Text = dr5[0].ToString();
			}

			baglanti.Close();

			//ortalama maas
			baglanti.Open();
			SqlCommand komut6 = new SqlCommand("select avg(PerMaas) from Tbl_Personel", baglanti);
			SqlDataReader dr6 = komut6.ExecuteReader();
			while (dr6.Read())
			{
				lblortamamaas.Text = dr6[0].ToString();
			}
			baglanti.Close();
		}
	}
}
