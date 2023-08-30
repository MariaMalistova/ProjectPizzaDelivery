namespace PizzaDelivery
{
    partial class fmAddDeliverman
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
            this.tbAddDelSur = new System.Windows.Forms.TextBox();
            this.tbAddDelName = new System.Windows.Forms.TextBox();
            this.tbAddDelPatr = new System.Windows.Forms.TextBox();
            this.cbAddDelivPoint = new System.Windows.Forms.ComboBox();
            this.btSaveDeliverman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пункт";
            // 
            // tbAddDelSur
            // 
            this.tbAddDelSur.Location = new System.Drawing.Point(138, 41);
            this.tbAddDelSur.Name = "tbAddDelSur";
            this.tbAddDelSur.Size = new System.Drawing.Size(216, 22);
            this.tbAddDelSur.TabIndex = 4;
            this.tbAddDelSur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddDelSur_KeyPress);
            // 
            // tbAddDelName
            // 
            this.tbAddDelName.Location = new System.Drawing.Point(138, 94);
            this.tbAddDelName.Name = "tbAddDelName";
            this.tbAddDelName.Size = new System.Drawing.Size(216, 22);
            this.tbAddDelName.TabIndex = 5;
            this.tbAddDelName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddDelName_KeyPress);
            // 
            // tbAddDelPatr
            // 
            this.tbAddDelPatr.Location = new System.Drawing.Point(138, 149);
            this.tbAddDelPatr.Name = "tbAddDelPatr";
            this.tbAddDelPatr.Size = new System.Drawing.Size(216, 22);
            this.tbAddDelPatr.TabIndex = 6;
            // 
            // cbAddDelivPoint
            // 
            this.cbAddDelivPoint.FormattingEnabled = true;
            this.cbAddDelivPoint.Location = new System.Drawing.Point(138, 201);
            this.cbAddDelivPoint.Name = "cbAddDelivPoint";
            this.cbAddDelivPoint.Size = new System.Drawing.Size(216, 24);
            this.cbAddDelivPoint.TabIndex = 7;
            this.cbAddDelivPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAddDelivPoint_KeyPress);
            // 
            // btSaveDeliverman
            // 
            this.btSaveDeliverman.Location = new System.Drawing.Point(43, 270);
            this.btSaveDeliverman.Name = "btSaveDeliverman";
            this.btSaveDeliverman.Size = new System.Drawing.Size(142, 39);
            this.btSaveDeliverman.TabIndex = 8;
            this.btSaveDeliverman.Text = "Сохранить";
            this.btSaveDeliverman.UseVisualStyleBackColor = true;
            this.btSaveDeliverman.Click += new System.EventHandler(this.btSaveDeliverman_Click);
            // 
            // fmAddDeliverman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 354);
            this.Controls.Add(this.btSaveDeliverman);
            this.Controls.Add(this.cbAddDelivPoint);
            this.Controls.Add(this.tbAddDelPatr);
            this.Controls.Add(this.tbAddDelName);
            this.Controls.Add(this.tbAddDelSur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmAddDeliverman";
            this.Text = "Добавить курьера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddDelSur;
        private System.Windows.Forms.TextBox tbAddDelName;
        private System.Windows.Forms.TextBox tbAddDelPatr;
        private System.Windows.Forms.ComboBox cbAddDelivPoint;
        private System.Windows.Forms.Button btSaveDeliverman;
    }
}