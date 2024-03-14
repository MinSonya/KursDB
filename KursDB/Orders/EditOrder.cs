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
    public partial class EditOrder : Form
    {
        public Int32 pId;
        public EditOrder(Int32 id, String product, String count, String price)
        {
            InitializeComponent();
            LoadData();
            pId = id;
            productOrder.Text = product;
            countOrder.Text = count;
            priceOrder.Text = price;
        }

        private void LoadData()
        {
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT cosm_name FROM cosmetics";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                productOrder.Items.Add(reader[0].ToString());
            }

            reader.Close();

            bd.closeConnection();

        }

        private void addNewCosm_Click(object sender, EventArgs e)
        {
            String product = productOrder.Text;
            Int32 count = Int32.Parse(countOrder.Text);
            Decimal price = Decimal.Parse(priceOrder.Text);

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE orders SET order_product = @product, order_count = @count, order_price = @price WHERE order_id = @pId", bd.getConnection());
            command.Parameters.Add("@product", MySqlDbType.VarChar).Value = product;
            command.Parameters.Add("@count", MySqlDbType.Int32).Value = count;
            command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = pId;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Обновлено!");
        }

        private void productOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                String name = productOrder.Text;

                BD bd = new BD();

                bd.openConnection();

                string query = "SELECT cosm_price FROM cosmetics WHERE cosm_name = @name";

                MySqlCommand command = new MySqlCommand(query, bd.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    priceOrder.Text = reader[0].ToString();

                reader.Close();

                bd.closeConnection();
            
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
