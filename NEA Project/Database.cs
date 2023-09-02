using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Drawing;

namespace Prototype1
{
    internal class Database
    {

        // make everything here static, so you dont have to instantiate Database wherever you wanna use it

        private static OleDbConnection databaseConnection = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:/Users/ibnsh/source/repos/NEA Project/Database/NEADatabase.accdb");
       
        
        // registration stuff



        public static void Add_New_User(string username,string password)
        {
            databaseConnection.Open();
            string command =
                $" INSERT INTO Accounts (Username, [Password]) VAlUES ('{username}' , '{password}') ";
            OleDbCommand cmd = new OleDbCommand(command, databaseConnection);
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
        }
        public static bool User_Exists(string username) 
        {
            databaseConnection.Open();
            string command =
                $"SELECT COUNT(Username) FROM Accounts WHERE Username = '{username}'";
            OleDbCommand cmd = new OleDbCommand(command, databaseConnection);
            int count = (int)cmd.ExecuteScalar();
            databaseConnection.Close();

            return (count > 0);
        }

    }
}
