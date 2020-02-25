using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DatabaseLayer
{
  public  interface IDatabaseHandler
    {
        IDbConnection CreateConnection();

        void CloseConnection(IDbConnection connection);

        IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection);

        IDataAdapter CreateAdapter(IDbCommand command);

        IDbDataParameter CreateParameter(IDbCommand command);
    }
}
