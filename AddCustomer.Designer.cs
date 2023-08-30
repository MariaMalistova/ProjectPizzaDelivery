namespace PizzaDelivery
{
    partial class fmAddCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAddCustomer = new System.Windows.Forms.Button();
            this.tbCusSur = new System.Windows.Forms.TextBox();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.tbCusPatr = new System.Windows.Forms.TextBox();
            this.tbCustAdress = new System.Windows.Forms.TextBox();
            this.mtbCustPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес";
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.Location = new System.Drawing.Point(38, 310);
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(164, 42);
            this.btAddCustomer.TabIndex = 5;
            this.btAddCustomer.Text = "Сохранить";
            this.btAddCustomer.UseVisualStyleBackColor = true;
            this.btAddCustomer.Click += new System.EventHandler(this.btAddCustomer_Click);
            // 
            // tbCusSur
            // 
            this.tbCusSur.Location = new System.Drawing.Point(144, 36);
            this.tbCusSur.Name = "tbCusSur";
            this.tbCusSur.Size = new System.Drawing.Size(246, 22);
            this.tbCusSur.TabIndex = 6;
            this.tbCusSur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCusSur_KeyPress);
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(144, 92);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(246, 22);
            this.tbCusName.TabIndex = 7;
            this.tbCusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCusName_KeyPress);
            // 
            // tbCusPatr
            // 
            this.tbCusPatr.Location = new System.Drawing.Point(144, 148);
            this.tbCusPatr.Name = "tbCusPatr";
            this.tbCusPatr.Size = new System.Drawing.Size(246, 22);
            this.tbCusPatr.TabIndex = 8;
            this.tbCusPatr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCusPatr_KeyPress);
            // 
            // tbCustAdress
            // 
            this.tbCustAdress.Location = new System.Drawing.Point(144, 259);
            this.tbCustAdress.Name = "tbCustAdress";
            this.tbCustAdress.Size = new System.Drawing.Size(246, 22);
            this.tbCustAdress.TabIndex = 10;
            // 
            // mtbCustPhone
            // 
            this.mtbCustPhone.Location = new System.Drawing.Point(144, 208);
            this.mtbCustPhone.Mask = "8 (999) 000-0000";
            this.mtbCustPhone.Name = "mtbCustPhone";
            this.mtbCustPhone.Size = new System.Drawing.Size(246, 22);
            this.mtbCustPhone.TabIndex = 11;
            // 
            // fmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 384);
            this.Controls.Add(this.mtbCustPhone);
            this.Controls.Add(this.tbCustAdress);
            this.Controls.Add(this.tbCusPatr);
            this.Controls.Add(this.tbCusName);
            this.Controls.Add(this.tbCusSur);
            this.Controls.Add(this.btAddCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmAddCustomer";
            this.Text = "Добавить покупателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAddCustomer;
        private System.Windows.Forms.TextBox tbCusSur;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.TextBox tbCusPatr;
        private System.Windows.Forms.TextBox tbCustAdress;
        private System.Windows.Forms.MaskedTextBox mtbCustPhone;
    }
}