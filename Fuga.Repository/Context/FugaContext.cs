using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fuga.Repository.Context
{
    public class FugaContext
    {
        public SqlConnection GetDbConnection(string _code)
        {
            SqlConnection con = new SqlConnection();
            switch (_code)
            {
                case "DB1":
                    string connectionString = @"server=ZB-ADM-CLETOS;
                         database=EBA_NEW;  
                         Integrated Security=False;                         
                         uid=sa;pwd=globe";
                    con = new SqlConnection(connectionString);
                    break;
                case "DB2":
                    Console.WriteLine("Case 2");
                    break;
                case "DB3":
                    Console.WriteLine("Default case");
                    break;
            }

            return con;
        }
    }
}
