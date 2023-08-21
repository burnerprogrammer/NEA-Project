using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Prototype1
{
    internal class Database
    {

        private static OleDbConnection databaseConnection = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:/Users/ibnsh/source/repos/NEA Project/Database/NEADatabase.accdb");
       
        
        // registration stuff



        public static void AddNewUser()
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO Accounts(Username) VALUES ('qwertyuio')", databaseConnection);

            databaseConnection.Open();
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public static void DeleteUser()
        {

        }

        public static bool IsUserNameTaken()
        {
            return false;
        }
    }
}
