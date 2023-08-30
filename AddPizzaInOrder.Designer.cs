namespace PizzaDelivery
{
    partial class fmAddPizzaInPrder
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
            this.cbPizzaList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btPizzaOrderSAve = new System.Windows.Forms.Button();
            this.numPizza = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPizzaPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPizzaList
            // 
            this.cbPizzaList.FormattingEnabled = true;
            this.cbPizzaList.Location = new System.Drawing.Point(131, 45);
            this.cbPizzaList.Name = "cbPizzaList";
            this.cbPizzaList.Size = new System.Drawing.Size(146, 24);
            this.cbPizzaList.TabIndex = 0;
            this.cbPizzaList.TextChanged += new System.EventHandler(this.cbPizzaList_TextChanged);
            this.cbPizzaList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPizzaList_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пицца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество";
            // 
            // btPizzaOrderSAve
            // 
            this.btPizzaOrderSAve.Location = new System.Drawing.Point(35, 175);
            this.btPizzaOrderSAve.Name = "btPizzaOrderSAve";
            this.btPizzaOrderSAve.Size = new System.Drawing.Size(124, 36);
            this.btPizzaOrderSAve.TabIndex = 4;
            this.btPizzaOrderSAve.Text = "Добавить";
            this.btPizzaOrderSAve.UseVisualStyleBackColor = true;
            this.btPizzaOrderSAve.Click += new System.EventHandler(this.btPizzaOrderSAve_Click);
            // 
            // numPizza
            // 
            this.numPizza.Location = new System.Drawing.Point(131, 110);
            this.numPizza.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numPizza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPizza.Name = "numPizza";
            this.numPizza.Size = new System.Drawing.Size(52, 22);
            this.numPizza.TabIndex = 5;
            this.numPizza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена:";
            // 
            // lbPizzaPrice
            // 
            this.lbPizzaPrice.AutoSize = true;
            this.lbPizzaPrice.Location = new System.Drawing.Point(370, 48);
            this.lbPizzaPrice.Name = "lbPizzaPrice";
            this.lbPizzaPrice.Size = new System.Drawing.Size(0, 17);
            this.lbPizzaPrice.TabIndex = 7;
            // 
            // fmAddPizzaInPrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 234);
            this.Controls.Add(this.lbPizzaPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPizza);
            this.Controls.Add(this.btPizzaOrderSAve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPizzaList);
            this.Name = "fmAddPizzaInPrder";
            this.Text = "Добавить пиццу в заказ";
            ((System.ComponentModel.ISupportInitialize)(this.numPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPizzaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPizzaOrderSAve;
        private System.Windows.Forms.NumericUpDown numPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPizzaPrice;
    }
}