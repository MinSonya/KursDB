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

namespace KursDB.DeliveryContract
{
    public partial class EditDeliveryContract : Form
    {
        public Int32 pid;
        public String data;
        public EditDeliveryContract(Int32 id, String name, String gen, String price, String count, String date)
        {
            InitializeComponent();
            LoadData();
            pid = id;
            productDelCon.Text = name;
            generatorDelCon.Text = gen;
            priceDelCon.Text = price;
            countDelCon.Text = count;
            dateDelCon.Text = date;
            data = date;
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
                productDelCon.Items.Add(reader[0].ToString());
            }

            reader.Close();

            bd.closeConnection();

        }
        private void addNewCosm_Click(object sender, EventArgs e)
        {
            String product = productDelCon.Text;
            String generator = generatorDelCon.Text;
            Int32 count = Int32.Parse(countDelCon.Text);
            Decimal price = Decimal.Parse(priceDelCon.Text);
            String date = dateDelCon.Text;

            BD bd = new BD();

            bd.openConnection();
            MySqlCommand command;

            if (date.Equals(data))
            {
                command = new MySqlCommand("UPDATE delivery_contract SET del_con_product = @name, del_con_generator = @gener, del_con_price = @price, del_con_count = @count WHERE del_con_id = @pId", bd.getConnection());
                command.Parameters.Add("@product", MySqlDbType.VarChar).Value = product;
                command.Parameters.Add("@gener", MySqlDbType.VarChar).Value = generator;
                command.Parameters.Add("@count", MySqlDbType.Int32).Value = count;
                command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
                command.Parameters.Add("@pId", MySqlDbType.Int32).Value = pid;
            } else
            {
                command = new MySqlCommand("UPDATE delivery_contract SET del_con_product = @name, del_con_generator = @gener, del_con_price = @price, del_con_count = @count, del_con_date = @date WHERE del_con_id = @pId", bd.getConnection());
                command.Parameters.Add("@product", MySqlDbType.VarChar).Value = product;
                command.Parameters.Add("@gener", MySqlDbType.VarChar).Value = generator;
                command.Parameters.Add("@count", MySqlDbType.Int32).Value = count;
                command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
                command.Parameters.Add("@date", MySqlDbType.Date).Value = date;
                command.Parameters.Add("@pId", MySqlDbType.Int32).Value = pid;
            }

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Обновлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productDelCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = productDelCon.Text;

            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT cosm_generator FROM cosmetics WHERE cosm_name = @name";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                generatorDelCon.Text = reader[0].ToString();

            reader.Close();

            query = "SELECT cosm_price FROM cosmetics WHERE cosm_name = @name";

            command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

            reader = command.ExecuteReader();

            if (reader.Read())
                priceDelCon.Text = reader[0].ToString();

            reader.Close();

            bd.closeConnection();
        }
    }
}
