using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Syntax_Error___4Pics_1Word
{
    public class DataAccesss
    {
        private static string cnnString = "PROVIDER=MICROSOFT.ACE.OLEDB.12.0;Data Source = " + Application.StartupPath + @"\4Pics1WordDB.accdb";
        private static OleDbConnection cn = new OleDbConnection();
        private static OleDbCommand command;
        private static OleDbDataReader reader;
        
        public static string GetWord()          //Get all the unanswered word in the database
        {
            cn.ConnectionString = cnnString;
            var word = "";
            if(cn.State == ConnectionState.Closed)
            {
                cn.Open();
                string sql = "SELECT * FROM [Stages] where [Status] = No";
                command = new OleDbCommand();
                command.Connection = cn;
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    word = reader["Word"].ToString().ToUpper();
                }
            }
            cn.Close();
            command.Dispose();
            return word;
        }



    }
}
