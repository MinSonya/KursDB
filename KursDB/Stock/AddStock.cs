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
    public partial class AddStock : Form
    {
        public Int32 ac;
        public AddStock(Int32 access)
        {
            InitializeComponent();
            ac = access;
        }

        private void addNewCosm_Click(object sender, EventArgs e)
        {
            String name = nameStock.Text;
            Int32 count = Int32.Parse(countStock.Text);

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO stock values (0, @name, @count)", bd.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@count", MySqlDbType.Int32).Value = count;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Добавлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Stock(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }
    }
}
