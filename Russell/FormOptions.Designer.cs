namespace Russell
{
    partial class FormOptions
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
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.labelDefaultAgency = new System.Windows.Forms.Label();
            this.comboBoxDefaultAgency = new System.Windows.Forms.ComboBox();
            this.comboBoxDefaultGraphStyle = new System.Windows.Forms.ComboBox();
            this.labelDeafaultGraphStyle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveClose = new System.Windows.Forms.Button();
            this.buttonAddAgency = new System.Windows.Forms.Button();
            this.groupBoxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.buttonAddAgency);
            this.groupBoxGeneral.Controls.Add(this.labelDeafaultGraphStyle);
            this.groupBoxGeneral.Controls.Add(this.comboBoxDefaultGraphStyle);
            this.groupBoxGeneral.Controls.Add(this.comboBoxDefaultAgency);
            this.groupBoxGeneral.Controls.Add(this.labelDefaultAgency);
            this.groupBoxGeneral.Location = new System.Drawing.Point(13, 13);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(439, 255);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // labelDefaultAgency
            // 
            this.labelDefaultAgency.AutoSize = true;
            this.labelDefaultAgency.Location = new System.Drawing.Point(16, 40);
            this.labelDefaultAgency.Name = "labelDefaultAgency";
            this.labelDefaultAgency.Size = new System.Drawing.Size(83, 13);
            this.labelDefaultAgency.TabIndex = 0;
            this.labelDefaultAgency.Text = "Default Agency:";
            // 
            // comboBoxDefaultAgency
            // 
            this.comboBoxDefaultAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultAgency.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxDefaultAgency.FormattingEnabled = true;
            this.comboBoxDefaultAgency.Location = new System.Drawing.Point(148, 40);
            this.comboBoxDefaultAgency.Name = "comboBoxDefaultAgency";
            this.comboBoxDefaultAgency.Size = new System.Drawing.Size(183, 21);
            this.comboBoxDefaultAgency.TabIndex = 1;
            // 
            // comboBoxDefaultGraphStyle
            // 
            this.comboBoxDefaultGraphStyle.FormattingEnabled = true;
            this.comboBoxDefaultGraphStyle.Location = new System.Drawing.Point(148, 89);
            this.comboBoxDefaultGraphStyle.Name = "comboBoxDefaultGraphStyle";
            this.comboBoxDefaultGraphStyle.Size = new System.Drawing.Size(183, 21);
            this.comboBoxDefaultGraphStyle.TabIndex = 2;
            // 
            // labelDeafaultGraphStyle
            // 
            this.labelDeafaultGraphStyle.AutoSize = true;
            this.labelDeafaultGraphStyle.Location = new System.Drawing.Point(19, 89);
            this.labelDeafaultGraphStyle.Name = "labelDeafaultGraphStyle";
            this.labelDeafaultGraphStyle.Size = new System.Drawing.Size(102, 13);
            this.labelDeafaultGraphStyle.TabIndex = 3;
            this.labelDeafaultGraphStyle.Text = "Default Graph Style:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(261, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonSaveClose
            // 
            this.buttonSaveClose.Location = new System.Drawing.Point(377, 283);
            this.buttonSaveClose.Name = "buttonSaveClose";
            this.buttonSaveClose.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveClose.TabIndex = 2;
            this.buttonSaveClose.Text = "Save & Close";
            this.buttonSaveClose.UseVisualStyleBackColor = true;
            this.buttonSaveClose.Click += new System.EventHandler(this.buttonSaveClose_Click);
            // 
            // buttonAddAgency
            // 
            this.buttonAddAgency.Location = new System.Drawing.Point(364, 40);
            this.buttonAddAgency.Name = "buttonAddAgency";
            this.buttonAddAgency.Size = new System.Drawing.Size(53, 23);
            this.buttonAddAgency.TabIndex = 4;
            this.buttonAddAgency.Text = "New";
            this.buttonAddAgency.UseVisualStyleBackColor = true;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 318);
            this.Controls.Add(this.buttonSaveClose);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxGeneral);
            this.Name = "FormOptions";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label labelDeafaultGraphStyle;
        private System.Windows.Forms.ComboBox comboBoxDefaultGraphStyle;
        private System.Windows.Forms.ComboBox comboBoxDefaultAgency;
        private System.Windows.Forms.Label labelDefaultAgency;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveClose;
        private System.Windows.Forms.Button buttonAddAgency;
    }
}