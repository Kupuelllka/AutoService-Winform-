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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        void GetInfo()
        {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "SELECT [Login],[Password],[Position],[Access_level]" +
                        "FROM [dbo].[Employee]";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                        }
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEmployee employee = new AddEmployee();
            employee.ShowDialog();
            if (employee.DialogResult == DialogResult.OK)
            {
                GetInfo();
                employee.Close();
            }

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ChangeEmployee change = new ChangeEmployee(dataGridView1.CurrentCell.RowIndex+1);
            change.ShowDialog();
            if (change.DialogResult == DialogResult.OK)
            {
                GetInfo();
                change.Close();
            }
        }
        void ClearDataGrid() {
            dataGridView1.Rows.Clear();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "DELETE FROM [dbo].[Employee] " +
                        "WHERE [Id]=@id";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentCell.RowIndex + 1);
                    int y = cmd.ExecuteNonQuery();
                    if (y == 1)
                    {
                        MessageBox.Show("Удаление успешно");
                    }
                    else {
                        MessageBox.Show("Такого сотрудник не существует");
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
            ClearDataGrid();
            GetInfo();
        }
    }
}
