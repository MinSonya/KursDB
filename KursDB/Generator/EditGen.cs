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
    public partial class EditGen : Form
    {
        public Int32 pid;
        public EditGen(Int32 id, String address, String director, String accounter, String phone, String bank)
        {
            InitializeComponent();
            addressDealer.Text = address;
            directorDealer.Text = director;
            accounterDealer.Text = accounter;
            phoneDealer.Text = phone;
            bank_accountDealer.Text = bank;
            pid = id;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            String address = addressDealer.Text;
            String director = directorDealer.Text;
            String accounter = accounterDealer.Text;
            String phone = phoneDealer.Text;
            Int32 bank = Int32.Parse(bank_accountDealer.Text);

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE provider SET pr_address = @address, pr_directoor = @director, pr_accounter = @accounter, pr_phone = @phone, pr_bank_account = @bank WHERE pr_id = @pId", bd.getConnection());
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@director", MySqlDbType.VarChar).Value = director;
            command.Parameters.Add("@accounter", MySqlDbType.VarChar).Value = accounter;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@bank", MySqlDbType.Int32).Value = bank;

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
