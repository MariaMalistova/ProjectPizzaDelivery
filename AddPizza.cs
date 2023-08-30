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
    public partial class fmAddPizza : Form
    {
        fmPizzaList parent;
        public fmAddPizza(fmPizzaList parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void tbSetPizzaPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.DigitsOnly(e);
        }

        private void tbSetPizzaMass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.DigitsOnly(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(tbSetPizzaMass.Text.Trim() == "" || tbSetPizzaName.Text.Trim() == "" || tbSetPizzaPrice.Text.Trim()==""))
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddPizza";

                command.Parameters.Add("@Name", SqlDbType.VarChar);
                command.Parameters["@Name"].Value = tbSetPizzaName.Text.Trim();

                command.Parameters.Add("@Mass", SqlDbType.Float);
                command.Parameters["@Mass"].Value = tbSetPizzaMass.Text;

                command.Parameters.Add("@Price", SqlDbType.Money);
                command.Parameters["@Price"].Value = tbSetPizzaPrice.Text;

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(this, "Пицца добавлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parent.UpdatePizzaList();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

    }
}
