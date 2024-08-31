using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mama
{
    internal class Global
    {
        public static string version = "0.0.1";
        public static string path = Environment.CurrentDirectory;
        public static string DB = "db.db3";
        public static string PathDB = path + @"\DB\" + DB;
    }
}
