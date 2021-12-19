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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        void LoadInfo() {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "INSERT INTO [dbo].[Employee]([Login],[Password],[Position],[Access_level])" +
                        "VALUES(@login,@password,@position,@Lvl)";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@login",textBoxLogin.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@position", textBoxPosition.Text);
                    cmd.Parameters.AddWithValue("@Lvl", int.Parse(textBoxLvl.Text));
                    int y = cmd.ExecuteNonQuery();
                    if (y == 1)
                    {
                        MessageBox.Show("Сотрудник добавлен");
                    }
                    else {
                        MessageBox.Show("Проверьте корректность ввода значений");
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LoadInfo();
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
