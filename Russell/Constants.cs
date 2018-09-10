using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;
using System.Xml;

namespace Russell
{
    public static class Constants
    {
        public static string ConnectionString { get; private set; }
        public static string UserFullName { get; private set; }
        public static int UserId { get; private set; }
        public static string StartupFolder { get; private set; }
        public static string AppName { get; private set; }
        public static string AppVersion { get; private set; }
        public static string DBMS { get; private set; }
        public enum RetrievalStatus
        {
            Single,
            Multiple
        };

        static Constants()
        {
            StartupFolder = ConfigurationManager.AppSettings["StartupFolder"];

            //ConnectionString = ConfigurationManager.ConnectionStrings["JO"].ConnectionString;

            // Get Secret from our external file
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Development\\PassPhrase.xml");
            XmlNode node = doc.DocumentElement.SelectSingleNode("passPhrase");
            string passPhrase = node.InnerText;
            // Assign the decrypted Connection String
            ConnectionString = Helper.Decrypt(ConfigurationManager.ConnectionStrings["Joe"].ConnectionString, passPhrase);

            UserFullName = UserPrincipal.Current.DisplayName;

            // Should get this from the DB but only one user for now
            if (UserFullName == "Russell")
            {
                UserId = 1;
                UserFullName = "Joe Finch";
            }
            else
            {
                UserId = 1;
                UserFullName = "Joe Finch";
            }

            AppName = ConfigurationManager.AppSettings["AplicationName"];
            AppVersion = ConfigurationManager.AppSettings["ApplicationVersion"];
            DBMS = ConfigurationManager.AppSettings["DBMS"];

        }

    }
}
