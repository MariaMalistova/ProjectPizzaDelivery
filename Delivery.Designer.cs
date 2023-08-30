namespace PizzaDelivery
{
    partial class fmDelivery
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
            this.dgDelivery = new System.Windows.Forms.DataGridView();
            this.кодДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставка_пиццыDataSet = new PizzaDelivery.Доставка_пиццыDataSet();
            this.доставкаTableAdapter = new PizzaDelivery.Доставка_пиццыDataSetTableAdapters.ДоставкаTableAdapter();
            this.tableAdapterManager = new PizzaDelivery.Доставка_пиццыDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставка_пиццыDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDelivery
            // 
            this.dgDelivery.AllowUserToAddRows = false;
            this.dgDelivery.AllowUserToDeleteRows = false;
            this.dgDelivery.AutoGenerateColumns = false;
            this.dgDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодДоставкиDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dgDelivery.DataSource = this.доставкаBindingSource;
            this.dgDelivery.Location = new System.Drawing.Point(12, 29);
            this.dgDelivery.Name = "dgDelivery";
            this.dgDelivery.ReadOnly = true;
            this.dgDelivery.RowTemplate.Height = 24;
            this.dgDelivery.Size = new System.Drawing.Size(552, 268);
            this.dgDelivery.TabIndex = 0;
            this.dgDelivery.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDelivery_CellDoubleClick);
            // 
            // кодДоставкиDataGridViewTextBoxColumn
            // 
            this.кодДоставкиDataGridViewTextBoxColumn.DataPropertyName = "Код_Доставки";
            this.кодДоставкиDataGridViewTextBoxColumn.HeaderText = "Код_Доставки";
            this.кодДоставкиDataGridViewTextBoxColumn.Name = "кодДоставкиDataGridViewTextBoxColumn";
            this.кодДоставкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this.доставка_пиццыDataSet;
            // 
            // доставка_пиццыDataSet
            // 
            this.доставка_пиццыDataSet.DataSetName = "Доставка_пиццыDataSet";
            this.доставка_пиццыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PizzaDelivery.Доставка_пиццыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоставкаTableAdapter = this.доставкаTableAdapter;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КурьерTableAdapter = null;
            this.tableAdapterManager.Пицца_в_ЗаказеTableAdapter = null;
            this.tableAdapterManager.ПиццаTableAdapter = null;
            this.tableAdapterManager.ПокупательTableAdapter = null;
            this.tableAdapterManager.ПунктTableAdapter = null;
            this.tableAdapterManager.СкидкаTableAdapter = null;
            this.tableAdapterManager.Статус_ЗаказаTableAdapter = null;
            // 
            // fmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 334);
            this.Controls.Add(this.dgDelivery);
            this.Name = "fmDelivery";
            this.Text = "Доставка";
            this.Load += new System.EventHandler(this.fmDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставка_пиццыDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDelivery;
        private Доставка_пиццыDataSet доставка_пиццыDataSet;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
        private Доставка_пиццыDataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private Доставка_пиццыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
    }
}