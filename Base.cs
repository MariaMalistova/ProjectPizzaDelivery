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
    public partial class fmBase : Form
    {
        public fmBase()
        {
            InitializeComponent();

            tabControl1.SelectedIndex = 0;
        }

        public void SetControl(int tab)
        {
            tabControl1.SelectedIndex = tab;
        }

        public void UpdateCustomerList()
        {
            this.покупательTableAdapter.Fill(this.доставка_пиццыDataSet.Покупатель);
        }

        public void UpdatePointList()
        {
            this.пунктTableAdapter.Fill(this.доставка_пиццыDataSet.Пункт);
        }

        public void LoadDelivermanList()
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");

            SqlCommand command = new SqlCommand("SELECT Курьер.Код_Курьера, Курьер.Фамилия, Курьер.Имя, Курьер.Отчество, Пункт.Адрес FROM Курьер INNER JOIN Пункт ON Курьер.Пункт = Пункт.Код_Пункта", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dgDelivermanList.DataSource = table;
            con.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "доставка_пиццыDataSet.Покупатель". При необходимости она может быть перемещена или удалена.
            this.покупательTableAdapter.Fill(this.доставка_пиццыDataSet.Покупатель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "доставка_пиццыDataSet.Пункт". При необходимости она может быть перемещена или удалена.
            this.пунктTableAdapter.Fill(this.доставка_пиццыDataSet.Пункт);
            LoadDelivermanList();
        }

        private void btAddPiont_Click(object sender, EventArgs e)
        {
            fmAddPoint fmAddPoint = new fmAddPoint(this);
            fmAddPoint.ShowDialog();
        }

        private void btAddDeliverman_Click(object sender, EventArgs e)
        {
            fmAddDeliverman fmAddDeliverman = new fmAddDeliverman(this);
            fmAddDeliverman.ShowDialog();
        }

        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            fmAddCustomer fmAddCustomer = new fmAddCustomer(this);
            fmAddCustomer.ShowDialog();
        }

        private void dgPoint_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                int idPoint = Int32.Parse(dgPoint[0, rowIndex].Value.ToString());
                string PointAdress = dgPoint[1, rowIndex].Value.ToString();

                fmEditPoint fmEditPoint = new fmEditPoint(this);
                fmEditPoint.FillPointEdit(idPoint, PointAdress);
                fmEditPoint.ShowDialog();
            }
        }

        private void dgPoint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                btDeletePoint.Enabled = true;
            }
            else
            {
                btDeletePoint.Enabled = false;
            }
        }

        private void btDeletePoint_Click(object sender, EventArgs e)
        {
            int rowIndex = dgPoint.CurrentRow.Index;
            int idPoint = Int32.Parse(dgPoint[0, rowIndex].Value.ToString());

            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeletePoint";

            command.Parameters.Add("@IdPoint", SqlDbType.VarChar);
            command.Parameters["@IdPoint"].Value = idPoint;

            command.ExecuteNonQuery();
            con.Close();
            UpdatePointList();
            MessageBox.Show(this, "Пункт удален", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgDelivermanList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                int idDelivman = Int32.Parse(dgDelivermanList[0, rowIndex].Value.ToString());
                string Sur = dgDelivermanList[1, rowIndex].Value.ToString();
                string Name = dgDelivermanList[2, rowIndex].Value.ToString();
                string Patr = dgDelivermanList[3, rowIndex].Value.ToString();
                string DelivPoint = dgDelivermanList[4, rowIndex].Value.ToString();


                fmEditDeliveryman fmEditDeliveryman = new fmEditDeliveryman(this);
                fmEditDeliveryman.FillDeliverymanEdit(idDelivman, DelivPoint, Sur, Name, Patr);
                fmEditDeliveryman.ShowDialog();
            }
        }

        private void btDeleteDelivman_Click(object sender, EventArgs e)
        {
            int rowIndex = dgDelivermanList.CurrentRow.Index;
            int idDelivman = Int32.Parse(dgDelivermanList[0, rowIndex].Value.ToString());

            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteDelivman";

            command.Parameters.Add("@IdMan", SqlDbType.VarChar);
            command.Parameters["@IdMan"].Value = idDelivman;

            command.ExecuteNonQuery();
            con.Close();
            LoadDelivermanList();
            MessageBox.Show(this, "Курьер удален", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgDelivermanList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                btDeleteDelivman.Enabled = true;
            }
            else
            {
                btDeleteDelivman.Enabled = false;
            }
        }

        private void dgCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                int idCustomer = Int32.Parse(dgCustomerList[0, rowIndex].Value.ToString());
                string Sur = dgCustomerList[1, rowIndex].Value.ToString();
                string Name = dgCustomerList[2, rowIndex].Value.ToString();
                string Patr = dgCustomerList[3, rowIndex].Value.ToString();
                string Phone = dgCustomerList[4, rowIndex].Value.ToString();
                string Adress = dgCustomerList[5, rowIndex].Value.ToString();

                fmEditCustomer fmEditCustomer = new fmEditCustomer(this);
                fmEditCustomer.FillCustomerEdit(idCustomer, Sur, Name, Patr, Phone, Adress);
                fmEditCustomer.ShowDialog();
            }
        }

        private void dgCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                btDeleteCustomer.Enabled = true;
            }
            else
            {
                btDeleteCustomer.Enabled = false;
            }
        }

        private void btDeleteCustomer_Click(object sender, EventArgs e)
        {
            int rowIndex = dgCustomerList.CurrentRow.Index;
            int idCustomer = Int32.Parse(dgCustomerList[0, rowIndex].Value.ToString());

            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Доставка_пиццы;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("DELETE Покупатель WHERE Код_Покупателя = @IdCustomer", con);

            command.Parameters.Add("@IdCustomer", SqlDbType.Int);
            command.Parameters["@IdCustomer"].Value = idCustomer;

            command.ExecuteNonQuery();
            con.Close();
            UpdateCustomerList();
            MessageBox.Show(this, "Покупатель удален", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
