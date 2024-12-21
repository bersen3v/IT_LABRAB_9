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
    public class ProductData : Product
    {
        private static string Table = "Products";

        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\code\с#\IT_LABRAB_9\IT_LABRAB_9\Database.mdf;Integrated Security=True";

        public static void AddProduct(Product product)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute($"INSERT INTO Products (ProductCode, ProductName, IsStandard, Note, AnnualProductionVolume) VALUES (@ProductCode, @ProductName, @IsStandard, @Note, @AnnualProductionVolume);", product);
            }
        }

        public static List<Product> ReadAllProducts()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Product>($"SELECT * FROM {Table}").ToList();

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
