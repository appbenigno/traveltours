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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_IT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TourCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_IT_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ETD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_IT_Comments_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_IT_CODE,
            this.Column_TourCode,
            this.Column_IT_Name,
            this.Column_ETA,
            this.Column_ETD,
            this.Column_IT_Comments_Description});
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 292);
            this.dataGridView1.TabIndex = 0;
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
            // Add_Itinerary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 377);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Add_Itinerary";
            this.Text = "Add Itineraries";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TourCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IT_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ETD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IT_Comments_Description;
    }
}