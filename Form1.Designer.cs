﻿namespace Windows_Form_DataGridView_Kullanımı
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_id = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lbl_isim = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lbl_soyisim = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btn_ekle = new System.Windows.Forms.Button();
			this.btn_sil = new System.Windows.Forms.Button();
			this.btn_guncelle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.İsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.btn_guncelle);
			this.groupBox1.Controls.Add(this.btn_sil);
			this.groupBox1.Controls.Add(this.btn_ekle);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.lbl_soyisim);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.lbl_isim);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.lbl_id);
			this.groupBox1.Location = new System.Drawing.Point(34, 78);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1776, 830);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// lbl_id
			// 
			this.lbl_id.AutoSize = true;
			this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_id.Location = new System.Drawing.Point(82, 67);
			this.lbl_id.Name = "lbl_id";
			this.lbl_id.Size = new System.Drawing.Size(70, 52);
			this.lbl_id.TabIndex = 0;
			this.lbl_id.Text = "id:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(199, 67);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 56);
			this.textBox1.TabIndex = 0;
			// 
			// lbl_isim
			// 
			this.lbl_isim.AutoSize = true;
			this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_isim.Location = new System.Drawing.Point(37, 158);
			this.lbl_isim.Name = "lbl_isim";
			this.lbl_isim.Size = new System.Drawing.Size(118, 52);
			this.lbl_isim.TabIndex = 0;
			this.lbl_isim.Text = "İsim:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(199, 158);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(260, 56);
			this.textBox2.TabIndex = 1;
			// 
			// lbl_soyisim
			// 
			this.lbl_soyisim.AutoSize = true;
			this.lbl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_soyisim.Location = new System.Drawing.Point(-9, 247);
			this.lbl_soyisim.Name = "lbl_soyisim";
			this.lbl_soyisim.Size = new System.Drawing.Size(193, 52);
			this.lbl_soyisim.TabIndex = 0;
			this.lbl_soyisim.Text = "Soyisim:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(199, 247);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(260, 56);
			this.textBox3.TabIndex = 2;
			// 
			// btn_ekle
			// 
			this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.btn_ekle.Location = new System.Drawing.Point(26, 355);
			this.btn_ekle.Name = "btn_ekle";
			this.btn_ekle.Size = new System.Drawing.Size(433, 68);
			this.btn_ekle.TabIndex = 2;
			this.btn_ekle.Text = "EKLE";
			this.btn_ekle.UseVisualStyleBackColor = true;
			this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
			// 
			// btn_sil
			// 
			this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.btn_sil.Location = new System.Drawing.Point(26, 459);
			this.btn_sil.Name = "btn_sil";
			this.btn_sil.Size = new System.Drawing.Size(433, 68);
			this.btn_sil.TabIndex = 2;
			this.btn_sil.Text = "SİL";
			this.btn_sil.UseVisualStyleBackColor = true;
			this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
			// 
			// btn_guncelle
			// 
			this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.btn_guncelle.Location = new System.Drawing.Point(26, 549);
			this.btn_guncelle.Name = "btn_guncelle";
			this.btn_guncelle.Size = new System.Drawing.Size(433, 68);
			this.btn_guncelle.TabIndex = 2;
			this.btn_guncelle.Text = "GÜNCELLE";
			this.btn_guncelle.UseVisualStyleBackColor = true;
			this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.İsim,
            this.soyisim});
			this.dataGridView1.Location = new System.Drawing.Point(545, 48);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 92;
			this.dataGridView1.RowTemplate.Height = 37;
			this.dataGridView1.Size = new System.Drawing.Size(424, 546);
			this.dataGridView1.TabIndex = 3;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 11;
			this.id.Name = "id";
			this.id.Width = 80;
			// 
			// İsim
			// 
			this.İsim.HeaderText = "İsim";
			this.İsim.MinimumWidth = 11;
			this.İsim.Name = "İsim";
			this.İsim.Width = 120;
			// 
			// soyisim
			// 
			this.soyisim.HeaderText = "Soyisim";
			this.soyisim.MinimumWidth = 11;
			this.soyisim.Name = "soyisim";
			this.soyisim.Width = 120;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1958, 1158);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label lbl_soyisim;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lbl_isim;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lbl_id;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_guncelle;
		private System.Windows.Forms.Button btn_sil;
		private System.Windows.Forms.Button btn_ekle;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn İsim;
		private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
	}
}

