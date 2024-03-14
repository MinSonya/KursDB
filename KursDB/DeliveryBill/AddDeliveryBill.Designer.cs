
namespace KursDB
{
    partial class AddDeliveryBill
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
            this.sumDelBill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addNewCosm = new System.Windows.Forms.Button();
            this.backAddCosm = new System.Windows.Forms.Button();
            this.dateDelBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Wt = new System.Windows.Forms.Label();
            this.bankDelBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contractDelBill = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delDelBill = new System.Windows.Forms.CheckBox();
            this.paymentDelBill = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumDelBill
            // 
            this.sumDelBill.Enabled = false;
            this.sumDelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumDelBill.Location = new System.Drawing.Point(398, 312);
            this.sumDelBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sumDelBill.Name = "sumDelBill";
            this.sumDelBill.Size = new System.Drawing.Size(516, 34);
            this.sumDelBill.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(154, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "Сумма";
            // 
            // addNewCosm
            // 
            this.addNewCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewCosm.Location = new System.Drawing.Point(536, 463);
            this.addNewCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewCosm.Name = "addNewCosm";
            this.addNewCosm.Size = new System.Drawing.Size(180, 47);
            this.addNewCosm.TabIndex = 46;
            this.addNewCosm.Text = "Добавить";
            this.addNewCosm.UseVisualStyleBackColor = true;
            this.addNewCosm.Click += new System.EventHandler(this.addNewCosm_Click);
            // 
            // backAddCosm
            // 
            this.backAddCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backAddCosm.Location = new System.Drawing.Point(735, 463);
            this.backAddCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backAddCosm.Name = "backAddCosm";
            this.backAddCosm.Size = new System.Drawing.Size(180, 47);
            this.backAddCosm.TabIndex = 45;
            this.backAddCosm.Text = "Назад";
            this.backAddCosm.UseVisualStyleBackColor = true;
            this.backAddCosm.Click += new System.EventHandler(this.backAddCosm_Click);
            // 
            // dateDelBill
            // 
            this.dateDelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDelBill.Location = new System.Drawing.Point(399, 238);
            this.dateDelBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDelBill.Name = "dateDelBill";
            this.dateDelBill.Size = new System.Drawing.Size(516, 34);
            this.dateDelBill.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(155, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 43;
            this.label4.Text = "Дата";
            // 
            // Wt
            // 
            this.Wt.AutoSize = true;
            this.Wt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wt.Location = new System.Drawing.Point(157, 90);
            this.Wt.Name = "Wt";
            this.Wt.Size = new System.Drawing.Size(203, 29);
            this.Wt.TabIndex = 41;
            this.Wt.Text = "Номер договора";
            // 
            // bankDelBill
            // 
            this.bankDelBill.Enabled = false;
            this.bankDelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankDelBill.Location = new System.Drawing.Point(400, 155);
            this.bankDelBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bankDelBill.Name = "bankDelBill";
            this.bankDelBill.Size = new System.Drawing.Size(513, 34);
            this.bankDelBill.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(154, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Банковский счет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Создание нового счета поставки";
            // 
            // contractDelBill
            // 
            this.contractDelBill.FormattingEnabled = true;
            this.contractDelBill.Location = new System.Drawing.Point(400, 97);
            this.contractDelBill.Margin = new System.Windows.Forms.Padding(4);
            this.contractDelBill.Name = "contractDelBill";
            this.contractDelBill.Size = new System.Drawing.Size(515, 24);
            this.contractDelBill.TabIndex = 50;
            this.contractDelBill.SelectedIndexChanged += new System.EventHandler(this.contractDelBill_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(155, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "Отметка об отгрузке";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(596, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 29);
            this.label7.TabIndex = 52;
            this.label7.Text = "Отметка об оплате";
            // 
            // delDelBill
            // 
            this.delDelBill.AutoSize = true;
            this.delDelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delDelBill.Location = new System.Drawing.Point(448, 391);
            this.delDelBill.Name = "delDelBill";
            this.delDelBill.Size = new System.Drawing.Size(18, 17);
            this.delDelBill.TabIndex = 53;
            this.delDelBill.UseVisualStyleBackColor = true;
            // 
            // paymentDelBill
            // 
            this.paymentDelBill.AutoSize = true;
            this.paymentDelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentDelBill.Location = new System.Drawing.Point(895, 387);
            this.paymentDelBill.Name = "paymentDelBill";
            this.paymentDelBill.Size = new System.Drawing.Size(18, 17);
            this.paymentDelBill.TabIndex = 54;
            this.paymentDelBill.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Формат: ГГГГ-ММ-ДД";
            // 
            // AddDeliveryBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymentDelBill);
            this.Controls.Add(this.delDelBill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contractDelBill);
            this.Controls.Add(this.sumDelBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addNewCosm);
            this.Controls.Add(this.backAddCosm);
            this.Controls.Add(this.dateDelBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Wt);
            this.Controls.Add(this.bankDelBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddDeliveryBill";
            this.Text = "AddDeliveryBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sumDelBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addNewCosm;
        private System.Windows.Forms.Button backAddCosm;
        private System.Windows.Forms.TextBox dateDelBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Wt;
        private System.Windows.Forms.TextBox bankDelBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox contractDelBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox delDelBill;
        private System.Windows.Forms.CheckBox paymentDelBill;
        private System.Windows.Forms.Label label2;
    }
}