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
    public partial class ChangeEmployee : Form
    {
        int id; 
        public ChangeEmployee(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        void LoadInfo(int id)
        {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "SELECT [Login],[Password],[Position],[Access_level]" +
                        "FROM [dbo].[Employee]" +
                        "WHERE [Id]=@id";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            textBoxLogin.Text = reader[0].ToString();
                            textBoxPassword.Text = reader[1].ToString();
                            textBoxPosition.Text = reader[2].ToString();
                            textBoxLvl.Text = reader[3].ToString();
                        }
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        void Change()
        {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "UPDATE [dbo].[Employee]" +
                        "SET [Login]=@login, [Password]=@password, [Position]=@position, [Access_level] = @lvl" +
                        "WHERE [Id]=@id";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@login",textBoxLogin.Text);
                    cmd.Parameters.AddWithValue("@position",textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@lvl",int.Parse(textBoxLvl.Text));
                    cmd.Parameters.AddWithValue("@id", id);

                    int y=cmd.ExecuteNonQuery();
                    if (y == 1) {
                        MessageBox.Show("Изменение успешно");
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }

            private void ChangeEmployee_Load(object sender, EventArgs e)
            {
            LoadInfo(id);
            }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Change();
                this.DialogResult = DialogResult.OK;
        }
    }
}
