namespace PizzaDelivery
{
    partial class fmAddDiscount
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
            this.btSaveDiscount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSaveDiscount
            // 
            this.btSaveDiscount.Location = new System.Drawing.Point(24, 182);
            this.btSaveDiscount.Name = "btSaveDiscount";
            this.btSaveDiscount.Size = new System.Drawing.Size(121, 40);
            this.btSaveDiscount.TabIndex = 0;
            this.btSaveDiscount.Text = "Сохранить";
            this.btSaveDiscount.UseVisualStyleBackColor = true;
            this.btSaveDiscount.Click += new System.EventHandler(this.btSaveDiscount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Процент";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(143, 41);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(154, 22);
            this.tbType.TabIndex = 3;
            // 
            // tbPercent
            // 
            this.tbPercent.Location = new System.Drawing.Point(143, 104);
            this.tbPercent.MaxLength = 3;
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(100, 22);
            this.tbPercent.TabIndex = 4;
            this.tbPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPercent_KeyPress);
            // 
            // fmAddDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 283);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSaveDiscount);
            this.Name = "fmAddDiscount";
            this.Text = "Добавить скидку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSaveDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbPercent;
    }
}