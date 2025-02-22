using E_Commerce.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLogic
{
    public class CategoriesService
    {
        DBContext context;

        public CategoriesService(string connectionString)
        {
            context = new DBContext(connectionString);
        }

        public DataTable GettALL()
        {
            string getAllcommand = "select * from categories";
            return context.Select(getAllcommand);
        }
        public DataTable GetById(int id)
        {
            string getById = $"select * from categories where CategoryId = {id}";
            return context.Select(getById);
        }

        public int Add(string categoryName)
        {
            string command = $"insert into categories (CategoryName) values ('{categoryName}')";
            return context.ExecuteNonQuery(command);
        }

        public int Update(int categoryId, string categoryName)
        {
            string command = $"UPDATE Categories SET CategoryName = '{categoryName}' WHERE CategoryId = {categoryId}";
            return context.ExecuteNonQuery(command);
        }

        public int Delete(int categoryId)
        {
            string deleteFavouritesCommand = $"delete from Favourites where ProductId in(select ProductId from Products where CategoryId = {categoryId})";
            context.ExecuteNonQuery(deleteFavouritesCommand);

            string deleteProductsCommand = $"DELETE FROM Products WHERE CategoryId = {categoryId}";
            context.ExecuteNonQuery(deleteProductsCommand);

            string deleteCategoryCommand = $"DELETE FROM Categories WHERE CategoryId = {categoryId}";
            return context.ExecuteNonQuery(deleteCategoryCommand);
        }

    }
}
