using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Ekzamen
{
    public partial class Katalog : Form
    {
        int n = 0;
        int[] answer;

        SqlConnection SqlConnection;

        public Katalog()
        {
            InitializeComponent();
            answer = new int[11];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ekzamenDataSet1.Каталог". При необходимости она может быть перемещена или удалена.
            this.каталогTableAdapter.Fill(this.ekzamenDataSet1.Каталог);

            var bmp = new Bitmap(Ekzamen.Properties.Resources.Снимо2);
            pictureBox1.BackgroundImage = bmp;



        }

        private void книжкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книжкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ekzamenDataSet);

        }

        public void show(int n)
        {
            int n1 = n + 1;
            label1.Text = "Вопрос №" + n1;
            switch (n)
            {
                case 0:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Снимо2);
                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Снимок32);
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Снимокуцк);
                    break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Снимок213);
                    break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Снимууу3ок);
                    break;
                case 5:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Сним234ок);
                    break;
                case 6:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Странстк);
                    break;
                case 7:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Снимвыапок);
                    break;
                case 8:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.СнимССССССок);
                    break;
                case 9:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Снимцу234ок);
                    break;
                case 10:
                    pictureBox1.BackgroundImage = new Bitmap(Ekzamen.Properties.Resources.Тестоск);
                    break;
            }
        }


        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 10) n = 10;
            show(n);
        }

        private void книжкиBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Korzina korzina = new Korzina();
            korzina.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dobavlenie dobav = new Dobavlenie();
            dobav.Show();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) n = 0;
            show(n);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int counts;
        int cost;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counts++;
            label2.Text = counts.ToString();
            cost = cost + 300;
            label3.Text = cost.ToString();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}


