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
    public partial class Updateqw : Form
    {

        SqlConnection SqlConnection;

        public Updateqw()
        {
            InitializeComponent();
        }

        private async void Redak_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))

            {
                SqlCommand command = new SqlCommand("UPDATE [Корзина] SET [Название]=@name, [Количество]=@col, [Номер_заказа]=@nom WHERE [id]=@id", SqlConnection);

                command.Parameters.AddWithValue("id", textBox1.Text);
                command.Parameters.AddWithValue("name", textBox2.Text);
                command.Parameters.AddWithValue("col", textBox3.Text);
                command.Parameters.AddWithValue("nom", textBox4.Text);

                await command.ExecuteNonQueryAsync();
            }
        }

        private async void Updateqw_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=Ekzamen;Integrated Security=True";

            SqlConnection = new SqlConnection(connectionString);
            await SqlConnection.OpenAsync();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
