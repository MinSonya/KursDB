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
    public partial class SalesBill : Form
    {
        public Int32 ac;
        public SalesBill(Int32 access)
        {
            InitializeComponent();
            LoadData();
            ac = access;
        }
        private void LoadData()
        {
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT * FROM sales_bill";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            bd.closeConnection();

            bool del = false;
            bool bill = false;

            foreach (string[] s in data)
            {
                if (s[5].Equals("1"))
                    del = true;
                else del = false;
                if (s[6].Equals("1"))
                    bill = true;
                else bill = false;
                dataGridView1.Rows.Add(s[0], s[1], s[2], s[3], s[4], del, bill);
            }

            Filtr.Items.Add("Оплаченные счета");
            Filtr.Items.Add("Неоплаченные счета");
        }

            private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ac == 1 || ac == 2)
            {
                this.Hide();
                var FormGame = new AddSalesBill(ac);
                FormGame.Owner = this;
                FormGame.Show();
            } else MessageBox.Show("Недостаточно прав");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ac == 1 || ac == 2)
            {
                BD bd = new BD();

                Int32 id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["sales_bill_id"].Value);

                bd.openConnection();

                MySqlCommand command = new MySqlCommand("DELETE FROM sales_bill WHERE sales_bill_id = @pId", bd.getConnection());
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
            } else MessageBox.Show("Недостаточно прав"); 
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

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Счета по продаже";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ac == 1 || ac == 2)
            {
                String bank = Convert.ToString(this.dataGridView1.CurrentRow.Cells["sales_bill_num_bill"].Value);
                String contract = Convert.ToString(this.dataGridView1.CurrentRow.Cells["sales_bill_num_contract"].Value);
                String sum = Convert.ToString(this.dataGridView1.CurrentRow.Cells["sales_bill_sum"].Value);
                String date = Convert.ToString(this.dataGridView1.CurrentRow.Cells["sales_bill_date"].Value);
                Int32 id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["sales_bill_id"].Value);
                bool del = Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells["sales_bill_check_del"].Value);
                bool pay = Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells["sales_bill_check_payment"].Value);

                var FormGame = new EditSalesBill(id, bank, contract, date, sum, del, pay);
                FormGame.Owner = this;
                FormGame.Show();
            } else MessageBox.Show("Недостаточно прав");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);

            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT * FROM sales_bill";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            bd.closeConnection();

            bool del = false;
            bool bill = false;

            foreach (string[] s in data)
            {
                if (s[5].Equals("1"))
                    del = true;
                else del = false;
                if (s[6].Equals("1"))
                    bill = true;
                else bill = false;
                dataGridView1.Rows.Add(s[0], s[1], s[2], s[3], s[4], del, bill);
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "sales_bill.docx";

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
            if(Filtr.SelectedIndex == 0)
            {
                while (dataGridView1.Rows.Count > 1)
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);

                BD bd = new BD();

                bd.openConnection();

                string query = "SELECT * FROM sales_bill";

                MySqlCommand command = new MySqlCommand(query, bd.getConnection());

                MySqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                }

                reader.Close();

                bd.closeConnection();

                bool del = false;
                bool bill = false;

                foreach (string[] s in data)
                {
                    if (s[5].Equals("1"))
                        del = true;
                    else del = false;
                    if (s[6].Equals("1"))
                        bill = true;
                    else bill = false;
                    if(bill)
                    dataGridView1.Rows.Add(s[0], s[1], s[2], s[3], s[4], del, bill);
                }
            }


            if (Filtr.SelectedIndex == 1)
            {
                while (dataGridView1.Rows.Count > 1)
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);

                BD bd = new BD();

                bd.openConnection();

                string query = "SELECT * FROM sales_bill";

                MySqlCommand command = new MySqlCommand(query, bd.getConnection());

                MySqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                }

                reader.Close();

                bd.closeConnection();

                bool del = false;
                bool bill = false;

                foreach (string[] s in data)
                {
                    if (s[5].Equals("1"))
                        del = true;
                    else del = false;
                    if (s[6].Equals("1"))
                        bill = true;
                    else bill = false;
                    if (!bill)
                        dataGridView1.Rows.Add(s[0], s[1], s[2], s[3], s[4], del, bill);
                }
            }

        }
    }
}
