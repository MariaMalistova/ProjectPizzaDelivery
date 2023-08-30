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
    public partial class fmAddOrder : Form
    {
        fmMain parent;
        public fmAddOrder(fmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select Фамилия From Покупатель";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbCustomer.Items.Add(reader["Фамилия"].ToString());

            }
            reader.Close();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "Select Тип From Доставка";
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                cbDelivery.Items.Add(reader1["Тип"].ToString());

            }
            reader1.Close();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandText = "Select Адрес From Пункт";
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                cbPoint.Items.Add(reader2["Адрес"].ToString());

            }
            reader2.Close();


            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandText = "Select Вид From Скидка";
            SqlDataReader reader3 = cmd3.ExecuteReader();

            cbDiscount.Items.Add("");

            while (reader3.Read())
            {
                cbDiscount.Items.Add(reader3["Вид"].ToString());

            }
            reader3.Close();

            con.Close();
        }

        private void btAddPizza_Click(object sender, EventArgs e)
        {
            fmAddPizzaInPrder fmAddPizzaInPrder = new fmAddPizzaInPrder(this);
            fmAddPizzaInPrder.ShowDialog();
        }


        public void AddPizzaOrder(string PizzaName, int PizzaNum)
         {
             dgPizzaOrderList.Rows.Add(PizzaName, PizzaNum); 
         }

        public void SetPizzaOrder(int IndexP, string PizzaName, int PizzaNum)
        {
            dgPizzaOrderList[0, IndexP].Value = PizzaName;
            dgPizzaOrderList[1, IndexP].Value = PizzaNum;
        }

        private void dgPizzaOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (dgPizzaOrderList.Enabled)
            {

                if (rowIndex >= 0)
                {
                    string PizName = dgPizzaOrderList[0, rowIndex].Value.ToString();
                    int PizNum = Int32.Parse(dgPizzaOrderList[1, rowIndex].Value.ToString());

                    fmEditPizzaOrder fmEditPizzaOrder = new fmEditPizzaOrder(this);
                    fmEditPizzaOrder.FillEditPizza(rowIndex, PizName, PizNum);
                    fmEditPizzaOrder.ShowDialog();
                }
            }
        }

        private void cbPoint_TextChanged(object sender, EventArgs e)
        {
            cbDeliveryman.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
            con.Open();
            SqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandText = "Select Фамилия From Курьер INNER JOIN Пункт ON Курьер.Пункт = Пункт.Код_Пункта WHERE Пункт.Адрес = @Adress";

            cmd4.Parameters.Add("@Adress", SqlDbType.VarChar);
            cmd4.Parameters["@Adress"].Value = cbPoint.Text;

            SqlDataReader reader4 = cmd4.ExecuteReader();

            while (reader4.Read())
            {
                cbDeliveryman.Items.Add(reader4["Фамилия"].ToString());
            }
            reader4.Close();

            con.Close();
        }

        private void btSaveOrder_Click(object sender, EventArgs e)
        {
            if (!(cbCustomer.Text == "" || cbPoint.Text == "" || cbDelivery.Text == "" || dgPizzaOrderList.RowCount == 0))
            {

                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddOrder";

                command.Parameters.Add("@Customer", SqlDbType.VarChar);
                command.Parameters["@Customer"].Value = cbCustomer.Text;

                command.Parameters.Add("@DelivMan", SqlDbType.VarChar);
                command.Parameters["@DelivMan"].Value = cbDeliveryman.Text;

                command.Parameters.Add("@Delivery", SqlDbType.VarChar);
                command.Parameters["@Delivery"].Value = cbDelivery.Text;

                command.Parameters.Add("@Point", SqlDbType.VarChar);
                command.Parameters["@Point"].Value = cbPoint.Text;

                command.Parameters.Add("@Disc", SqlDbType.VarChar);
                command.Parameters["@Disc"].Value = cbDiscount.Text;

                var returnParam = new SqlParameter
                {
                    ParameterName = "@K",
                    Direction = ParameterDirection.ReturnValue
                };

                command.Parameters.Add(returnParam);
                command.ExecuteNonQuery();
                var IndexOrder = (int)returnParam.Value;
                con.Close();

                int Strings = dgPizzaOrderList.RowCount;

                for (int i = 0; i < Strings; i++)
                {
                    con.Open();
                    SqlCommand command1 = con.CreateCommand();
                    command1.CommandType = CommandType.StoredProcedure;
                    command1.CommandText = "AddOrder2";

                    command1.Parameters.Add("@K", SqlDbType.Int);
                    command1.Parameters["@K"].Value = Int32.Parse(IndexOrder.ToString());

                    command1.Parameters.Add("@Pizza", SqlDbType.VarChar);
                    command1.Parameters["@Pizza"].Value = dgPizzaOrderList.Rows[i].Cells[0].Value.ToString();

                    command1.Parameters.Add("@Number", SqlDbType.Int);
                    command1.Parameters["@Number"].Value = Int32.Parse(dgPizzaOrderList.Rows[i].Cells[1].Value.ToString());
                    command1.ExecuteNonQuery();

                    con.Close();
                }

                con.Open();
                SqlCommand command2 = con.CreateCommand();
                command2.CommandType = CommandType.StoredProcedure;
                command2.CommandText = "AddOrder3";

                command2.Parameters.Add("@K", SqlDbType.Int);
                command2.Parameters["@K"].Value = Int32.Parse(IndexOrder.ToString());
                command2.ExecuteNonQuery();

                con.Close();

                if (cbDiscount.Text != "")
                {
                    con.Open();
                    SqlCommand command3 = con.CreateCommand();
                    command3.CommandType = CommandType.StoredProcedure;
                    command3.CommandText = "AddOrder4";

                    command3.Parameters.Add("@K", SqlDbType.Int);
                    command3.Parameters["@K"].Value = Int32.Parse(IndexOrder.ToString());

                    command3.Parameters.Add("@Disc", SqlDbType.VarChar);
                    command3.Parameters["@Disc"].Value = cbDiscount.Text.ToString();

                    command3.ExecuteNonQuery();

                    con.Close();
                }

                con.Open();
                SqlCommand command4 = con.CreateCommand();
                command4.CommandType = CommandType.StoredProcedure;
                command4.CommandText = "AddOrder5";

                command4.Parameters.Add("@K", SqlDbType.Int);
                command4.Parameters["@K"].Value = Int32.Parse(IndexOrder.ToString());

                command4.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(this, "Заказ добавлен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parent.OrdersLoad();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbDelivery_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        }
}
