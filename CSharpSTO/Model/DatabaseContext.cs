using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSTO.Model
{
    internal class DatabaseContext
    {
        private readonly string _connectionString;
        private static DatabaseContext instance;
        public static DatabaseContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseContext();
                }

                return instance;
            }
        }

        private DatabaseContext()
        {
            _connectionString = "Server=localhost\\SQLEXPRESS;" +
                   "Database=sto_db;" +
                   "Trusted_Connection=True;" +
                   "TrustServerCertificate=True;";
        }

        public List<Master> GetMasters()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [Master]";

                return connection.Query<Master>(query).ToList();
            }
        }
    }
}
