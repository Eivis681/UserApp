using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace UserApp
{
    public class GetData
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=C:\\Users\\PC\\Desktop\\UserApp\\UserApp\\student.db; Version = 3; New = True; Compress = True; ");
        public List<string> getStudentCodes()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select AsmensKodas from Student ";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<string> studentCodes = new List<string>();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                studentCodes.Add(myreader);
            }
            sqlite_conn.Close();
            return studentCodes;
        }
    }
}