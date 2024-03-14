
namespace KursDB
{
    partial class AddOrder
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
            this.addNewCosm = new System.Windows.Forms.Button();
            this.backAddCosm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order_product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.order_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewCosm
            // 
            this.addNewCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewCosm.Location = new System.Drawing.Point(535, 438);
            this.addNewCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewCosm.Name = "addNewCosm";
            this.addNewCosm.Size = new System.Drawing.Size(180, 47);
            this.addNewCosm.TabIndex = 34;
            this.addNewCosm.Text = "Добавить";
            this.addNewCosm.UseVisualStyleBackColor = true;
            this.addNewCosm.Click += new System.EventHandler(this.addNewCosm_Click);
            // 
            // backAddCosm
            // 
            this.backAddCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backAddCosm.Location = new System.Drawing.Point(733, 438);
            this.backAddCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backAddCosm.Name = "backAddCosm";
            this.backAddCosm.Size = new System.Drawing.Size(180, 47);
            this.backAddCosm.TabIndex = 33;
            this.backAddCosm.Text = "Назад";
            this.backAddCosm.UseVisualStyleBackColor = true;
            this.backAddCosm.Click += new System.EventHandler(this.backAddCosm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Добавление нового заказа";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_product,
            this.order_count,
            this.order_price});
            this.dataGridView1.Location = new System.Drawing.Point(159, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 327);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // order_product
            // 
            this.order_product.HeaderText = "Наименование товара";
            this.order_product.MinimumWidth = 6;
            this.order_product.Name = "order_product";
            // 
            // order_count
            // 
            this.order_count.HeaderText = "Количество";
            this.order_count.MinimumWidth = 6;
            this.order_count.Name = "order_count";
            // 
            // order_price
            // 
            this.order_price.HeaderText = "Цена";
            this.order_price.MinimumWidth = 6;
            this.order_price.Name = "order_price";
            this.order_price.ReadOnly = true;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addNewCosm);
            this.Controls.Add(this.backAddCosm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewCosm;
        private System.Windows.Forms.Button backAddCosm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn order_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
    }
}