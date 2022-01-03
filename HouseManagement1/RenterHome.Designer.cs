namespace HouseManagement1
{
    partial class RenterHome
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.apid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aparttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRenterName = new System.Windows.Forms.Label();
            this.lblApid = new System.Windows.Forms.Label();
            this.txtRenterName = new System.Windows.Forms.TextBox();
            this.txtapid = new System.Windows.Forms.TextBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBookingHistoey = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dgvBooking);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblRenterName);
            this.panel1.Controls.Add(this.lblApid);
            this.panel1.Controls.Add(this.txtRenterName);
            this.panel1.Controls.Add(this.txtapid);
            this.panel1.Controls.Add(this.dtpBookingDate);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 439);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(645, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 39);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(117, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apid,
            this.apno,
            this.aparttype,
            this.size,
            this.floor,
            this.rentprice,
            this.specification,
            this.region,
            this.area});
            this.dgvBooking.Location = new System.Drawing.Point(3, 188);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.Size = new System.Drawing.Size(942, 239);
            this.dgvBooking.TabIndex = 6;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellClick);
            this.dgvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellContentClick);
            // 
            // apid
            // 
            this.apid.DataPropertyName = "BookAprtId";
            this.apid.HeaderText = "Id";
            this.apid.Name = "apid";
            this.apid.ReadOnly = true;
            // 
            // apno
            // 
            this.apno.DataPropertyName = "BookAprtNo";
            this.apno.HeaderText = "Ap.No";
            this.apno.Name = "apno";
            this.apno.ReadOnly = true;
            // 
            // aparttype
            // 
            this.aparttype.DataPropertyName = "Bookaparttype";
            this.aparttype.HeaderText = "Type";
            this.aparttype.Name = "aparttype";
            this.aparttype.ReadOnly = true;
            // 
            // size
            // 
            this.size.DataPropertyName = "Bookapartsize";
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // floor
            // 
            this.floor.DataPropertyName = "BookFloor";
            this.floor.HeaderText = "Floor";
            this.floor.Name = "floor";
            this.floor.ReadOnly = true;
            // 
            // rentprice
            // 
            this.rentprice.DataPropertyName = "Bookrentprice";
            this.rentprice.HeaderText = "Price";
            this.rentprice.Name = "rentprice";
            this.rentprice.ReadOnly = true;
            // 
            // specification
            // 
            this.specification.DataPropertyName = "Bookapartspecification";
            this.specification.HeaderText = "Specificaton";
            this.specification.Name = "specification";
            this.specification.ReadOnly = true;
            // 
            // region
            // 
            this.region.DataPropertyName = "BookHouseRegion";
            this.region.HeaderText = "Region";
            this.region.Name = "region";
            this.region.ReadOnly = true;
            // 
            // area
            // 
            this.area.DataPropertyName = "BookHouseArea";
            this.area.HeaderText = "Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(52, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblRenterName
            // 
            this.lblRenterName.AutoSize = true;
            this.lblRenterName.Location = new System.Drawing.Point(3, 92);
            this.lblRenterName.Name = "lblRenterName";
            this.lblRenterName.Size = new System.Drawing.Size(99, 16);
            this.lblRenterName.TabIndex = 4;
            this.lblRenterName.Text = "Renter Name";
            // 
            // lblApid
            // 
            this.lblApid.AutoSize = true;
            this.lblApid.Location = new System.Drawing.Point(53, 24);
            this.lblApid.Name = "lblApid";
            this.lblApid.Size = new System.Drawing.Size(40, 16);
            this.lblApid.TabIndex = 3;
            this.lblApid.Text = "Apid";
            // 
            // txtRenterName
            // 
            this.txtRenterName.Location = new System.Drawing.Point(117, 86);
            this.txtRenterName.Name = "txtRenterName";
            this.txtRenterName.ReadOnly = true;
            this.txtRenterName.Size = new System.Drawing.Size(179, 22);
            this.txtRenterName.TabIndex = 2;
            // 
            // txtapid
            // 
            this.txtapid.Location = new System.Drawing.Point(117, 18);
            this.txtapid.Name = "txtapid";
            this.txtapid.Size = new System.Drawing.Size(179, 22);
            this.txtapid.TabIndex = 1;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(117, 55);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(179, 22);
            this.dtpBookingDate.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnBookingHistoey);
            this.panel2.Controls.Add(this.btnBooking);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 42);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(843, -1);
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
            this.btnBookingHistoey.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(0, 1);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(126, 38);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // RenterHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "RenterHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBookingHistoey;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRenterName;
        private System.Windows.Forms.Label lblApid;
        private System.Windows.Forms.TextBox txtRenterName;
        private System.Windows.Forms.TextBox txtapid;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn apid;
        private System.Windows.Forms.DataGridViewTextBoxColumn apno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aparttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
    }
}