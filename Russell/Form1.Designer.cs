namespace Russell
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.JobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgencyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Startjob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentReceived = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WebLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartJob = new System.Windows.Forms.DateTimePicker();
            this.labelAgency = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.textBoxjobDetails = new System.Windows.Forms.TextBox();
            this.dateTimePickerEndJob = new System.Windows.Forms.DateTimePicker();
            this.labelJobDetails = new System.Windows.Forms.Label();
            this.comboBoxAgency = new System.Windows.Forms.ComboBox();
            this.labelTotalPayment = new System.Windows.Forms.Label();
            this.textBoxTotalPayment = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClearJobDetails = new System.Windows.Forms.Button();
            this.groupBoxEntry = new System.Windows.Forms.GroupBox();
            this.textBoxMediaLink = new System.Windows.Forms.TextBox();
            this.textBoxWebLink = new System.Windows.Forms.TextBox();
            this.labelMediaLink = new System.Windows.Forms.Label();
            this.labelWebLink = new System.Windows.Forms.Label();
            this.radioButtonGraph = new System.Windows.Forms.RadioButton();
            this.radioButtonData = new System.Windows.Forms.RadioButton();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.textBoxJobId = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOver90Days = new System.Windows.Forms.TextBox();
            this.textBoxLast90Days = new System.Windows.Forms.TextBox();
            this.textBoxLast60Days = new System.Windows.Forms.TextBox();
            this.textBoxLast30Days = new System.Windows.Forms.TextBox();
            this.labelOver90Days = new System.Windows.Forms.Label();
            this.labelLast90Days = new System.Windows.Forms.Label();
            this.labelLast60Days = new System.Windows.Forms.Label();
            this.labelLast30Days = new System.Windows.Forms.Label();
            this.groupBoxJobHistory = new System.Windows.Forms.GroupBox();
            this.labelJobCount = new System.Windows.Forms.Label();
            this.chartJobs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jODataSet = new Russell.JODataSet();
            this.jobTableAdapter = new Russell.JODataSetTableAdapters.JobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.groupBoxEntry.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxJobHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJobs
            // 
            this.dataGridViewJobs.AllowUserToAddRows = false;
            this.dataGridViewJobs.AllowUserToOrderColumns = true;
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobId,
            this.EmployeeId,
            this.AgencyId,
            this.AgencyName,
            this.JobDetails,
            this.Startjob,
            this.EndJob,
            this.TotalPayment,
            this.PaymentReceived,
            this.WebLink,
            this.MediaLink});
            this.dataGridViewJobs.Location = new System.Drawing.Point(15, 49);
            this.dataGridViewJobs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.Size = new System.Drawing.Size(1148, 398);
            this.dataGridViewJobs.TabIndex = 0;
            this.dataGridViewJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellContentClick);
            // 
            // JobId
            // 
            this.JobId.HeaderText = "Job Id";
            this.JobId.Name = "JobId";
            this.JobId.ReadOnly = true;
            this.JobId.Visible = false;
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            // 
            // AgencyId
            // 
            this.AgencyId.HeaderText = "Agency Id";
            this.AgencyId.Name = "AgencyId";
            this.AgencyId.ReadOnly = true;
            this.AgencyId.Visible = false;
            // 
            // AgencyName
            // 
            this.AgencyName.HeaderText = "Agency Name";
            this.AgencyName.Name = "AgencyName";
            this.AgencyName.ReadOnly = true;
            this.AgencyName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AgencyName.Width = 135;
            // 
            // JobDetails
            // 
            this.JobDetails.HeaderText = "Job Details";
            this.JobDetails.Name = "JobDetails";
            this.JobDetails.ReadOnly = true;
            this.JobDetails.Width = 300;
            // 
            // Startjob
            // 
            this.Startjob.HeaderText = "Start job";
            this.Startjob.Name = "Startjob";
            this.Startjob.ReadOnly = true;
            this.Startjob.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // EndJob
            // 
            this.EndJob.HeaderText = "End Job";
            this.EndJob.Name = "EndJob";
            this.EndJob.ReadOnly = true;
            // 
            // TotalPayment
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.TotalPayment.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalPayment.HeaderText = "Total Payment";
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.ReadOnly = true;
            // 
            // PaymentReceived
            // 
            this.PaymentReceived.HeaderText = "Payment Received";
            this.PaymentReceived.Name = "PaymentReceived";
            this.PaymentReceived.ReadOnly = true;
            this.PaymentReceived.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentReceived.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PaymentReceived.Width = 65;
            // 
            // WebLink
            // 
            this.WebLink.HeaderText = "WebLink";
            this.WebLink.Name = "WebLink";
            this.WebLink.Visible = false;
            // 
            // MediaLink
            // 
            this.MediaLink.HeaderText = "MediaLink";
            this.MediaLink.Name = "MediaLink";
            this.MediaLink.Visible = false;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(435, 43);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(72, 17);
            this.labelStartDate.TabIndex = 5;
            this.labelStartDate.Text = "StartDate:";
            this.labelStartDate.Click += new System.EventHandler(this.labelStartDate_Click);
            // 
            // dateTimePickerStartJob
            // 
            this.dateTimePickerStartJob.Location = new System.Drawing.Point(438, 68);
            this.dateTimePickerStartJob.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStartJob.Name = "dateTimePickerStartJob";
            this.dateTimePickerStartJob.Size = new System.Drawing.Size(177, 22);
            this.dateTimePickerStartJob.TabIndex = 6;
            this.dateTimePickerStartJob.ValueChanged += new System.EventHandler(this.dateTimePickerStartJob_ValueChanged_1);
            // 
            // labelAgency
            // 
            this.labelAgency.AutoSize = true;
            this.labelAgency.Location = new System.Drawing.Point(39, 43);
            this.labelAgency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAgency.Name = "labelAgency";
            this.labelAgency.Size = new System.Drawing.Size(59, 17);
            this.labelAgency.TabIndex = 3;
            this.labelAgency.Text = "Agency:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(435, 106);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(71, 17);
            this.labelEndDate.TabIndex = 7;
            this.labelEndDate.Text = "End Date:";
            // 
            // textBoxjobDetails
            // 
            this.textBoxjobDetails.Location = new System.Drawing.Point(107, 89);
            this.textBoxjobDetails.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxjobDetails.Multiline = true;
            this.textBoxjobDetails.Name = "textBoxjobDetails";
            this.textBoxjobDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxjobDetails.Size = new System.Drawing.Size(301, 64);
            this.textBoxjobDetails.TabIndex = 2;
            // 
            // dateTimePickerEndJob
            // 
            this.dateTimePickerEndJob.Location = new System.Drawing.Point(438, 131);
            this.dateTimePickerEndJob.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEndJob.Name = "dateTimePickerEndJob";
            this.dateTimePickerEndJob.Size = new System.Drawing.Size(177, 22);
            this.dateTimePickerEndJob.TabIndex = 8;
            // 
            // labelJobDetails
            // 
            this.labelJobDetails.AutoSize = true;
            this.labelJobDetails.Location = new System.Drawing.Point(16, 89);
            this.labelJobDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJobDetails.Name = "labelJobDetails";
            this.labelJobDetails.Size = new System.Drawing.Size(82, 17);
            this.labelJobDetails.TabIndex = 1;
            this.labelJobDetails.Text = "Job Details:";
            // 
            // comboBoxAgency
            // 
            this.comboBoxAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgency.FormattingEnabled = true;
            this.comboBoxAgency.Location = new System.Drawing.Point(107, 43);
            this.comboBoxAgency.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAgency.Name = "comboBoxAgency";
            this.comboBoxAgency.Size = new System.Drawing.Size(301, 24);
            this.comboBoxAgency.TabIndex = 4;
            // 
            // labelTotalPayment
            // 
            this.labelTotalPayment.Location = new System.Drawing.Point(695, 49);
            this.labelTotalPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPayment.Name = "labelTotalPayment";
            this.labelTotalPayment.Size = new System.Drawing.Size(71, 24);
            this.labelTotalPayment.TabIndex = 14;
            this.labelTotalPayment.Text = "Payment:";
            this.labelTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalPayment.Click += new System.EventHandler(this.labelTotalPayment_Click);
            // 
            // textBoxTotalPayment
            // 
            this.textBoxTotalPayment.Location = new System.Drawing.Point(782, 49);
            this.textBoxTotalPayment.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalPayment.Name = "textBoxTotalPayment";
            this.textBoxTotalPayment.Size = new System.Drawing.Size(75, 22);
            this.textBoxTotalPayment.TabIndex = 15;
            this.textBoxTotalPayment.Text = "0";
            this.textBoxTotalPayment.TextChanged += new System.EventHandler(this.textBoxTotalPayment_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox1.Location = new System.Drawing.Point(857, 49);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 21);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Received:";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1015, 144);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 28);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClearJobDetails
            // 
            this.buttonClearJobDetails.Location = new System.Drawing.Point(1015, 92);
            this.buttonClearJobDetails.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearJobDetails.Name = "buttonClearJobDetails";
            this.buttonClearJobDetails.Size = new System.Drawing.Size(125, 28);
            this.buttonClearJobDetails.TabIndex = 21;
            this.buttonClearJobDetails.Text = "Clear Job Details";
            this.buttonClearJobDetails.UseVisualStyleBackColor = true;
            this.buttonClearJobDetails.Click += new System.EventHandler(this.buttonClearJobDetails_Click);
            // 
            // groupBoxEntry
            // 
            this.groupBoxEntry.Controls.Add(this.textBoxMediaLink);
            this.groupBoxEntry.Controls.Add(this.textBoxWebLink);
            this.groupBoxEntry.Controls.Add(this.labelMediaLink);
            this.groupBoxEntry.Controls.Add(this.labelWebLink);
            this.groupBoxEntry.Controls.Add(this.radioButtonGraph);
            this.groupBoxEntry.Controls.Add(this.radioButtonData);
            this.groupBoxEntry.Controls.Add(this.buttonBackup);
            this.groupBoxEntry.Controls.Add(this.textBoxJobId);
            this.groupBoxEntry.Controls.Add(this.buttonRefresh);
            this.groupBoxEntry.Controls.Add(this.buttonClearJobDetails);
            this.groupBoxEntry.Controls.Add(this.buttonSave);
            this.groupBoxEntry.Controls.Add(this.checkBox1);
            this.groupBoxEntry.Controls.Add(this.textBoxTotalPayment);
            this.groupBoxEntry.Controls.Add(this.labelTotalPayment);
            this.groupBoxEntry.Controls.Add(this.comboBoxAgency);
            this.groupBoxEntry.Controls.Add(this.labelJobDetails);
            this.groupBoxEntry.Controls.Add(this.dateTimePickerEndJob);
            this.groupBoxEntry.Controls.Add(this.textBoxjobDetails);
            this.groupBoxEntry.Controls.Add(this.labelEndDate);
            this.groupBoxEntry.Controls.Add(this.labelAgency);
            this.groupBoxEntry.Controls.Add(this.dateTimePickerStartJob);
            this.groupBoxEntry.Controls.Add(this.labelStartDate);
            this.groupBoxEntry.Location = new System.Drawing.Point(16, 454);
            this.groupBoxEntry.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEntry.Name = "groupBoxEntry";
            this.groupBoxEntry.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEntry.Size = new System.Drawing.Size(1148, 180);
            this.groupBoxEntry.TabIndex = 10;
            this.groupBoxEntry.TabStop = false;
            this.groupBoxEntry.Text = "Job Details";
            // 
            // textBoxMediaLink
            // 
            this.textBoxMediaLink.Location = new System.Drawing.Point(782, 137);
            this.textBoxMediaLink.Name = "textBoxMediaLink";
            this.textBoxMediaLink.Size = new System.Drawing.Size(168, 22);
            this.textBoxMediaLink.TabIndex = 30;
            // 
            // textBoxWebLink
            // 
            this.textBoxWebLink.Location = new System.Drawing.Point(782, 95);
            this.textBoxWebLink.Name = "textBoxWebLink";
            this.textBoxWebLink.Size = new System.Drawing.Size(168, 22);
            this.textBoxWebLink.TabIndex = 29;
            // 
            // labelMediaLink
            // 
            this.labelMediaLink.AutoSize = true;
            this.labelMediaLink.Location = new System.Drawing.Point(695, 142);
            this.labelMediaLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMediaLink.Name = "labelMediaLink";
            this.labelMediaLink.Size = new System.Drawing.Size(80, 17);
            this.labelMediaLink.TabIndex = 28;
            this.labelMediaLink.Text = "Media Link:";
            this.labelMediaLink.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelWebLink
            // 
            this.labelWebLink.AutoSize = true;
            this.labelWebLink.Location = new System.Drawing.Point(683, 100);
            this.labelWebLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWebLink.Name = "labelWebLink";
            this.labelWebLink.Size = new System.Drawing.Size(92, 17);
            this.labelWebLink.TabIndex = 27;
            this.labelWebLink.Text = "Job Info Link:";
            this.labelWebLink.Click += new System.EventHandler(this.labelWebLink_Click);
            // 
            // radioButtonGraph
            // 
            this.radioButtonGraph.AutoSize = true;
            this.radioButtonGraph.Location = new System.Drawing.Point(1071, 14);
            this.radioButtonGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonGraph.Name = "radioButtonGraph";
            this.radioButtonGraph.Size = new System.Drawing.Size(69, 21);
            this.radioButtonGraph.TabIndex = 26;
            this.radioButtonGraph.Text = "Graph";
            this.radioButtonGraph.UseVisualStyleBackColor = true;
            // 
            // radioButtonData
            // 
            this.radioButtonData.AutoSize = true;
            this.radioButtonData.Checked = true;
            this.radioButtonData.Location = new System.Drawing.Point(1005, 14);
            this.radioButtonData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonData.Name = "radioButtonData";
            this.radioButtonData.Size = new System.Drawing.Size(59, 21);
            this.radioButtonData.TabIndex = 25;
            this.radioButtonData.TabStop = true;
            this.radioButtonData.Text = "Data";
            this.radioButtonData.UseVisualStyleBackColor = true;
            this.radioButtonData.CheckedChanged += new System.EventHandler(this.radioButtonData_CheckedChanged);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Enabled = false;
            this.buttonBackup.Location = new System.Drawing.Point(246, 154);
            this.buttonBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(75, 28);
            this.buttonBackup.TabIndex = 24;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Visible = false;
            // 
            // textBoxJobId
            // 
            this.textBoxJobId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxJobId.Location = new System.Drawing.Point(107, 158);
            this.textBoxJobId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJobId.Name = "textBoxJobId";
            this.textBoxJobId.Size = new System.Drawing.Size(132, 22);
            this.textBoxJobId.TabIndex = 23;
            this.textBoxJobId.Visible = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Enabled = false;
            this.buttonRefresh.Location = new System.Drawing.Point(3, 152);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 28);
            this.buttonRefresh.TabIndex = 22;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Visible = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1179, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.newToolStripMenuItem.Text = "&New Agency";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.deleteToolStripMenuItem.Text = "Options";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem1.Text = "E&dit";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOver90Days);
            this.groupBox1.Controls.Add(this.textBoxLast90Days);
            this.groupBox1.Controls.Add(this.textBoxLast60Days);
            this.groupBox1.Controls.Add(this.textBoxLast30Days);
            this.groupBox1.Controls.Add(this.labelOver90Days);
            this.groupBox1.Controls.Add(this.labelLast90Days);
            this.groupBox1.Controls.Add(this.labelLast60Days);
            this.groupBox1.Controls.Add(this.labelLast30Days);
            this.groupBox1.Location = new System.Drawing.Point(16, 642);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1148, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outstanding Financials";
            // 
            // textBoxOver90Days
            // 
            this.textBoxOver90Days.Enabled = false;
            this.textBoxOver90Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOver90Days.ForeColor = System.Drawing.Color.Red;
            this.textBoxOver90Days.Location = new System.Drawing.Point(959, 34);
            this.textBoxOver90Days.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOver90Days.Name = "textBoxOver90Days";
            this.textBoxOver90Days.ReadOnly = true;
            this.textBoxOver90Days.Size = new System.Drawing.Size(147, 23);
            this.textBoxOver90Days.TabIndex = 7;
            // 
            // textBoxLast90Days
            // 
            this.textBoxLast90Days.Enabled = false;
            this.textBoxLast90Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLast90Days.ForeColor = System.Drawing.Color.Red;
            this.textBoxLast90Days.Location = new System.Drawing.Point(683, 34);
            this.textBoxLast90Days.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLast90Days.Name = "textBoxLast90Days";
            this.textBoxLast90Days.ReadOnly = true;
            this.textBoxLast90Days.Size = new System.Drawing.Size(147, 23);
            this.textBoxLast90Days.TabIndex = 6;
            // 
            // textBoxLast60Days
            // 
            this.textBoxLast60Days.Enabled = false;
            this.textBoxLast60Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLast60Days.ForeColor = System.Drawing.Color.Red;
            this.textBoxLast60Days.Location = new System.Drawing.Point(381, 34);
            this.textBoxLast60Days.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLast60Days.Name = "textBoxLast60Days";
            this.textBoxLast60Days.ReadOnly = true;
            this.textBoxLast60Days.Size = new System.Drawing.Size(147, 23);
            this.textBoxLast60Days.TabIndex = 5;
            // 
            // textBoxLast30Days
            // 
            this.textBoxLast30Days.Enabled = false;
            this.textBoxLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLast30Days.ForeColor = System.Drawing.Color.Red;
            this.textBoxLast30Days.Location = new System.Drawing.Point(107, 34);
            this.textBoxLast30Days.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLast30Days.Name = "textBoxLast30Days";
            this.textBoxLast30Days.ReadOnly = true;
            this.textBoxLast30Days.Size = new System.Drawing.Size(147, 23);
            this.textBoxLast30Days.TabIndex = 4;
            // 
            // labelOver90Days
            // 
            this.labelOver90Days.AutoSize = true;
            this.labelOver90Days.Location = new System.Drawing.Point(851, 34);
            this.labelOver90Days.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOver90Days.Name = "labelOver90Days";
            this.labelOver90Days.Size = new System.Drawing.Size(99, 17);
            this.labelOver90Days.TabIndex = 3;
            this.labelOver90Days.Text = "Over 90 Days:";
            // 
            // labelLast90Days
            // 
            this.labelLast90Days.AutoSize = true;
            this.labelLast90Days.Location = new System.Drawing.Point(579, 34);
            this.labelLast90Days.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLast90Days.Name = "labelLast90Days";
            this.labelLast90Days.Size = new System.Drawing.Size(95, 17);
            this.labelLast90Days.TabIndex = 2;
            this.labelLast90Days.Text = "Last 90 Days:";
            // 
            // labelLast60Days
            // 
            this.labelLast60Days.AutoSize = true;
            this.labelLast60Days.Location = new System.Drawing.Point(277, 34);
            this.labelLast60Days.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLast60Days.Name = "labelLast60Days";
            this.labelLast60Days.Size = new System.Drawing.Size(95, 17);
            this.labelLast60Days.TabIndex = 1;
            this.labelLast60Days.Text = "Last 60 Days:";
            // 
            // labelLast30Days
            // 
            this.labelLast30Days.AutoSize = true;
            this.labelLast30Days.Location = new System.Drawing.Point(8, 34);
            this.labelLast30Days.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLast30Days.Name = "labelLast30Days";
            this.labelLast30Days.Size = new System.Drawing.Size(95, 17);
            this.labelLast30Days.TabIndex = 0;
            this.labelLast30Days.Text = "Last 30 Days:";
            // 
            // groupBoxJobHistory
            // 
            this.groupBoxJobHistory.Controls.Add(this.labelJobCount);
            this.groupBoxJobHistory.Location = new System.Drawing.Point(16, 741);
            this.groupBoxJobHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxJobHistory.Name = "groupBoxJobHistory";
            this.groupBoxJobHistory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxJobHistory.Size = new System.Drawing.Size(1148, 66);
            this.groupBoxJobHistory.TabIndex = 13;
            this.groupBoxJobHistory.TabStop = false;
            this.groupBoxJobHistory.Text = "Job History";
            // 
            // labelJobCount
            // 
            this.labelJobCount.AutoSize = true;
            this.labelJobCount.Location = new System.Drawing.Point(8, 32);
            this.labelJobCount.Name = "labelJobCount";
            this.labelJobCount.Size = new System.Drawing.Size(12, 17);
            this.labelJobCount.TabIndex = 0;
            this.labelJobCount.Text = ".";
            // 
            // chartJobs
            // 
            this.chartJobs.BorderlineColor = System.Drawing.Color.Black;
            this.chartJobs.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartJobs.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartJobs.Legends.Add(legend1);
            this.chartJobs.Location = new System.Drawing.Point(15, 49);
            this.chartJobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartJobs.Name = "chartJobs";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartJobs.Series.Add(series1);
            this.chartJobs.Size = new System.Drawing.Size(1148, 398);
            this.chartJobs.TabIndex = 1;
            this.chartJobs.Text = "Job Visualisation";
            title1.Name = "Title1";
            this.chartJobs.Titles.Add(title1);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.jODataSet;
            // 
            // jODataSet
            // 
            this.jODataSet.DataSetName = "JODataSet";
            this.jODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 818);
            this.Controls.Add(this.groupBoxJobHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEntry);
            this.Controls.Add(this.dataGridViewJobs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chartJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.groupBoxEntry.ResumeLayout(false);
            this.groupBoxEntry.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxJobHistory.ResumeLayout(false);
            this.groupBoxJobHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private JODataSet jODataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private JODataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartJob;
        private System.Windows.Forms.Label labelAgency;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.TextBox textBoxjobDetails;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndJob;
        private System.Windows.Forms.Label labelJobDetails;
        private System.Windows.Forms.ComboBox comboBoxAgency;
        private System.Windows.Forms.Label labelTotalPayment;
        private System.Windows.Forms.TextBox textBoxTotalPayment;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClearJobDetails;
        private System.Windows.Forms.GroupBox groupBoxEntry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOver90Days;
        private System.Windows.Forms.TextBox textBoxLast90Days;
        private System.Windows.Forms.TextBox textBoxLast60Days;
        private System.Windows.Forms.TextBox textBoxLast30Days;
        private System.Windows.Forms.Label labelOver90Days;
        private System.Windows.Forms.Label labelLast90Days;
        private System.Windows.Forms.Label labelLast60Days;
        private System.Windows.Forms.Label labelLast30Days;
        private System.Windows.Forms.TextBox textBoxJobId;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.GroupBox groupBoxJobHistory;
        private System.Windows.Forms.Label labelJobCount;
        private System.Windows.Forms.RadioButton radioButtonGraph;
        private System.Windows.Forms.RadioButton radioButtonData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartJobs;
        private System.Windows.Forms.Label labelWebLink;
        private System.Windows.Forms.Label labelMediaLink;
        private System.Windows.Forms.TextBox textBoxMediaLink;
        private System.Windows.Forms.TextBox textBoxWebLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgencyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startjob;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPayment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PaymentReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaLink;
    }
}

