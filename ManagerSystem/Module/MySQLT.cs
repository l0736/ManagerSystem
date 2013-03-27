using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            setConnection();
        }

        public static void setDataBase(String host, String dbName, String password, String user)
        {
            setDataBase(host, dbName, password, user, 3306);
        }

        public static void setDataBase(String host, String dbName, String password)
        {
            setDataBase(host, dbName, password, "root", 3306);
        }

        private static void setConnection()
        {
            connetion = "server=" + host + ";user=" + user + ";database=" + dbName + ";port=" + port + ";password=" + password + ";";
            conn = new MySqlConnection(connetion);
            cmd = new MySqlCommand();
        }

        public static void setHost(String host)
        {
            MySQLT.host = host;
        }

        public static void setUser(String user)
        {
            MySQLT.user = user;
        }

        public static void setPassword(String password)
        {
            MySQLT.password = password;
        }

        public static void setDBname(String dbName)
        {
            MySQLT.dbName = dbName;
        }

        public static void setPort(int port)
        {
            MySQLT.port = port;
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

        private static Boolean isOpen()
        {
            if (conn.State == ConnectionState.Open && conn != null)
            {
                return true;
            }
            return false;
        }

        private static Boolean isClose()
        {
            if (conn.State == ConnectionState.Closed && conn != null)
            {
                return true;
            }
            return false;
        }

        private static Boolean isConnetion()
        {
            if (conn.State == ConnectionState.Connecting && conn != null)
            {
                return true;
            }
            return false;
        }

        public static Boolean Open()
        {
            if (isOpen() == false)
            {
                conn.Open();
                return true;
            }
            return false;
        }

        public static Boolean Close()
        {
            if (isClose() == false)
            {
                conn.Close();
                return true;
            }
            return false;
        }
    }
}