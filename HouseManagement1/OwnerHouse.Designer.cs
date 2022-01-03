namespace HouseManagement1
{
    partial class OwnerHouse
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
            this.btnBookingLog = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAddApart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbResidential = new System.Windows.Forms.RadioButton();
            this.rbCommercial = new System.Windows.Forms.RadioButton();
            this.txtSearchHouse = new System.Windows.Forms.TextBox();
            this.dgvHouse = new System.Windows.Forms.DataGridView();
            this.houseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hregion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hroadno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.txtHouseId = new System.Windows.Forms.TextBox();
            this.lblSearchHouse = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtRoadNo = new System.Windows.Forms.TextBox();
            this.btvSave = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.txtHouseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnBookingLog);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnAddApart);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnBookingLog
            // 
            this.btnBookingLog.Location = new System.Drawing.Point(214, 3);
            this.btnBookingLog.Name = "btnBookingLog";
            this.btnBookingLog.Size = new System.Drawing.Size(101, 33);
            this.btnBookingLog.TabIndex = 4;
            this.btnBookingLog.Text = "Booking Log";
            this.btnBookingLog.UseVisualStyleBackColor = true;
            this.btnBookingLog.Click += new System.EventHandler(this.btnBookingLog_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(860, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 39);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(759, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(95, 33);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAddApart
            // 
            this.btnAddApart.Location = new System.Drawing.Point(107, 3);
            this.btnAddApart.Name = "btnAddApart";
            this.btnAddApart.Size = new System.Drawing.Size(101, 33);
            this.btnAddApart.TabIndex = 1;
            this.btnAddApart.Text = " Apartment";
            this.btnAddApart.UseVisualStyleBackColor = true;
            this.btnAddApart.Click += new System.EventHandler(this.btnAddApart_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(9, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(92, 33);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbResidential);
            this.panel2.Controls.Add(this.rbCommercial);
            this.panel2.Controls.Add(this.txtSearchHouse);
            this.panel2.Controls.Add(this.dgvHouse);
            this.panel2.Controls.Add(this.cmbArea);
            this.panel2.Controls.Add(this.cmbRegion);
            this.panel2.Controls.Add(this.txtHouseId);
            this.panel2.Controls.Add(this.lblSearchHouse);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.txtRoadNo);
            this.panel2.Controls.Add(this.btvSave);
            this.panel2.Controls.Add(this.txtCityName);
            this.panel2.Controls.Add(this.txtHouseNo);
            this.panel2.Controls.Add(this.txtHouseName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(7, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 439);
            this.panel2.TabIndex = 8;
            // 
            // rbResidential
            // 
            this.rbResidential.AutoSize = true;
            this.rbResidential.Location = new System.Drawing.Point(218, 76);
            this.rbResidential.Name = "rbResidential";
            this.rbResidential.Size = new System.Drawing.Size(145, 24);
            this.rbResidential.TabIndex = 39;
            this.rbResidential.TabStop = true;
            this.rbResidential.Text = "RESIDENTIAL";
            this.rbResidential.UseVisualStyleBackColor = true;
            // 
            // rbCommercial
            // 
            this.rbCommercial.AutoSize = true;
            this.rbCommercial.Location = new System.Drawing.Point(37, 76);
            this.rbCommercial.Name = "rbCommercial";
            this.rbCommercial.Size = new System.Drawing.Size(145, 24);
            this.rbCommercial.TabIndex = 38;
            this.rbCommercial.TabStop = true;
            this.rbCommercial.Text = "COMMERCIAL";
            this.rbCommercial.UseVisualStyleBackColor = true;
            // 
            // txtSearchHouse
            // 
            this.txtSearchHouse.Location = new System.Drawing.Point(560, 259);
            this.txtSearchHouse.Name = "txtSearchHouse";
            this.txtSearchHouse.Size = new System.Drawing.Size(210, 26);
            this.txtSearchHouse.TabIndex = 37;
            this.txtSearchHouse.TextChanged += new System.EventHandler(this.txtSearchHouse_TextChanged);
            // 
            // dgvHouse
            // 
            this.dgvHouse.AllowUserToAddRows = false;
            this.dgvHouse.AllowUserToDeleteRows = false;
            this.dgvHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseid,
            this.housename,
            this.houseno,
            this.type,
            this.hcity,
            this.hregion,
            this.harea,
            this.hroadno});
            this.dgvHouse.Location = new System.Drawing.Point(9, 304);
            this.dgvHouse.Name = "dgvHouse";
            this.dgvHouse.ReadOnly = true;
            this.dgvHouse.Size = new System.Drawing.Size(943, 123);
            this.dgvHouse.TabIndex = 36;
            this.dgvHouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHouse_CellClick);
            // 
            // houseid
            // 
            this.houseid.DataPropertyName = "HouseId";
            this.houseid.HeaderText = "Id";
            this.houseid.Name = "houseid";
            this.houseid.ReadOnly = true;
            // 
            // housename
            // 
            this.housename.DataPropertyName = "HouseName";
            this.housename.HeaderText = "Name";
            this.housename.Name = "housename";
            this.housename.ReadOnly = true;
            // 
            // houseno
            // 
            this.houseno.DataPropertyName = "HouseNo";
            this.houseno.HeaderText = "H.No";
            this.houseno.Name = "houseno";
            this.houseno.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "HouseType";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // hcity
            // 
            this.hcity.DataPropertyName = "HouseCity";
            this.hcity.HeaderText = "City";
            this.hcity.Name = "hcity";
            this.hcity.ReadOnly = true;
            // 
            // hregion
            // 
            this.hregion.DataPropertyName = "HouseRegion";
            this.hregion.HeaderText = "Region";
            this.hregion.Name = "hregion";
            this.hregion.ReadOnly = true;
            // 
            // harea
            // 
            this.harea.DataPropertyName = "HouseArea";
            this.harea.HeaderText = "Area";
            this.harea.Name = "harea";
            this.harea.ReadOnly = true;
            // 
            // hroadno
            // 
            this.hroadno.DataPropertyName = "HouseRoadNo";
            this.hroadno.HeaderText = "Road No";
            this.hroadno.Name = "hroadno";
            this.hroadno.ReadOnly = true;
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(142, 192);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(220, 28);
            this.cmbArea.TabIndex = 35;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // cmbRegion
            // 
            this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Items.AddRange(new object[] {
            "Banani",
            "Bashundhara",
            "Mirpur",
            "Uttara"});
            this.cmbRegion.Location = new System.Drawing.Point(142, 158);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(220, 28);
            this.cmbRegion.TabIndex = 34;
            this.cmbRegion.SelectedIndexChanged += new System.EventHandler(this.cmbRegion_SelectedIndexChanged);
            // 
            // txtHouseId
            // 
            this.txtHouseId.Location = new System.Drawing.Point(823, 3);
            this.txtHouseId.Name = "txtHouseId";
            this.txtHouseId.ReadOnly = true;
            this.txtHouseId.Size = new System.Drawing.Size(129, 26);
            this.txtHouseId.TabIndex = 30;
            // 
            // lblSearchHouse
            // 
            this.lblSearchHouse.AutoSize = true;
            this.lblSearchHouse.Location = new System.Drawing.Point(598, 218);
            this.lblSearchHouse.Name = "lblSearchHouse";
            this.lblSearchHouse.Size = new System.Drawing.Size(133, 20);
            this.lblSearchHouse.TabIndex = 29;
            this.lblSearchHouse.Text = "Search House :";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(734, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 45);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtRoadNo
            // 
            this.txtRoadNo.Location = new System.Drawing.Point(143, 230);
            this.txtRoadNo.Name = "txtRoadNo";
            this.txtRoadNo.Size = new System.Drawing.Size(220, 26);
            this.txtRoadNo.TabIndex = 28;
            // 
            // btvSave
            // 
            this.btvSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvSave.Location = new System.Drawing.Point(550, 85);
            this.btvSave.Name = "btvSave";
            this.btvSave.Size = new System.Drawing.Size(135, 45);
            this.btvSave.TabIndex = 0;
            this.btvSave.Text = "SAVE";
            this.btvSave.UseVisualStyleBackColor = true;
            this.btvSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(142, 116);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.ReadOnly = true;
            this.txtCityName.Size = new System.Drawing.Size(220, 26);
            this.txtCityName.TabIndex = 25;
            this.txtCityName.Text = "Dhaka";
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Location = new System.Drawing.Point(142, 35);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(220, 26);
            this.txtHouseNo.TabIndex = 23;
            // 
            // txtHouseName
            // 
            this.txtHouseName.Location = new System.Drawing.Point(142, 3);
            this.txtHouseName.Name = "txtHouseName";
            this.txtHouseName.Size = new System.Drawing.Size(220, 26);
            this.txtHouseName.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Road No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "City Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "House No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "House Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Area";
            // 
            // OwnerHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(964, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "OwnerHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddHouse";
            this.Load += new System.EventHandler(this.AddHouse_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAddApart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoadNo;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.TextBox txtHouseName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btvSave;
        private System.Windows.Forms.TextBox txtHouseId;
        private System.Windows.Forms.Label lblSearchHouse;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.DataGridView dgvHouse;
        private System.Windows.Forms.TextBox txtSearchHouse;
        private System.Windows.Forms.RadioButton rbResidential;
        private System.Windows.Forms.RadioButton rbCommercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn housename;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn hcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn hregion;
        private System.Windows.Forms.DataGridViewTextBoxColumn harea;
        private System.Windows.Forms.DataGridViewTextBoxColumn hroadno;
        private System.Windows.Forms.Button btnBookingLog;
    }
}