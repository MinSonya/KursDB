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
using Word = Microsoft.Office.Interop.Word;

namespace KursDB
{
    public partial class Dealer : Form
    {
        public Int32 ac;
        public Dealer(Int32 access)
        {
            InitializeComponent();
            LoadData();
            ac = access;
        }

        private void LoadData()
        {
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT * FROM dealer";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                addressDealer.Text = reader[1].ToString();
                directorDealer.Text = reader[2].ToString();
                accounterDealer.Text = reader[3].ToString();
                phoneDealer.Text = reader[4].ToString();
                bank_accountDealer.Text = reader[5].ToString();
            }

            reader.Close();

            bd.closeConnection();
        }

        private void backCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Form1(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ac == 1)
            {
                String address = addressDealer.Text;
                String director = directorDealer.Text;
                String accounter = accounterDealer.Text;
                String phone = phoneDealer.Text;
                String bank = bank_accountDealer.Text;
                Int32 id = 1;

                var FormGame = new EditDealer(id, address, director, accounter, phone, bank);
                FormGame.Owner = this;
                FormGame.Show();
            }
            else MessageBox.Show("Недостаточно прав");
        }
    }
}
