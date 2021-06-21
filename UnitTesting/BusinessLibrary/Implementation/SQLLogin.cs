using BusinessLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLibrary.Implementation
{
    public class SQLLogin : ILogin
    {
        private string _connString;
        public SQLLogin(string connString)
        {
            _connString = connString;
        }

        public bool Login(string userID, string pin)
        {
            var sqlConnection = new SqlConnection(_connString);
            var sqlCommand = new SqlCommand($"select count(*) from [User] where UserName = '{userID}' and Password = '{pin}'", sqlConnection)
            {
                CommandType = System.Data.CommandType.Text
            };

            try
            {
                sqlCommand.Connection.Open();
                var result = sqlCommand.ExecuteScalar();
                return (result != null && (int)result > 0);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }
    }
}
