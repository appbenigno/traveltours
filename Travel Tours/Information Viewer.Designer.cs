﻿namespace Travel_Tours
{
    partial class Information_Viewer
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
            this.Elmanjovin_Database_Viewer = new System.Windows.Forms.DataGridView();
            this.comboBox_Information_Viewer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Edit_Info = new System.Windows.Forms.Button();
            this.button_DELETE_INFORMATION = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Elmanjovin_Database_Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // Elmanjovin_Database_Viewer
            // 
            this.Elmanjovin_Database_Viewer.AllowUserToAddRows = false;
            this.Elmanjovin_Database_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Elmanjovin_Database_Viewer.Location = new System.Drawing.Point(12, 127);
            this.Elmanjovin_Database_Viewer.Name = "Elmanjovin_Database_Viewer";
            this.Elmanjovin_Database_Viewer.Size = new System.Drawing.Size(963, 370);
            this.Elmanjovin_Database_Viewer.TabIndex = 0;
            // 
            // comboBox_Information_Viewer
            // 
            this.comboBox_Information_Viewer.FormattingEnabled = true;
            this.comboBox_Information_Viewer.Items.AddRange(new object[] {
            "Tour Information",
            "Itinerary Information",
            "Bus Information",
            "Tour Guides"});
            this.comboBox_Information_Viewer.Location = new System.Drawing.Point(12, 37);
            this.comboBox_Information_Viewer.Name = "comboBox_Information_Viewer";
            this.comboBox_Information_Viewer.Size = new System.Drawing.Size(159, 21);
            this.comboBox_Information_Viewer.TabIndex = 1;
            this.comboBox_Information_Viewer.Text = "Tour Information";
            this.comboBox_Information_Viewer.SelectedIndexChanged += new System.EventHandler(this.comboBox_Information_Viewer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Information to be viewed:";
            // 
            // button_Edit_Info
            // 
            this.button_Edit_Info.Location = new System.Drawing.Point(12, 98);
            this.button_Edit_Info.Name = "button_Edit_Info";
            this.button_Edit_Info.Size = new System.Drawing.Size(159, 23);
            this.button_Edit_Info.TabIndex = 3;
            this.button_Edit_Info.Text = "Edit Information";
            this.button_Edit_Info.UseVisualStyleBackColor = true;
            this.button_Edit_Info.Click += new System.EventHandler(this.button_Edit_Info_Click);
            // 
            // button_DELETE_INFORMATION
            // 
            this.button_DELETE_INFORMATION.Location = new System.Drawing.Point(177, 98);
            this.button_DELETE_INFORMATION.Name = "button_DELETE_INFORMATION";
            this.button_DELETE_INFORMATION.Size = new System.Drawing.Size(159, 23);
            this.button_DELETE_INFORMATION.TabIndex = 6;
            this.button_DELETE_INFORMATION.Text = "Delete Information";
            this.button_DELETE_INFORMATION.UseVisualStyleBackColor = true;
            this.button_DELETE_INFORMATION.Click += new System.EventHandler(this.button_DELETE_INFORMATION_Click);
            // 
            // Information_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 509);
            this.Controls.Add(this.button_DELETE_INFORMATION);
            this.Controls.Add(this.button_Edit_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Information_Viewer);
            this.Controls.Add(this.Elmanjovin_Database_Viewer);
            this.Name = "Information_Viewer";
            this.Text = "Tour Information Viewer";
            this.Activated += new System.EventHandler(this.Information_Viewer_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Information_Viewer_FormClosing);
            this.Load += new System.EventHandler(this.Information_Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Elmanjovin_Database_Viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Elmanjovin_Database_Viewer;
        private System.Windows.Forms.ComboBox comboBox_Information_Viewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Edit_Info;
        private System.Windows.Forms.Button button_DELETE_INFORMATION;
    }
}