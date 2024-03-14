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
    public partial class AddDeliveryContract : Form
    {
        public Int32 ac;
        public AddDeliveryContract(Int32 access)
        {
            InitializeComponent();
            LoadData();
            ac = access;
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

            MySqlCommand command = new MySqlCommand("INSERT INTO delivery_contract values (0, @product, @gener, @price, @count, @date)", bd.getConnection());
            command.Parameters.Add("@product", MySqlDbType.VarChar).Value = product;
            command.Parameters.Add("@gener", MySqlDbType.VarChar).Value = generator;
            command.Parameters.Add("@count", MySqlDbType.Int32).Value = count;
            command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Добавлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new DelContract(ac);
            FormGame.Owner = this;
            FormGame.Show();
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
