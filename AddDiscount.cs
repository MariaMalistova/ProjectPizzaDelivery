using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PizzaDelivery
{
    public partial class fmAddDiscount : Form
    {
        fmDiscount parent;
        public fmAddDiscount(fmDiscount parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btSaveDiscount_Click(object sender, EventArgs e)
        {
            if (!(tbType.Text.Trim() == "" || tbPercent.Text == "") && Int32.Parse(tbPercent.Text) <= 100)
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddDiscount";

                command.Parameters.Add("@Type", SqlDbType.VarChar);
                command.Parameters["@Type"].Value = tbType.Text;

                command.Parameters.Add("@Persent", SqlDbType.Float);
                command.Parameters["@Persent"].Value = tbPercent.Text;

                command.ExecuteNonQuery();
                con.Close();
                parent.UpdateDiscountList();
                MessageBox.Show(this, "Скидка добавлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tbPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.DigitsOnly(e);
        }
    }
}
