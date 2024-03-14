
namespace KursDB
{
    partial class OrderInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumOfOrder = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backCosm = new System.Windows.Forms.Button();
            this.cosm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosm_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosm_generator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosm_describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о заказе";
            // 
            // NumOfOrder
            // 
            this.NumOfOrder.AutoSize = true;
            this.NumOfOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfOrder.Location = new System.Drawing.Point(432, 92);
            this.NumOfOrder.Name = "NumOfOrder";
            this.NumOfOrder.Size = new System.Drawing.Size(135, 32);
            this.NumOfOrder.TabIndex = 1;
            this.NumOfOrder.Text = "Заказ №";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cosm_id,
            this.cosm_name,
            this.order_count,
            this.cosm_price,
            this.cosm_generator,
            this.cosm_describe});
            this.dataGridView1.Location = new System.Drawing.Point(70, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 328);
            this.dataGridView1.TabIndex = 2;
            // 
            // backCosm
            // 
            this.backCosm.Location = new System.Drawing.Point(837, 497);
            this.backCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backCosm.Name = "backCosm";
            this.backCosm.Size = new System.Drawing.Size(147, 36);
            this.backCosm.TabIndex = 6;
            this.backCosm.Text = "Назад";
            this.backCosm.UseVisualStyleBackColor = true;
            this.backCosm.Click += new System.EventHandler(this.backCosm_Click);
            // 
            // cosm_id
            // 
            this.cosm_id.HeaderText = "№";
            this.cosm_id.MinimumWidth = 6;
            this.cosm_id.Name = "cosm_id";
            this.cosm_id.Width = 125;
            // 
            // cosm_name
            // 
            this.cosm_name.HeaderText = "Наименование товара";
            this.cosm_name.MinimumWidth = 6;
            this.cosm_name.Name = "cosm_name";
            this.cosm_name.Width = 125;
            // 
            // order_count
            // 
            this.order_count.HeaderText = "Количество";
            this.order_count.MinimumWidth = 6;
            this.order_count.Name = "order_count";
            this.order_count.Width = 125;
            // 
            // cosm_price
            // 
            this.cosm_price.HeaderText = "Цена";
            this.cosm_price.MinimumWidth = 6;
            this.cosm_price.Name = "cosm_price";
            this.cosm_price.Width = 125;
            // 
            // cosm_generator
            // 
            this.cosm_generator.HeaderText = "Производитель";
            this.cosm_generator.MinimumWidth = 6;
            this.cosm_generator.Name = "cosm_generator";
            this.cosm_generator.Width = 125;
            // 
            // cosm_describe
            // 
            this.cosm_describe.HeaderText = "Описание";
            this.cosm_describe.MinimumWidth = 6;
            this.cosm_describe.Name = "cosm_describe";
            this.cosm_describe.Width = 125;
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.backCosm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NumOfOrder);
            this.Controls.Add(this.label1);
            this.Name = "OrderInfo";
            this.Text = "OrderInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumOfOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backCosm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosm_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosm_generator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosm_describe;
    }
}