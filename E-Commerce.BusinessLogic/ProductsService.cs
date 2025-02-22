using E_Commerce.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLogic
{
    public class ProductsService
    {
        DBContext context;
        public ProductsService(string connectionString)
        {
            context = new DBContext(connectionString);
        }

        public DataTable GetAll()
        {
            string getAllcommand = "select * FROM products";
            return context.Select(getAllcommand);
        }
        public DataTable GetProductIdByName(string product_name)
        {
            string GetByNamecommand = $"select productid FROM products where productname = '{product_name}'";
            return context.Select(GetByNamecommand);
        }


        public int Add(string pname , int price , int categoryId)
        {
            string addCommand = $"insert into products (productname, price, categoryId) VALUES ('{pname}', '{price}', '{categoryId}')";
            return context.ExecuteNonQuery(addCommand);
        }

        public int Update(int productId ,string pname, int price, int categoryId)
        {
            string updateCommand = $@" UPDATE products 
            SET productname = '{pname}', 
            price = '{price}', 
            categoryId = '{categoryId}'
            WHERE productId = {productId}";

            return context.ExecuteNonQuery(updateCommand);
        }

        public int Delete(int productId)
        {
            string deleteFavorites = $"DELETE FROM Favourites WHERE productId = {productId}";
            context.ExecuteNonQuery(deleteFavorites);

            string deleteCommand = $"delete from products where productId = {productId}";
            return context.ExecuteNonQuery(deleteCommand);
        }


    }
}
