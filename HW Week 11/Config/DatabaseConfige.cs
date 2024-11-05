using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week_11.Config
{
    public class DatabaseConfige
    {
        public static string ConnectionString { get; set; }
        static DatabaseConfige()
        {
            ConnectionString = "Server=DESKTOP-O8SFUP7\\SQLEXP; DataBase=ShopDb; Integrated Security=True; TrustServerCertificate=True;";
        }
    }
}
