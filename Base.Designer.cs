namespace PizzaDelivery
{
    partial class fmBase
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPoint = new System.Windows.Forms.TabPage();
            this.btDeletePoint = new System.Windows.Forms.Button();
            this.btAddPiont = new System.Windows.Forms.Button();
            this.dgPoint = new System.Windows.Forms.DataGridView();
            this.кодПунктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставка_пиццыDataSet = new PizzaDelivery.Доставка_пиццыDataSet();
            this.tabDelivman = new System.Windows.Forms.TabPage();
            this.btDeleteDelivman = new System.Windows.Forms.Button();
            this.btAddDeliverman = new System.Windows.Forms.Button();
            this.dgDelivermanList = new System.Windows.Forms.DataGridView();
            this.tbCustomers = new System.Windows.Forms.TabPage();
            this.btAddCustomer = new System.Windows.Forms.Button();
            this.dgCustomerList = new System.Windows.Forms.DataGridView();
            this.кодПокупателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.покупательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пунктTableAdapter = new PizzaDelivery.Доставка_пиццыDataSetTableAdapters.ПунктTableAdapter();
            this.tableAdapterManager = new PizzaDelivery.Доставка_пиццыDataSetTableAdapters.TableAdapterManager();
            this.покупательTableAdapter = new PizzaDelivery.Доставка_пиццыDataSetTableAdapters.ПокупательTableAdapter();
            this.btDeleteCustomer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пунктBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставка_пиццыDataSet)).BeginInit();
            this.tabDelivman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivermanList)).BeginInit();
            this.tbCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpPoint);
            this.tabControl1.Controls.Add(this.tabDelivman);
            this.tabControl1.Controls.Add(this.tbCustomers);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpPoint
            // 
            this.tbpPoint.Controls.Add(this.btDeletePoint);
            this.tbpPoint.Controls.Add(this.btAddPiont);
            this.tbpPoint.Controls.Add(this.dgPoint);
            this.tbpPoint.Location = new System.Drawing.Point(4, 25);
            this.tbpPoint.Name = "tbpPoint";
            this.tbpPoint.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPoint.Size = new System.Drawing.Size(909, 396);
            this.tbpPoint.TabIndex = 0;
            this.tbpPoint.Text = "Пункты";
            this.tbpPoint.UseVisualStyleBackColor = true;
            // 
            // btDeletePoint
            // 
            this.btDeletePoint.Enabled = false;
            this.btDeletePoint.Location = new System.Drawing.Point(182, 342);
            this.btDeletePoint.Name = "btDeletePoint";
            this.btDeletePoint.Size = new System.Drawing.Size(129, 38);
            this.btDeletePoint.TabIndex = 2;
            this.btDeletePoint.Text = "Удалить";
            this.btDeletePoint.UseVisualStyleBackColor = true;
            this.btDeletePoint.Click += new System.EventHandler(this.btDeletePoint_Click);
            // 
            // btAddPiont
            // 
            this.btAddPiont.Location = new System.Drawing.Point(18, 342);
            this.btAddPiont.Name = "btAddPiont";
            this.btAddPiont.Size = new System.Drawing.Size(129, 38);
            this.btAddPiont.TabIndex = 1;
            this.btAddPiont.Text = "Добавить";
            this.btAddPiont.UseVisualStyleBackColor = true;
            this.btAddPiont.Click += new System.EventHandler(this.btAddPiont_Click);
            // 
            // dgPoint
            // 
            this.dgPoint.AllowUserToAddRows = false;
            this.dgPoint.AllowUserToDeleteRows = false;
            this.dgPoint.AutoGenerateColumns = false;
            this.dgPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПунктаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.dgPoint.DataSource = this.пунктBindingSource;
            this.dgPoint.Location = new System.Drawing.Point(18, 19);
            this.dgPoint.Name = "dgPoint";
            this.dgPoint.ReadOnly = true;
            this.dgPoint.RowTemplate.Height = 24;
            this.dgPoint.Size = new System.Drawing.Size(741, 302);
            this.dgPoint.TabIndex = 0;
            this.dgPoint.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPoint_CellClick);
            this.dgPoint.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPoint_CellDoubleClick);
            // 
            // кодПунктаDataGridViewTextBoxColumn
            // 
            this.кодПунктаDataGridViewTextBoxColumn.DataPropertyName = "Код_Пункта";
            this.кодПунктаDataGridViewTextBoxColumn.HeaderText = "Код_Пункта";
            this.кодПунктаDataGridViewTextBoxColumn.Name = "кодПунктаDataGridViewTextBoxColumn";
            this.кодПунктаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            this.адресDataGridViewTextBoxColumn.Width = 368;
            // 
            // пунктBindingSource
            // 
            this.пунктBindingSource.DataMember = "Пункт";
            this.пунктBindingSource.DataSource = this.доставка_пиццыDataSet;
            // 
            // доставка_пиццыDataSet
            // 
            this.доставка_пиццыDataSet.DataSetName = "Доставка_пиццыDataSet";
            this.доставка_пиццыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabDelivman
            // 
            this.tabDelivman.Controls.Add(this.btDeleteDelivman);
            this.tabDelivman.Controls.Add(this.btAddDeliverman);
            this.tabDelivman.Controls.Add(this.dgDelivermanList);
            this.tabDelivman.Location = new System.Drawing.Point(4, 25);
            this.tabDelivman.Name = "tabDelivman";
            this.tabDelivman.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelivman.Size = new System.Drawing.Size(909, 396);
            this.tabDelivman.TabIndex = 1;
            this.tabDelivman.Text = "Курьеры";
            this.tabDelivman.UseVisualStyleBackColor = true;
            // 
            // btDeleteDelivman
            // 
            this.btDeleteDelivman.Enabled = false;
            this.btDeleteDelivman.Location = new System.Drawing.Point(158, 344);
            this.btDeleteDelivman.Name = "btDeleteDelivman";
            this.btDeleteDelivman.Size = new System.Drawing.Size(129, 36);
            this.btDeleteDelivman.TabIndex = 3;
            this.btDeleteDelivman.Text = "Удалить";
            this.btDeleteDelivman.UseVisualStyleBackColor = true;
            this.btDeleteDelivman.Click += new System.EventHandler(this.btDeleteDelivman_Click);
            // 
            // btAddDeliverman
            // 
            this.btAddDeliverman.Location = new System.Drawing.Point(20, 344);
            this.btAddDeliverman.Name = "btAddDeliverman";
            this.btAddDeliverman.Size = new System.Drawing.Size(109, 36);
            this.btAddDeliverman.TabIndex = 2;
            this.btAddDeliverman.Text = "Добавить";
            this.btAddDeliverman.UseVisualStyleBackColor = true;
            this.btAddDeliverman.Click += new System.EventHandler(this.btAddDeliverman_Click);
            // 
            // dgDelivermanList
            // 
            this.dgDelivermanList.AllowUserToAddRows = false;
            this.dgDelivermanList.AllowUserToDeleteRows = false;
            this.dgDelivermanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDelivermanList.Location = new System.Drawing.Point(20, 20);
            this.dgDelivermanList.Name = "dgDelivermanList";
            this.dgDelivermanList.ReadOnly = true;
            this.dgDelivermanList.RowTemplate.Height = 24;
            this.dgDelivermanList.Size = new System.Drawing.Size(773, 306);
            this.dgDelivermanList.TabIndex = 1;
            this.dgDelivermanList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDelivermanList_CellClick);
            this.dgDelivermanList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDelivermanList_CellDoubleClick);
            // 
            // tbCustomers
            // 
            this.tbCustomers.Controls.Add(this.btDeleteCustomer);
            this.tbCustomers.Controls.Add(this.btAddCustomer);
            this.tbCustomers.Controls.Add(this.dgCustomerList);
            this.tbCustomers.Location = new System.Drawing.Point(4, 25);
            this.tbCustomers.Name = "tbCustomers";
            this.tbCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tbCustomers.Size = new System.Drawing.Size(909, 396);
            this.tbCustomers.TabIndex = 2;
            this.tbCustomers.Text = "Покупатели";
            this.tbCustomers.UseVisualStyleBackColor = true;
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.Location = new System.Drawing.Point(17, 345);
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(120, 34);
            this.btAddCustomer.TabIndex = 1;
            this.btAddCustomer.Text = "Добавить";
            this.btAddCustomer.UseVisualStyleBackColor = true;
            this.btAddCustomer.Click += new System.EventHandler(this.btAddCustomer_Click);
            // 
            // dgCustomerList
            // 
            this.dgCustomerList.AllowUserToAddRows = false;
            this.dgCustomerList.AllowUserToDeleteRows = false;
            this.dgCustomerList.AutoGenerateColumns = false;
            this.dgCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПокупателяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn1});
            this.dgCustomerList.DataSource = this.покупательBindingSource;
            this.dgCustomerList.Location = new System.Drawing.Point(6, 16);
            this.dgCustomerList.Name = "dgCustomerList";
            this.dgCustomerList.ReadOnly = true;
            this.dgCustomerList.RowTemplate.Height = 24;
            this.dgCustomerList.Size = new System.Drawing.Size(875, 314);
            this.dgCustomerList.TabIndex = 0;
            this.dgCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomerList_CellClick);
            this.dgCustomerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomerList_CellDoubleClick);
            // 
            // кодПокупателяDataGridViewTextBoxColumn
            // 
            this.кодПокупателяDataGridViewTextBoxColumn.DataPropertyName = "Код_Покупателя";
            this.кодПокупателяDataGridViewTextBoxColumn.HeaderText = "Код_Покупателя";
            this.кодПокупателяDataGridViewTextBoxColumn.Name = "кодПокупателяDataGridViewTextBoxColumn";
            this.кодПокупателяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn1
            // 
            this.адресDataGridViewTextBoxColumn1.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn1.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn1.Name = "адресDataGridViewTextBoxColumn1";
            this.адресDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // покупательBindingSource
            // 
            this.покупательBindingSource.DataMember = "Покупатель";
            this.покупательBindingSource.DataSource = this.доставка_пиццыDataSet;
            // 
            // пунктTableAdapter
            // 
            this.пунктTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PizzaDelivery.Доставка_пиццыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоставкаTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КурьерTableAdapter = null;
            this.tableAdapterManager.Пицца_в_ЗаказеTableAdapter = null;
            this.tableAdapterManager.ПиццаTableAdapter = null;
            this.tableAdapterManager.ПокупательTableAdapter = null;
            this.tableAdapterManager.ПунктTableAdapter = this.пунктTableAdapter;
            this.tableAdapterManager.СкидкаTableAdapter = null;
            this.tableAdapterManager.Статус_ЗаказаTableAdapter = null;
            // 
            // покупательTableAdapter
            // 
            this.покупательTableAdapter.ClearBeforeFill = true;
            // 
            // btDeleteCustomer
            // 
            this.btDeleteCustomer.Enabled = false;
            this.btDeleteCustomer.Location = new System.Drawing.Point(173, 343);
            this.btDeleteCustomer.Name = "btDeleteCustomer";
            this.btDeleteCustomer.Size = new System.Drawing.Size(129, 36);
            this.btDeleteCustomer.TabIndex = 4;
            this.btDeleteCustomer.Text = "Удалить";
            this.btDeleteCustomer.UseVisualStyleBackColor = true;
            this.btDeleteCustomer.Click += new System.EventHandler(this.btDeleteCustomer_Click);
            // 
            // fmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "fmBase";
            this.Text = "Базы данных";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пунктBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставка_пиццыDataSet)).EndInit();
            this.tabDelivman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivermanList)).EndInit();
            this.tbCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPoint;
        private System.Windows.Forms.DataGridView dgPoint;
        private System.Windows.Forms.TabPage tabDelivman;
        private Доставка_пиццыDataSet доставка_пиццыDataSet;
        private System.Windows.Forms.BindingSource пунктBindingSource;
        private Доставка_пиццыDataSetTableAdapters.ПунктTableAdapter пунктTableAdapter;
        private Доставка_пиццыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btAddPiont;
        private System.Windows.Forms.DataGridView dgDelivermanList;
        private System.Windows.Forms.Button btAddDeliverman;
        private System.Windows.Forms.TabPage tbCustomers;
        private System.Windows.Forms.DataGridView dgCustomerList;
        private System.Windows.Forms.BindingSource покупательBindingSource;
        private Доставка_пиццыDataSetTableAdapters.ПокупательTableAdapter покупательTableAdapter;
        private System.Windows.Forms.Button btAddCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПокупателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПунктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btDeletePoint;
        private System.Windows.Forms.Button btDeleteDelivman;
        private System.Windows.Forms.Button btDeleteCustomer;
    }
}