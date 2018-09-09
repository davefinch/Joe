using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;

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
            
            // ********* Cannot store password in GitHub as MS picks it up and flags it as a security risk **********
            //ConnectionString = ConfigurationManager.ConnectionStrings["Joe"].ConnectionString;
            ConnectionString = "Data Source=logsysdev.database.windows.net;Initial Catalog=Joe;user id=finchd;password=LuckyStrike123";

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
