namespace HouseManagement1
{
    partial class AdminApart
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
            this.btnAdminBooking = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdminHouse = new System.Windows.Forms.Button();
            this.btnAdminHome = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvApart = new System.Windows.Forms.DataGridView();
            this.apartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartNoOfRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartRentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnAdminProfile);
            this.panel1.Controls.Add(this.btnAdminBooking);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAdminHouse);
            this.panel1.Controls.Add(this.btnAdminHome);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 41);
            this.panel1.TabIndex = 3;
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.Location = new System.Drawing.Point(783, 1);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(123, 37);
            this.btnAdminProfile.TabIndex = 5;
            this.btnAdminProfile.Text = "Profile";
            this.btnAdminProfile.UseVisualStyleBackColor = true;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // btnAdminBooking
            // 
            this.btnAdminBooking.Location = new System.Drawing.Point(387, 4);
            this.btnAdminBooking.Name = "btnAdminBooking";
            this.btnAdminBooking.Size = new System.Drawing.Size(123, 37);
            this.btnAdminBooking.TabIndex = 4;
            this.btnAdminBooking.Text = "Booking";
            this.btnAdminBooking.UseVisualStyleBackColor = true;
            this.btnAdminBooking.Click += new System.EventHandler(this.btnAdminBooking_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(912, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdminHouse
            // 
            this.btnAdminHouse.Location = new System.Drawing.Point(258, 4);
            this.btnAdminHouse.Name = "btnAdminHouse";
            this.btnAdminHouse.Size = new System.Drawing.Size(123, 37);
            this.btnAdminHouse.TabIndex = 2;
            this.btnAdminHouse.Text = "House";
            this.btnAdminHouse.UseVisualStyleBackColor = true;
            this.btnAdminHouse.Click += new System.EventHandler(this.btnAdminHouse_Click);
            // 
            // btnAdminHome
            // 
            this.btnAdminHome.Location = new System.Drawing.Point(129, 4);
            this.btnAdminHome.Name = "btnAdminHome";
            this.btnAdminHome.Size = new System.Drawing.Size(123, 37);
            this.btnAdminHome.TabIndex = 1;
            this.btnAdminHome.Text = "Home";
            this.btnAdminHome.UseVisualStyleBackColor = true;
            this.btnAdminHome.Click += new System.EventHandler(this.btnAdminHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(123, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvApart);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSearchUser);
            this.panel2.Location = new System.Drawing.Point(4, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 422);
            this.panel2.TabIndex = 4;
            // 
            // dgvApart
            // 
            this.dgvApart.AllowUserToAddRows = false;
            this.dgvApart.AllowUserToDeleteRows = false;
            this.dgvApart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apartid,
            this.apartType,
            this.apartNo,
            this.apartSize,
            this.apartView,
            this.apartNoOfRoom,
            this.apartRentPrice,
            this.sp,
            this.status,
            this.Floor});
            this.dgvApart.Location = new System.Drawing.Point(9, 214);
            this.dgvApart.Name = "dgvApart";
            this.dgvApart.ReadOnly = true;
            this.dgvApart.Size = new System.Drawing.Size(1010, 195);
            this.dgvApart.TabIndex = 8;
            // 
            // apartid
            // 
            this.apartid.DataPropertyName = "ApartId";
            this.apartid.HeaderText = "ID";
            this.apartid.Name = "apartid";
            this.apartid.ReadOnly = true;
            // 
            // apartType
            // 
            this.apartType.DataPropertyName = "ApartType";
            this.apartType.HeaderText = "A.Type";
            this.apartType.Name = "apartType";
            this.apartType.ReadOnly = true;
            // 
            // apartNo
            // 
            this.apartNo.DataPropertyName = "ApartNo";
            this.apartNo.HeaderText = "A.No";
            this.apartNo.Name = "apartNo";
            this.apartNo.ReadOnly = true;
            // 
            // apartSize
            // 
            this.apartSize.DataPropertyName = "ApartSize";
            this.apartSize.HeaderText = "Size";
            this.apartSize.Name = "apartSize";
            this.apartSize.ReadOnly = true;
            // 
            // apartView
            // 
            this.apartView.DataPropertyName = "ApartView";
            this.apartView.HeaderText = "View";
            this.apartView.Name = "apartView";
            this.apartView.ReadOnly = true;
            // 
            // apartNoOfRoom
            // 
            this.apartNoOfRoom.DataPropertyName = "ApartNoOfRoom";
            this.apartNoOfRoom.HeaderText = "Room";
            this.apartNoOfRoom.Name = "apartNoOfRoom";
            this.apartNoOfRoom.ReadOnly = true;
            // 
            // apartRentPrice
            // 
            this.apartRentPrice.DataPropertyName = "ApartRentPrice";
            this.apartRentPrice.HeaderText = "Rent Price";
            this.apartRentPrice.Name = "apartRentPrice";
            this.apartRentPrice.ReadOnly = true;
            // 
            // sp
            // 
            this.sp.DataPropertyName = "ApartSpecification";
            this.sp.HeaderText = "Specification";
            this.sp.Name = "sp";
            this.sp.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "ApartStatus";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Floor
            // 
            this.Floor.DataPropertyName = "ApartfloorNo";
            this.Floor.HeaderText = "Floor No";
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search  Apartment:";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(299, 138);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(273, 20);
            this.txtSearchUser.TabIndex = 6;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // AdminApart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "AdminApart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminApart";
            this.Load += new System.EventHandler(this.AdminApart_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnAdminBooking;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdminHouse;
        private System.Windows.Forms.Button btnAdminHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvApart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartType;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartView;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartNoOfRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartRentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
    }
}