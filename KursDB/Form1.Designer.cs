
namespace KursDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BDname = new System.Windows.Forms.Label();
            this.cosmetica_button = new System.Windows.Forms.Button();
            this.buttonDealer = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.provider = new System.Windows.Forms.Button();
            this.buttonBillDel = new System.Windows.Forms.Button();
            this.buttonContractDel = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonBillSales = new System.Windows.Forms.Button();
            this.buttonContractSales = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BDname
            // 
            this.BDname.AutoSize = true;
            this.BDname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDname.Location = new System.Drawing.Point(239, 12);
            this.BDname.Name = "BDname";
            this.BDname.Size = new System.Drawing.Size(522, 36);
            this.BDname.TabIndex = 0;
            this.BDname.Text = "База данных \"Дилер косметики\"";
            // 
            // cosmetica_button
            // 
            this.cosmetica_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cosmetica_button.Location = new System.Drawing.Point(115, 63);
            this.cosmetica_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cosmetica_button.Name = "cosmetica_button";
            this.cosmetica_button.Size = new System.Drawing.Size(397, 62);
            this.cosmetica_button.TabIndex = 1;
            this.cosmetica_button.Text = "Косметика";
            this.cosmetica_button.UseVisualStyleBackColor = true;
            this.cosmetica_button.Click += new System.EventHandler(this.cosmetica_button_Click);
            // 
            // buttonDealer
            // 
            this.buttonDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDealer.Location = new System.Drawing.Point(539, 63);
            this.buttonDealer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDealer.Name = "buttonDealer";
            this.buttonDealer.Size = new System.Drawing.Size(397, 62);
            this.buttonDealer.TabIndex = 2;
            this.buttonDealer.Text = "Дилер";
            this.buttonDealer.UseVisualStyleBackColor = true;
            this.buttonDealer.Click += new System.EventHandler(this.buttonDealer_Click);
            // 
            // orders
            // 
            this.orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orders.Location = new System.Drawing.Point(115, 143);
            this.orders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(397, 62);
            this.orders.TabIndex = 3;
            this.orders.Text = "Заказы";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // provider
            // 
            this.provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.provider.Location = new System.Drawing.Point(539, 143);
            this.provider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(397, 62);
            this.provider.TabIndex = 4;
            this.provider.Text = "Поставщики";
            this.provider.UseVisualStyleBackColor = true;
            this.provider.Click += new System.EventHandler(this.provider_Click);
            // 
            // buttonBillDel
            // 
            this.buttonBillDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBillDel.Location = new System.Drawing.Point(539, 310);
            this.buttonBillDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBillDel.Name = "buttonBillDel";
            this.buttonBillDel.Size = new System.Drawing.Size(397, 62);
            this.buttonBillDel.TabIndex = 8;
            this.buttonBillDel.Text = "Cчета по поставке";
            this.buttonBillDel.UseVisualStyleBackColor = true;
            this.buttonBillDel.Click += new System.EventHandler(this.buttonBillDel_Click);
            // 
            // buttonContractDel
            // 
            this.buttonContractDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContractDel.Location = new System.Drawing.Point(115, 310);
            this.buttonContractDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonContractDel.Name = "buttonContractDel";
            this.buttonContractDel.Size = new System.Drawing.Size(397, 62);
            this.buttonContractDel.TabIndex = 7;
            this.buttonContractDel.Text = "Договоры на поставку";
            this.buttonContractDel.UseVisualStyleBackColor = true;
            this.buttonContractDel.Click += new System.EventHandler(this.buttonContractDel_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStock.Location = new System.Drawing.Point(539, 227);
            this.buttonStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(397, 62);
            this.buttonStock.TabIndex = 6;
            this.buttonStock.Text = "Cклад";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.Location = new System.Drawing.Point(115, 227);
            this.buttonClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(397, 62);
            this.buttonClients.TabIndex = 5;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonBillSales
            // 
            this.buttonBillSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBillSales.Location = new System.Drawing.Point(539, 399);
            this.buttonBillSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBillSales.Name = "buttonBillSales";
            this.buttonBillSales.Size = new System.Drawing.Size(397, 62);
            this.buttonBillSales.TabIndex = 10;
            this.buttonBillSales.Text = "Cчета по продаже";
            this.buttonBillSales.UseVisualStyleBackColor = true;
            this.buttonBillSales.Click += new System.EventHandler(this.buttonBillSales_Click);
            // 
            // buttonContractSales
            // 
            this.buttonContractSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContractSales.Location = new System.Drawing.Point(115, 399);
            this.buttonContractSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonContractSales.Name = "buttonContractSales";
            this.buttonContractSales.Size = new System.Drawing.Size(397, 62);
            this.buttonContractSales.TabIndex = 9;
            this.buttonContractSales.Text = "Договоры по продаже";
            this.buttonContractSales.UseVisualStyleBackColor = true;
            this.buttonContractSales.Click += new System.EventHandler(this.buttonContractSales_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(115, 481);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(821, 62);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBillSales);
            this.Controls.Add(this.buttonContractSales);
            this.Controls.Add(this.buttonBillDel);
            this.Controls.Add(this.buttonContractDel);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.provider);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.buttonDealer);
            this.Controls.Add(this.cosmetica_button);
            this.Controls.Add(this.BDname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BDname;
        private System.Windows.Forms.Button cosmetica_button;
        private System.Windows.Forms.Button buttonDealer;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button provider;
        private System.Windows.Forms.Button buttonBillDel;
        private System.Windows.Forms.Button buttonContractDel;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonBillSales;
        private System.Windows.Forms.Button buttonContractSales;
        private System.Windows.Forms.Button buttonExit;
    }
}

