using ConectarBdDapper.Models;
using Dapper;
using System.Data.SqlClient;

namespace ConectarBdDapper.Data
{
    internal class DataUser : IDisposable
    {

        string connectionString = @"Data Source=DESKTOP-D5JMIHP\SQLEXPRESS;Initial Catalog=user;User ID=code;Password=1506;";

        private SqlConnection dbConnection;


        public DataUser()
        {
            dbConnection = new SqlConnection(connectionString);

        }

        //obtener todos los usuarios de la db
        public void getUsers()
        {


            var sql = "SELECT user_id, user_name, user_age FROM [user]";
            var lst = dbConnection.Query<User>(sql);
            foreach (var item in lst)
            {

                Console.WriteLine($"codigo: {item.user_id} nombre: {item.user_name} edad: {item.user_age}");
            }


        }
        //obtener usuario por id 
        public void GetUserById(int id)
        {

            var sql = $"SELECT user_id, user_name, user_age FROM [user] WHERE user_id = {id}";
            var user = dbConnection.QueryFirstOrDefault<User>(sql);

            if (user != null)
            {
                Console.WriteLine($"User ID: {user.user_id}, User Name: {user.user_name}, User Age: {user.user_age}");
            }
            else
            {
                Console.WriteLine("Usuario no encontrado");
            }

        }

        public void Dispose()
        {


            // Cierra la conexión en el método Dispose
            dbConnection.Dispose();


        }
    }
}