using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace AutoService_Winform_
{
    class UserAutorisation
    {
        string login;
        string password ;
        int access_level;
        public string Login { get { return login; } set {this.login=value; } }
        public string Password { get { return password; } set { this.password = value; } }

        public int Access_level{ get { return access_level; } set { this.access_level = value; } }
        public int Check(string login, string password)
        {
            UserAutorisation user = new UserAutorisation();
                try
                {
                    Connection.connection.Open();
                    {
                        string SqlExp = "SELECT [Login],[Password],[Access_level]" +
                            "FROM [dbo].[Employee]" +
                            "WHERE [Login]=@login AND [Password] = @password";
                        SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                user.login = reader[0].ToString();
                                user.password = reader[1].ToString();
                                user.Access_level = (int)reader[2];
                                Access.Acces = (int)reader[2];
                            }
                        }
                        reader.Close();
                    }
                }
                catch (SqlException ex) { MessageBox.Show("Ошибка" + ex.Message); }
                Connection.connection.Close();
            if (user.login == login) {
                if (user.password == password && user.login == login)
                {
                    MessageBox.Show("Авторизация успешна");
                    return user.access_level;
                }
                else {
                    MessageBox.Show("Пароль не верный");
                    return 7;
                }
            }
            else {
                MessageBox.Show("Неверный логин или пароль");
                return 7;
            }
        }
    }
}
