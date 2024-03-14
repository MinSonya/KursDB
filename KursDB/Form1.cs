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
    public partial class Form1 : Form
    {
        public Int32 ac;
        public Form1(Int32 access)
        {
            InitializeComponent();
            ac = access;
        }

        private void cosmetica_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Cosm(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonDealer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Dealer(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Orders(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void provider_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Generator(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Clients(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Stock(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonContractDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new DelContract(ac);
            FormGame.Owner = this;
            FormGame.Show();

        }

        private void buttonBillDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new DeliveryBill(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonContractSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new SalesContract(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonBillSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new SalesBill(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}