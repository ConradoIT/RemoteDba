using RemoteDba.Terminal.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RemoteDba.Terminal.DataAcess
{
    public class Connection : IDisposable
    {
        private readonly SqlConnection _sqlConnetion;
        private readonly StringBuilder _sql;
        private readonly List<SqlParameter> _parameters;

        public Connection ()
        {
            _sqlConnetion = new SqlConnection(Manager.ConnectionString());
            _sqlConnetion.Open();
            _sql = new StringBuilder();
            _parameters = new List<SqlParameter>();
        }

        public StringBuilder SQL { get => _sql; }
        public List<SqlParameter> Parameters { get => _parameters; }

        public void Dispose()
        {
            _sqlConnetion.Dispose();
        }
    }
}
