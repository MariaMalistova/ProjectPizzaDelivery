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
    public partial class fmEditCustomer : Form
    {
        fmBase parent;
        public fmEditCustomer(fmBase parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public void FillCustomerEdit(int idCustomer, string Sur, string Name, string Patr, string Phone, string Adress)
        {
            tbId.Text = idCustomer.ToString();
            tbCusSur.Text = Sur;
            tbCusName.Text = Name;
            tbCusPatr.Text = Patr;
            mtbCustPhone.Text = Phone;
            tbCustAdress.Text = Adress;
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

        private void mtbCustPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.DigitsOnly(e);
        }

        private void btEditCustomer_Click(object sender, EventArgs e)
        {
            if (!(tbCusSur.Text.Trim() == "" || tbCusName.Text.Trim() == "" || tbCusPatr.Text.Trim() == "" || tbCustAdress.Text.Trim() == ""))
            {
                string Surname = Procedures.TitleText(tbCusSur);
                string Name = Procedures.TitleText(tbCusName);
                string Patron = Procedures.TitleText(tbCusPatr);

                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "EditCustomer";

                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = tbId.Text;

                command.Parameters.Add("@Surname", SqlDbType.VarChar);
                command.Parameters["@Surname"].Value = Surname;

                command.Parameters.Add("@Name", SqlDbType.VarChar);
                command.Parameters["@Name"].Value = Name;

                command.Parameters.Add("@Patron", SqlDbType.VarChar);
                command.Parameters["@Patron"].Value = Patron;

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
                parent.UpdateCustomerList();
                MessageBox.Show(this, "Изменения сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void fmEditCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
