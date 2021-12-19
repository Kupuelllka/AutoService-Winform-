using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService_Winform_
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }
        void LoadComboboxAuto() {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "SELECT [Id],[Mark],[Model],[Year_of_issue]" +
                        "FROM[dbo].[Auto]";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comboBoxAuto.Items.Add(reader[0].ToString()+reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        void LoadComboboxClient() {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "SELECT [Id],[LastName],[FirstName]" +
                        "FROM [dbo].[Owner]";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comboBoxOwner.Items.Add(reader[0].ToString()+"." + reader[1].ToString()+ " " + reader[2].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        void AddOwner() {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "INSERT INTO [dbo].[Order]([Id_auto],[Id_owner],[Receipt_date],[Description])" +
                        "VALUES(@id_auto,@id_owner,@date,@description)";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@id_auto",comboBoxAuto.SelectedIndex+1);
                    cmd.Parameters.AddWithValue("@id_owner", comboBoxOwner.SelectedIndex+1);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@description",textBoxDescription.Text);
                    int y = cmd.ExecuteNonQuery();
                    if (y == 1)
                    {
                        MessageBox.Show("Заказ добавлен");
                    }
                    else {
                        MessageBox.Show("Проверьте корректность ввода значений");
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        private void AddOrder_Load(object sender, EventArgs e)
        {
            LoadComboboxClient();
            LoadComboboxAuto();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            AddOwner();
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonAddAuto_Click(object sender, EventArgs e)
        {
            AddAuto auto = new AddAuto();
            auto.ShowDialog();
            if (auto.DialogResult == DialogResult.OK) {
                LoadComboboxAuto();
                auto.Close();
            }
        }

        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            AddOwner owner = new AddOwner();
            owner.ShowDialog();
            if (owner.DialogResult == DialogResult.OK)
            {
                LoadComboboxClient();
                owner.Close();
            }
        }
    }
}
