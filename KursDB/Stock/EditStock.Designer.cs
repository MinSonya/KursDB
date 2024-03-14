
namespace KursDB
{
    partial class EditStock
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
            this.countStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNewCosm
            // 
            this.addNewCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewCosm.Location = new System.Drawing.Point(401, 311);
            this.addNewCosm.Margin = new System.Windows.Forms.Padding(2);
            this.addNewCosm.Name = "addNewCosm";
            this.addNewCosm.Size = new System.Drawing.Size(135, 38);
            this.addNewCosm.TabIndex = 28;
            this.addNewCosm.Text = "Сохранить";
            this.addNewCosm.UseVisualStyleBackColor = true;
            this.addNewCosm.Click += new System.EventHandler(this.addNewCosm_Click);
            // 
            // backAddCosm
            // 
            this.backAddCosm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backAddCosm.Location = new System.Drawing.Point(550, 311);
            this.backAddCosm.Margin = new System.Windows.Forms.Padding(2);
            this.backAddCosm.Name = "backAddCosm";
            this.backAddCosm.Size = new System.Drawing.Size(135, 38);
            this.backAddCosm.TabIndex = 27;
            this.backAddCosm.Text = "Назад";
            this.backAddCosm.UseVisualStyleBackColor = true;
            this.backAddCosm.Click += new System.EventHandler(this.backAddCosm_Click);
            // 
            // countStock
            // 
            this.countStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countStock.Location = new System.Drawing.Point(343, 240);
            this.countStock.Margin = new System.Windows.Forms.Padding(2);
            this.countStock.Name = "countStock";
            this.countStock.Size = new System.Drawing.Size(342, 28);
            this.countStock.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(115, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Количество";
            // 
            // nameStock
            // 
            this.nameStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameStock.Location = new System.Drawing.Point(343, 181);
            this.nameStock.Margin = new System.Windows.Forms.Padding(2);
            this.nameStock.Name = "nameStock";
            this.nameStock.Size = new System.Drawing.Size(342, 28);
            this.nameStock.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Наименование товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(232, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Изменение товара на склад";
            // 
            // EditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewCosm);
            this.Controls.Add(this.backAddCosm);
            this.Controls.Add(this.countStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditStock";
            this.Text = "EditStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewCosm;
        private System.Windows.Forms.Button backAddCosm;
        private System.Windows.Forms.TextBox countStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}