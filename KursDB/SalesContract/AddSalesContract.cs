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
    public partial class AddSalesContract : Form
    {
        public Int32 ac;
        public AddSalesContract(Int32 access)
        {
            InitializeComponent();
            LoadData();
            ac = access;
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

            MySqlCommand command = new MySqlCommand("INSERT INTO sales_contract values (0, @order, @client, @date)", bd.getConnection());
            command.Parameters.Add("@order", MySqlDbType.Int32).Value = order;
            command.Parameters.Add("@client", MySqlDbType.VarChar).Value = client;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Добавлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new SalesContract(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void orderSalesContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 order = Int32.Parse(orderSalesContract.Text);

            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT order_product FROM orders WHERE order_id = @order";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@order", MySqlDbType.Int32).Value = order;

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                itemsSalesContract.Text = reader[0].ToString();

            reader.Close();

            bd.closeConnection();
        }
    }
}
