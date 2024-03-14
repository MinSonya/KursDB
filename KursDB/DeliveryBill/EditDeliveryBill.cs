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
    public partial class EditDeliveryBill : Form
    {
        public Int32 pid;
        public String data;
        public EditDeliveryBill(Int32 id, String bank, String contract, String date, String sum, bool del, bool pay)
        {
            InitializeComponent();
            pid = id;
            bankDelBill.Text = bank;
            contractDelBill.Text = contract;
            dateDelBill.Text = date;
            sumDelBill.Text = sum;
            delDelBill.Checked = del;
            paymentDelBill.Checked = pay;
            data = date;
        }

        private void addNewCosm_Click_1(object sender, EventArgs e)
        {
            String date = dateDelBill.Text;
            Int32 del = 0;
            Int32 pay = 0;
            if (delDelBill.Checked) del = 1;
            if (paymentDelBill.Checked) pay = 1;

            BD bd = new BD();

            bd.openConnection();
            MySqlCommand command;

            if (date.Equals(data))
            {
                command = new MySqlCommand("UPDATE delivery_bill SET del_bill_check_del = @del, del_bill_check_payment = @pay WHERE del_bill_id = @pId", bd.getConnection());
                command.Parameters.Add("@del", MySqlDbType.Int32).Value = del;
                command.Parameters.Add("@pay", MySqlDbType.Int32).Value = pay;
                command.Parameters.Add("@pId", MySqlDbType.Int32).Value = pid;
            } else
            {
                command = new MySqlCommand("UPDATE delivery_bill SET del_bill_date = @date, del_bill_check_del = @del, del_bill_check_payment = @pay WHERE del_bill_id = @pId", bd.getConnection());
                command.Parameters.Add("@date", MySqlDbType.Date).Value = date;
                command.Parameters.Add("@del", MySqlDbType.Int32).Value = del;
                command.Parameters.Add("@pay", MySqlDbType.Int32).Value = pay;
                command.Parameters.Add("@pId", MySqlDbType.Int32).Value = pid;
            }

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
