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
    public partial class AddCosm : Form
    {
        public Int32 ac;
        public AddCosm(Int32 access)
        {
            InitializeComponent();
            ac = access;
        }

        private void addNewCosm_Click(object sender, EventArgs e)
        {
            String name = nameCosm.Text;
            String generator = generatorCosm.Text;
            String describe = descCosm.Text;
            Decimal price = Decimal.Parse(priceCosm.Text);

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO cosmetics values (0, @name, @gener, @desc, @price)", bd.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@gener", MySqlDbType.VarChar).Value = generator;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = describe;
            command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;

            command.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("Добавлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Cosm(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }
    }
}
