using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursDB
{
    public partial class SalesContractInfo : Form
    {
        public Int32 ac;
        public Int32 id;
        public SalesContractInfo(Int32 access, Int32 pid)
        {
            InitializeComponent();
            ac = access;
            id = pid;
            Fill();
            LoadData();
        }

        private void LoadData()
        {

            string filePath = "C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор продажи1.docx";
            object readOnly = false;
            object visible = true;
            object save = false;
            object fileName = filePath;
            object newTemplate = false;
            object docType = 0;
            object missing = Type.Missing;
            Microsoft.Office.Interop.Word.Document document;
            Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            IDataObject dataobject = Clipboard.GetDataObject();
            rtfContent.Rtf = dataobject.GetData(DataFormats.Rtf).ToString();
            application.Quit(ref missing, ref missing, ref missing);
        }


        private void Fill()
        {
            DateTime date = DateTime.Now;
            String client = "";
            Decimal price = 0;
            Decimal sum = 0;
            Int32 count = 0;
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT sales_con_date, sales_con_client FROM sales_contract WHERE sales_con_id = @pId";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = id;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                date = DateTime.Parse(reader[0].ToString());
                client = reader[1].ToString();
            }

            reader.Close();

            bd.closeConnection();

            // Путь к файлу Word с пропусками
            string filePath = "C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор продажи.docx";
            string destinationFilePath = "C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор продажи1.docx";

            File.Copy(filePath, destinationFilePath);

            if (File.Exists(destinationFilePath))
            {

                // Создаем объект приложения Word
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

                // Открываем существующий документ
                Document doc = wordApp.Documents.Open(destinationFilePath);


                // Заменяем пропуски в документе данными из формы
                Find findObj = wordApp.Selection.Find;
                findObj.ClearFormatting();
                findObj.Text = "[НОМЕР]";  // [ПРОПУСК1] - метка для первого пропуска
                findObj.Replacement.ClearFormatting();
                findObj.Replacement.Text = id.ToString();
                object replaceAll = WdReplace.wdReplaceAll;
                findObj.Execute(Replace: ref replaceAll);

                findObj.Text = "[ДАТА]";  // [ПРОПУСК2] - метка для второго пропуска
                findObj.Replacement.Text = date.ToString("dd.MM.yyyy");
                findObj.Execute(Replace: ref replaceAll);

                findObj.Text = "[ПОКУПАТЕЛЬ]";  // [ПРОПУСК2] - метка для второго пропуска
                findObj.Replacement.Text = client;
                findObj.Execute(Replace: ref replaceAll);

                findObj.Text = "[ДАТА2]";  // [ПРОПУСК2] - метка для второго пропуска
                findObj.Replacement.Text = date.AddDays(7).ToString("dd.MM.yyyy");
                findObj.Execute(Replace: ref replaceAll);

                findObj.Text = "[ПОКУПАТЕЛЬ2]";  // [ПРОПУСК2] - метка для второго пропуска
                findObj.Replacement.Text = client;
                findObj.Execute(Replace: ref replaceAll);

                Paragraph targetParagraph = doc.Paragraphs[19];

                bd.openConnection();

                query = "SELECT order_product, order_price, order_count FROM orders WHERE order_num = @pId";

                command = new MySqlCommand(query, bd.getConnection());
                command.Parameters.Add("@pId", MySqlDbType.Int32).Value = id;

                reader = command.ExecuteReader();

                int i = 2;

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    i++;
                }

                reader.Close();

                bd.closeConnection();

                // Вставляем таблицу после параграфа
                Range range = targetParagraph.Range;
                Table table = doc.Tables.Add(range, i, 3);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Наименование товара";
                table.Cell(1, 2).Range.Text = "Цена";
                table.Cell(1, 3).Range.Text = "Количество";

                for( int j = 2; j < i; j++)
                {
                    table.Cell(j, 1).Range.Text = data[j - 2][0];
                    table.Cell(j, 2).Range.Text = data[j - 2][1];
                    price = Decimal.Parse(data[j - 2][1].ToString());
                    table.Cell(j, 3).Range.Text = data[j - 2][2];
                    count = Int32.Parse(data[j - 2][2].ToString());
                    sum += count * price;
                }

                findObj.Text = "[СУММА]";  // [ПРОПУСК2] - метка для второго пропуска
                findObj.Replacement.Text = sum.ToString();
                findObj.Execute(Replace: ref replaceAll);

                // Сохраняем изменения в документе
                doc.Save();

                // Закрываем документ и завершаем работу с приложением Word
                doc.Close();
                wordApp.Quit();
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "sales_contract1.docx";
            string filePath = "C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор продажи1.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(filePath, sfd.FileName);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор продажи1.docx");
            this.Hide();
            var FormGame = new DelContract(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }
    }
}
