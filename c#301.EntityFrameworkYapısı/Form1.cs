using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_301.EntityFrameworkYapısı
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
		EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities(); // db ie nesne türetip db ismi sayesinde ulaşıbelceğiz. 
		private void btnList_Click(object sender, EventArgs e)
		{
			
			var values=db.Guide.ToList();// Guide tablosundaki verileri listeler
			dataGridView1.DataSource = values;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Guide guide = new Guide(); // ekleme işlemini buna yapağımız için burdan nesne türettik.
			guide.GuideName =txtName.Text;
			guide.GuideSurname =txtSurname.Text;
			db.Guide.Add(guide);
			db.SaveChanges();// değişikleri veritabanıa kaydeder.
			MessageBox.Show("Rehber Başarıyla Eklendi."); // mesaj işkemi için.
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var updateValue = db.Guide.Find(id);
			updateValue.GuideName = txtName.Text;
			updateValue.GuideSurname=txtSurname.Text;
			db.SaveChanges();
			MessageBox.Show("Rehber Başarılı bir şekilde güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// silme işlemleri id ' ye göre yapılır. 
			int id = int.Parse(txtId.Text); // DÖNÜŞÜM YAPTIK.
			var removeValue = db.Guide.Find(id);
			db.Guide.Remove(removeValue);
			db.SaveChanges();
			MessageBox.Show("Silinme İşlemi Başarılı");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var values = db.Guide.Where(x=>x.GuideId == id).ToList();
			dataGridView1.DataSource= values;
		}
	}
}
