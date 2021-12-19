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
    public partial class ChangeService : Form
    {
        int id;
        public ChangeService(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        void LoadInfo() {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "SELECT [Type_work],[Price],[Period_of_execution],[Garantee]" +
                        "FROM [dbo].[Types_work]" +
                        "WHERE [dbo].[Types_work].[Id] = @Id";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            textBoxService.Text = reader[0].ToString();
                            textBoxPrice.Text = reader[1].ToString();
                            textBoxPeriod.Text = reader[2].ToString();
                            textBoxDays.Text = reader[3].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        void Save()
        {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "UPDATE [dbo].[Types_work]" +
                        "SET [Type_work]=@type_work, [Price]=@price, [Period_of_execution]= @period, [Garantee]= @days" +
                        "WHERE [Id]=@Id";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@type_work", textBoxService.Text);
                    cmd.Parameters.AddWithValue("@price", int.Parse(textBoxPrice.Text));
                    cmd.Parameters.AddWithValue("@period", int.Parse(textBoxPeriod.Text));
                    cmd.Parameters.AddWithValue("@garantee", int.Parse(textBoxDays.Text));
                    int y = cmd.ExecuteNonQuery();
                    if (y == 1)
                    {
                        MessageBox.Show("Данные успешно обновлены");
                    }
                    else {
                        MessageBox.Show("Проверьте корректность ввода значений");
                    }
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
            private void ChangeService_Load(object sender, EventArgs e)
            {
            LoadInfo();
            }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
