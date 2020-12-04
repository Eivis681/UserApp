using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Web;

namespace UserApp
{
    public class AddData
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=C:\\Users\\PC\\Desktop\\UserApp\\UserApp\\student.db; Version = 3; New = True; Compress = True; ");
        public void addStudent(string vardas, string pavarde, string asmensKodas, string lytis, string adresas, string telefonoNumeris, string studPrograma,string studForma)
        {
            string dir = Directory.GetCurrentDirectory();
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Student (Vardas, Pavarde, Lytis, Adresas, TelefonoNumeris, StudPrograma,StudForma,AsmensKodas) VALUES('" + vardas + "' ,'" + pavarde + "' ,'" + lytis + "','" + adresas + "','" + telefonoNumeris + "','" + studPrograma + "','" + studForma + "','" + asmensKodas + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
    }
}