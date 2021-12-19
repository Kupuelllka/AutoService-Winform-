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
    public partial class AddOwner : Form
    {
        public AddOwner()
        {
            InitializeComponent();
        }
        void Add() {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "INSERT [dbo].[Owner] ([LastName],[FirstName],[Mobile_number],[Description])" +
                        "VALUES(@LastName,@FirstName,@number,@description)";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@LastName",textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@number", textBoxMobile.Text);
                    cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                    int y = cmd.ExecuteNonQuery();
                    if (y == 1)
                    {
                        MessageBox.Show("Клиент добавлен в базу");
                    }
                    else {
                        MessageBox.Show("Проверьте корректность ввода значений");
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        private void AddOwner_Load(object sender, EventArgs e)
        {
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            Add();
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
