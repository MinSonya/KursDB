
namespace KursDB
{
    partial class SalesBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.backCosm = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sales_bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_bill_num_bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_bill_num_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_bill_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_bill_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_bill_check_del = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sales_bill_check_payment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Filtr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(695, 496);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(147, 36);
            this.buttonReport.TabIndex = 31;
            this.buttonReport.Text = "Создать отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(383, 496);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(147, 36);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // backCosm
            // 
            this.backCosm.Location = new System.Drawing.Point(847, 496);
            this.backCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backCosm.Name = "backCosm";
            this.backCosm.Size = new System.Drawing.Size(147, 36);
            this.backCosm.TabIndex = 29;
            this.backCosm.Text = "Назад";
            this.backCosm.UseVisualStyleBackColor = true;
            this.backCosm.Click += new System.EventHandler(this.backCosm_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(535, 496);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(147, 36);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(225, 496);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(147, 36);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(73, 496);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 36);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sales_bill_id,
            this.sales_bill_num_bill,
            this.sales_bill_num_contract,
            this.sales_bill_date,
            this.sales_bill_sum,
            this.sales_bill_check_del,
            this.sales_bill_check_payment});
            this.dataGridView1.Location = new System.Drawing.Point(73, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 394);
            this.dataGridView1.TabIndex = 25;
            // 
            // sales_bill_id
            // 
            this.sales_bill_id.HeaderText = "№";
            this.sales_bill_id.MinimumWidth = 6;
            this.sales_bill_id.Name = "sales_bill_id";
            this.sales_bill_id.Width = 125;
            // 
            // sales_bill_num_bill
            // 
            this.sales_bill_num_bill.HeaderText = "Банковский счет";
            this.sales_bill_num_bill.MinimumWidth = 6;
            this.sales_bill_num_bill.Name = "sales_bill_num_bill";
            this.sales_bill_num_bill.Width = 125;
            // 
            // sales_bill_num_contract
            // 
            this.sales_bill_num_contract.HeaderText = "Номер договора";
            this.sales_bill_num_contract.MinimumWidth = 6;
            this.sales_bill_num_contract.Name = "sales_bill_num_contract";
            this.sales_bill_num_contract.Width = 125;
            // 
            // sales_bill_date
            // 
            this.sales_bill_date.HeaderText = "Дата";
            this.sales_bill_date.MinimumWidth = 6;
            this.sales_bill_date.Name = "sales_bill_date";
            this.sales_bill_date.Width = 125;
            // 
            // sales_bill_sum
            // 
            this.sales_bill_sum.HeaderText = "Сумма";
            this.sales_bill_sum.MinimumWidth = 6;
            this.sales_bill_sum.Name = "sales_bill_sum";
            this.sales_bill_sum.Width = 125;
            // 
            // sales_bill_check_del
            // 
            this.sales_bill_check_del.HeaderText = "Отметка об отгрузке";
            this.sales_bill_check_del.MinimumWidth = 6;
            this.sales_bill_check_del.Name = "sales_bill_check_del";
            this.sales_bill_check_del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sales_bill_check_del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sales_bill_check_del.Width = 125;
            // 
            // sales_bill_check_payment
            // 
            this.sales_bill_check_payment.HeaderText = "Отметка об оплате";
            this.sales_bill_check_payment.MinimumWidth = 6;
            this.sales_bill_check_payment.Name = "sales_bill_check_payment";
            this.sales_bill_check_payment.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(355, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Счета по продаже";
            // 
            // Filtr
            // 
            this.Filtr.FormattingEnabled = true;
            this.Filtr.Location = new System.Drawing.Point(765, 34);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(227, 24);
            this.Filtr.TabIndex = 32;
            this.Filtr.SelectedIndexChanged += new System.EventHandler(this.Filtr_SelectedIndexChanged);
            // 
            // SalesBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.backCosm);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesBill";
            this.Text = "SalesBill";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button backCosm;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_bill_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_bill_num_bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_bill_num_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_bill_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_bill_sum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sales_bill_check_del;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sales_bill_check_payment;
        private System.Windows.Forms.ComboBox Filtr;
    }
}