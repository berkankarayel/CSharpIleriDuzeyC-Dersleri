﻿using System;
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
	public partial class FrmLocation : Form
	{
		public FrmLocation()
		{
			InitializeComponent();
		}

		EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
		private object cmbGuide;

		private void btnList_Click(object sender, EventArgs e)
		{
			var values = db.Location.ToList();
			dataGridView1.DataSource = values;

		}

		private void FrmLocation_Load(object sender, EventArgs e)
		{
			var values  = db.Guide.Select(x =>new
			{
				FullName = x.GuideName + " " + x.GuideSurname,
				x.GuideId
				}).ToList();
			txtGuide.DisplayMember = "FullName";
			txtGuide.ValueMember = "GuideId";
			txtGuide.DataSource = values;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Location location = new Location();
			location.Capacity = (byte)nudCapacity.Value;
			location.City = txtCity.Text;
			location.Country = txtCountry.Text;
			location.Price = decimal.Parse(txtPrice.Text);
			location.DayNight = txtDayNight.Text;
			location.GuideId = int.Parse(txtGuide.SelectedValue.ToString());

			db.Location.Add(location);
			db.SaveChanges();
			MessageBox.Show("Ekleme İşlemi Başarılı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var deletedValue = db.Location.Find(id);
			db.Location.Remove(deletedValue);
			db.SaveChanges();
			MessageBox.Show("Silme İşlemi Başarılı");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var updatedValue = db.Location.Find(id);
			updatedValue.DayNight = txtDayNight.Text;
			updatedValue.Price = decimal.Parse(txtPrice.Text);
			updatedValue.Capacity = (byte)nudCapacity.Value;
			updatedValue.City = txtCity.Text;
			updatedValue.Country = txtCountry.Text;
			updatedValue.GuideId = int.Parse(txtGuide.SelectedValue.ToString());
			db.SaveChanges();
			MessageBox.Show("Güncelleme İşlemi Başarılı");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var values = db.Location.Where(x=>x.LocationId == id).ToList();
			dataGridView1.DataSource = values;
		}
	}
}
