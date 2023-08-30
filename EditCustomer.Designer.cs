namespace PizzaDelivery
{
    partial class fmEditCustomer
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
            this.mtbCustPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbCustAdress = new System.Windows.Forms.TextBox();
            this.tbCusPatr = new System.Windows.Forms.TextBox();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.tbCusSur = new System.Windows.Forms.TextBox();
            this.btEditCustomer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mtbCustPhone
            // 
            this.mtbCustPhone.Location = new System.Drawing.Point(158, 191);
            this.mtbCustPhone.Mask = "8 (999) 000-0000";
            this.mtbCustPhone.Name = "mtbCustPhone";
            this.mtbCustPhone.Size = new System.Drawing.Size(246, 22);
            this.mtbCustPhone.TabIndex = 22;
            this.mtbCustPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCustPhone_KeyPress);
            // 
            // tbCustAdress
            // 
            this.tbCustAdress.Location = new System.Drawing.Point(158, 242);
            this.tbCustAdress.Name = "tbCustAdress";
            this.tbCustAdress.Size = new System.Drawing.Size(246, 22);
            this.tbCustAdress.TabIndex = 21;
            // 
            // tbCusPatr
            // 
            this.tbCusPatr.Location = new System.Drawing.Point(158, 131);
            this.tbCusPatr.Name = "tbCusPatr";
            this.tbCusPatr.Size = new System.Drawing.Size(246, 22);
            this.tbCusPatr.TabIndex = 20;
            this.tbCusPatr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCusPatr_KeyPress);
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(158, 75);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(246, 22);
            this.tbCusName.TabIndex = 19;
            this.tbCusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCusName_KeyPress);
            // 
            // tbCusSur
            // 
            this.tbCusSur.Location = new System.Drawing.Point(158, 19);
            this.tbCusSur.Name = "tbCusSur";
            this.tbCusSur.Size = new System.Drawing.Size(246, 22);
            this.tbCusSur.TabIndex = 18;
            this.tbCusSur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCusSur_KeyPress);
            // 
            // btEditCustomer
            // 
            this.btEditCustomer.Location = new System.Drawing.Point(52, 293);
            this.btEditCustomer.Name = "btEditCustomer";
            this.btEditCustomer.Size = new System.Drawing.Size(164, 42);
            this.btEditCustomer.TabIndex = 17;
            this.btEditCustomer.Text = "Сохранить";
            this.btEditCustomer.UseVisualStyleBackColor = true;
            this.btEditCustomer.Click += new System.EventHandler(this.btEditCustomer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Фамилия";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(299, 308);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 23;
            this.tbId.Visible = false;
            // 
            // fmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 354);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.mtbCustPhone);
            this.Controls.Add(this.tbCustAdress);
            this.Controls.Add(this.tbCusPatr);
            this.Controls.Add(this.tbCusName);
            this.Controls.Add(this.tbCusSur);
            this.Controls.Add(this.btEditCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmEditCustomer";
            this.Text = "Редактировать";
            this.Load += new System.EventHandler(this.fmEditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCustPhone;
        private System.Windows.Forms.TextBox tbCustAdress;
        private System.Windows.Forms.TextBox tbCusPatr;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.TextBox tbCusSur;
        private System.Windows.Forms.Button btEditCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
    }
}