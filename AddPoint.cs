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
    public partial class fmAddPoint : Form
    {
        fmBase parent;
        public fmAddPoint(fmBase parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btAddPoint_Click(object sender, EventArgs e)
        {
            if (!(tbAddPoint.Text.Trim() == ""))
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Пункт(Адрес) VALUES (@Adress)", con);

                command.Parameters.Add("@Adress", SqlDbType.VarChar);
                command.Parameters["@Adress"].Value = tbAddPoint.Text;

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(this, "Пункт добавлен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parent.UpdatePointList();
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
