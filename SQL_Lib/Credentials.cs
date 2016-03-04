using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lib
{
    public class Credentials
    {
        private static string userName;
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private static string userEmail;
        public static string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
        private static string givenName;
        public static string GivenName
        {
            get { return givenName; }
            set { givenName = value; }
        }
        private static string familyName;
        public static string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }
        private static string position;
        public static string Position
        {
            get { return position; }
            set { position = value; }
        }

        public static void StoreCredentials(string userName, string userEmail, string givenName, string familyName, string position)
        {
            UserName = userName;
            UserEmail = userEmail;
            GivenName = givenName;
            FamilyName = familyName;
            Position = position;
        }
    }
}
