using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_DataGridView_Kullanımı
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btn_ekle_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text);
			textBox1.Text = string.Empty;
			textBox2.Text = string.Empty;	
			textBox3.Text = string.Empty;
		}

		private void btn_sil_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
		}

		private void btn_guncelle_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
			dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);

		}
	}
}
