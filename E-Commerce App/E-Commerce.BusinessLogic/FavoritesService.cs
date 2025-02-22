using E_Commerce.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLogic
{
    public class FavoritesService
    {
        DBContext context;
        public FavoritesService(string connectionString)
        {
            context = new DBContext(connectionString);
        }

        public DataTable GetAllByUserId(int UserId)
        {
            string command = $" select p.ProductName from Products p ,Favourites f where p.ProductId = f.ProductId and f.UserId = {UserId}";
            return context.Select(command);
        }

        public int Add(int userId, int productId)
        {
            string addCommand = $"insert into Favourites values ({userId},{productId})";
            return context.ExecuteNonQuery(addCommand);
        }

        public int Delete(int UsertId, int productId)
        {
            string deleteCommand = $"delete from Favourites where UserId = {UsertId} and ProductId={productId} ";
            return context.ExecuteNonQuery(deleteCommand);
        }

    }
}
