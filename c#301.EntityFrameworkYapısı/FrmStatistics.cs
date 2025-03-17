using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_301.EntityFrameworkYapısı
{
	public partial class FrmStatistics : Form
	{
		public FrmStatistics()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

		private void FrmStatistics_Load(object sender, EventArgs e)
		{
			// Toplam lokasyon sayısı 

			lblCount.Text = db.Location.Count().ToString();

			// toplam kapasite 

			lblkapasite.Text =db.Location.Sum(x=>x.Capacity).ToString();

			// Rehber Sayısı 

			lblrehbersayisi.Text = db.Guide.Count().ToString();	


			// Ortalama Kapasite

			txtortKapasite.Text = ((int)db.Location.Average(x=>x.Capacity)).ToString();

			// Ortalama tur fiyatı 

			ortturfiyat.Text = db.Location.Average(x => x.Price).GetValueOrDefault().ToString("F2");

			// eklenen son ülke 
			int soneklenensehirid = db.Location.Max(x => x.LocationId);
			sonulke.Text = db.Location.Where(x => x.LocationId == soneklenensehirid).Select(y => y.Country).FirstOrDefault();

			// roma turu kapasite 

			romakapasite.Text = db.Location.Where(x=>x.City=="Roma").Select(y=>y.Capacity).FirstOrDefault().ToString();

			// ülke bazında ortalama kapasiteler türkiye için : 
			turkiyeort.Text = db.Location.Where(x => x.Country == "türkiye").Average(y => y.Capacity).GetValueOrDefault().ToString("F2");

			// roma rehberin ismi :

			var romarehberId = db.Location.Where(x => x.City == "Roma").Select(y=>y.GuideId).FirstOrDefault();
			romarehber.Text = db.Guide.Where(x => x.GuideId == romarehberId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

			// MAKS KAPASİTE 

			var mc = db.Location.Max(x => x.Capacity);
			makskapasite.Text = db.Location.Where(x=>x.Capacity==mc).Select(y=>y.City + "/ " + y.Country).FirstOrDefault().ToString();

			// en pahalı tur 

			var ep = db.Location.Max(x=>x.Price);
			enpahalıtur.Text= db.Location.Where(x=>x.Price==ep).Select(y=>y.City).FirstOrDefault().ToString();

			//berk karabaş tur sayısı 

			var bk = db.Guide.Where(x => x.GuideName == "Berk" && x.GuideSurname == "Karabaş").Select(y => y.GuideId).FirstOrDefault();
			berkkarabas.Text = db.Location.Where(x=> x.GuideId==bk).Count().ToString();
		}
	}
}
