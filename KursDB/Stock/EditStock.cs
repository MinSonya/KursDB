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
    public partial class EditStock : Form
    {
        public int pid;
        public EditStock(Int32 id, String name, String count)
        {
            InitializeComponent();
            pid = id;
            nameStock.Text = name;
            countStock.Text = count;
        }

        private void addNewCosm_Click(object sender, EventArgs e)
        {
            String name = nameStock.Text;
            Int32 count = Int32.Parse(countStock.Text);

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE stock SET st_poduct = @name, st_count = @count WHERE st_id = @pId", bd.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@count", MySqlDbType.Int32).Value = count;
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
