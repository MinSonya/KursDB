
namespace KursDB
{
    partial class EditOrder
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
            this.priceOrder = new System.Windows.Forms.TextBox();
            this.Wt = new System.Windows.Forms.Label();
            this.countOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productOrder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addNewCosm
            // 
            this.addNewCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewCosm.Location = new System.Drawing.Point(535, 423);
            this.addNewCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewCosm.Name = "addNewCosm";
            this.addNewCosm.Size = new System.Drawing.Size(193, 47);
            this.addNewCosm.TabIndex = 43;
            this.addNewCosm.Text = "Сохранить";
            this.addNewCosm.UseVisualStyleBackColor = true;
            this.addNewCosm.Click += new System.EventHandler(this.addNewCosm_Click);
            // 
            // backAddCosm
            // 
            this.backAddCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backAddCosm.Location = new System.Drawing.Point(733, 423);
            this.backAddCosm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backAddCosm.Name = "backAddCosm";
            this.backAddCosm.Size = new System.Drawing.Size(180, 47);
            this.backAddCosm.TabIndex = 42;
            this.backAddCosm.Text = "Назад";
            this.backAddCosm.UseVisualStyleBackColor = true;
            this.backAddCosm.Click += new System.EventHandler(this.backAddCosm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(337, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Редактирование заказа";
            // 
            // priceOrder
            // 
            this.priceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceOrder.Location = new System.Drawing.Point(397, 335);
            this.priceOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceOrder.Name = "priceOrder";
            this.priceOrder.Size = new System.Drawing.Size(516, 34);
            this.priceOrder.TabIndex = 49;
            // 
            // Wt
            // 
            this.Wt.AutoSize = true;
            this.Wt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wt.Location = new System.Drawing.Point(153, 340);
            this.Wt.Name = "Wt";
            this.Wt.Size = new System.Drawing.Size(72, 29);
            this.Wt.TabIndex = 48;
            this.Wt.Text = "Цена";
            // 
            // countOrder
            // 
            this.countOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOrder.Location = new System.Drawing.Point(397, 258);
            this.countOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countOrder.Name = "countOrder";
            this.countOrder.Size = new System.Drawing.Size(515, 34);
            this.countOrder.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(153, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(153, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 44;
            this.label2.Text = "Товар";
            // 
            // productOrder
            // 
            this.productOrder.FormattingEnabled = true;
            this.productOrder.Location = new System.Drawing.Point(397, 185);
            this.productOrder.Name = "productOrder";
            this.productOrder.Size = new System.Drawing.Size(502, 24);
            this.productOrder.TabIndex = 50;
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.productOrder);
            this.Controls.Add(this.priceOrder);
            this.Controls.Add(this.Wt);
            this.Controls.Add(this.countOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNewCosm);
            this.Controls.Add(this.backAddCosm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewCosm;
        private System.Windows.Forms.Button backAddCosm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceOrder;
        private System.Windows.Forms.Label Wt;
        private System.Windows.Forms.TextBox countOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productOrder;
    }
}