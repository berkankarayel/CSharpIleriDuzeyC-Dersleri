﻿namespace c_301.EntityFrameworkYapısı
{
	partial class FrmLocation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGetById = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDayNight = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.nudCapacity = new System.Windows.Forms.NumericUpDown();
			this.txtGuide = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.BackColor = System.Drawing.Color.Cyan;
			this.btnGetById.ForeColor = System.Drawing.Color.Black;
			this.btnGetById.Location = new System.Drawing.Point(146, 366);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(126, 44);
			this.btnGetById.TabIndex = 23;
			this.btnGetById.Text = "Idye Göre Getir ";
			this.btnGetById.UseVisualStyleBackColor = false;
			this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Cyan;
			this.btnAdd.ForeColor = System.Drawing.Color.Black;
			this.btnAdd.Location = new System.Drawing.Point(104, 321);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(88, 39);
			this.btnAdd.TabIndex = 22;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Cyan;
			this.btnUpdate.ForeColor = System.Drawing.Color.Black;
			this.btnUpdate.Location = new System.Drawing.Point(198, 321);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(89, 39);
			this.btnUpdate.TabIndex = 21;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Cyan;
			this.btnDelete.ForeColor = System.Drawing.Color.Black;
			this.btnDelete.Location = new System.Drawing.Point(12, 366);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(128, 44);
			this.btnDelete.TabIndex = 20;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(110, 117);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(156, 20);
			this.txtCountry.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Ülke : ";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(110, 77);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(156, 20);
			this.txtCity.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Şehir :";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(293, 44);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(483, 365);
			this.dataGridView1.TabIndex = 15;
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.Cyan;
			this.btnList.ForeColor = System.Drawing.Color.Black;
			this.btnList.Location = new System.Drawing.Point(12, 321);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(86, 39);
			this.btnList.TabIndex = 14;
			this.btnList.Text = "Listele ";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(110, 41);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(156, 20);
			this.txtId.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Lokasyon Id: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "Kapasite :";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(110, 192);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(156, 20);
			this.txtPrice.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 231);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Gün Gece :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(63, 199);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 28;
			this.label6.Text = "Fiyat :";
			// 
			// txtDayNight
			// 
			this.txtDayNight.Location = new System.Drawing.Point(110, 228);
			this.txtDayNight.Name = "txtDayNight";
			this.txtDayNight.Size = new System.Drawing.Size(156, 20);
			this.txtDayNight.TabIndex = 31;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(50, 271);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 13);
			this.label7.TabIndex = 30;
			this.label7.Text = "Rehber :";
			// 
			// nudCapacity
			// 
			this.nudCapacity.Location = new System.Drawing.Point(110, 159);
			this.nudCapacity.Name = "nudCapacity";
			this.nudCapacity.Size = new System.Drawing.Size(156, 20);
			this.nudCapacity.TabIndex = 33;
			// 
			// txtGuide
			// 
			this.txtGuide.FormattingEnabled = true;
			this.txtGuide.Location = new System.Drawing.Point(104, 263);
			this.txtGuide.Name = "txtGuide";
			this.txtGuide.Size = new System.Drawing.Size(162, 21);
			this.txtGuide.TabIndex = 34;
			// 
			// FrmLocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 650);
			this.Controls.Add(this.txtGuide);
			this.Controls.Add(this.nudCapacity);
			this.Controls.Add(this.txtDayNight);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Name = "FrmLocation";
			this.Text = "FrmLocation";
			this.Load += new System.EventHandler(this.FrmLocation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDayNight;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nudCapacity;
		private System.Windows.Forms.ComboBox txtGuide;
	}
}