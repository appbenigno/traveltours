namespace Travel_Tours
{
    partial class frmControlPanel
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnViewTours = new System.Windows.Forms.Button();
            this.buttonADD_TOUR = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabelUser,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.statusLabelPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 214);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(427, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "User:";
            // 
            // statusLabelUser
            // 
            this.statusLabelUser.Name = "statusLabelUser";
            this.statusLabelUser.Size = new System.Drawing.Size(12, 17);
            this.statusLabelUser.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel2.Text = "     ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel3.Text = "Position:";
            // 
            // statusLabelPosition
            // 
            this.statusLabelPosition.Name = "statusLabelPosition";
            this.statusLabelPosition.Size = new System.Drawing.Size(12, 17);
            this.statusLabelPosition.Text = "-";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Enabled = false;
            this.btnManageUsers.Location = new System.Drawing.Point(116, 27);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(205, 39);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "MANAGE USERS";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnViewTours
            // 
            this.btnViewTours.Location = new System.Drawing.Point(116, 117);
            this.btnViewTours.Name = "btnViewTours";
            this.btnViewTours.Size = new System.Drawing.Size(205, 39);
            this.btnViewTours.TabIndex = 2;
            this.btnViewTours.Text = "VIEW TOUR INFO";
            this.btnViewTours.UseVisualStyleBackColor = true;
            this.btnViewTours.Click += new System.EventHandler(this.btnViewTours_Click);
            // 
            // buttonADD_TOUR
            // 
            this.buttonADD_TOUR.Location = new System.Drawing.Point(116, 72);
            this.buttonADD_TOUR.Name = "buttonADD_TOUR";
            this.buttonADD_TOUR.Size = new System.Drawing.Size(205, 39);
            this.buttonADD_TOUR.TabIndex = 3;
            this.buttonADD_TOUR.Text = "ADD TOUR";
            this.buttonADD_TOUR.UseVisualStyleBackColor = true;
            this.buttonADD_TOUR.Click += new System.EventHandler(this.buttonADD_TOUR_Click);
            // 
            // frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 236);
            this.Controls.Add(this.buttonADD_TOUR);
            this.Controls.Add(this.btnViewTours);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "frmControlPanel";
            this.Text = "Control Panel";
            this.Activated += new System.EventHandler(this.frmControlPanel_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControlPanel_FormClosing);
            this.Load += new System.EventHandler(this.frmControlPanel_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelPosition;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewTours;
        private System.Windows.Forms.Button buttonADD_TOUR;
    }
}