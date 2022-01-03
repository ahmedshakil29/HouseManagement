namespace HouseManagement1
{
    partial class AdminBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.btnAdminApartment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdminHouse = new System.Windows.Forms.Button();
            this.btnAdminHome = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBooking = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnAdminProfile);
            this.panel1.Controls.Add(this.btnAdminApartment);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAdminHouse);
            this.panel1.Controls.Add(this.btnAdminHome);
            this.panel1.Controls.Add(this.btn);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 42);
            this.panel1.TabIndex = 2;
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.Location = new System.Drawing.Point(803, 0);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(123, 37);
            this.btnAdminProfile.TabIndex = 5;
            this.btnAdminProfile.Text = "Profile";
            this.btnAdminProfile.UseVisualStyleBackColor = true;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // btnAdminApartment
            // 
            this.btnAdminApartment.Location = new System.Drawing.Point(390, -1);
            this.btnAdminApartment.Name = "btnAdminApartment";
            this.btnAdminApartment.Size = new System.Drawing.Size(123, 37);
            this.btnAdminApartment.TabIndex = 4;
            this.btnAdminApartment.Text = "Apartment";
            this.btnAdminApartment.UseVisualStyleBackColor = true;
            this.btnAdminApartment.Click += new System.EventHandler(this.btnAdminApartment_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(942, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log  Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdminHouse
            // 
            this.btnAdminHouse.Location = new System.Drawing.Point(261, 0);
            this.btnAdminHouse.Name = "btnAdminHouse";
            this.btnAdminHouse.Size = new System.Drawing.Size(123, 37);
            this.btnAdminHouse.TabIndex = 2;
            this.btnAdminHouse.Text = "House";
            this.btnAdminHouse.UseVisualStyleBackColor = true;
            this.btnAdminHouse.Click += new System.EventHandler(this.btnAdminHouse_Click);
            // 
            // btnAdminHome
            // 
            this.btnAdminHome.Location = new System.Drawing.Point(132, 0);
            this.btnAdminHome.Name = "btnAdminHome";
            this.btnAdminHome.Size = new System.Drawing.Size(123, 37);
            this.btnAdminHome.TabIndex = 1;
            this.btnAdminHome.Text = "Home";
            this.btnAdminHome.UseVisualStyleBackColor = true;
            this.btnAdminHome.Click += new System.EventHandler(this.btnAdminHome_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(3, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(123, 37);
            this.btn.TabIndex = 0;
            this.btn.Text = "Home";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBooking);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSearchBooking);
            this.panel2.Location = new System.Drawing.Point(13, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 436);
            this.panel2.TabIndex = 3;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bid,
            this.bData,
            this.bAid,
            this.bStatus,
            this.rName,
            this.aNo,
            this.bUser});
            this.dgvBooking.Location = new System.Drawing.Point(4, 244);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.Size = new System.Drawing.Size(1003, 180);
            this.dgvBooking.TabIndex = 10;
            // 
            // bid
            // 
            this.bid.DataPropertyName = "BookId";
            this.bid.HeaderText = "ID";
            this.bid.Name = "bid";
            this.bid.ReadOnly = true;
            // 
            // bData
            // 
            this.bData.DataPropertyName = "BookDate";
            this.bData.HeaderText = "Date";
            this.bData.Name = "bData";
            this.bData.ReadOnly = true;
            // 
            // bAid
            // 
            this.bAid.DataPropertyName = "BookAprtId";
            this.bAid.HeaderText = "ApartId";
            this.bAid.Name = "bAid";
            this.bAid.ReadOnly = true;
            // 
            // bStatus
            // 
            this.bStatus.DataPropertyName = "BookIsAvtive";
            this.bStatus.HeaderText = "Booking Status";
            this.bStatus.Name = "bStatus";
            this.bStatus.ReadOnly = true;
            // 
            // rName
            // 
            this.rName.DataPropertyName = "BookRenterName";
            this.rName.HeaderText = "Renter Name";
            this.rName.Name = "rName";
            this.rName.ReadOnly = true;
            // 
            // aNo
            // 
            this.aNo.DataPropertyName = "BookAprtNo";
            this.aNo.HeaderText = "ApartNo";
            this.aNo.Name = "aNo";
            this.aNo.ReadOnly = true;
            // 
            // bUser
            // 
            this.bUser.DataPropertyName = "BookUserId";
            this.bUser.HeaderText = "UserId";
            this.bUser.Name = "bUser";
            this.bUser.ReadOnly = true;
            this.bUser.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Booking:";
            // 
            // txtSearchBooking
            // 
            this.txtSearchBooking.Location = new System.Drawing.Point(251, 114);
            this.txtSearchBooking.Name = "txtSearchBooking";
            this.txtSearchBooking.Size = new System.Drawing.Size(273, 20);
            this.txtSearchBooking.TabIndex = 8;
            this.txtSearchBooking.TextChanged += new System.EventHandler(this.txtSearchBooking_TextChanged);
            // 
            // AdminBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AdminBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminBooking";
            this.Load += new System.EventHandler(this.AdminBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnAdminApartment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdminHouse;
        private System.Windows.Forms.Button btnAdminHome;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bData;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn rName;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUser;
    }
}