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
    public partial class OrderInfo : Form
    {
        public Int32 ac;
        public OrderInfo(Int32 access, Int32 num)
        {
            InitializeComponent();
            ac = access;
            LoadData(num);
        }

        private void LoadData(Int32 id)
        {
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT o.order_product, o.order_count, o.order_price, c.cosm_generator, c.cosm_describe FROM orders AS o Join cosmetics AS c ON c.cosm_name = o.order_product WHERE o.order_num = @pId";
            
            MySqlCommand command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = id;

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            Int32 i = 1;

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = i.ToString();
                data[data.Count - 1][1] = reader[0].ToString();
                data[data.Count - 1][2] = reader[1].ToString();
                data[data.Count - 1][3] = reader[2].ToString();
                data[data.Count - 1][4] = reader[3].ToString();
                data[data.Count - 1][5] = reader[4].ToString();
                i++;
            }

            reader.Close();

            bd.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

            NumOfOrder.Text += id.ToString();
        }
        private void backCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new SalesContract(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }
    }
}
