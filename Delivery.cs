using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class fmDelivery : Form
    {
        public fmDelivery()
        {
            InitializeComponent();
        }

        private void fmDelivery_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "доставка_пиццыDataSet.Доставка". При необходимости она может быть перемещена или удалена.
            this.доставкаTableAdapter.Fill(this.доставка_пиццыDataSet.Доставка);

        }

        private void dgDelivery_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (rowIndex == 1 && colIndex == 2)
            {
            float DelivePrice = float.Parse(dgDelivery[2, 1].Value.ToString());  
            fmEditDeliveryPrice fmEditDeliveryPrice = new fmEditDeliveryPrice();
            fmEditDeliveryPrice.FilEditDeliveryPrice(DelivePrice);
            fmEditDeliveryPrice.ShowDialog();           
            }

        }
    }
}
