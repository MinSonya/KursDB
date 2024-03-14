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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = log.Text;
            String pass = password.Text;

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=144957189SmKc;database=dealer_user");

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @log AND passwordd = @pass", connection);
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                var FormGame = new Form1(table.Rows[0].Field<Int32>(3));
                FormGame.Owner = this;
                FormGame.Show();
            }
            else MessageBox.Show("Неверные данные");
        }
    }
}
