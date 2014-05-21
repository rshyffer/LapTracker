using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LapTracker
{
    class LapDatabase
    {
        private readonly SQLiteDatabase database = new SQLiteDatabase("Data Source=laps.s3db");

        private const string createLapTableSql =
            "CREATE TABLE lap(ID INTEGER PRIMARY KEY AUTOINCREMENT,DATE DATETIME NOT NULL,BARCODE TEXT NOT NULL);";
        private const string createRunnerTableSql =
            "CREATE TABLE runner(ID INTEGER PRIMARY KEY AUTOINCREMENT, BARCODE TEXT NOT NULL, FIRST_NAME TEXT NOT NULL, LAST_NAME TEXT NOT NULL, CLASS TEXT);";

        public LapDatabase()
        {
            CreateDatabaseIfMissing();
        }

        public bool AddLaps(List<Lap> laps)
        {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var lap in laps)
            {
                var entry = new Dictionary<string, string>
                {
                    {"BARCODE", lap.BarcodeId},
                    {"DATE", SQLiteDatabase.DateTimeToSQLiteString(lap.Time)}
                };
                if (!database.Insert("lap", entry))
                {
                    return false;
                }
            }
            return true;
        }

        public DataTable GetAllLaps()
        {
            var table = database.GetDataTable("select ID \"id\", BARCODE \"barcode\", DATE \"date\" from lap");
            return table;
//            return (from DataRow row in table.Rows select new Lap() {
//                    Id = (long) row["id"], 
//                    BarcodeId = (string) row["barcode"], 
//                    Time = (DateTime) row["date"]
//            }).ToList();
        }
        private bool CreateDatabaseIfMissing()
        {
            if (!DatabaseExists())
            {
                return CreateDatabase();
            }
            return true;
        }

        private bool DatabaseExists()
        {
            var tables = database.GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");
            if (tables.Rows.Count >= 2)
            {
                var tableNames = (from DataRow table in tables.Rows select table["NAME"].ToString()).ToList();
                if (tableNames.Contains("lap") && tableNames.Contains("runner"))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CreateDatabase()
        {
            if (!database.ClearDB())
            {
                return false;
            }
            if (database.ExecuteNonQuery(createLapTableSql) < 0)
            {
                return false;
            }
            if (database.ExecuteNonQuery(createRunnerTableSql) < 0)
            {
                return false;
            }
            return true;
        }
    }
}
