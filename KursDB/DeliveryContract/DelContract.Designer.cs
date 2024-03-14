
namespace KursDB
{
    partial class DelContract
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
            this.del_con_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_con_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_con_generator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_con_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_con_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_con_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.buttonReport.TabIndex = 23;
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
            this.buttonEdit.TabIndex = 22;
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
            this.backCosm.TabIndex = 21;
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
            this.buttonUpdate.TabIndex = 20;
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
            this.buttonDelete.TabIndex = 19;
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
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.del_con_id,
            this.del_con_product,
            this.del_con_generator,
            this.del_con_price,
            this.del_con_count,
            this.del_con_date});
            this.dataGridView1.Location = new System.Drawing.Point(73, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 394);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // del_con_id
            // 
            this.del_con_id.HeaderText = "№";
            this.del_con_id.MinimumWidth = 6;
            this.del_con_id.Name = "del_con_id";
            this.del_con_id.Width = 125;
            // 
            // del_con_product
            // 
            this.del_con_product.HeaderText = "Наименование товара";
            this.del_con_product.MinimumWidth = 6;
            this.del_con_product.Name = "del_con_product";
            this.del_con_product.Width = 125;
            // 
            // del_con_generator
            // 
            this.del_con_generator.HeaderText = "Производитель";
            this.del_con_generator.MinimumWidth = 6;
            this.del_con_generator.Name = "del_con_generator";
            this.del_con_generator.Width = 125;
            // 
            // del_con_price
            // 
            this.del_con_price.HeaderText = "Цена";
            this.del_con_price.MinimumWidth = 6;
            this.del_con_price.Name = "del_con_price";
            this.del_con_price.Width = 125;
            // 
            // del_con_count
            // 
            this.del_con_count.HeaderText = "Количество";
            this.del_con_count.MinimumWidth = 6;
            this.del_con_count.Name = "del_con_count";
            this.del_con_count.Width = 125;
            // 
            // del_con_date
            // 
            this.del_con_date.HeaderText = "Дата";
            this.del_con_date.MinimumWidth = 6;
            this.del_con_date.Name = "del_con_date";
            this.del_con_date.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(355, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Договоры на поставку";
            // 
            // Filtr
            // 
            this.Filtr.FormattingEnabled = true;
            this.Filtr.Location = new System.Drawing.Point(831, 36);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(161, 24);
            this.Filtr.TabIndex = 24;
            this.Filtr.SelectedIndexChanged += new System.EventHandler(this.Filtr_SelectedIndexChanged);
            // 
            // DelContract
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DelContract";
            this.Text = "DeliveryContract";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn del_con_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn del_con_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn del_con_generator;
        private System.Windows.Forms.DataGridViewTextBoxColumn del_con_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn del_con_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn del_con_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Filtr;
    }
}