
namespace KursDB
{
    partial class AddSalesContract
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
            this.dateSalesContract = new System.Windows.Forms.TextBox();
            this.Wt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderSalesContract = new System.Windows.Forms.ComboBox();
            this.clientSalesContract = new System.Windows.Forms.ComboBox();
            this.itemsSalesContract = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNewCosm
            // 
            this.addNewCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewCosm.Location = new System.Drawing.Point(547, 433);
            this.addNewCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewCosm.Name = "addNewCosm";
            this.addNewCosm.Size = new System.Drawing.Size(180, 47);
            this.addNewCosm.TabIndex = 32;
            this.addNewCosm.Text = "Добавить";
            this.addNewCosm.UseVisualStyleBackColor = true;
            this.addNewCosm.Click += new System.EventHandler(this.addNewCosm_Click);
            // 
            // backAddCosm
            // 
            this.backAddCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backAddCosm.Location = new System.Drawing.Point(746, 433);
            this.backAddCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backAddCosm.Name = "backAddCosm";
            this.backAddCosm.Size = new System.Drawing.Size(180, 47);
            this.backAddCosm.TabIndex = 31;
            this.backAddCosm.Text = "Назад";
            this.backAddCosm.UseVisualStyleBackColor = true;
            this.backAddCosm.Click += new System.EventHandler(this.backAddCosm_Click);
            // 
            // dateSalesContract
            // 
            this.dateSalesContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateSalesContract.Location = new System.Drawing.Point(406, 351);
            this.dateSalesContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateSalesContract.Name = "dateSalesContract";
            this.dateSalesContract.Size = new System.Drawing.Size(516, 34);
            this.dateSalesContract.TabIndex = 28;
            // 
            // Wt
            // 
            this.Wt.AutoSize = true;
            this.Wt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wt.Location = new System.Drawing.Point(162, 356);
            this.Wt.Name = "Wt";
            this.Wt.Size = new System.Drawing.Size(67, 29);
            this.Wt.TabIndex = 27;
            this.Wt.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(162, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Номер заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(225, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Добавление нового договора по продаже";
            // 
            // orderSalesContract
            // 
            this.orderSalesContract.FormattingEnabled = true;
            this.orderSalesContract.Location = new System.Drawing.Point(409, 147);
            this.orderSalesContract.Name = "orderSalesContract";
            this.orderSalesContract.Size = new System.Drawing.Size(515, 24);
            this.orderSalesContract.TabIndex = 33;
            this.orderSalesContract.SelectedIndexChanged += new System.EventHandler(this.orderSalesContract_SelectedIndexChanged);
            // 
            // clientSalesContract
            // 
            this.clientSalesContract.FormattingEnabled = true;
            this.clientSalesContract.Location = new System.Drawing.Point(409, 281);
            this.clientSalesContract.Name = "clientSalesContract";
            this.clientSalesContract.Size = new System.Drawing.Size(515, 24);
            this.clientSalesContract.TabIndex = 34;
            // 
            // itemsSalesContract
            // 
            this.itemsSalesContract.Enabled = false;
            this.itemsSalesContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsSalesContract.Location = new System.Drawing.Point(410, 200);
            this.itemsSalesContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemsSalesContract.Name = "itemsSalesContract";
            this.itemsSalesContract.Size = new System.Drawing.Size(516, 34);
            this.itemsSalesContract.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(166, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Состав заказа";
            // 
            // AddSalesContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.itemsSalesContract);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientSalesContract);
            this.Controls.Add(this.orderSalesContract);
            this.Controls.Add(this.addNewCosm);
            this.Controls.Add(this.backAddCosm);
            this.Controls.Add(this.dateSalesContract);
            this.Controls.Add(this.Wt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSalesContract";
            this.Text = "AddSalesContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewCosm;
        private System.Windows.Forms.Button backAddCosm;
        private System.Windows.Forms.TextBox dateSalesContract;
        private System.Windows.Forms.Label Wt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox orderSalesContract;
        private System.Windows.Forms.ComboBox clientSalesContract;
        private System.Windows.Forms.TextBox itemsSalesContract;
        private System.Windows.Forms.Label label4;
    }
}