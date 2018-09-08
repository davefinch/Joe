using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Russell
{
    public class Sql : IDisposable
    {
        /// <summary>
        /// Indicate if object has been disposed or not. This is to allow Dispose to be called multiple times without crashing
        /// </summary>
        /// 
        private bool _isDisposed = false;

        /// ----------------------------------------------------------------------------------------------------------------------------
        /// <summary>Dispose method for class</summary>
        /// 
        /// <param name='disposing'>Indicates if disposing or not</param>
        /// 
        /// <returns>void</returns>
        ///
        /// <remarks>
        /// Free up all the managed and un-managed resources. I have dealt with these in code so nothing to do here at moment
        /// </remarks>
        /// ----------------------------------------------------------------------------------------------------------------------------
        protected void Dispose(bool disposing)
        {
            // Get out of here if disposed already
            if (_isDisposed) return;

            // Do we Need to Free Managed Resources we have none as using block used 
            if (disposing)
            {
                // Put code in here to close down managed resources such as DB connection. 
            }

            // Clean up all unmanged resources here
            // We have none as all are managed in using blocks anyway
            _isDisposed = true;
        }

        /// ----------------------------------------------------------------------------------------------------------------------------
        /// <summary>Dispose method for class</summary>
        /// 
        /// <returns>void</returns>
        ///
        /// <remarks>
        /// Free up all the managed and un-managed resources. I have dealt with these in code so nothing to do here at moment
        /// </remarks>
        /// ----------------------------------------------------------------------------------------------------------------------------
        public void Dispose()
        {
            Dispose(true);
        }

        /// ----------------------------------------------------------------------------------------------------------------------------
        /// <summary>Provides details reagrdaing the class</summary>
        /// 
        /// <returns>Information reagrding the class</returns>
        ///
        /// <remarks>
        /// Overide the existing ToString() method to provide additional information on the class
        /// </remarks>
        /// ----------------------------------------------------------------------------------------------------------------------------
        public override string ToString()
        {
            return "Sql Class";
        }

        public List<DataJob> SQLGetJobs(int EditJobId)
        {
            // Assign Empty Values


            List<DataJob> listDataJob = new List<DataJob>();

            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT j.JobId, j.EmployeeId, e.FirstName, e.LastName, j.AgencyId, a.AgencyName, j.JobDetails, ");
                    sb.AppendLine("j.StartJob, j.EndJob, j.PaymentReceived, j.TotalPayment  ");
                    sb.AppendLine("FROM Job j INNER JOIN ");
                    sb.AppendLine("Employee e ON e.EmployeeId = j.EmployeeId INNER JOIN ");
                    sb.AppendLine("Agency a ON a.AgencyId = j.AgencyId ");
                    if (EditJobId > 0) { sb.AppendLine("WHERE j.JobId = @EditJobId "); }
                    sb.AppendLine("ORDER BY j.StartJob DESC ");


                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    if (EditJobId > 0) { comm.Parameters.AddWithValue("EditJobId", EditJobId); }

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        sb.Clear();

                        while (reader.Read())
                        {
                            DataJob dj = new DataJob();

                            // Assign our Output Variables
                            dj.JobId = Convert.ToInt32(reader["JobId"]);

                            dj.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                            dj.EmployeeFirstName = reader["FirstName"].ToString();
                            dj.EmployeeLastName = reader["LastName"].ToString();

                            dj.AgencyId = Convert.ToInt32(reader["AgencyId"]);
                            dj.AgencyName = reader["AgencyName"].ToString();

                            dj.JobDetails = reader["JobDetails"].ToString();

                            int ordinal = reader.GetOrdinal("StartJob");
                            dj.StartJob = reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDateTime(reader["StartJob"]);
                            ordinal = reader.GetOrdinal("EndJob");
                            dj.EndJob = reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDateTime(reader["EndJob"]);

                            dj.TotalPayment = Convert.ToDecimal(reader["TotalPayment"]);
                            dj.PaymentReceived = Convert.ToBoolean(reader["PaymentReceived"]);

                            //dj.Hours = Convert.ToInt32(reader["Hours"]);
                            //dj.Rate = Convert.ToDecimal(reader["Rate"]);

                            //ordinal = reader.GetOrdinal("PaymentReceivedDate");
                            //dj.PaymentReceivedDate = reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDateTime(reader["PaymentReceivedDate"]);
                            //ordinal = reader.GetOrdinal("TotalPaymentReceived");



                            // Add to the DataRecord
                            listDataJob.Add(dj);

                        }
                    }

                    return listDataJob;

                }

            }

        }

        public List<DataJob> OLEGetJobs(int EditJobId)
        {
            // Assign Empty Values
            List<DataJob> listDataJob = new List<DataJob>();

            using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OleDbCommand comm = new OleDbCommand())
                {

                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("SELECT Job.JobId, Job.EmployeeId, Job.AgencyId, Agency.AgencyName, Job.JobDetails, Job.StartJob, Job.EndJob, ");
                    sb.AppendLine("Job.TotalPayment, Job.PaymentReceived, Employee.FirstName, Employee.LastName ");
                    sb.AppendLine("FROM (Job LEFT JOIN Agency ON Job.AgencyId = Agency.AgencyId) "); 
                    sb.AppendLine("INNER JOIN Employee ON Job.EmployeeId = Employee.EmployeeId ");
                    if (EditJobId > 0) { sb.AppendLine("WHERE Job.JobId = @EditJobId "); }
                    sb.AppendLine("ORDER BY Job.EndJob DESC;");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;

                    comm.Parameters.Clear();
                    if (EditJobId > 0) { comm.Parameters.AddWithValue("EditJobId", EditJobId); }

                    using (OleDbDataReader reader = comm.ExecuteReader())
                    {
                        sb.Clear();

                        while (reader.Read())
                        {
                            DataJob dj = new DataJob();

                            // Assign our Output Variables
                            dj.JobId = Convert.ToInt32(reader["JobId"]);

                            dj.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                            dj.EmployeeFirstName = reader["FirstName"].ToString();
                            dj.EmployeeLastName = reader["LastName"].ToString();
                            dj.AgencyId = Convert.ToInt32(reader["AgencyId"]);
                            dj.AgencyName = reader["AgencyName"].ToString();
                            dj.JobDetails = reader["JobDetails"].ToString();
                            int ordinal = reader.GetOrdinal("StartJob");
                            dj.StartJob = reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDateTime(reader["StartJob"]);
                            ordinal = reader.GetOrdinal("EndJob");
                            dj.EndJob = reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDateTime(reader["EndJob"]);
                            dj.TotalPayment = Convert.ToDecimal(reader["TotalPayment"]);
                            dj.PaymentReceived = Convert.ToBoolean(reader["PaymentReceived"]);

                            // Add to the DataRecord
                            listDataJob.Add(dj);
                        }
                    }
                    return listDataJob;
                }
            }
        }


        public int SQLInsertNewJob(DataJob dj)
        {
            int newJobId = 0;
            List<DataJob> listDataJob = new List<DataJob>();

            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("INSERT INTO Job (EmployeeId, AgencyId, JobDetails, StartJob, Endjob, PaymentReceived, TotalPayment) ");
                    sb.AppendLine("OUTPUT Inserted.JobId ");
                    sb.AppendLine("VALUES (@EmployeeId, @AgencyId, @JobDetails, @StartJob, @EndJob, @PaymentReceived, @TotalPayment) ");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@EmployeeId", dj.EmployeeId);
                    comm.Parameters.AddWithValue("@AgencyId", dj.AgencyId);
                    comm.Parameters.AddWithValue("@JobDetails", dj.JobDetails);
                    comm.Parameters.AddWithValue("@StartJob", dj.StartJob);
                    comm.Parameters.AddWithValue("@Endjob", dj.EndJob);
                    comm.Parameters.AddWithValue("@PaymentReceived", dj.PaymentReceived);
                    comm.Parameters.AddWithValue("@TotalPayment", dj.TotalPayment);

                    newJobId = Convert.ToInt32(comm.ExecuteScalar());

                    return newJobId;
                }
            }
        }

        public void OLEInsertNewJob(DataJob dj)
        {
            //int newJobId = 0;
            List<DataJob> listDataJob = new List<DataJob>();

            using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OleDbCommand comm = new OleDbCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("INSERT INTO Job (EmployeeId, AgencyId, JobDetails, StartJob, Endjob, PaymentReceived, TotalPayment) ");
                    sb.AppendLine("VALUES (@EmployeeId, @AgencyId, @JobDetails, @StartJob, @EndJob, @PaymentReceived, @TotalPayment) ");
                    comm.CommandText = sb.ToString();
                   
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@EmployeeId", dj.EmployeeId);
                    comm.Parameters.AddWithValue("@AgencyId", dj.AgencyId);
                    comm.Parameters.AddWithValue("@JobDetails", dj.JobDetails);
                    comm.Parameters.AddWithValue("@StartJob", Convert.ToDateTime(dj.StartJob).ToString());
                    comm.Parameters.AddWithValue("@Endjob", Convert.ToDateTime(dj.EndJob).ToString());
                    comm.Parameters.AddWithValue("@PaymentReceived", dj.PaymentReceived);
                    comm.Parameters.AddWithValue("@TotalPayment", dj.TotalPayment);

                    comm.ExecuteNonQuery();

                    return;
                }
            }
        }

        public void SQLUpdateExistingJob(DataJob dj)
        {
            List<DataJob> listDataJob = new List<DataJob>();

            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("UPDATE Job SET AgencyId = @AgencyId, JobDetails = @JobDetails, StartJob = @StartJob, ");
                    sb.AppendLine("Endjob = @EndJob, PaymentReceived = @PaymentReceived, TotalPayment = @TotalPayment ");
                    sb.AppendLine("WHERE JobId = @JobId");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@JobId", dj.JobId);
                    comm.Parameters.AddWithValue("@AgencyId", dj.AgencyId);
                    comm.Parameters.AddWithValue("@JobDetails", dj.JobDetails);
                    comm.Parameters.AddWithValue("@StartJob", dj.StartJob);
                    comm.Parameters.AddWithValue("@Endjob", dj.EndJob);
                    comm.Parameters.AddWithValue("@PaymentReceived", dj.PaymentReceived);
                    comm.Parameters.AddWithValue("@TotalPayment", dj.TotalPayment);

                    comm.ExecuteScalar();

                    return;
                }
            }
        }

        public void OLEUpdateExistingJob(DataJob dj)
        {
            List<DataJob> listDataJob = new List<DataJob>();

            using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OleDbCommand comm = new OleDbCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("UPDATE Job SET AgencyId = @AgencyId, JobDetails = @JobDetails, StartJob = @StartJob, ");
                    sb.AppendLine("Endjob = @EndJob, PaymentReceived = @PaymentReceived, TotalPayment = @TotalPayment ");
                    sb.AppendLine("WHERE JobId = @JobId");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@JobId", dj.JobId);
                    comm.Parameters.AddWithValue("@AgencyId", dj.AgencyId);
                    comm.Parameters.AddWithValue("@JobDetails", dj.JobDetails);
                    comm.Parameters.AddWithValue("@StartJob", dj.StartJob);
                    comm.Parameters.AddWithValue("@Endjob", dj.EndJob);
                    comm.Parameters.AddWithValue("@PaymentReceived", dj.PaymentReceived);
                    comm.Parameters.AddWithValue("@TotalPayment", dj.TotalPayment);

                    comm.ExecuteScalar();

                    return;
                }
            }
        }


        public bool SQLCheckJobExists(int exisitingJobId)
        {
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT COUNT(*) FROM Job WHERE JobId = @ExisitingJobId");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@ExisitingJobId", exisitingJobId);

                    return (Convert.ToInt32(comm.ExecuteScalar()) > 0);
                }
            }
        }

        public bool OLECheckJobExists(int exisitingJobId)
        {
            using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OleDbCommand comm = new OleDbCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT COUNT(*) FROM Job WHERE JobId = @ExisitingJobId");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@ExisitingJobId", exisitingJobId);

                    return (Convert.ToInt32(comm.ExecuteScalar()) > 0);
                }
            }
        }


        public Dictionary<string, int> SQLGetAgencies()
        {
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT AgencyName, AgencyId ");
                    sb.AppendLine("FROM Agency ");
                    sb.AppendLine("ORDER BY AgencyName");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;

                    Dictionary<string, int> agencies = new Dictionary<string, int>();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            agencies.Add(reader["AgencyName"].ToString(), Convert.ToInt32(reader["AgencyId"]));
                        }
                    }
                    return agencies;
                }

            }
        }

        public Dictionary<string, int> OLEGetAgencies()
        {
            using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OleDbCommand comm = new OleDbCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT AgencyName, AgencyId ");
                    sb.AppendLine("FROM Agency ");
                    sb.AppendLine("ORDER BY AgencyName");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;

                    Dictionary<string, int> agencies = new Dictionary<string, int>();

                    using (OleDbDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            agencies.Add(reader["AgencyName"].ToString(), Convert.ToInt32(reader["AgencyId"]));
                        }
                    }
                    return agencies;
                }
            }
        }



        public void SQLDeleteJob(int jobId)
        {
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("DELETE FROM Job ");
                    sb.AppendLine("WHERE JobId = @JobId ");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@JobId", jobId);
                    
                    Convert.ToInt32(comm.ExecuteScalar());

                    return;
                }
            }
        }

        public void OLEDeleteJob(int jobId)
        {
            using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OleDbCommand comm = new OleDbCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("DELETE FROM Job ");
                    sb.AppendLine("WHERE JobId = @JobId ");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@JobId", jobId);

                    Convert.ToInt32(comm.ExecuteScalar());

                    return;
                }
            }
        }

        public void SQLMarkRowAsPaid(int jobId)
        {
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("UPDATE Job SET PaymentReceived = 1 ");
                    sb.AppendLine("WHERE JobId = @JobId ");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@JobId", jobId);

                    Convert.ToInt32(comm.ExecuteScalar());

                    return;
                }
            }
        }

        public void OLEMarkRowAsPaid(int jobId)
        {
            using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OleDbCommand comm = new OleDbCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("UPDATE Job SET PaymentReceived = 1 ");
                    sb.AppendLine("WHERE JobId = @JobId ");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@JobId", jobId);

                    Convert.ToInt32(comm.ExecuteScalar());

                    return;
                }
            }
        }
        public void SQLMarkRowAsUnPaid(int jobId)
        {
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("UPDATE Job SET PaymentReceived = 0 ");
                    sb.AppendLine("WHERE JobId = @JobId ");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@JobId", jobId);

                    Convert.ToInt32(comm.ExecuteScalar());

                    return;
                }
            }
        }

        public void OLEMarkRowAsUnPaid(int jobId)
        {
            using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OleDbCommand comm = new OleDbCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("UPDATE Job SET PaymentReceived = 0 ");
                    sb.AppendLine("WHERE JobId = @JobId ");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@JobId", jobId);

                    Convert.ToInt32(comm.ExecuteScalar());

                    return;
                }
            }
        }
        public string GetAgencyWebsite(int agencyId)
        {
            string agencyWebsite;

            if (Constants.DBMS == "MSSQL")
            {
                using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand comm = new SqlCommand())
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("SELECT Website FROM Agency");
                        sb.AppendLine("WHERE AgencyId = @AgencyId ");

                        comm.CommandText = sb.ToString();
                        comm.Connection = conn;
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@AgencyId", agencyId);

                        agencyWebsite = (comm.ExecuteScalar().ToString());

                        return agencyWebsite;
                    }
                }
            }
            else
            {
                using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
                {
                    conn.Open();

                    using (OleDbCommand comm = new OleDbCommand())
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("SELECT Website FROM Agency");
                        sb.AppendLine("WHERE AgencyId = @AgencyId ");

                        comm.CommandText = sb.ToString();
                        comm.Connection = conn;
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@AgencyId", agencyId);

                        agencyWebsite = (comm.ExecuteScalar().ToString());

                        return agencyWebsite;
                    }
                }
            }
        }

        public List<DataFinance> SQLGetOutstandingInvoiceAmounts()
        {
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT 'Sum30Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND ");
                    sb.AppendLine("(j.EndJob BETWEEN DATEADD(mm, -1, GETDATE()) AND GETDATE()) UNION ");
                    sb.AppendLine("SELECT 'Sum60Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND ");
                    sb.AppendLine("(j.EndJob BETWEEN DATEADD(mm, -2, GETDATE()) AND DATEADD(mm, -1, GETDATE())) UNION ");
                    sb.AppendLine("SELECT 'Sum90Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND ");
                    sb.AppendLine("(j.EndJob BETWEEN DATEADD(mm, -3, GETDATE()) AND DATEADD(mm, -2, GETDATE())) UNION ");
                    sb.AppendLine("SELECT 'Over90Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND ");
                    sb.AppendLine("(j.EndJob < DATEADD(mm, -3, GETDATE())) ");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;

                    comm.ExecuteScalar().ToString();

                    List<DataFinance> listAmounts = new List<DataFinance>();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataFinance df = new DataFinance();

                            //listAmounts.Tota   .Add(reader["AgencyName"].ToString(), Convert.ToInt32(reader["AgencyId"]);
                            df.TotalName = reader["DateRange"].ToString();
                            df.TotalAmount = reader["Total"].ToString();
                            
                            // Add to the DataRecord
                            listAmounts.Add(df);
                        }
                    }

                    return listAmounts;
                }
            }
        }

        public List<DataFinance> OLEGetOutstandingInvoiceAmounts()
        {
            using (OleDbConnection conn = new OleDbConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OleDbCommand comm = new OleDbCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT 'Sum30Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND ");
                    sb.AppendLine("(j.EndJob BETWEEN DateAdd('m', -1, Date()) AND Date()) UNION ");
                    sb.AppendLine("SELECT 'Sum60Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND ");
                    sb.AppendLine("(j.EndJob BETWEEN DateAdd('m', -2, Date()) AND DateAdd('m', -1, Date())) UNION ");
                    sb.AppendLine("SELECT 'Sum90Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND ");
                    sb.AppendLine("(j.EndJob BETWEEN DateAdd('m', -3, Date()) AND DateAdd('m', -2, Date())) UNION ");
                    sb.AppendLine("SELECT 'Over90Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND ");
                    sb.AppendLine("(j.EndJob < DateAdd('m', -3, Date())) ");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;

                    comm.ExecuteScalar().ToString();

                    List<DataFinance> listAmounts = new List<DataFinance>();

                    using (OleDbDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataFinance df = new DataFinance();

                            //listAmounts.Tota   .Add(reader["AgencyName"].ToString(), Convert.ToInt32(reader["AgencyId"]);
                            df.TotalName = reader["DateRange"].ToString();
                            df.TotalAmount = reader["Total"].ToString();

                            // Add to the DataRecord
                            listAmounts.Add(df);
                        }
                    }

                    return listAmounts;
                }
            }
        }


        public List<DataChart> SQLGetChartData()
        {
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(";WITH alltransactions");
                    sb.AppendLine("AS");
                    sb.AppendLine("(");
                    sb.AppendLine("    SELECT      MIN(StartJob) AS continuousdate");
                    sb.AppendLine("            ,   MAX(StartJob) AS maximumdate");
                    sb.AppendLine("    FROM        Job");
                    sb.AppendLine("    WHERE           StartJob > DATEADD(year, -1, GETDATE())");
                    sb.AppendLine("    UNION ALL ");
                    sb.AppendLine("    SELECT      DATEADD(MONTH, 1, continuousdate) AS continuousdate");
                    sb.AppendLine("            ,   maximumdate");
                    sb.AppendLine("    FROM        alltransactions");
                    sb.AppendLine("    WHERE       DATEADD(MONTH, 1, continuousdate) <= DATEADD(MONTH, 1, maximumdate)");
                    sb.AppendLine(")");
                    sb.AppendLine("SELECT          YEAR(at.continuousdate)     AS [Year]");
                    sb.AppendLine("            ,   MONTH(at.continuousdate)    AS [Month]");
                    sb.AppendLine("			,   DATENAME(MONTH, at.continuousdate) + ' ' + CONVERT(CHAR(4), YEAR(at.continuousdate)) AS PeriodName");
                    sb.AppendLine("            ,   COUNT(j2.StartJob)        AS [Count]");
                    sb.AppendLine("FROM            alltransactions at");
                    sb.AppendLine("LEFT OUTER JOIN Job j2");
                    sb.AppendLine("ON              YEAR(at.continuousdate)     = YEAR(j2.StartJob)");
                    sb.AppendLine("AND             MONTH(at.continuousdate)    = MONTH(j2.StartJob)");
                    sb.AppendLine("GROUP BY        YEAR(at.continuousdate)");
                    sb.AppendLine("            ,   MONTH(at.continuousdate)");
                    sb.AppendLine("			,   DATENAME(MONTH, at.continuousdate) + ' ' + CONVERT(CHAR(4), YEAR(at.continuousdate))");
                    sb.AppendLine("ORDER BY        [Year]");
                    sb.AppendLine("            ,   [Month];");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;

                    comm.ExecuteScalar().ToString();

                    List<DataChart> listAmounts = new List<DataChart>();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataChart dc = new DataChart();

                            dc.JobPeriod = reader["PeriodName"].ToString();
                            dc.TotalJobs = Convert.ToInt32(reader["Count"]);

                            // Add to the DataRecord
                            listAmounts.Add(dc);
                        }
                    }

                    return listAmounts;
                }

            }
        }


    }

}


