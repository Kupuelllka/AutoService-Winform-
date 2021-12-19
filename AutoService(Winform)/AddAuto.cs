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
    public partial class AddAuto : Form
    {
        public AddAuto()
        {
            InitializeComponent();
        }
        void  Addauto() {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "INSERT INTO [dbo].[Auto]([Mark],[Model],[Year_of_issue],[Description])" +
                        "VALUES(@mark,@model,@date,@description)";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@mark", textBoxMark.Text);
                    cmd.Parameters.AddWithValue("@model",textBoxModel.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                    int y = cmd.ExecuteNonQuery();
                    if (y == 1)
                    {
                        MessageBox.Show("Авто успешно добавлено");
                    }
                    else {
                        MessageBox.Show("Проверьте корректность значений");
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            Addauto();
            this.DialogResult = DialogResult.OK;
        }

        private void AddAuto_Load(object sender, EventArgs e)
        {

        }
    }
}
