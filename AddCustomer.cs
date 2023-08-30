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
    public partial class fmAddCustomer : Form
    {
        fmBase parent;
        public fmAddCustomer(fmBase parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            if (!(tbCusSur.Text.Trim() == "" || tbCusName.Text.Trim() == "" || tbCusPatr.Text.Trim() == "" || tbCustAdress.Text.Trim() == ""))
            {
                string Sur = Procedures.TitleText(tbCusSur);
                string Name = Procedures.TitleText(tbCusName);
                string Patr = Procedures.TitleText(tbCusPatr);

                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddCustomer";

                command.Parameters.Add("@Sur", SqlDbType.VarChar);
                command.Parameters["@Sur"].Value = Sur;

                command.Parameters.Add("@Name", SqlDbType.VarChar);
                command.Parameters["@Name"].Value = Name;

                command.Parameters.Add("@Patr", SqlDbType.VarChar);
                command.Parameters["@Patr"].Value = Patr;

                command.Parameters.Add("@Phone", SqlDbType.VarChar);

                if (mtbCustPhone.Text.Length == 16)
                {
                    command.Parameters["@Phone"].Value = mtbCustPhone.Text;
                }
                else
                {
                    command.Parameters["@Phone"].Value = "";
                }

                command.Parameters.Add("@Adress", SqlDbType.VarChar);
                command.Parameters["@Adress"].Value = tbCustAdress.Text.Trim();

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(this, "Покупатель добавлен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parent.UpdateCustomerList();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tbCusSur_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.LetterOnly(e);
        }

        private void tbCusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.LetterOnly(e);
        }

        private void tbCusPatr_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.LetterOnly(e);
        }

        private void tbCustPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
        Procedures.DigitsOnly(e);
        }
    }
}
