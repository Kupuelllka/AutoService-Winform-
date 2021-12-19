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
    public partial class Price_list : Form
    {
        public Price_list()
        {
            InitializeComponent();
        }
        void LoadDataGrid() {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "SELECT [Type_work],[Price],[Period_of_execution],[Garantee]" +
                        "FROM[dbo].[Types_work]";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                        }
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Price_list_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        void ClearDataGrid() {
            dataGridView1.Rows.Clear();
        }
        private void buttonAddService_Click(object sender, EventArgs e)
        {
            AddService service = new AddService();
            service.ShowDialog();
            if (service.DialogResult == DialogResult.OK) {
                service.Close();
            }
            ClearDataGrid();
            LoadDataGrid();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentCell.RowIndex + 1;
            ChangeService service = new ChangeService(id);
            service.ShowDialog();
            if (service.DialogResult == DialogResult.OK)
            {
                service.Close();
            }
            ClearDataGrid();
            LoadDataGrid();
        }

          
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "DELETE FROM [dbo].[Types_work]" +
                        "WHERE [Id] = @id";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentCell.RowIndex+1);
                    int y = cmd.ExecuteNonQuery();
                    if (y == 1)
                    {
                        MessageBox.Show("Удаление успешно");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка ");
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
            ClearDataGrid();
            LoadDataGrid();
        }

    }
}
