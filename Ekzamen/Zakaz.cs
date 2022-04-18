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
    public partial class Zakaz : Form
    {
        SqlConnection SqlConnection;
        public Zakaz()
        {
            InitializeComponent();
        }

        private async void Zakaz_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=Ekzamen;Integrated Security=True";

            SqlConnection = new SqlConnection(connectionString);
            await SqlConnection.OpenAsync();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "ekzamenDataSet5.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.ekzamenDataSet5.Заказы);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
            (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text)) &&
            (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text)))

            {

                SqlCommand command = new SqlCommand("INSERT INTO [Заказы] (Номер_заказа, Адрес, Имя, Дата) VALUES (@Номер_заказа, @Адрес, @Имя, @Дата)", SqlConnection);

                command.Parameters.AddWithValue("Номер_заказа", textBox1.Text);
                command.Parameters.AddWithValue("Адрес", textBox2.Text);
                command.Parameters.AddWithValue("Имя", textBox3.Text);
                command.Parameters.AddWithValue("Дата", dateTimePicker1.Value);

                await command.ExecuteNonQueryAsync();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otmena otm = new Otmena();
            otm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Korzina kor = new Korzina();
            kor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Katalog kat = new Katalog();
            kat.Show();
        }
    }
}
