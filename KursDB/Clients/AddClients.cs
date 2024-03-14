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
    public partial class AddClients : Form
    {
        public Int32 ac;
        public AddClients(Int32 access)
        {
            InitializeComponent();
            ac = access;
        }

        private void addNewCosm_Click(object sender, EventArgs e)
        {
            String address = addressClient.Text;
            String phone = phoneClients.Text;
            String name = nameClients.Text;
            Int32 bank = Int32.Parse(bankClients.Text);

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO client values (0, @address, @phone, @name, @bank)", bd.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@bank", MySqlDbType.Int32).Value = bank;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Добавлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Clients(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }
    }
}
