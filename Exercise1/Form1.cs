using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            //Warna Font pada kolom
            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Red;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.DarkViolet;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.OrangeRed;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.IndianRed;
            this.dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.Coral;

            //Warna Kursor
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Beige;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.BlueViolet;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Bisque;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.OldLace;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            this.dataGridView1.Columns[5].DefaultCellStyle.SelectionBackColor = Color.LightPink;

            //Membuat data menjadi center 
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
