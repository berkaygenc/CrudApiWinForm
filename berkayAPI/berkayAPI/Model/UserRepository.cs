using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace berkayAPI.Model
{
    public class UserRepository
    {
        private string connectionString;

        public UserRepository()
        {
            connectionString = @"Data Source=LENOVO;Initial Catalog=berkayAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public IDbConnection Connection
        {
            get 
            {
                return new SqlConnection(connectionString); 
            }
        }

        public IEnumerable<User> GetAll()
        {
            using(IDbConnection dbConnection = Connection)
            {
                string sQuery = @"Select * FROM [User]";
                dbConnection.Open();
                return dbConnection.Query<User>(sQuery); 
            }
        }

        public  User GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"Select * FROM [User] Where Id=@Id";
                dbConnection.Open();
                return dbConnection.Query<User>(sQuery, new {Id=id}).FirstOrDefault();
            }
        }
        public bool Add(User user)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO [User] (Ad,Soyad) Values(@Ad,@Soyad)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, user);
                return true;      
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM [User] Where Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new {Id=id});
                return true;
            }
        }

        public bool Update(User user)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE [User] SET Ad=@Ad,Soyad=@Soyad Where Id=@Id";
                dbConnection.Open();
                dbConnection.Query(sQuery, user);
                return true;
            }
        }
    }
}
