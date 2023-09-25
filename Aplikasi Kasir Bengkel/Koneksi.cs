using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Kasir_Bengkel
{
    internal class Koneksi
    {
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;UID=root;PWD=;Database=dbkasirbengkel");
    }
}
