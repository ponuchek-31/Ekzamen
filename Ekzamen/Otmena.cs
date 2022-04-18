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

    public partial class Otmena : Form
    {
        SqlConnection SqlConnection;

        public Otmena()
        {
            InitializeComponent();
        }
        private async void Otmena_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=Ekzamen;Integrated Security=True";

            SqlConnection = new SqlConnection(connectionString);
            
            await SqlConnection.OpenAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Заказы] WHERE [id]=@id", SqlConnection);

            command.Parameters.AddWithValue("id", textBox1.Text);

            await command.ExecuteNonQueryAsync();
        }

       
    }
}
