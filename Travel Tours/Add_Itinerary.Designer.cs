namespace Travel_Tours
{
    partial class Add_Itinerary
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
            this.dataGridView_Tour_Itineraries = new System.Windows.Forms.DataGridView();
            this.Column_IT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TourCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_IT_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ETD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_IT_Comments_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ADD_INFO = new System.Windows.Forms.Button();
            this.dataGridView_Tour_Guide_Information = new System.Windows.Forms.DataGridView();
            this.Column_TourGuide_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TourGuide_TourCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Assigned_Bus_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourGuide_LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TourGuide_FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Bus_Information = new System.Windows.Forms.DataGridView();
            this.Column_BusInfoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTourCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBusPlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBusPaxTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBusAssignedTourGuideLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBusAssignedTourGuideFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_TEST_IT = new System.Windows.Forms.Button();
            this.button_TEST_TOUR_GUIDE = new System.Windows.Forms.Button();
            this.button_TEST_BUS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tour_Itineraries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tour_Guide_Information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bus_Information)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Tour_Itineraries
            // 
            this.dataGridView_Tour_Itineraries.AllowUserToDeleteRows = false;
            this.dataGridView_Tour_Itineraries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tour_Itineraries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_IT_CODE,
            this.Column_TourCode,
            this.Column_IT_Name,
            this.Column_ETA,
            this.Column_ETD,
            this.Column_IT_Comments_Description});
            this.dataGridView_Tour_Itineraries.Location = new System.Drawing.Point(12, 121);
            this.dataGridView_Tour_Itineraries.Name = "dataGridView_Tour_Itineraries";
            this.dataGridView_Tour_Itineraries.Size = new System.Drawing.Size(734, 155);
            this.dataGridView_Tour_Itineraries.TabIndex = 0;
            this.dataGridView_Tour_Itineraries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tour_Itineraries_CellContentClick);
            this.dataGridView_Tour_Itineraries.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_Tour_Itineraries_DefaultValuesNeeded);
            this.dataGridView_Tour_Itineraries.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_Tour_Itineraries_RowsAdded);
            // 
            // Column_IT_CODE
            // 
            this.Column_IT_CODE.HeaderText = "Tour Itinerary Code";
            this.Column_IT_CODE.Name = "Column_IT_CODE";
            // 
            // Column_TourCode
            // 
            this.Column_TourCode.HeaderText = "Tour Code";
            this.Column_TourCode.Name = "Column_TourCode";
            // 
            // Column_IT_Name
            // 
            this.Column_IT_Name.HeaderText = "Itinerary Name";
            this.Column_IT_Name.Name = "Column_IT_Name";
            // 
            // Column_ETA
            // 
            this.Column_ETA.HeaderText = "Expected Time of Arrival";
            this.Column_ETA.Name = "Column_ETA";
            // 
            // Column_ETD
            // 
            this.Column_ETD.HeaderText = "Expected Time of Departure";
            this.Column_ETD.Name = "Column_ETD";
            // 
            // Column_IT_Comments_Description
            // 
            this.Column_IT_Comments_Description.HeaderText = "Itinerary Description";
            this.Column_IT_Comments_Description.Name = "Column_IT_Comments_Description";
            // 
            // button_ADD_INFO
            // 
            this.button_ADD_INFO.Location = new System.Drawing.Point(12, 12);
            this.button_ADD_INFO.Name = "button_ADD_INFO";
            this.button_ADD_INFO.Size = new System.Drawing.Size(171, 23);
            this.button_ADD_INFO.TabIndex = 1;
            this.button_ADD_INFO.Text = "Add entered Information";
            this.button_ADD_INFO.UseVisualStyleBackColor = true;
            this.button_ADD_INFO.Click += new System.EventHandler(this.button_ADD_INFO_Click);
            // 
            // dataGridView_Tour_Guide_Information
            // 
            this.dataGridView_Tour_Guide_Information.AllowUserToDeleteRows = false;
            this.dataGridView_Tour_Guide_Information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tour_Guide_Information.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_TourGuide_ID,
            this.Column_TourGuide_TourCode,
            this.Column_Assigned_Bus_Number,
            this.ColumnTourGuide_LName,
            this.Column_TourGuide_FName});
            this.dataGridView_Tour_Guide_Information.Location = new System.Drawing.Point(12, 356);
            this.dataGridView_Tour_Guide_Information.Name = "dataGridView_Tour_Guide_Information";
            this.dataGridView_Tour_Guide_Information.Size = new System.Drawing.Size(734, 128);
            this.dataGridView_Tour_Guide_Information.TabIndex = 3;
            this.dataGridView_Tour_Guide_Information.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_Tour_Guide_Information_DefaultValuesNeeded);
            this.dataGridView_Tour_Guide_Information.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_Tour_Guide_Information_RowsAdded);
            // 
            // Column_TourGuide_ID
            // 
            this.Column_TourGuide_ID.HeaderText = "Tour Guide ID";
            this.Column_TourGuide_ID.Name = "Column_TourGuide_ID";
            // 
            // Column_TourGuide_TourCode
            // 
            this.Column_TourGuide_TourCode.HeaderText = "Tour Code";
            this.Column_TourGuide_TourCode.Name = "Column_TourGuide_TourCode";
            // 
            // Column_Assigned_Bus_Number
            // 
            this.Column_Assigned_Bus_Number.HeaderText = "Bus Number Assigned";
            this.Column_Assigned_Bus_Number.Name = "Column_Assigned_Bus_Number";
            // 
            // ColumnTourGuide_LName
            // 
            this.ColumnTourGuide_LName.HeaderText = "Tour Guide\'s Last Name";
            this.ColumnTourGuide_LName.Name = "ColumnTourGuide_LName";
            // 
            // Column_TourGuide_FName
            // 
            this.Column_TourGuide_FName.HeaderText = "Tour Guide\'s First Name";
            this.Column_TourGuide_FName.Name = "Column_TourGuide_FName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tour Itineraries:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tour Guide information:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bus Information:";
            // 
            // dataGridView_Bus_Information
            // 
            this.dataGridView_Bus_Information.AllowUserToDeleteRows = false;
            this.dataGridView_Bus_Information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bus_Information.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_BusInfoID,
            this.ColumnTourCode,
            this.ColumnBusNumber,
            this.ColumnBusPlateNumber,
            this.ColumnBusPaxTotal,
            this.ColumnBusAssignedTourGuideLName,
            this.ColumnBusAssignedTourGuideFName});
            this.dataGridView_Bus_Information.Location = new System.Drawing.Point(12, 543);
            this.dataGridView_Bus_Information.Name = "dataGridView_Bus_Information";
            this.dataGridView_Bus_Information.Size = new System.Drawing.Size(734, 150);
            this.dataGridView_Bus_Information.TabIndex = 7;
            this.dataGridView_Bus_Information.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Bus_Information_DataBindingComplete);
            this.dataGridView_Bus_Information.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_Bus_Information_DefaultValuesNeeded);
            this.dataGridView_Bus_Information.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_Bus_Information_RowsAdded);
            // 
            // Column_BusInfoID
            // 
            this.Column_BusInfoID.HeaderText = "Bus Info ID";
            this.Column_BusInfoID.Name = "Column_BusInfoID";
            // 
            // ColumnTourCode
            // 
            this.ColumnTourCode.HeaderText = "Tour Code";
            this.ColumnTourCode.Name = "ColumnTourCode";
            // 
            // ColumnBusNumber
            // 
            this.ColumnBusNumber.HeaderText = "Bus Number";
            this.ColumnBusNumber.Name = "ColumnBusNumber";
            // 
            // ColumnBusPlateNumber
            // 
            this.ColumnBusPlateNumber.HeaderText = "Bus Plate Number";
            this.ColumnBusPlateNumber.Name = "ColumnBusPlateNumber";
            // 
            // ColumnBusPaxTotal
            // 
            this.ColumnBusPaxTotal.HeaderText = "Number of Passengers";
            this.ColumnBusPaxTotal.Name = "ColumnBusPaxTotal";
            // 
            // ColumnBusAssignedTourGuideLName
            // 
            this.ColumnBusAssignedTourGuideLName.HeaderText = "Tour Guide\'s Last Name";
            this.ColumnBusAssignedTourGuideLName.Name = "ColumnBusAssignedTourGuideLName";
            // 
            // ColumnBusAssignedTourGuideFName
            // 
            this.ColumnBusAssignedTourGuideFName.HeaderText = "Tour Guide\'s First Name";
            this.ColumnBusAssignedTourGuideFName.Name = "ColumnBusAssignedTourGuideFName";
            // 
            // button_TEST_IT
            // 
            this.button_TEST_IT.Location = new System.Drawing.Point(239, 43);
            this.button_TEST_IT.Name = "button_TEST_IT";
            this.button_TEST_IT.Size = new System.Drawing.Size(108, 23);
            this.button_TEST_IT.TabIndex = 8;
            this.button_TEST_IT.Text = "Test Tour IT";
            this.button_TEST_IT.UseVisualStyleBackColor = true;
            this.button_TEST_IT.Click += new System.EventHandler(this.button_TEST_IT_Click);
            // 
            // button_TEST_TOUR_GUIDE
            // 
            this.button_TEST_TOUR_GUIDE.Location = new System.Drawing.Point(353, 43);
            this.button_TEST_TOUR_GUIDE.Name = "button_TEST_TOUR_GUIDE";
            this.button_TEST_TOUR_GUIDE.Size = new System.Drawing.Size(108, 23);
            this.button_TEST_TOUR_GUIDE.TabIndex = 9;
            this.button_TEST_TOUR_GUIDE.Text = "Test Tour Guide";
            this.button_TEST_TOUR_GUIDE.UseVisualStyleBackColor = true;
            // 
            // button_TEST_BUS
            // 
            this.button_TEST_BUS.Location = new System.Drawing.Point(467, 43);
            this.button_TEST_BUS.Name = "button_TEST_BUS";
            this.button_TEST_BUS.Size = new System.Drawing.Size(108, 23);
            this.button_TEST_BUS.TabIndex = 10;
            this.button_TEST_BUS.Text = "Test Bus Info";
            this.button_TEST_BUS.UseVisualStyleBackColor = true;
            // 
            // Add_Itinerary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 693);
            this.Controls.Add(this.button_TEST_BUS);
            this.Controls.Add(this.button_TEST_TOUR_GUIDE);
            this.Controls.Add(this.button_TEST_IT);
            this.Controls.Add(this.dataGridView_Bus_Information);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Tour_Guide_Information);
            this.Controls.Add(this.button_ADD_INFO);
            this.Controls.Add(this.dataGridView_Tour_Itineraries);
            this.Name = "Add_Itinerary";
            this.Text = "Add Itineraries";
            this.Load += new System.EventHandler(this.Add_Itinerary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tour_Itineraries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tour_Guide_Information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bus_Information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Tour_Itineraries;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TourCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IT_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ETD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IT_Comments_Description;
        private System.Windows.Forms.Button button_ADD_INFO;
        private System.Windows.Forms.DataGridView dataGridView_Tour_Guide_Information;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TourGuide_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TourGuide_TourCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Assigned_Bus_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTourGuide_LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TourGuide_FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Bus_Information;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BusInfoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTourCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBusPlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBusPaxTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBusAssignedTourGuideLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBusAssignedTourGuideFName;
        private System.Windows.Forms.Button button_TEST_IT;
        private System.Windows.Forms.Button button_TEST_TOUR_GUIDE;
        private System.Windows.Forms.Button button_TEST_BUS;
    }
}