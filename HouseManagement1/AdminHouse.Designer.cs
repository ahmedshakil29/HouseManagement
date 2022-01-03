namespace HouseManagement1
{
    partial class AdminHouse
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
            this.btnAdminApart = new System.Windows.Forms.Button();
            this.btnAdminHome = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHouse = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hregion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hroadno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHome = new System.Windows.Forms.Label();
            this.txtSearchHome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnAdminProfile);
            this.panel1.Controls.Add(this.btnAdminBooking);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAdminApart);
            this.panel1.Controls.Add(this.btnAdminHome);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(1, -2);
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
            // btnAdminBooking
            // 
            this.btnAdminBooking.Location = new System.Drawing.Point(390, -1);
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
            this.btnLogout.Location = new System.Drawing.Point(942, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdminApart
            // 
            this.btnAdminApart.Location = new System.Drawing.Point(261, 0);
            this.btnAdminApart.Name = "btnAdminApart";
            this.btnAdminApart.Size = new System.Drawing.Size(123, 37);
            this.btnAdminApart.TabIndex = 2;
            this.btnAdminApart.Text = "Apartment";
            this.btnAdminApart.UseVisualStyleBackColor = true;
            this.btnAdminApart.Click += new System.EventHandler(this.btnAdminApart_Click);
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
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(123, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHouse);
            this.panel2.Controls.Add(this.lblHome);
            this.panel2.Controls.Add(this.txtSearchHome);
            this.panel2.Location = new System.Drawing.Point(4, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 433);
            this.panel2.TabIndex = 3;
            // 
            // dgvHouse
            // 
            this.dgvHouse.AllowUserToAddRows = false;
            this.dgvHouse.AllowUserToDeleteRows = false;
            this.dgvHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.houseno,
            this.houseType,
            this.hcity,
            this.hregion,
            this.harea,
            this.hroadno});
            this.dgvHouse.Location = new System.Drawing.Point(9, 215);
            this.dgvHouse.Name = "dgvHouse";
            this.dgvHouse.ReadOnly = true;
            this.dgvHouse.Size = new System.Drawing.Size(1025, 215);
            this.dgvHouse.TabIndex = 10;
            // 
            // id
            // 
            this.id.DataPropertyName = "HouseId";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "HouseName";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // houseno
            // 
            this.houseno.DataPropertyName = "HouseNo";
            this.houseno.HeaderText = "H.NO";
            this.houseno.Name = "houseno";
            this.houseno.ReadOnly = true;
            // 
            // houseType
            // 
            this.houseType.DataPropertyName = "HouseType";
            this.houseType.HeaderText = "Type";
            this.houseType.Name = "houseType";
            this.houseType.ReadOnly = true;
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
            this.hroadno.HeaderText = "Road";
            this.hroadno.Name = "hroadno";
            this.hroadno.ReadOnly = true;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(154, 153);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(123, 20);
            this.lblHome.TabIndex = 9;
            this.lblHome.Text = "Search Home:";
            // 
            // txtSearchHome
            // 
            this.txtSearchHome.Location = new System.Drawing.Point(287, 153);
            this.txtSearchHome.Name = "txtSearchHome";
            this.txtSearchHome.Size = new System.Drawing.Size(273, 20);
            this.txtSearchHome.TabIndex = 8;
            this.txtSearchHome.TextChanged += new System.EventHandler(this.txtSearchHome_TextChanged);
            // 
            // AdminHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "AdminHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHouse";
            this.Load += new System.EventHandler(this.AdminHouse_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnAdminBooking;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdminApart;
        private System.Windows.Forms.Button btnAdminHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHouse;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.TextBox txtSearchHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn hcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn hregion;
        private System.Windows.Forms.DataGridViewTextBoxColumn harea;
        private System.Windows.Forms.DataGridViewTextBoxColumn hroadno;
    }
}