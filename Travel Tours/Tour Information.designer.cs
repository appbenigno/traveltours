namespace Travel_Tours
{
    partial class Tour_Information
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
            this.label1 = new System.Windows.Forms.Label();
            this.texBox_TourCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CompanyInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_START = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_END = new System.Windows.Forms.DateTimePicker();
            this.textBox_PAX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Num_Buses = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Num_Tour_Guides = new System.Windows.Forms.TextBox();
            this.richTextBox_Preview = new System.Windows.Forms.RichTextBox();
            this.PreviewInfo_Button = new System.Windows.Forms.Button();
            this.Itineraries_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.button_ADD_TOUR = new System.Windows.Forms.Button();
            this.button_Clear_Info_Preview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tour Code:";
            // 
            // texBox_TourCode
            // 
            this.texBox_TourCode.Location = new System.Drawing.Point(534, 38);
            this.texBox_TourCode.Name = "texBox_TourCode";
            this.texBox_TourCode.ReadOnly = true;
            this.texBox_TourCode.Size = new System.Drawing.Size(100, 20);
            this.texBox_TourCode.TabIndex = 2;
            this.texBox_TourCode.TextChanged += new System.EventHandler(this.texBox_TourCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of Company/Personnel/School etc.  :";
            // 
            // textBox_CompanyInfo
            // 
            this.textBox_CompanyInfo.Location = new System.Drawing.Point(232, 38);
            this.textBox_CompanyInfo.Name = "textBox_CompanyInfo";
            this.textBox_CompanyInfo.Size = new System.Drawing.Size(230, 20);
            this.textBox_CompanyInfo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Tour:";
            // 
            // dateTimePicker_START
            // 
            this.dateTimePicker_START.Location = new System.Drawing.Point(12, 94);
            this.dateTimePicker_START.Name = "dateTimePicker_START";
            this.dateTimePicker_START.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_START.TabIndex = 6;
            this.dateTimePicker_START.ValueChanged += new System.EventHandler(this.dateTimePicker_START_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "End date of Tour:";
            // 
            // dateTimePicker_END
            // 
            this.dateTimePicker_END.Location = new System.Drawing.Point(262, 94);
            this.dateTimePicker_END.Name = "dateTimePicker_END";
            this.dateTimePicker_END.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_END.TabIndex = 8;
            // 
            // textBox_PAX
            // 
            this.textBox_PAX.Location = new System.Drawing.Point(123, 140);
            this.textBox_PAX.Name = "textBox_PAX";
            this.textBox_PAX.Size = new System.Drawing.Size(119, 20);
            this.textBox_PAX.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total number of Pax:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of Bus/es:";
            // 
            // textBox_Num_Buses
            // 
            this.textBox_Num_Buses.Location = new System.Drawing.Point(114, 240);
            this.textBox_Num_Buses.Name = "textBox_Num_Buses";
            this.textBox_Num_Buses.Size = new System.Drawing.Size(128, 20);
            this.textBox_Num_Buses.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Number of Tour Guides/Facilitators:";
            // 
            // textBox_Num_Tour_Guides
            // 
            this.textBox_Num_Tour_Guides.Location = new System.Drawing.Point(190, 190);
            this.textBox_Num_Tour_Guides.Name = "textBox_Num_Tour_Guides";
            this.textBox_Num_Tour_Guides.Size = new System.Drawing.Size(52, 20);
            this.textBox_Num_Tour_Guides.TabIndex = 14;
            // 
            // richTextBox_Preview
            // 
            this.richTextBox_Preview.Location = new System.Drawing.Point(262, 169);
            this.richTextBox_Preview.Name = "richTextBox_Preview";
            this.richTextBox_Preview.Size = new System.Drawing.Size(372, 184);
            this.richTextBox_Preview.TabIndex = 15;
            this.richTextBox_Preview.Text = "";
            this.richTextBox_Preview.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PreviewInfo_Button
            // 
            this.PreviewInfo_Button.Location = new System.Drawing.Point(262, 138);
            this.PreviewInfo_Button.Name = "PreviewInfo_Button";
            this.PreviewInfo_Button.Size = new System.Drawing.Size(198, 23);
            this.PreviewInfo_Button.TabIndex = 16;
            this.PreviewInfo_Button.Text = "Information Preview";
            this.PreviewInfo_Button.UseVisualStyleBackColor = true;
            this.PreviewInfo_Button.Click += new System.EventHandler(this.PreviewInfo_Button_Click);
            // 
            // Itineraries_Button
            // 
            this.Itineraries_Button.Location = new System.Drawing.Point(123, 283);
            this.Itineraries_Button.Name = "Itineraries_Button";
            this.Itineraries_Button.Size = new System.Drawing.Size(119, 30);
            this.Itineraries_Button.TabIndex = 17;
            this.Itineraries_Button.Text = "Itineraries";
            this.Itineraries_Button.UseVisualStyleBackColor = true;
            this.Itineraries_Button.Click += new System.EventHandler(this.Itineraries_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(12, 323);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(230, 30);
            this.Cancel_Button.TabIndex = 18;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // button_ADD_TOUR
            // 
            this.button_ADD_TOUR.Location = new System.Drawing.Point(12, 283);
            this.button_ADD_TOUR.Name = "button_ADD_TOUR";
            this.button_ADD_TOUR.Size = new System.Drawing.Size(105, 30);
            this.button_ADD_TOUR.TabIndex = 19;
            this.button_ADD_TOUR.Text = "Add Tour";
            this.button_ADD_TOUR.UseVisualStyleBackColor = true;
            this.button_ADD_TOUR.Click += new System.EventHandler(this.button_ADD_TOUR_Click);
            // 
            // button_Clear_Info_Preview
            // 
            this.button_Clear_Info_Preview.Location = new System.Drawing.Point(466, 138);
            this.button_Clear_Info_Preview.Name = "button_Clear_Info_Preview";
            this.button_Clear_Info_Preview.Size = new System.Drawing.Size(168, 23);
            this.button_Clear_Info_Preview.TabIndex = 20;
            this.button_Clear_Info_Preview.Text = "Clear Information Preview";
            this.button_Clear_Info_Preview.UseVisualStyleBackColor = true;
            this.button_Clear_Info_Preview.Click += new System.EventHandler(this.button_Clear_Info_Preview_Click);
            // 
            // Tour_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 365);
            this.Controls.Add(this.button_Clear_Info_Preview);
            this.Controls.Add(this.button_ADD_TOUR);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Itineraries_Button);
            this.Controls.Add(this.PreviewInfo_Button);
            this.Controls.Add(this.richTextBox_Preview);
            this.Controls.Add(this.textBox_Num_Tour_Guides);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Num_Buses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_PAX);
            this.Controls.Add(this.dateTimePicker_END);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_START);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CompanyInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texBox_TourCode);
            this.Controls.Add(this.label1);
            this.Name = "Tour_Information";
            this.Text = "Tour Information Window";
            this.Load += new System.EventHandler(this.Tour_Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texBox_TourCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CompanyInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_START;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_END;
        private System.Windows.Forms.TextBox textBox_PAX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Num_Buses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Num_Tour_Guides;
        private System.Windows.Forms.RichTextBox richTextBox_Preview;
        private System.Windows.Forms.Button PreviewInfo_Button;
        private System.Windows.Forms.Button Itineraries_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button button_ADD_TOUR;
        private System.Windows.Forms.Button button_Clear_Info_Preview;
    }
}