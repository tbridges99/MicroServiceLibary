using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Voltron.Hackathon.Context
{
    public class SqlConnectionFactory : ISqlConnectionFactory, IDisposable
    {
        private readonly string _connectionString;
        private IDbConnection _connection;

        /// <summary>
        /// Constuructor
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Creates & opens a connection specified in the connection string
        /// </summary>
        /// <returns>open connection</returns>
        public IDbConnection OpenConnection()
        {
            if (_connection == null)                                        //create connection
                _connection = new SqlConnection(_connectionString);

            if (_connection.State != ConnectionState.Open)                  //make sure connection is open, otherwise commands will fail
                _connection.Open();

            return _connection;
        }

        /// <summary>
        /// Disposes
        /// </summary>
        public void Dispose()
        {
            _connection?.Dispose();
        }

        /// <summary>
        /// Terminates & resets the connection
        /// </summary>
        /// <remarks>used in error handling situations</remarks>
        public void CloseConnection()
        {
            _connection?.Close();
            _connection = null;
        }
    }
}
