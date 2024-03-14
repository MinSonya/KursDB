
namespace KursDB
{
    partial class Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.pr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_accounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_generator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_bank_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(521, 408);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(110, 29);
            this.buttonReport.TabIndex = 23;
            this.buttonReport.Text = "Создать отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(287, 408);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 29);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // backCosm
            // 
            this.backCosm.Location = new System.Drawing.Point(635, 408);
            this.backCosm.Margin = new System.Windows.Forms.Padding(2);
            this.backCosm.Name = "backCosm";
            this.backCosm.Size = new System.Drawing.Size(110, 29);
            this.backCosm.TabIndex = 21;
            this.backCosm.Text = "Назад";
            this.backCosm.UseVisualStyleBackColor = true;
            this.backCosm.Click += new System.EventHandler(this.backCosm_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(401, 408);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(110, 29);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(169, 408);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 29);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(55, 408);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 29);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pr_id,
            this.pr_address,
            this.pr_director,
            this.pr_accounter,
            this.pr_generator,
            this.pr_bank_account});
            this.dataGridView1.Location = new System.Drawing.Point(55, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 320);
            this.dataGridView1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Поставщики";
            // 
            // pr_id
            // 
            this.pr_id.HeaderText = "№";
            this.pr_id.MinimumWidth = 6;
            this.pr_id.Name = "pr_id";
            this.pr_id.Width = 125;
            // 
            // pr_address
            // 
            this.pr_address.HeaderText = "Адрес";
            this.pr_address.MinimumWidth = 6;
            this.pr_address.Name = "pr_address";
            this.pr_address.Width = 125;
            // 
            // pr_director
            // 
            this.pr_director.HeaderText = "Директор";
            this.pr_director.MinimumWidth = 6;
            this.pr_director.Name = "pr_director";
            this.pr_director.Width = 125;
            // 
            // pr_accounter
            // 
            this.pr_accounter.HeaderText = "Бухгалтер";
            this.pr_accounter.MinimumWidth = 6;
            this.pr_accounter.Name = "pr_accounter";
            this.pr_accounter.Width = 125;
            // 
            // pr_generator
            // 
            this.pr_generator.HeaderText = "Производитель";
            this.pr_generator.MinimumWidth = 6;
            this.pr_generator.Name = "pr_generator";
            this.pr_generator.Width = 125;
            // 
            // pr_bank_account
            // 
            this.pr_bank_account.HeaderText = "Банковский счет";
            this.pr_bank_account.MinimumWidth = 6;
            this.pr_bank_account.Name = "pr_bank_account";
            this.pr_bank_account.Width = 125;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.backCosm);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Generator";
            this.Text = "Generator";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_director;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_accounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_generator;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_bank_account;
    }
}