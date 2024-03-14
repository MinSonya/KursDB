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
    public partial class AddOrder : Form
    {
        public Int32 ac;
        public AddOrder(Int32 access)
        {
            InitializeComponent();
            LoadData();
            ac = access;
        }

        private void LoadData()
        {
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT cosm_name FROM cosmetics";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridView1.Columns[0];

            while (reader.Read())
            {

                theColumn.Items.Add(reader[0].ToString());
            }

            reader.Close();

            bd.closeConnection();

        }
        private void addNewCosm_Click(object sender, EventArgs e)
        {
            Int32 num = 0;
            BD bd = new BD();

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT sales_con_id FROM sales_contract", bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                num = Int32.Parse(reader[0].ToString());
            }

            num++;

            reader.Close();

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {

                String product = dataGridView1.Rows[i].Cells[0].Value.ToString();
                Int32 count = Int32.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                Decimal price = Decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                command = new MySqlCommand("INSERT INTO orders values (0, @num, @product, @count, @price)", bd.getConnection());
                command.Parameters.Add("@num", MySqlDbType.Int32).Value = num;
                command.Parameters.Add("@product", MySqlDbType.VarChar).Value = product;
                command.Parameters.Add("@count", MySqlDbType.Int32).Value = count;
                command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;

                command.ExecuteNonQuery();
            }

            bd.closeConnection();

            MessageBox.Show("Добавлено!");
        }

        private void backAddCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Orders(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0];

                if (cb.Value != null)
                {
                    String name = cb.Value.ToString();

                    BD bd = new BD();

                    bd.openConnection();

                    string query = "SELECT cosm_price FROM cosmetics WHERE cosm_name = @name";

                    MySqlCommand command = new MySqlCommand(query, bd.getConnection());
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = reader[0].ToString();

                    reader.Close();

                    bd.closeConnection();
                    dataGridView1.Invalidate();
                }
            }
        }
    }
}
