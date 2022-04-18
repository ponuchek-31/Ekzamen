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
    public partial class Dobavlenie : Form
    {
        SqlConnection SqlConnection;
        public Dobavlenie()
        {
            InitializeComponent();
        }
        //Подключение к БД
        private async void Dobavlenie_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=Ekzamen;Integrated Security=True";

            SqlConnection = new SqlConnection(connectionString);
            await SqlConnection.OpenAsync();

        }

        //Изменение данных
        private async void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
             (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text)) &&
             (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text)))

                {

                SqlCommand command = new SqlCommand("INSERT INTO [Корзина] (Название, Количество, Номер_заказа) VALUES (@Название, @Количество, @Номер_заказа)", SqlConnection);

                command.Parameters.AddWithValue("Название", textBox1.Text);
                command.Parameters.AddWithValue("Количество", textBox2.Text);
                command.Parameters.AddWithValue("Номер_заказа", textBox3.Text);

                await command.ExecuteNonQueryAsync();
            }

        }

        
    }
}
