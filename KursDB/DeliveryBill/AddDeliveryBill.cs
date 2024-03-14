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
    public partial class AddDeliveryBill : Form
    {
        public Int32 ac;
        public AddDeliveryBill(Int32 access)
        {
            InitializeComponent();
            LoadData();
            ac = access;
        }

        private void LoadData()
        {
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT del_con_id FROM delivery_contract WHERE del_con_id not in (SELECT del_bill_num_contract FROM delivery_bill) ";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                contractDelBill.Items.Add(reader[0].ToString());
            }

            reader.Close();

            bd.closeConnection();

        }

        private void addNewCosm_Click(object sender, EventArgs e)
        {
            Int32 bank = Int32.Parse(bankDelBill.Text);
            Int32 contract = Int32.Parse(contractDelBill.Text);
            Decimal sum = Decimal.Parse(sumDelBill.Text);
            String date = dateDelBill.Text;
            Int32 del = 0;
            Int32 pay = 0;
            if (delDelBill.Checked) del = 1;
            if (paymentDelBill.Checked) pay = 1;

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO delivery_bill values (0, @bank, @contract, @date, @sum, @del, @pay)", bd.getConnection());
            command.Parameters.Add("@bank", MySqlDbType.Int32).Value = bank;
            command.Parameters.Add("@contract", MySqlDbType.Int32).Value = contract;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@sum", MySqlDbType.Decimal).Value = sum;
            command.Parameters.Add("@del", MySqlDbType.Int32).Value = del;
            command.Parameters.Add("@pay", MySqlDbType.Int32).Value = pay;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Добавлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new DeliveryBill(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }


        private void contractDelBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 id = Int32.Parse(contractDelBill.Text);
            Decimal price = 0;
            Decimal count = 0;
            String gener = "day";

            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT del_con_price FROM delivery_contract WHERE del_con_id = @id";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                price = Decimal.Parse(reader[0].ToString());

            reader.Close();

            query = "SELECT del_con_count FROM delivery_contract WHERE del_con_id = @id";

            command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            reader = command.ExecuteReader();

            if (reader.Read())
                count = Decimal.Parse(reader[0].ToString());

            reader.Close();

            query = "SELECT del_con_generator FROM delivery_contract WHERE del_con_id = @id";

            command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            reader = command.ExecuteReader();

            if (reader.Read())
                gener = reader[0].ToString();

            reader.Close();

           query = "SELECT pr_bank_account FROM provider WHERE pr_generator = @gener";

            command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@gener", MySqlDbType.VarChar).Value = gener;

            reader = command.ExecuteReader();

            if (reader.Read())
                bankDelBill.Text = reader[0].ToString();

            reader.Close(); 

            bd.closeConnection();

            sumDelBill.Text = (price * count).ToString();
        }
    }
}
