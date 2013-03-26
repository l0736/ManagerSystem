using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ManagerSystem.Module
{
    public static class MySQLT
    {
        private static MySqlConnection conn;
        public static MySqlCommand cmd;
        private static String host;
        private static String dbName;
        private static String user;
        private static String password;
        private static int port;
        private static String connetion;

        public static void setDataBase(String host, String dbName, String password, String user, int port)
        {
            MySQLT.host = host;
            MySQLT.dbName = dbName;
            MySQLT.user = user;
            MySQLT.password = password;
            MySQLT.port = port;
            connetion = "server=" + host + ";user=" + user + ";database=" + dbName + ";port=" + port + ";password=" + password + ";";
            conn = new MySqlConnection(connetion);
            cmd = new MySqlCommand();
        }

        public static MySqlCommand getMySqlCommand()
        {
            if (cmd != null)
            {
                return cmd;
            }
            return null;
        }

        public static MySqlConnection getMySqlConnection()
        {
            if (conn != null)
            {
                return conn;
            }
            return null;
        }
    }
}