using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlTypes;
using System.Net.NetworkInformation;

namespace Prototype1
{
    internal class Database
    {

        // make everything here static, so you dont have to instantiate Database wherever you wanna use it

        private static OleDbConnection databaseConnection = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:/Users/ibnsh/source/repos/NEA Project/Database/NEADatabase.accdb");
       
        
        // registration stuff


        // adds new user to the accounts table
        public static void Add_New_User(string username,string password)
        {
            //generate salt
            // hash the password

            databaseConnection.Open();
            string command =
                $" INSERT INTO Accounts (Username, [Password]) VAlUES ('{username}' , '{password}') ";  // 
            OleDbCommand cmd = new OleDbCommand(command, databaseConnection);
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        // checks if user exists in database
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


        //checks to see if the password input is valid if valid then return true else return false
        public static bool Password_Valid(string password,string username)
        {
            
            databaseConnection.Open ();
            string command =
                $"SELECT Password FROM Accounts WHERE Username ='{username}'";
            OleDbCommand cmd = new OleDbCommand (command, databaseConnection);
            OleDbDataReader oleDbDataReader = cmd.ExecuteReader();

            string pass = "";
            while (oleDbDataReader.Read())
            {
                pass = oleDbDataReader["Password"].ToString();
            }
            databaseConnection.Close();

            if (password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void Add_Booking(string username, string class_name)
        {

            databaseConnection.Open();
            string command =
                $"SELECT ClassID FROM Classes WHERE Class_Name = '{class_name}'";
            OleDbCommand cmd = new OleDbCommand(command, databaseConnection);
            int classID = (int)cmd.ExecuteScalar();
            databaseConnection.Close();

            databaseConnection.Open();
            command =
                $"SELECT AccountID FROM Accounts WHERE Username = '{username}'";
            cmd = new OleDbCommand(command, databaseConnection);
            int userID = (int)cmd.ExecuteScalar();
            databaseConnection.Close();


            databaseConnection.Open();
             command =
                $" INSERT INTO Bookings (AccountID, ClassID) VAlUES ({userID} , {classID}) ";
             cmd = new OleDbCommand(command, databaseConnection);
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public static List<string[]> Get_Booked_Classes(string username)
        {
            List<string[]> list = new List<string[]>();
            databaseConnection.Open();
            string command =
                $"SELECT * " +
                $"FROM (Bookings " +
                $"RIGHT JOIN Accounts ON Bookings.AccountID = Accounts.AccountID)" +
                $"LEFT JOIN Classes ON Bookings.ClassID = Classes.ClassID" +
                $" WHERE Accounts.Username = '{username}'";
            OleDbCommand cmd = new OleDbCommand(command, databaseConnection);
            OleDbDataReader oleDbDataReader = cmd.ExecuteReader();
            while (oleDbDataReader.Read())
            {

                string[] record = new string[6];
                record[0] = oleDbDataReader["BookingID"].ToString(); 
                record[1] = oleDbDataReader["Username"].ToString();
                record[2] = oleDbDataReader["Class_Name"].ToString();
                record[3] = oleDbDataReader["Time"].ToString();
                record[4] = oleDbDataReader["Instructors"].ToString();
                record[5] = oleDbDataReader["Number_of_Slots"].ToString();
                list.Add(record);
            }
            databaseConnection.Close();
            return list;
        }

        public static void Delete_Booking(int bookingID)
        {
            databaseConnection.Open();
            string command =
                    $" DELETE FROM Bookings WHERE BookingID = {bookingID}";
            OleDbCommand cmd = new OleDbCommand(command, databaseConnection);
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
        }
    
    }
}
