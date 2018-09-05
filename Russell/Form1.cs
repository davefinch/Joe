using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Russell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = Constants.AppName + " - " + Constants.UserFullName;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise the entry window job id 
            textBoxJobId.Text = "0";
            
            // Fill the dgv
            jobRefresh();

            // Update the finance info
            UpdateFinances();

            // Load up the Agency Combo Box
            using (Sql sql = new Sql())
            {
                Dictionary<string, int> listAgency = new Dictionary<string, int>();

                // Function determined by the type of db we are connecting to
                if (Constants.DBMS == "MSSQL") { listAgency = sql.SQLGetAgencies(); } else { listAgency = sql.OLEGetAgencies(); }

                comboBoxAgency.DataSource = listAgency.ToList();
                comboBoxAgency.DisplayMember = "Key";
                comboBoxAgency.ValueMember = "Value";
            }
        }


        private void dgv_DeleteSelectedRow()
        {

            string rowString = "row";
            if (dataGridViewJobs.SelectedRows.Count > 1) { rowString = "rows"; }

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete the selected " + rowString + "?", "Question",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewJobs.SelectedRows)
                {
                    //Remove from database
                    using (Sql sql = new Sql())
                    {
                        if (Constants.DBMS == "MSSQL")
                        {
                            sql.SQLDeleteJob(Convert.ToInt32(dataGridViewJobs.Rows[row.Index].Cells["JobId"].Value));
                        }
                        else
                        {
                            sql.OLEDeleteJob(Convert.ToInt32(dataGridViewJobs.Rows[row.Index].Cells["JobId"].Value));
                        }
                        
                    }
                    //Remove from DataGridView
                    dataGridViewJobs.Rows.RemoveAt(row.Index);
                }

                // Update the finance info
                UpdateFinances();

            }
        }


        private void dgv_EditSelectedRow()
        {
            if (dataGridViewJobs.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select just one job to edit.", "Information");
            }

            List<DataJob> listDataJob = new List<DataJob>();

            foreach (DataGridViewRow row in dataGridViewJobs.SelectedRows)
                {
                using (Sql sql = new Sql())
                {
                    // Function determined by the type of db we are connecting to
                    if (Constants.DBMS == "MSSQL")
                    {
                        listDataJob = sql.SQLGetJobs(Convert.ToInt32(dataGridViewJobs.Rows[row.Index].Cells["JobId"].Value));
                    }
                    else
                    {
                        listDataJob = sql.OLEGetJobs(Convert.ToInt32(dataGridViewJobs.Rows[row.Index].Cells["JobId"].Value));
                    }
                }

                foreach (DataJob item in listDataJob)
                {

                    //Populate the details
                    textBoxJobId.Text = item.JobId.ToString();
                    comboBoxAgency.SelectedValue = item.AgencyId;
                    textBoxjobDetails.Text = item.JobDetails;
                    dateTimePickerStartJob.Value = Convert.ToDateTime(item.StartJob);
                    dateTimePickerEndJob.Value = Convert.ToDateTime(item.EndJob);
                    checkBox1.Checked = item.PaymentReceived; // Cannot rename as pops open the save as dialog ?????
                    textBoxTotalPayment.Text = Math.Round(Convert.ToDecimal(item.TotalPayment), 2).ToString(); //item.TotalPayment.ToString();

                }
            }

                // Update the finance info
                UpdateFinances();
        }


        private void dgv_MarkRowAsPaid()
        {
            int rownumber = 0;
            foreach (DataGridViewRow row in dataGridViewJobs.SelectedRows)
            {
                //Remove from database
                using (Sql sql = new Sql())
                {
                    if (Constants.DBMS == "MSSQL")
                    {
                        sql.SQLMarkRowAsPaid(Convert.ToInt32(dataGridViewJobs.Rows[row.Index].Cells["JobId"].Value));
                    }
                    else
                    {
                        sql.OLEMarkRowAsPaid(Convert.ToInt32(dataGridViewJobs.Rows[row.Index].Cells["JobId"].Value));
                    }
                    rownumber = row.Index;
                }
            }

            //Refresh the dgv
            jobRefresh();

            //Select and scroll to the current row
            dataGridViewJobs.ClearSelection();
            dataGridViewJobs.Rows[rownumber].Selected = true;
            dataGridViewJobs.FirstDisplayedScrollingRowIndex = dataGridViewJobs.SelectedRows[0].Index;

            // Update the finance info
            UpdateFinances();

        }

        private void dgv_MarkRowAsUnPaid()
        {
            int rownumber = 0;
            foreach (DataGridViewRow row in dataGridViewJobs.SelectedRows)
            {
                //Remove from database
                using (Sql sql = new Sql())
                {
                    if (Constants.DBMS == "MSSQL")
                    {
                        sql.SQLMarkRowAsUnPaid(Convert.ToInt32(dataGridViewJobs.Rows[row.Index].Cells["JobId"].Value));
                    }
                    else
                    {
                        sql.OLEMarkRowAsUnPaid(Convert.ToInt32(dataGridViewJobs.Rows[row.Index].Cells["JobId"].Value));
                    }
                    rownumber = row.Index;
                }
            }

            //Refresh the dgv
            jobRefresh();

            //Select and scroll to the current row
            dataGridViewJobs.ClearSelection();
            dataGridViewJobs.Rows[rownumber].Selected = true;
            dataGridViewJobs.FirstDisplayedScrollingRowIndex = dataGridViewJobs.SelectedRows[0].Index;

            // Update the finance info
            UpdateFinances();

        }


        private void dgv_VisitAgency()
        {
            string agencyURL;

            foreach (DataGridViewRow row in dataGridViewJobs.SelectedRows)
            {
                //Remove from database
                using (Sql sql = new Sql())
                {
                    agencyURL = sql.GetAgencyWebsite(Convert.ToInt32(dataGridViewJobs.Rows[row.Index].Cells["AgencyId"].Value));
                    System.Diagnostics.Process.Start(agencyURL);
                }
            }
        }

       

        private void dataGridViewJobs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Double click to edit the clicked row
            dataGridViewJobs.ClearSelection();
            dataGridViewJobs.Rows[e.RowIndex].Selected = true;
            dgv_EditSelectedRow();
        }

        private void dataGridViewJobs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Set the cuurent row as highlighted
                ContextMenuStrip m = new ContextMenuStrip();
                m.Items.Add("Edit");
                m.Items.Add("Copy");
                m.Items.Add("-");
                m.Items.Add("Delete Row");
                m.Items.Add("-");
                m.Items.Add("Mark as Paid");
                m.Items.Add("Mark as UnPaid");
                m.Items.Add("-");
                m.Items.Add("Visit Agency Website");

                int currentMouseOverRow = dataGridViewJobs.HitTest(e.X, e.Y).RowIndex;
                
                m.Show(dataGridViewJobs, new Point(e.X, e.Y));

                // Set up event handler
                m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);

                // highlight the row
                //dataGridViewJobs.ClearSelection();
                //dataGridViewJobs.Rows[currentMouseOverRow].Selected = true;
                

                    if (dataGridViewJobs.GetCellCount(DataGridViewElementStates.Selected) > 0)
                    {
                    try
                    {
                        // Add the selection to the clipboard.
                        //Clipboard.SetDataObject(dataGridViewJobs.GetClipboardContent());
                        // Replace the text box contents with the clipboard text. 
                        //MessageBox.Show(Clipboard.GetText());





                    }
                    catch (System.Runtime.InteropServices.ExternalException)
                    {

                        MessageBox.Show("The Clipboard could not be accessed. Please try again.");
                    }
                }
            }
        }


        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Edit":
                    dgv_EditSelectedRow();
                    break;
                case "Copy":
                    Clipboard.SetDataObject(dataGridViewJobs.GetClipboardContent());
                    break;
                case "Delete Row":
                    dgv_DeleteSelectedRow();
                    break;
                case "Mark as Paid":
                    dgv_MarkRowAsPaid();
                    break;
                case "Mark as UnPaid":
                    dgv_MarkRowAsUnPaid();
                    break;
                case "-":
                    break;
                case "Visit Agency Website":
                    dgv_VisitAgency();
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewJobs.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dataGridViewJobs.Rows[e.RowIndex].Selected = true;
        }

        private void jobRefresh()
        {
            //Clear down the dgv
            dataGridViewJobs.Rows.Clear();

            // Load up the DataGrid
            using (Sql sql = new Sql())
            {
                List<DataJob> listDataJob = new List<DataJob>();

                //Set the dgv formats
                dataGridViewJobs.Columns["StartJob"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewJobs.Columns["EndJob"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Set up Event Handlers
                dataGridViewJobs.MouseClick += dataGridViewJobs_MouseClick;
                dataGridViewJobs.CellContentDoubleClick += new DataGridViewCellEventHandler(dataGridViewJobs_CellCont​entDoubleClick);

                dataGridViewJobs.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

                // Function determined by the type of db we are connecting to
                if (Constants.DBMS == "MSSQL") { listDataJob = sql.SQLGetJobs(0); } else { listDataJob = sql.OLEGetJobs(0); }

                int jobsPaid = 0;
                int jobsUnpaid = 0;

                foreach (DataJob item in listDataJob)
                {
                    var index = dataGridViewJobs.Rows.Add();
                    dataGridViewJobs.Rows[index].Cells["JobId"].Value = item.JobId;
                    dataGridViewJobs.Rows[index].Cells["EmployeeId"].Value = item.EmployeeId;
                    dataGridViewJobs.Rows[index].Cells["AgencyId"].Value = item.AgencyId;
                    dataGridViewJobs.Rows[index].Cells["AgencyName"].Value = item.AgencyName;
                    dataGridViewJobs.Rows[index].Cells["JobDetails"].Value = item.JobDetails;
                    dataGridViewJobs.Rows[index].Cells["StartJob"].Value = item.StartJob;
                    dataGridViewJobs.Rows[index].Cells["EndJob"].Value = item.EndJob;
                    dataGridViewJobs.Rows[index].Cells["PaymentReceived"].Value = item.PaymentReceived;
                    dataGridViewJobs.Rows[index].Cells["TotalPayment"].Value = item.TotalPayment;

                    // Colour the rows green if payment received
                    if (item.PaymentReceived) // Have received payment
                    {
                        dataGridViewJobs.Rows[index].DefaultCellStyle.BackColor = Color.Green;
                        dataGridViewJobs.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                        jobsPaid++;
                    }
                    else
                    {
                        jobsUnpaid++;
                    }



                    //string jobCount = listDataJob.Count.ToString() + " jobs.";
                    labelJobCount.Text = listDataJob.Count.ToString() + " jobs (" + jobsPaid.ToString() + " Paid & " + 
                                jobsUnpaid.ToString() + " Unpaid)";
                }

            }
        }

        private void textBoxTotalPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            using (Sql sql = new Sql())
            {
                // Refresh the job list 
                jobRefresh();
                // Update the finance info
                UpdateFinances();
            }
        }
         
        private void UpdateFinances()
        {

            using (Sql sql = new Sql())
            {
                // Updates the finance info
                List<DataFinance> df = new List<DataFinance>();

                // Function determined by the type of db we are connecting to
                if (Constants.DBMS == "MSSQL") { df = sql.SQLGetOutstandingInvoiceAmounts(); } else { df = sql.OLEGetOutstandingInvoiceAmounts(); }

                //Reset the amounts on the form
                textBoxLast30Days.Text = "£0.00";
                textBoxLast60Days.Text = "£0.00";
                textBoxLast90Days.Text = "£0.00";
                textBoxOver90Days.Text = "£0.00";

                foreach (var item in df)
                {
                    if (item.TotalName == "Sum30Days" && item.TotalAmount != "") { textBoxLast30Days.Text = "£" + string.Format("{0:#.00}", Convert.ToDecimal(item.TotalAmount) ); }
                    if (item.TotalName == "Sum60Days" && item.TotalAmount != "") { textBoxLast60Days.Text = "£" + string.Format("{0:#.00}", Convert.ToDecimal(item.TotalAmount)); }
                    if (item.TotalName == "Sum90Days" && item.TotalAmount != "") { textBoxLast90Days.Text = "£" + string.Format("{0:#.00}", Convert.ToDecimal(item.TotalAmount)); }
                    if (item.TotalName == "Over90Days" && item.TotalAmount != "") { textBoxOver90Days.Text = "£" + string.Format("{0:#.00}", Convert.ToDecimal(item.TotalAmount)); }
                }
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataJob dj = new DataJob();

            int newFileId = 0;
            int existingJobId = Convert.ToInt32(textBoxJobId.Text);

            if (textBoxjobDetails.Text == "") 
            {
                MessageBox.Show("No job details entered.", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (textBoxTotalPayment.Text == "0")
            {
                MessageBox.Show("No payment details entered.", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            using (Sql sql = new Sql())
            {

                // Do validation first so we know we've got everything
                dj.EmployeeId = Constants.UserId;
                dj.AgencyId = Convert.ToInt32(comboBoxAgency.SelectedValue);
                dj.JobDetails = textBoxjobDetails.Text;
                dj.StartJob = Convert.ToDateTime(dateTimePickerStartJob.Value);
                dj.EndJob = Convert.ToDateTime(dateTimePickerEndJob.Value);
                dj.PaymentReceived = Convert.ToBoolean(checkBox1.Checked);
                dj.TotalPayment = Convert.ToDecimal(textBoxTotalPayment.Text);

                // Function determined by the type of db we are connecting to
                if (Constants.DBMS == "MSSQL") 
                {
                    if (sql.SQLCheckJobExists(existingJobId))
                    {
                        // must be update
                        dj.JobId = existingJobId;
                        sql.SQLUpdateExistingJob(dj);
                    }
                    else
                    {
                        //Insert Job to DB and dgv.
                        newFileId = sql.SQLInsertNewJob(dj);
                    }
                }
                else
                {
                    if (sql.OLECheckJobExists(existingJobId))
                    {
                        // must be update
                        dj.JobId = existingJobId;
                        sql.OLEUpdateExistingJob(dj);
                    }
                    else
                    {
                        //Insert Job to DB and dgv.
                        sql.OLEInsertNewJob(dj);
                    }
                }

                
                // Add to dgv - Or could just do a refresh of the dgv from the db??????????
                jobRefresh();

                // Clear down the insert window
                comboBoxAgency.SelectedValue = 1;
                textBoxjobDetails.Text = "";
                dateTimePickerStartJob.Value = DateTime.Now;
                dateTimePickerEndJob.Value = DateTime.Now;
                checkBox1.Checked = Convert.ToBoolean(0); // Cannot rename as pops open the save as dialog ?????
                textBoxTotalPayment.Text = "0";
                textBoxJobId.Text = "0";

                // Update the finance info
                UpdateFinances();
            }
        }

        private void buttonClearJobDetails_Click(object sender, EventArgs e)
        {
            comboBoxAgency.SelectedValue = 1;
            textBoxjobDetails.Text = "";
            //dateTimePickerStartJob.CustomFormat = " ";
            //dateTimePickerStartJob.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartJob.Value = DateTime.Now;
            //dateTimePickerEndJob.CustomFormat = " ";
            //dateTimePickerEndJob.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndJob.Value = DateTime.Now;
            checkBox1.Checked = Convert.ToBoolean(0); // Cannot rename as pops open the save as dialog ?????
            textBoxTotalPayment.Text = "0";
            textBoxJobId.Text = "0";
        }



        private void dateTimePickerStartJob_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePickerEndJob.Value = dateTimePickerStartJob.Value;
        }

       


    }
}

