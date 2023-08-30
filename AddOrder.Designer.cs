namespace PizzaDelivery
{
    partial class fmAddOrder
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
            this.dgPizzaOrderList = new System.Windows.Forms.DataGridView();
            this.ColPizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAddPizza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDeliveryman = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDelivery = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPoint = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.btSaveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPizzaOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPizzaOrderList
            // 
            this.dgPizzaOrderList.AllowUserToAddRows = false;
            this.dgPizzaOrderList.AllowUserToDeleteRows = false;
            this.dgPizzaOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPizzaOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPizza,
            this.ColNum});
            this.dgPizzaOrderList.Location = new System.Drawing.Point(22, 31);
            this.dgPizzaOrderList.Name = "dgPizzaOrderList";
            this.dgPizzaOrderList.ReadOnly = true;
            this.dgPizzaOrderList.RowTemplate.Height = 24;
            this.dgPizzaOrderList.Size = new System.Drawing.Size(362, 249);
            this.dgPizzaOrderList.TabIndex = 0;
            this.dgPizzaOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPizzaOrderList_CellDoubleClick);
            // 
            // ColPizza
            // 
            this.ColPizza.Frozen = true;
            this.ColPizza.HeaderText = "Пицца";
            this.ColPizza.Name = "ColPizza";
            this.ColPizza.ReadOnly = true;
            this.ColPizza.Width = 150;
            // 
            // ColNum
            // 
            this.ColNum.Frozen = true;
            this.ColNum.HeaderText = "Количество";
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
            // 
            // btAddPizza
            // 
            this.btAddPizza.Location = new System.Drawing.Point(22, 307);
            this.btAddPizza.Name = "btAddPizza";
            this.btAddPizza.Size = new System.Drawing.Size(144, 36);
            this.btAddPizza.TabIndex = 1;
            this.btAddPizza.Text = "Добавить пиццу";
            this.btAddPizza.UseVisualStyleBackColor = true;
            this.btAddPizza.Click += new System.EventHandler(this.btAddPizza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Покупатель";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(466, 64);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 24);
            this.cbCustomer.TabIndex = 3;
            this.cbCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCustomer_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Курьер";
            this.label2.Visible = false;
            // 
            // cbDeliveryman
            // 
            this.cbDeliveryman.FormattingEnabled = true;
            this.cbDeliveryman.Location = new System.Drawing.Point(644, 234);
            this.cbDeliveryman.Name = "cbDeliveryman";
            this.cbDeliveryman.Size = new System.Drawing.Size(121, 24);
            this.cbDeliveryman.TabIndex = 5;
            this.cbDeliveryman.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Доставка";
            // 
            // cbDelivery
            // 
            this.cbDelivery.FormattingEnabled = true;
            this.cbDelivery.Location = new System.Drawing.Point(466, 159);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(121, 24);
            this.cbDelivery.TabIndex = 7;
            this.cbDelivery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDelivery_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пункт";
            // 
            // cbPoint
            // 
            this.cbPoint.FormattingEnabled = true;
            this.cbPoint.Location = new System.Drawing.Point(644, 64);
            this.cbPoint.Name = "cbPoint";
            this.cbPoint.Size = new System.Drawing.Size(121, 24);
            this.cbPoint.TabIndex = 9;
            this.cbPoint.TextChanged += new System.EventHandler(this.cbPoint_TextChanged);
            this.cbPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPoint_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Скидка";
            // 
            // cbDiscount
            // 
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Location = new System.Drawing.Point(644, 159);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(121, 24);
            this.cbDiscount.TabIndex = 12;
            this.cbDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDiscount_KeyPress);
            // 
            // btSaveOrder
            // 
            this.btSaveOrder.Location = new System.Drawing.Point(653, 303);
            this.btSaveOrder.Name = "btSaveOrder";
            this.btSaveOrder.Size = new System.Drawing.Size(112, 40);
            this.btSaveOrder.TabIndex = 13;
            this.btSaveOrder.Text = "Сохранить";
            this.btSaveOrder.UseVisualStyleBackColor = true;
            this.btSaveOrder.Click += new System.EventHandler(this.btSaveOrder_Click);
            // 
            // fmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 374);
            this.Controls.Add(this.btSaveOrder);
            this.Controls.Add(this.cbDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDelivery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDeliveryman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddPizza);
            this.Controls.Add(this.dgPizzaOrderList);
            this.Name = "fmAddOrder";
            this.Text = "Добавить заказ";
            ((System.ComponentModel.ISupportInitialize)(this.dgPizzaOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPizzaOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.Button btAddPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDeliveryman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDelivery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.Button btSaveOrder;
    }
}