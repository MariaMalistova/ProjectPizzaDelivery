namespace PizzaDelivery
{
    partial class fmAddPizza
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
            this.tbSetPizzaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSetPizzaMass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSetPizzaPrice = new System.Windows.Forms.TextBox();
            this.btPizzaSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tbSetPizzaName
            // 
            this.tbSetPizzaName.Location = new System.Drawing.Point(164, 43);
            this.tbSetPizzaName.Name = "tbSetPizzaName";
            this.tbSetPizzaName.Size = new System.Drawing.Size(149, 22);
            this.tbSetPizzaName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Масса";
            // 
            // tbSetPizzaMass
            // 
            this.tbSetPizzaMass.Location = new System.Drawing.Point(164, 92);
            this.tbSetPizzaMass.MaxLength = 4;
            this.tbSetPizzaMass.Name = "tbSetPizzaMass";
            this.tbSetPizzaMass.Size = new System.Drawing.Size(149, 22);
            this.tbSetPizzaMass.TabIndex = 3;
            this.tbSetPizzaMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSetPizzaMass_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // tbSetPizzaPrice
            // 
            this.tbSetPizzaPrice.Location = new System.Drawing.Point(164, 141);
            this.tbSetPizzaPrice.MaxLength = 5;
            this.tbSetPizzaPrice.Name = "tbSetPizzaPrice";
            this.tbSetPizzaPrice.Size = new System.Drawing.Size(149, 22);
            this.tbSetPizzaPrice.TabIndex = 5;
            this.tbSetPizzaPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSetPizzaPrice_KeyPress);
            // 
            // btPizzaSave
            // 
            this.btPizzaSave.Location = new System.Drawing.Point(34, 193);
            this.btPizzaSave.Name = "btPizzaSave";
            this.btPizzaSave.Size = new System.Drawing.Size(134, 47);
            this.btPizzaSave.TabIndex = 6;
            this.btPizzaSave.Text = "Сохранить";
            this.btPizzaSave.UseVisualStyleBackColor = true;
            this.btPizzaSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmAddPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 286);
            this.Controls.Add(this.btPizzaSave);
            this.Controls.Add(this.tbSetPizzaPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSetPizzaMass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSetPizzaName);
            this.Controls.Add(this.label1);
            this.Name = "fmAddPizza";
            this.Text = "Добавить пиццу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSetPizzaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSetPizzaMass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSetPizzaPrice;
        private System.Windows.Forms.Button btPizzaSave;
    }
}