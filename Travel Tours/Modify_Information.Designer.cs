namespace Travel_Tours
{
    partial class Modify_Information
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
            this.button_MODIFY = new System.Windows.Forms.Button();
            this.button_DELETE_INFO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MODIFY
            // 
            this.button_MODIFY.Location = new System.Drawing.Point(63, 26);
            this.button_MODIFY.Name = "button_MODIFY";
            this.button_MODIFY.Size = new System.Drawing.Size(155, 39);
            this.button_MODIFY.TabIndex = 0;
            this.button_MODIFY.Text = "Edit Information";
            this.button_MODIFY.UseVisualStyleBackColor = true;
            // 
            // button_DELETE_INFO
            // 
            this.button_DELETE_INFO.Location = new System.Drawing.Point(63, 71);
            this.button_DELETE_INFO.Name = "button_DELETE_INFO";
            this.button_DELETE_INFO.Size = new System.Drawing.Size(155, 39);
            this.button_DELETE_INFO.TabIndex = 1;
            this.button_DELETE_INFO.Text = "Delete Information";
            this.button_DELETE_INFO.UseVisualStyleBackColor = true;
            // 
            // Modify_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 139);
            this.Controls.Add(this.button_DELETE_INFO);
            this.Controls.Add(this.button_MODIFY);
            this.Name = "Modify_Information";
            this.Text = "Modify_Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MODIFY;
        private System.Windows.Forms.Button button_DELETE_INFO;
    }
}