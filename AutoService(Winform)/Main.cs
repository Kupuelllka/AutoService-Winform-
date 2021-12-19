using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AutoService_Winform_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void AddOrder()
        {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "INSERT ";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetInfo()
        {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "SELECT [LastName],[FirstName],[Mobile_number],[Mark],[Model],[Receipt_date]" +
                        "FROM[dbo].[Order]" +
                        "JOIN[dbo].[Auto] ON[dbo].[Auto].[Id] =[dbo].[Order].[Id_auto]" +
                        "JOIN[dbo].[Owner] ON[dbo].[Owner].[Id] =[dbo].[Order].[Id_owner]";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridViewOrders.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4],reader[5]);
                        }
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            GetInfo();
            this.Hide();
            Autorisation autorisation = new Autorisation();
            autorisation.ShowDialog();
            if (autorisation.DialogResult == DialogResult.OK) {
                autorisation.Close();
                Show();
            }
            if (Access.Acces > 1) {
                buttonEmployees.Enabled = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDetals_Click(object sender, EventArgs e)
        {
            Detals detals = new Detals();
            this.Show();
            detals.ShowDialog();
            if (detals.DialogResult == DialogResult.OK) {
                this.Show();
                detals.Close();
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder order = new AddOrder();
            this.Hide();
            order.ShowDialog();
            if (order.DialogResult == DialogResult.OK) {
                GetInfo();
                this.Show();
                order.Close();     
            }
        }

        private void buttonInstallDetals_Click(object sender, EventArgs e)
        {
            Price_list list = new Price_list();
            this.Hide();
            list.ShowDialog();
            if (list.DialogResult == DialogResult.OK) {
                this.Show();
                list.Close();
            }
        }

        private void buttonTypesWorks_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.ShowDialog();
            if (employees.DialogResult == DialogResult.OK) {
                employees.Close();
                this.Show();
            }
        }
    }
}
