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


namespace Ekzamen
{
    public partial class Korzina : Form
    {
        public Korzina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        int counts;
        int cost;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counts++;
            
        }

        private void Korzina_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ekzamenDataSet4.Корзина". При необходимости она может быть перемещена или удалена.
            this.корзинаTableAdapter2.Fill(this.ekzamenDataSet4.Корзина);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ekzamenDataSet3.Корзина". При необходимости она может быть перемещена или удалена.
            this.корзинаTableAdapter1.Fill(this.ekzamenDataSet3.Корзина);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ekzamenDataSet2.Корзина". При необходимости она может быть перемещена или удалена.
            this.корзинаTableAdapter.Fill(this.ekzamenDataSet2.Корзина);

        }

        private void Delett_Click(object sender, EventArgs e)
        {
            Del D = new Del();
            D.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Katalog kat = new Katalog();
            kat.Show();

        }

        private void izmeneni_Click(object sender, EventArgs e)
        {
            Updateqw up = new Updateqw();
            up.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Zakaz zak = new Zakaz();
            zak.Show();
        }
    }
}
