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
    public class ProductionData : Production
    {
        private static string Table = "Production";

        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\code\с#\IT_LABRAB_9\IT_LABRAB_9\Database.mdf;Integrated Security=True";

        public static void AddProduct(Production production)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute($"INSERT INTO Production (Year, Volume, ProductCode, EnterpriseCode) VALUES (@Year, @Volume, @ProductCode, @EnterpriseCode);", production);
            }
        }

        public static List<Production> ReadAllProduction()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Production>($"SELECT Production.Year, Production.Volume, {Table}.ProductCode, {Table}.EnterpriseCode, Enterprises.Name as EnterpriseName, Products.ProductName as ProductName " +
                    $"FROM {Table} " +
                    $"JOIN Products ON Products.ProductCode = Production.ProductCode " +
                    $"JOIN Enterprises ON Production.EnterpriseCode = Enterprises.Code; ").ToList();
            }
        }

        public static List<Production> ReadProductionByYear(string year)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                try
                {
                    return db.Query<Production>($"SELECT Production.Year, Production.Volume, {Table}.ProductCode, {Table}.EnterpriseCode, Enterprises.Name as EnterpriseName, Products.ProductName as ProductName " +
                    $"FROM {Table} " +
                    $"JOIN Products ON Products.ProductCode = Production.ProductCode " +
                    $"JOIN Enterprises ON Production.EnterpriseCode = Enterprises.Code " +
                    $"WHERE {Table}.Year LIKE '%{year}%'").ToList();

                }catch (Exception ex)
                {
                    return ReadAllProduction();
                }

            }
        }

        public static void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute($"DELETE FROM {Table} WHERE ProductCode = {id}");

            }
        }
    }
}
