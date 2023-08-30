namespace PizzaDelivery
{
    partial class fmAddPoint
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
            this.tbAddPoint = new System.Windows.Forms.TextBox();
            this.btAddPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите адрес пункта";
            // 
            // tbAddPoint
            // 
            this.tbAddPoint.Location = new System.Drawing.Point(43, 58);
            this.tbAddPoint.Name = "tbAddPoint";
            this.tbAddPoint.Size = new System.Drawing.Size(469, 22);
            this.tbAddPoint.TabIndex = 1;
            // 
            // btAddPoint
            // 
            this.btAddPoint.Location = new System.Drawing.Point(43, 103);
            this.btAddPoint.Name = "btAddPoint";
            this.btAddPoint.Size = new System.Drawing.Size(129, 29);
            this.btAddPoint.TabIndex = 2;
            this.btAddPoint.Text = "Сохранить";
            this.btAddPoint.UseVisualStyleBackColor = true;
            this.btAddPoint.Click += new System.EventHandler(this.btAddPoint_Click);
            // 
            // fmAddPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 161);
            this.Controls.Add(this.btAddPoint);
            this.Controls.Add(this.tbAddPoint);
            this.Controls.Add(this.label1);
            this.Name = "fmAddPoint";
            this.Text = "Добавить пункт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddPoint;
        private System.Windows.Forms.Button btAddPoint;
    }
}