﻿using Microsoft.Office.Interop.Word;
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
    public partial class Orders : Form
    {
        public Int32 ac;
        public Orders(Int32 access)
        {
            InitializeComponent();
            LoadData();
            ac = access;
        }

        private void LoadData()
        {
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT o.order_num, o.order_product, o.order_count, o.order_price, s.sales_con_date FROM orders AS o JOIN sales_contract AS s ON o.order_num = s.sales_con_id";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            bd.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

            Filtr.Items.Add("Последняя неделя");
            Filtr.Items.Add("Последний месяц");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new AddOrder(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            BD bd = new BD();

            Int32 id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["order_id"].Value);

            bd.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM orders WHERE order_id = @pId", bd.getConnection());
            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = id;

            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удаление записи", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                command.ExecuteNonQuery();

                bd.closeConnection();

                MessageBox.Show("Удалено");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Не удалено");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            String product = Convert.ToString(this.dataGridView1.CurrentRow.Cells["order_product"].Value);
            String count = Convert.ToString(this.dataGridView1.CurrentRow.Cells["order_count"].Value);
            String price = Convert.ToString(this.dataGridView1.CurrentRow.Cells["order_price"].Value);
            Int32 id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["order_id"].Value);

            var FormGame = new EditOrder(id, product, count, price);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);

            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT o.order_num, o.order_product, o.order_count, o.order_price, s.sales_con_date FROM orders AS o JOIN sales_contract AS s ON o.order_num = s.sales_con_id";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            bd.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                String Today = DateTime.Now.ToString("dd.MM.yyyy");
                String week = DateTime.Now.AddDays(-7).ToString("dd.MM.yyyy");
                String month = DateTime.Now.AddDays(-30).ToString("dd.MM.yyyy");

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    if (this.Filtr.SelectedIndex == 0)
                    {
                        headerRange.Text = "Заказы за период " + week + "-" + Today;
                    } else if (this.Filtr.SelectedIndex == 1)
                    {
                        headerRange.Text = "Заказы за период " + month + "-" + Today;
                    } else headerRange.Text = "Заказы";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                Decimal sum = 0;
                for(int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    int count = Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    Decimal price = Decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    sum += count * price;
                }
                oDoc.Content.InsertAfter("Общая сумма: " + sum.ToString() + " рублей");
                    //InsertAfter("Общая сумма: ");
                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }
        private void buttonReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "order.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }

        private void backCosm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormGame = new Form1(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void Filtr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Filtr.SelectedIndex == 0)
            {
                String Today = DateTime.Now.ToString("yyyy-MM-dd");
                String week = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");

                while (dataGridView1.Rows.Count > 1)
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);

                BD bd = new BD();

                bd.openConnection();

                string query = "SELECT o.order_num, o.order_product, o.order_count, o.order_price, s.sales_con_date FROM orders AS o JOIN sales_contract AS s ON o.order_num = s.sales_con_id WHERE sales_con_date <= @today AND sales_con_date >= @week";

                MySqlCommand command = new MySqlCommand(query, bd.getConnection());
                command.Parameters.Add("@today", MySqlDbType.Date).Value = Today;
                command.Parameters.Add("@week", MySqlDbType.Date).Value = week;

                MySqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                }

                reader.Close();

                bd.closeConnection();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }

            if (this.Filtr.SelectedIndex == 1)
            {
                String Today = DateTime.Now.ToString("yyyy-MM-dd");
                String week = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");

                while (dataGridView1.Rows.Count > 1)
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);

                BD bd = new BD();

                bd.openConnection();

                string query = "SELECT o.order_num, o.order_product, o.order_count, o.order_price, s.sales_con_date FROM orders AS o JOIN sales_contract AS s ON o.order_num = s.sales_con_id WHERE sales_con_date <= @today AND sales_con_date >= @week";

                MySqlCommand command = new MySqlCommand(query, bd.getConnection());
                command.Parameters.Add("@today", MySqlDbType.Date).Value = Today;
                command.Parameters.Add("@week", MySqlDbType.Date).Value = week;

                MySqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                }

                reader.Close();

                bd.closeConnection();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }
    }
}