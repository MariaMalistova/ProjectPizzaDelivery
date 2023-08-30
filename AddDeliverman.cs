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
    public partial class fmAddDeliverman : Form
    {
        fmBase parent;
        public fmAddDeliverman(fmBase parent)
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
                cbAddDelivPoint.Items.Add(reader["Адрес"].ToString());

            }
            reader.Close();
            con.Close();
        }

        private void btSaveDeliverman_Click(object sender, EventArgs e)
        {
            if (!(tbAddDelSur.Text.Trim() == "" || tbAddDelName.Text.Trim() == "" || tbAddDelPatr.Text.Trim() == "" || cbAddDelivPoint.Text == ""))
            {
                string Surname = Procedures.TitleText(tbAddDelSur);
                string Name = Procedures.TitleText(tbAddDelName);
                string Patron = Procedures.TitleText(tbAddDelPatr);

                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddDelvierman";

                command.Parameters.Add("@Point", SqlDbType.VarChar);
                command.Parameters["@Point"].Value = cbAddDelivPoint.Text;

                command.Parameters.Add("@Surname", SqlDbType.VarChar);
                command.Parameters["@Surname"].Value = Surname;

                command.Parameters.Add("@Name", SqlDbType.VarChar);
                command.Parameters["@Name"].Value = Name;

                command.Parameters.Add("@Patron", SqlDbType.VarChar);
                command.Parameters["@Patron"].Value = Patron;

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(this, "Курьер добавлен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parent.LoadDelivermanList();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tbAddDelSur_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.LetterOnly(e);
        }

        private void tbAddDelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.LetterOnly(e);
        }

        private void tbAddDelPatr_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procedures.LetterOnly(e);
        }

        private void cbAddDelivPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
