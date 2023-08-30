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
    public partial class fmAddPizzaInPrder : Form
    {
        fmAddOrder parent;
        public fmAddPizzaInPrder(fmAddOrder parent)
        {
            InitializeComponent();
            this.parent = parent;
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select Название From Пицца WHERE Доступна_к_Заказу = 1";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbPizzaList.Items.Add(reader["Название"].ToString());

            }
            reader.Close();
            con.Close();
        }

        private void cbPizzaList_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbPizzaNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.DigitsOnly(e);
        }

        private void btPizzaOrderSAve_Click(object sender, EventArgs e)
        {
            if (!(cbPizzaList.Text == "" || numPizza.Text == ""))
            {
                string PizzaName = cbPizzaList.Text;
                int PizzaNum = Int32.Parse(numPizza.Text);
                parent.AddPizzaOrder(PizzaName, PizzaNum);
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbPizzaList_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select Цена From Пицца WHERE Название = @Name";

            cmd.Parameters.Add("@Name", SqlDbType.VarChar);
            cmd.Parameters["@Name"].Value = cbPizzaList.Text;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbPizzaPrice.Text = reader["Цена"].ToString();
            }
            reader.Close();

            con.Close();      
        }
    }
}
