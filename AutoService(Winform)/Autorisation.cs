using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService_Winform_
{
    public partial class Autorisation : Form
    {
        UserAutorisation user = new UserAutorisation();

        public Autorisation()
        {
            InitializeComponent();
        }

        private void Autorisation_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 16;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           int y = user.Check(textBoxLogin.Text, textBoxPassword.Text);
            if (y != 7)
            {
             this.DialogResult = DialogResult.OK;
            }
        }
    }
}
