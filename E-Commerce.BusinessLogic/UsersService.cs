using E_Commerce.DataAccess;
using System.Data;

namespace E_Commerce.BusinessLogic
{
    public class UsersService
    {
        public DBContext context ;
        public UsersService(string connectionString)
        {
            context = new DBContext(connectionString);
        }
        public DataTable GetAll()
        {
            string getAllCommand = "SELECT * FROM Users";
            return context.Select(getAllCommand);
        }

        public DataTable GetByUserName(string userName , string password)
        {
            string getByUserNameCommand = $"SELECT * from Users where Username = '{userName}' and password ='{password}'";
            return context.Select(getByUserNameCommand);
        }
        public DataTable GetById(int user_id)
        {
            string getByIdCommand = $"SELECT * from Users where userId = {user_id}";
            return context.Select(getByIdCommand);
        }
        public int Add(string username, string password, string email, int age, string address , string Role = "User")
        {
            string addCommand = $"insert into users (Username, Password, Email, Age, Address) VALUES ('{username}', '{password}', '{email}', {age}, '{address}')";
            return context.ExecuteNonQuery(addCommand);
        }

        public int Update(int userId, string username, string password, string email, int age, string address, string role)
        {
            string updateCommand = $@" UPDATE Users 
            SET Username = '{username}', 
            Password = '{password}', 
            Email = '{email}', 
            Age = {age}, 
            Address = '{address}', 
            Role = '{role}'
            WHERE UserId = {userId}";

            return context.ExecuteNonQuery(updateCommand);
        }

        public int Delete(int userId)
        {
            string deleteFavoritesCommand = $"DELETE FROM Favourites WHERE UserId = {userId}";
            context.ExecuteNonQuery(deleteFavoritesCommand);


            string deleteCommand = $"delete from users where userId = {userId}";
            return context.ExecuteNonQuery(deleteCommand);
        }

        public int UpdatePassword(int user_id ,string password)
        {
            string updatePassCommand = $@" UPDATE Users 
            SET Password = '{password}'
            WHERE UserId = {user_id}";

            return context.ExecuteNonQuery(updatePassCommand);
        }

        public DataTable GetRoles()
        {
            string getRolesCommand = "select distinct role from users";
            return context.Select(getRolesCommand);
        }

    }
}
