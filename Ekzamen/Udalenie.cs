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

    public partial class Del : Form
    {

        SqlConnection SqlConnection;

        public Del()
        {
            InitializeComponent();
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Delit.Text) && !string.IsNullOrWhiteSpace(Delit.Text))

            {
                SqlCommand command = new SqlCommand("DELETE FROM [Корзина] WHERE [id]=@id", SqlConnection);

                command.Parameters.AddWithValue("id", Delit.Text);

                await command.ExecuteNonQueryAsync();

            }
        }

        private async void Del_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=Ekzamen;Integrated Security=True";

            SqlConnection = new SqlConnection(connectionString);
            await SqlConnection.OpenAsync();

          
        }
    }
}
