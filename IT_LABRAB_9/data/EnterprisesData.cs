using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using IT_LABRAB_9.entities;

namespace IT_LABRAB_9
{
    public class EnterprisesData : Enterprise
    {
        private static string EnterprisesTable = "Enterprises";


        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\code\с#\IT_LABRAB_9\IT_LABRAB_9\Database.mdf;Integrated Security=True";

        public static void AddEnterprise(Enterprise enterprise)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute($"INSERT INTO Enterprises (Code, Name, Address, Phone) VALUES (@Code, @Name, @Address, @Phone);", enterprise);
            }
        }

        public static List<Enterprise> ReadAllEnterprises()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Enterprise>($"SELECT * FROM {EnterprisesTable}").ToList();

            }
        }

        public static List<Enterprise> ReadEnterprisesByYear(string year)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Enterprise>($"SELECT * FROM {EnterprisesTable}").ToList();

            }
        }

        public static void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute($"DELETE FROM {EnterprisesTable} WHERE Code = {id}");

            }
        }
    }
}
