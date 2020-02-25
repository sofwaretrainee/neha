using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseLayer
{
    
        public class MySqlDataAccess : IDatabaseHandler
        {
            private string ConnectionString { get; set; }

            public MySqlDataAccess(string connectionString)
            {
                ConnectionString = connectionString;
            }

            public IDbConnection CreateConnection()
            {
                return new MySqlConnection(ConnectionString);
            }

            public void CloseConnection(IDbConnection connection)
            {
                var MysqlConnection = (MySqlConnection)connection;
                MysqlConnection.Close();
                MysqlConnection.Dispose();
            }

            public IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection)
            {
                return new MySqlCommand
                {
                    CommandText = commandText,
                    Connection = (MySqlConnection)connection,
                    CommandType = commandType
                };
            }

            public IDataAdapter CreateAdapter(IDbCommand command)
            {
                return new MySqlDataAdapter((MySqlCommand)command);
            }

            public IDbDataParameter CreateParameter(IDbCommand command)
            {
                MySqlCommand SQLcommand = (MySqlCommand)command;
                return SQLcommand.CreateParameter();
            }
        }
    }
