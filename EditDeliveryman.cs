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
    public partial class fmEditDeliveryman : Form
    {
        fmBase parent;
        public fmEditDeliveryman(fmBase parent)
        {
            InitializeComponent();
            this.parent = parent;
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select Адрес From Пункт";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbEditDelivPoint.Items.Add(reader["Адрес"].ToString());

            }
            reader.Close();
            con.Close();

        }

        public void FillDeliverymanEdit(int idDelivman, string DelivPoint, string Sur, string Name, string Patr)
        {
            tbId.Text = idDelivman.ToString();
            cbEditDelivPoint.Text = DelivPoint;
            tbEditDelSur.Text = Sur;
            tbEditDelName.Text = Name;
            tbEditDelPatr.Text = Patr;
        }

        private void btEditDeliverman_Click(object sender, EventArgs e)
        {
            if (!(tbEditDelSur.Text.Trim() == "" || tbEditDelName.Text.Trim() == "" || tbEditDelPatr.Text.Trim() == "" || cbEditDelivPoint.Text.Trim() == ""))
            {
                string Surname = Procedures.TitleText(tbEditDelSur);
                string Name = Procedures.TitleText(tbEditDelName);
                string Patron = Procedures.TitleText(tbEditDelPatr);

                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "EditDelvierman";

                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = tbId.Text;

                command.Parameters.Add("@Point", SqlDbType.VarChar);
                command.Parameters["@Point"].Value = cbEditDelivPoint.Text;

                command.Parameters.Add("@Surname", SqlDbType.VarChar);
                command.Parameters["@Surname"].Value = Surname;

                command.Parameters.Add("@Name", SqlDbType.VarChar);
                command.Parameters["@Name"].Value = Name;

                command.Parameters.Add("@Patron", SqlDbType.VarChar);
                command.Parameters["@Patron"].Value = Patron;

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(this, "Изменения сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parent.LoadDelivermanList();

                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tbEditDelSur_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.LetterOnly(e);
        }

        private void tbEditDelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.LetterOnly(e);
        }

        private void tbEditDelPatr_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.LetterOnly(e);
        }

        private void cbEditDelivPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
