namespace HouseManagement1
{
    partial class RenterBookingHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBookingHistoey = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBid = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.dgvBookingHistory = new System.Windows.Forms.DataGridView();
            this.BId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnBookingHistoey);
            this.panel2.Controls.Add(this.btnBooking);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 42);
            this.panel2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(857, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(270, 1);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(119, 39);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnBookingHistoey
            // 
            this.btnBookingHistoey.Location = new System.Drawing.Point(132, 1);
            this.btnBookingHistoey.Name = "btnBookingHistoey";
            this.btnBookingHistoey.Size = new System.Drawing.Size(132, 38);
            this.btnBookingHistoey.TabIndex = 1;
            this.btnBookingHistoey.Text = "Booking Histoey";
            this.btnBookingHistoey.UseVisualStyleBackColor = true;
            this.btnBookingHistoey.Click += new System.EventHandler(this.btnBookingHistoey_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(0, 1);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(126, 38);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBid);
            this.panel1.Controls.Add(this.txtBid);
            this.panel1.Controls.Add(this.dgvBookingHistory);
            this.panel1.Location = new System.Drawing.Point(1, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 369);
            this.panel1.TabIndex = 4;
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBid.Location = new System.Drawing.Point(292, 43);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(31, 16);
            this.lblBid.TabIndex = 2;
            this.lblBid.Text = "Bid";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(348, 37);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(189, 20);
            this.txtBid.TabIndex = 1;
            // 
            // dgvBookingHistory
            // 
            this.dgvBookingHistory.AllowUserToAddRows = false;
            this.dgvBookingHistory.AllowUserToDeleteRows = false;
            this.dgvBookingHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BId,
            this.apno,
            this.Date,
            this.isactive});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookingHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookingHistory.Location = new System.Drawing.Point(11, 93);
            this.dgvBookingHistory.Name = "dgvBookingHistory";
            this.dgvBookingHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookingHistory.Size = new System.Drawing.Size(945, 168);
            this.dgvBookingHistory.TabIndex = 0;
            this.dgvBookingHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookingHistory_CellClick);
            // 
            // BId
            // 
            this.BId.DataPropertyName = "BookId";
            this.BId.HeaderText = "Book ID";
            this.BId.Name = "BId";
            this.BId.ReadOnly = true;
            // 
            // apno
            // 
            this.apno.DataPropertyName = "BookAprtNo";
            this.apno.HeaderText = "Apartment No";
            this.apno.Name = "apno";
            this.apno.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "BookDate";
            this.Date.HeaderText = "Date of Booking";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // isactive
            // 
            this.isactive.DataPropertyName = "BookIsAvtive";
            this.isactive.HeaderText = "Is Active";
            this.isactive.Name = "isactive";
            this.isactive.ReadOnly = true;
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPending.Location = new System.Drawing.Point(53, 60);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(83, 20);
            this.rbPending.TabIndex = 5;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            this.rbPending.CheckedChanged += new System.EventHandler(this.rbPending_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.Location = new System.Drawing.Point(220, 60);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(69, 20);
            this.rbActive.TabIndex = 6;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(740, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RenterBookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 473);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.rbPending);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "RenterBookingHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenterBookingHistory";
            this.Load += new System.EventHandler(this.RenterBookingHistory_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBookingHistoey;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBookingHistory;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn BId;
        private System.Windows.Forms.DataGridViewTextBoxColumn apno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn isactive;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Button btnDelete;
    }
}