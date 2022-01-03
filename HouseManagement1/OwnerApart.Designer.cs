namespace HouseManagement1
{
    partial class OwnerApart
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txthousetype = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchApart = new System.Windows.Forms.TextBox();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.dgvApart = new System.Windows.Forms.DataGridView();
            this.apartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.views = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFloorNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHouseType = new System.Windows.Forms.Label();
            this.cmbHouseid = new System.Windows.Forms.ComboBox();
            this.cmbNoOfRoom = new System.Windows.Forms.ComboBox();
            this.cmbApartType = new System.Windows.Forms.ComboBox();
            this.lblHouseName = new System.Windows.Forms.Label();
            this.txtApartId = new System.Windows.Forms.TextBox();
            this.lblHouseId = new System.Windows.Forms.Label();
            this.btnApartClear = new System.Windows.Forms.Button();
            this.txtSpecification = new System.Windows.Forms.TextBox();
            this.btnApartSave = new System.Windows.Forms.Button();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.txtApartNo = new System.Windows.Forms.TextBox();
            this.txtApartSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBookingLog = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txthousetype);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSearchApart);
            this.panel2.Controls.Add(this.rbInactive);
            this.panel2.Controls.Add(this.rbActive);
            this.panel2.Controls.Add(this.dgvApart);
            this.panel2.Controls.Add(this.cmbView);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtFloorNo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblHouseType);
            this.panel2.Controls.Add(this.cmbHouseid);
            this.panel2.Controls.Add(this.cmbNoOfRoom);
            this.panel2.Controls.Add(this.cmbApartType);
            this.panel2.Controls.Add(this.lblHouseName);
            this.panel2.Controls.Add(this.txtApartId);
            this.panel2.Controls.Add(this.lblHouseId);
            this.panel2.Controls.Add(this.btnApartClear);
            this.panel2.Controls.Add(this.txtSpecification);
            this.panel2.Controls.Add(this.btnApartSave);
            this.panel2.Controls.Add(this.txtRentPrice);
            this.panel2.Controls.Add(this.txtApartNo);
            this.panel2.Controls.Add(this.txtApartSize);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 566);
            this.panel2.TabIndex = 9;
            // 
            // txthousetype
            // 
            this.txthousetype.Location = new System.Drawing.Point(134, 3);
            this.txthousetype.Name = "txthousetype";
            this.txthousetype.ReadOnly = true;
            this.txthousetype.Size = new System.Drawing.Size(215, 26);
            this.txthousetype.TabIndex = 47;
            this.txthousetype.TextChanged += new System.EventHandler(this.txthousetype_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Search :";
            // 
            // txtSearchApart
            // 
            this.txtSearchApart.Location = new System.Drawing.Point(632, 247);
            this.txtSearchApart.Name = "txtSearchApart";
            this.txtSearchApart.Size = new System.Drawing.Size(220, 26);
            this.txtSearchApart.TabIndex = 45;
            this.txtSearchApart.TextChanged += new System.EventHandler(this.txtSearchApart_TextChanged);
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(632, 83);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(90, 24);
            this.rbInactive.TabIndex = 44;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(528, 83);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(76, 24);
            this.rbActive.TabIndex = 43;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // dgvApart
            // 
            this.dgvApart.AllowUserToAddRows = false;
            this.dgvApart.AllowUserToDeleteRows = false;
            this.dgvApart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apartid,
            this.apno,
            this.aptype,
            this.size,
            this.noofroom,
            this.floorno,
            this.views,
            this.rentprice});
            this.dgvApart.Location = new System.Drawing.Point(11, 291);
            this.dgvApart.Name = "dgvApart";
            this.dgvApart.ReadOnly = true;
            this.dgvApart.Size = new System.Drawing.Size(955, 153);
            this.dgvApart.TabIndex = 42;
            this.dgvApart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApart_CellClick);
            // 
            // apartid
            // 
            this.apartid.DataPropertyName = "apartid";
            this.apartid.HeaderText = "ID";
            this.apartid.Name = "apartid";
            this.apartid.ReadOnly = true;
            // 
            // apno
            // 
            this.apno.DataPropertyName = "apartno";
            this.apno.HeaderText = "A.No";
            this.apno.Name = "apno";
            this.apno.ReadOnly = true;
            // 
            // aptype
            // 
            this.aptype.DataPropertyName = "aparttype";
            this.aptype.HeaderText = "Type";
            this.aptype.Name = "aptype";
            this.aptype.ReadOnly = true;
            // 
            // size
            // 
            this.size.DataPropertyName = "apartsize";
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // noofroom
            // 
            this.noofroom.DataPropertyName = "ApartNoOfRoom";
            this.noofroom.HeaderText = "Room";
            this.noofroom.Name = "noofroom";
            this.noofroom.ReadOnly = true;
            // 
            // floorno
            // 
            this.floorno.DataPropertyName = "ApartfloorNo";
            this.floorno.HeaderText = "Floor";
            this.floorno.Name = "floorno";
            this.floorno.ReadOnly = true;
            // 
            // views
            // 
            this.views.DataPropertyName = "apartview";
            this.views.HeaderText = "Views";
            this.views.Name = "views";
            this.views.ReadOnly = true;
            // 
            // rentprice
            // 
            this.rentprice.DataPropertyName = "apartrentprice";
            this.rentprice.HeaderText = "Price";
            this.rentprice.Name = "rentprice";
            this.rentprice.ReadOnly = true;
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "Front",
            "Back",
            "Middle"});
            this.cmbView.Location = new System.Drawing.Point(632, 42);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(220, 28);
            this.cmbView.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "View";
            // 
            // txtFloorNo
            // 
            this.txtFloorNo.Location = new System.Drawing.Point(129, 119);
            this.txtFloorNo.Name = "txtFloorNo";
            this.txtFloorNo.Size = new System.Drawing.Size(220, 26);
            this.txtFloorNo.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Floor No";
            // 
            // lblHouseType
            // 
            this.lblHouseType.AutoSize = true;
            this.lblHouseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseType.Location = new System.Drawing.Point(2, 3);
            this.lblHouseType.Name = "lblHouseType";
            this.lblHouseType.Size = new System.Drawing.Size(124, 24);
            this.lblHouseType.TabIndex = 37;
            this.lblHouseType.Text = "House Type";
            // 
            // cmbHouseid
            // 
            this.cmbHouseid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHouseid.FormattingEnabled = true;
            this.cmbHouseid.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbHouseid.Location = new System.Drawing.Point(632, 119);
            this.cmbHouseid.Name = "cmbHouseid";
            this.cmbHouseid.Size = new System.Drawing.Size(220, 28);
            this.cmbHouseid.TabIndex = 35;
            this.cmbHouseid.SelectedIndexChanged += new System.EventHandler(this.cmbHouseid_SelectedIndexChanged);
            // 
            // cmbNoOfRoom
            // 
            this.cmbNoOfRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoOfRoom.FormattingEnabled = true;
            this.cmbNoOfRoom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbNoOfRoom.Location = new System.Drawing.Point(129, 200);
            this.cmbNoOfRoom.Name = "cmbNoOfRoom";
            this.cmbNoOfRoom.Size = new System.Drawing.Size(220, 28);
            this.cmbNoOfRoom.TabIndex = 34;
            // 
            // cmbApartType
            // 
            this.cmbApartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApartType.FormattingEnabled = true;
            this.cmbApartType.Location = new System.Drawing.Point(129, 37);
            this.cmbApartType.Name = "cmbApartType";
            this.cmbApartType.Size = new System.Drawing.Size(220, 28);
            this.cmbApartType.TabIndex = 33;
            // 
            // lblHouseName
            // 
            this.lblHouseName.AutoSize = true;
            this.lblHouseName.Location = new System.Drawing.Point(492, 122);
            this.lblHouseName.Name = "lblHouseName";
            this.lblHouseName.Size = new System.Drawing.Size(112, 20);
            this.lblHouseName.TabIndex = 31;
            this.lblHouseName.Text = "House Name";
            // 
            // txtApartId
            // 
            this.txtApartId.Location = new System.Drawing.Point(632, 5);
            this.txtApartId.Name = "txtApartId";
            this.txtApartId.ReadOnly = true;
            this.txtApartId.Size = new System.Drawing.Size(220, 26);
            this.txtApartId.TabIndex = 30;
            // 
            // lblHouseId
            // 
            this.lblHouseId.AutoSize = true;
            this.lblHouseId.Location = new System.Drawing.Point(549, 9);
            this.lblHouseId.Name = "lblHouseId";
            this.lblHouseId.Size = new System.Drawing.Size(77, 20);
            this.lblHouseId.TabIndex = 29;
            this.lblHouseId.Text = "Apart ID";
            // 
            // btnApartClear
            // 
            this.btnApartClear.BackColor = System.Drawing.Color.Red;
            this.btnApartClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartClear.Location = new System.Drawing.Point(632, 205);
            this.btnApartClear.Name = "btnApartClear";
            this.btnApartClear.Size = new System.Drawing.Size(100, 26);
            this.btnApartClear.TabIndex = 1;
            this.btnApartClear.Text = "Clear";
            this.btnApartClear.UseVisualStyleBackColor = false;
            this.btnApartClear.Click += new System.EventHandler(this.btnApartClear_Click);
            // 
            // txtSpecification
            // 
            this.txtSpecification.Location = new System.Drawing.Point(632, 169);
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.Size = new System.Drawing.Size(220, 26);
            this.txtSpecification.TabIndex = 28;
            // 
            // btnApartSave
            // 
            this.btnApartSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnApartSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartSave.Location = new System.Drawing.Point(747, 205);
            this.btnApartSave.Name = "btnApartSave";
            this.btnApartSave.Size = new System.Drawing.Size(105, 26);
            this.btnApartSave.TabIndex = 0;
            this.btnApartSave.Text = "SAVE";
            this.btnApartSave.UseVisualStyleBackColor = false;
            this.btnApartSave.Click += new System.EventHandler(this.btnApartSave_Click);
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(129, 247);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(220, 26);
            this.txtRentPrice.TabIndex = 25;
            // 
            // txtApartNo
            // 
            this.txtApartNo.Location = new System.Drawing.Point(129, 77);
            this.txtApartNo.Name = "txtApartNo";
            this.txtApartNo.Size = new System.Drawing.Size(220, 26);
            this.txtApartNo.TabIndex = 23;
            // 
            // txtApartSize
            // 
            this.txtApartSize.Location = new System.Drawing.Point(129, 160);
            this.txtApartSize.Name = "txtApartSize";
            this.txtApartSize.Size = new System.Drawing.Size(220, 26);
            this.txtApartSize.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "No of Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apart No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rent Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apart Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Specification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apart Size";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnBookingLog);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnAddHouse);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 39);
            this.panel1.TabIndex = 10;
            // 
            // btnBookingLog
            // 
            this.btnBookingLog.Location = new System.Drawing.Point(229, 3);
            this.btnBookingLog.Name = "btnBookingLog";
            this.btnBookingLog.Size = new System.Drawing.Size(106, 33);
            this.btnBookingLog.TabIndex = 4;
            this.btnBookingLog.Text = "Booking Log";
            this.btnBookingLog.UseVisualStyleBackColor = true;
            this.btnBookingLog.Click += new System.EventHandler(this.btnBookingLog_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(877, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 39);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(341, 1);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(108, 36);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Location = new System.Drawing.Point(117, 3);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(106, 33);
            this.btnAddHouse.TabIndex = 1;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 33);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // OwnerApart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MinimizeBox = false;
            this.Name = "OwnerApart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartment";
            this.Load += new System.EventHandler(this.AddApart_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbHouseid;
        private System.Windows.Forms.ComboBox cmbNoOfRoom;
        private System.Windows.Forms.ComboBox cmbApartType;
        private System.Windows.Forms.Label lblHouseName;
        private System.Windows.Forms.TextBox txtApartId;
        private System.Windows.Forms.Label lblHouseId;
        private System.Windows.Forms.Button btnApartClear;
        private System.Windows.Forms.TextBox txtSpecification;
        private System.Windows.Forms.Button btnApartSave;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.TextBox txtApartNo;
        private System.Windows.Forms.TextBox txtApartSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblHouseType;
        private System.Windows.Forms.TextBox txtFloorNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvApart;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchApart;
        private System.Windows.Forms.TextBox txthousetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn apno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aptype;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn views;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentprice;
        private System.Windows.Forms.Button btnBookingLog;
    }
}