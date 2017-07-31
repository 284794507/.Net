using Dapper;
using DBServer.Model;
using DBServer.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServer.Business
{
    public class SqlServerHandler
    {
        private static SqlServerHandler _SqlServerHandler;
        public static SqlServerHandler GetHandler
        {
            get
            {
                if(_SqlServerHandler==null)
                {
                    _SqlServerHandler = new SqlServerHandler();
                }
                return _SqlServerHandler;
            }
        }

        public  SqlConnection GetSqlConn(string SqlConnStr)
        {
            SqlConnection conn = new SqlConnection(SqlConnStr);
            conn.Open();
            return conn;
        }

        public SqlConnection GetSqlConn()
        {
            SqlConnection conn = new SqlConnection(Share.GetSqlConnStr);
            conn.Open();
            return conn;
        }

        public List<tCTUInfo> GetALLCtuInfo()
        {
            using (IDbConnection conn = GetSqlConn())
            {
                string sql = "Select * from tCTUInfo";
                List<tCTUInfo> ctuList=conn.Query<tCTUInfo>(sql).ToList();

                return ctuList;
            }
        }
    }
}
