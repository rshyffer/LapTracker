using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LapTracker
{
    internal class SQLiteDatabase
    {
        private const string defaultDbConnection = "Data Source=database.s3db";
        private readonly string dbConnection;

        public SQLiteDatabase()
            : this(defaultDbConnection)
        {          
        }

        public SQLiteDatabase(string dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public DataTable GetDataTable(string sql)
        {
            try
            {
                var dataTable = new DataTable();
                using (var connection = new SQLiteConnection(dbConnection))
                {
                    connection.Open();
                    var command = new SQLiteCommand(connection) {CommandText = sql};
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
            catch (Exception e)
            {
                //TODO: Log Exception
                return null;
            }
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                using (var connection = new SQLiteConnection(dbConnection))
                {
                    connection.Open();
                    var command = new SQLiteCommand(connection) {CommandText = sql};
                    var rowsUpdated = command.ExecuteNonQuery();
                    return rowsUpdated;
                }
            }
            catch (Exception e)
            {
                //TODO: Log Exception
                return -1;
            }

        }

        public string ExecuteScalar(string sql)
        {
            try
            {
                using (var connection = new SQLiteConnection(dbConnection))
                {
                    connection.Open();
                    var command = new SQLiteCommand(connection) {CommandText = sql};
                    var value = command.ExecuteScalar();
                    if (value != null)
                    {
                        return value.ToString();
                    }
                    return string.Empty;
                }
            }
            catch (Exception e)
            {
                //TODO: Log Exception
                return string.Empty;
                ;
            }
        }

        public bool Update(String tableName, Dictionary<String, String> data, String where)
        {
            var vals = string.Empty;
            if (data.Count >= 1)
            {
                vals = data.Aggregate(vals,
                    (current, val) =>
                        current +
                        String.Format(" {0} = '{1}',", val.Key.ToString(CultureInfo.InvariantCulture),
                            val.Value.ToString(CultureInfo.InvariantCulture)));
                vals = vals.Substring(0, vals.Length - 1);
            }
            try
            {
                ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where));
                return true;
            }
            catch (Exception e)
            {
                //TODO: Log Exception
                return false;
            }
        }


        public bool Delete(String tableName, String where)
        {
            try
            {
                ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));
                return true;
            }
            catch (Exception fail)
            {
                //TODO: Log Exception
                return false;
            }
        }

        public bool Insert(String tableName, Dictionary<String, String> data)

        {
            var columns = string.Empty;
            var values = string.Empty;
            foreach (var val in data)
            {
                columns += String.Format(" {0},", val.Key);
                values += String.Format(" '{0}',", val.Value);
            }
            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);
            try
            {
                var result = ExecuteNonQuery(String.Format("insert into {0}({1}) values({2});", tableName, columns, values));
                return result >= 0;
            }
            catch (Exception e)
            {
                //TODO: Log Exception
                return false;
            }
        }

        public bool ClearDB()
        {
            try
            {
                var tables = GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");
                foreach (DataRow table in tables.Rows)
                {
                    ClearTable(table["NAME"].ToString());
                }
                return true;
            }
            catch (Exception e)
            {
                //TODO: Log Exception
                return false;
            }
        }

        public bool ClearTable(String table)
        {
            try
            {
                ExecuteNonQuery(String.Format("delete from {0};", table));
                return true;
            }
            catch (Exception e)
            {
                //TODO: Log Exception
                return false;
            }
        }

        public static string DateTimeToSQLiteString(DateTime datetime)
        {
            return datetime.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
    }
}
