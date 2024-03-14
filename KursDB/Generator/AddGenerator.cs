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
    public partial class AddGenerator : Form
    {
        public Int32 ac;
        public AddGenerator(Int32 access)
        {
            InitializeComponent();
            ac = access;
        }

        private void addNewCosm_Click(object sender, EventArgs e)
        {
            String address = addressGen.Text;
            String director = directorGen.Text;
            String accounter = accounterGen.Text;
            String phone = phoneGen.Text;
            Int32 bank = Int32.Parse(bank_accountGen.Text);

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO provider values (0, @address, @director, @accounter, @phone, @bank)", bd.getConnection());
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@director", MySqlDbType.VarChar).Value = director;
            command.Parameters.Add("@accounter", MySqlDbType.VarChar).Value = accounter;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@bank", MySqlDbType.Int32).Value = bank;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Добавлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Generator(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }
    }
}
