namespace Travel_Tours
{
    partial class frmCLI
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
            this.txtCLI = new System.Windows.Forms.TextBox();
            this.dataGridSched = new System.Windows.Forms.DataGridView();
            this.btnExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSched)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCLI
            // 
            this.txtCLI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCLI.Location = new System.Drawing.Point(12, 329);
            this.txtCLI.Name = "txtCLI";
            this.txtCLI.Size = new System.Drawing.Size(760, 20);
            this.txtCLI.TabIndex = 4;
            this.txtCLI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCLI_KeyPress);
            // 
            // dataGridSched
            // 
            this.dataGridSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSched.Location = new System.Drawing.Point(12, 12);
            this.dataGridSched.Name = "dataGridSched";
            this.dataGridSched.Size = new System.Drawing.Size(760, 302);
            this.dataGridSched.TabIndex = 3;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(351, 355);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // frmCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 385);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtCLI);
            this.Controls.Add(this.dataGridSched);
            this.MaximizeBox = false;
            this.Name = "frmCLI";
            this.Text = "SQL Command Line Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCLI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSched)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCLI;
        private System.Windows.Forms.DataGridView dataGridSched;
        private System.Windows.Forms.Button btnExecute;
    }
}