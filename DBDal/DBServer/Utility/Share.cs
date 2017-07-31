using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServer.Utility
{
    public class Share
    {
        private static Share _Share;
        public static Share GetHandler
        {
            get
            {
                if(_Share==null)
                {
                    _Share = new Share();
                }
                return _Share;
            }
        }

        private static string SqlServerConnStr;
        public static string GetSqlConnStr
        {
            get
            {
                if(String.IsNullOrEmpty(SqlServerConnStr))
                {
                    SqlServerConnStr= ConfigurationManager.ConnectionStrings["SqlServerConnStr"].ToString();
                }
                return SqlServerConnStr;
            }
        }
    }
}
