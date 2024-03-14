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
    public partial class EditClients : Form
    {
        public Int32 pid;
        public EditClients(Int32 id, String address, String phone, String name, String bank)
        {
            InitializeComponent();
            pid = id;
            addressClient.Text = address;
            phoneClients.Text = phone;
            nameClients.Text = name;
            bankClients.Text = bank;
        }

        private void addNewCosm_Click(object sender, EventArgs e)
        {
            String address = addressClient.Text;
            String phone = phoneClients.Text;
            String name = nameClients.Text;
            Int32 bank = Int32.Parse(bankClients.Text);

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE client SET cl_name = @name, cl_address = @address, cl_phone = @phone, cl_bank_account = @bank WHERE cl_id = @pId", bd.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@bank", MySqlDbType.Int32).Value = bank;
            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = pid;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Обновлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
