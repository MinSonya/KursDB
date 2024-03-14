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
    public partial class EditCosm : Form
    {
        public Int32 pid;
        public EditCosm(Int32 id, String name, String gen, String desc, String price)
        {
            InitializeComponent();
            nameCosm.Text = name;
            generatorCosm.Text = gen;
            descCosm.Text = desc;
            priceCosm.Text = price;
            pid = id;
        }

        private void addNewCosm_Click(object sender, EventArgs e)
        {
            String name = nameCosm.Text;
            String generator = generatorCosm.Text;
            String describe = descCosm.Text;
            Decimal price = Decimal.Parse(priceCosm.Text);

            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE cosmetics SET cosm_name = @name, cosm_generator = @gener, cosm_describe = @desc, cosm_price = @price WHERE cosm_id = @pId", bd.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@gener", MySqlDbType.VarChar).Value = generator;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = describe;
            command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
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
