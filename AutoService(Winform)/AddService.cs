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
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }
        void Addservice()
        {
            int period,price,garantee;
            period = int.Parse(textBoxPeriod.Text);
            price = int.Parse(textBoxPrice.Text);
            garantee = int.Parse(textBoxDays.Text);
            try
            {
                Connection.connection.Open();
                {
                    string SqlExp = "INSERT INTO [dbo].[Types_work]([Type_work],[Price],[Period_of_execution],[Garantee])" +
                        "VALUES(@type_work,@price,@period,@garantee)";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    cmd.Parameters.AddWithValue("@type_work", textBoxService.Text);
                    cmd.Parameters.AddWithValue("@price",price);
                    cmd.Parameters.AddWithValue("@period",period);
                    cmd.Parameters.AddWithValue("@garantee",garantee);
                    int y = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex) { MessageBox.Show("Ошибка:" + ex.Message); }
            Connection.connection.Close();
        }
        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Addservice();
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
