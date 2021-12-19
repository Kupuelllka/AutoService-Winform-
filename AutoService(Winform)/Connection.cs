using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AutoService_Winform_
{
    class Connection
    {
        internal static string ConnectionStr = @"Data Source=DESKTOP-DHRJN05;Initial Catalog=AutoService;User ID=kupuelllka;Password=123123";
        internal static SqlConnection connection = new SqlConnection(ConnectionStr);
    }
}
