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
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using Application = Microsoft.Office.Interop.Word.Application;

namespace KursDB
{
    public partial class DeliveryContractInfo : Form
    {
        public Int32 id;
        public Int32 ac;
        public DeliveryContractInfo(Int32 access, Int32 pid)
        {
            InitializeComponent();
            id = pid;
            ac = access;
            Fill();
            LoadData();
        }

        private void LoadData()
        {

            string filePath = "C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор поставки1.docx";
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
            String generation = "";
            String director = "";
            Decimal price = 0;
            Decimal sum = 0;
            Int32 count = 0;
            BD bd = new BD();

            bd.openConnection();

            string query = "SELECT del_con_date, del_con_generator FROM delivery_contract WHERE del_con_id = @pId";

            MySqlCommand command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = id;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                date = DateTime.Parse(reader[0].ToString());
                generation = reader[1].ToString();
            }

            reader.Close();

            query = "SELECT pr_director FROM provider WHERE pr_generator = @gener";

            command = new MySqlCommand(query, bd.getConnection());
            command.Parameters.Add("@gener", MySqlDbType.VarChar).Value = generation;

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                director = reader[0].ToString();
            }

            reader.Close();

            bd.closeConnection();

            // Путь к файлу Word с пропусками
            string filePath = "C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор поставки.docx";
            string destinationFilePath = "C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор поставки1.docx";

            File.Copy(filePath, destinationFilePath);

            if (File.Exists(destinationFilePath)) {

                // Создаем объект приложения Word
                Application wordApp = new Application();

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

                findObj.Text = "[ПРОИЗВОДИТЕЛЬ]";  // [ПРОПУСК2] - метка для второго пропуска
                findObj.Replacement.Text = generation;
                findObj.Execute(Replace: ref replaceAll);

                findObj.Text = "[ДИРЕКТОР]";  // [ПРОПУСК2] - метка для второго пропуска
                findObj.Replacement.Text = director;
                findObj.Execute(Replace: ref replaceAll);

                findObj.Text = "[ДАТА2]";  // [ПРОПУСК2] - метка для второго пропуска
                findObj.Replacement.Text = date.AddDays(7).ToString("dd.MM.yyyy");
                findObj.Execute(Replace: ref replaceAll);

                findObj.Text = "[ДИРЕКТОР2]";  // [ПРОПУСК2] - метка для второго пропуска
                findObj.Replacement.Text = director;
                findObj.Execute(Replace: ref replaceAll);

                Paragraph targetParagraph = doc.Paragraphs[20];

                // Вставляем таблицу после параграфа
                Range range = targetParagraph.Range;
                Table table = doc.Tables.Add(range, 2, 3);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Наименование товара";
                table.Cell(1, 2).Range.Text = "Цена";
                table.Cell(1, 3).Range.Text = "Количество";

                bd.openConnection();

                query = "SELECT del_con_product, del_con_price, del_con_count FROM delivery_contract";

                command = new MySqlCommand(query, bd.getConnection());

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    table.Cell(2, 1).Range.Text = reader[0].ToString();
                    table.Cell(2, 2).Range.Text = reader[1].ToString();
                    price = Decimal.Parse(reader[1].ToString());
                    table.Cell(2, 3).Range.Text = reader[2].ToString();
                    count = Int32.Parse(reader[2].ToString());
                }

                reader.Close();

                bd.closeConnection();

                sum = price * count;

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор поставки1.docx");
            this.Hide();
            var FormGame = new DelContract(ac);
            FormGame.Owner = this;
            FormGame.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "delivery_contract1.docx";
            string filePath = "C:\\Users\\minso\\OneDrive\\Документы\\Базы данных\\Договор поставки1.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(filePath, sfd.FileName);
            }
        }
    }
}
