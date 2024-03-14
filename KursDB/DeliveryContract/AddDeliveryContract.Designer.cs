
namespace KursDB.DeliveryContract
{
    partial class AddDeliveryContract
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
            this.countDelCon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceDelCon = new System.Windows.Forms.TextBox();
            this.Wt = new System.Windows.Forms.Label();
            this.generatorDelCon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDelCon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productDelCon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNewCosm
            // 
            this.addNewCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewCosm.Location = new System.Drawing.Point(536, 485);
            this.addNewCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewCosm.Name = "addNewCosm";
            this.addNewCosm.Size = new System.Drawing.Size(180, 47);
            this.addNewCosm.TabIndex = 21;
            this.addNewCosm.Text = "Добавить";
            this.addNewCosm.UseVisualStyleBackColor = true;
            this.addNewCosm.Click += new System.EventHandler(this.addNewCosm_Click);
            // 
            // backAddCosm
            // 
            this.backAddCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backAddCosm.Location = new System.Drawing.Point(735, 485);
            this.backAddCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backAddCosm.Name = "backAddCosm";
            this.backAddCosm.Size = new System.Drawing.Size(180, 47);
            this.backAddCosm.TabIndex = 20;
            this.backAddCosm.Text = "Назад";
            this.backAddCosm.UseVisualStyleBackColor = true;
            this.backAddCosm.Click += new System.EventHandler(this.backAddCosm_Click);
            // 
            // countDelCon
            // 
            this.countDelCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDelCon.Location = new System.Drawing.Point(397, 356);
            this.countDelCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countDelCon.Name = "countDelCon";
            this.countDelCon.Size = new System.Drawing.Size(516, 34);
            this.countDelCon.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(153, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Количество";
            // 
            // priceDelCon
            // 
            this.priceDelCon.Enabled = false;
            this.priceDelCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceDelCon.Location = new System.Drawing.Point(397, 283);
            this.priceDelCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceDelCon.Name = "priceDelCon";
            this.priceDelCon.Size = new System.Drawing.Size(516, 34);
            this.priceDelCon.TabIndex = 17;
            // 
            // Wt
            // 
            this.Wt.AutoSize = true;
            this.Wt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wt.Location = new System.Drawing.Point(153, 288);
            this.Wt.Name = "Wt";
            this.Wt.Size = new System.Drawing.Size(72, 29);
            this.Wt.TabIndex = 16;
            this.Wt.Text = "Цена";
            // 
            // generatorDelCon
            // 
            this.generatorDelCon.Enabled = false;
            this.generatorDelCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatorDelCon.Location = new System.Drawing.Point(399, 206);
            this.generatorDelCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generatorDelCon.Name = "generatorDelCon";
            this.generatorDelCon.Size = new System.Drawing.Size(513, 34);
            this.generatorDelCon.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(153, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Производитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(153, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Товар";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(227, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Создание нового договора по продаже";
            // 
            // dateDelCon
            // 
            this.dateDelCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDelCon.Location = new System.Drawing.Point(396, 426);
            this.dateDelCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDelCon.Name = "dateDelCon";
            this.dateDelCon.Size = new System.Drawing.Size(516, 34);
            this.dateDelCon.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(152, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Дата";
            // 
            // productDelCon
            // 
            this.productDelCon.FormattingEnabled = true;
            this.productDelCon.Location = new System.Drawing.Point(399, 137);
            this.productDelCon.Margin = new System.Windows.Forms.Padding(4);
            this.productDelCon.Name = "productDelCon";
            this.productDelCon.Size = new System.Drawing.Size(515, 24);
            this.productDelCon.TabIndex = 36;
            this.productDelCon.SelectedIndexChanged += new System.EventHandler(this.productDelCon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "Формат: ГГГГ-ММ-ДД";
            // 
            // AddDeliveryContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productDelCon);
            this.Controls.Add(this.dateDelCon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addNewCosm);
            this.Controls.Add(this.backAddCosm);
            this.Controls.Add(this.countDelCon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceDelCon);
            this.Controls.Add(this.Wt);
            this.Controls.Add(this.generatorDelCon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDeliveryContract";
            this.Text = "AddDeliveryContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewCosm;
        private System.Windows.Forms.Button backAddCosm;
        private System.Windows.Forms.TextBox countDelCon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceDelCon;
        private System.Windows.Forms.Label Wt;
        private System.Windows.Forms.TextBox generatorDelCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateDelCon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox productDelCon;
        private System.Windows.Forms.Label label6;
    }
}