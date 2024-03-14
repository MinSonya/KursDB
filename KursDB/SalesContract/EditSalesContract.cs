using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursDB
{
    public partial class EditSalesContract : Form
    {
        public int pid;
        public EditSalesContract(Int32 id, String order, String client, String date)
        {
            InitializeComponent();
            LoadData();
            pid = id;
            orderSalesContract.Text = order;
            clientSalesContract.Text = client;
            dateSalesContract.Text = date;
        }

        private void LoadData()
        {
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT cl_name FROM client";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                clientSalesContract.Items.Add(reader[0].ToString());
            }

            reader.Close();

            query = "SELECT order_id FROM orders WHERE order_id not in (SELECT sales_con_order FROM sales_contract) ";

            command = new MySqlCommand(query, bd.getConnection());

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                orderSalesContract.Items.Add(reader[0].ToString());
            }

            reader.Close();

            bd.closeConnection();

        }


        private void addNewCosm_Click(object sender, EventArgs e)
        {

            Int32 order = Int32.Parse(orderSalesContract.Text);
            String client = clientSalesContract.Text;
            String date = dateSalesContract.Text;

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE sales_contract SET sales_con_order = @order, sales_con_client = @client, sales_con_date = @date WHERE sales_con_id = @pId", bd.getConnection());
            command.Parameters.Add("@order", MySqlDbType.Int32).Value = order;
            command.Parameters.Add("@client", MySqlDbType.VarChar).Value = client;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = pid;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Добавлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
