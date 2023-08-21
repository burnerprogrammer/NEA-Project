using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    internal class Database
    {

        private OleDbConnection databaseConnection;
        
        public Database()
        {

            string test = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:/Users/ibnsh/source/repos/NEA Project/Database/NEADatabase.accdb";
            databaseConnection = new OleDbConnection(test
            );
        }
        
        // registration stuff

        public void AddNewUser()
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO Accounts(Username) VALUES ('Adam')", databaseConnection);

            databaseConnection.Open();
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }


    }
}
