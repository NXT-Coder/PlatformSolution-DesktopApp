using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlatformImpact2
{
    internal class koneksi
    {
        public SqlConnection GetConnection()
        {
            SqlConnection connect = new SqlConnection("Data Source=LAPTOP-65G6I7P1;Initial Catalog=Meja_01;Integrated Security=True");
            return connect;
        }
        public string hashPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] plain = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(plain);

            /*for(int i = 0; i < hash.Length; i++)
            {
                
            }*/
            return Convert.ToBase64String(hash);
        }
    }
}
