namespace HouseManagement1
{
    partial class AdminHome
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
            this.btnAdminHouse = new System.Windows.Forms.Button();
            this.btnAdminHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.dgvHome = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnAdminProfile);
            this.panel1.Controls.Add(this.btnAdminBooking);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAdminApart);
            this.panel1.Controls.Add(this.btnAdminHouse);
            this.panel1.Controls.Add(this.btnAdminHome);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 39);
            this.panel1.TabIndex = 1;
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
            this.btnLogout.Size = new System.Drawing.Size(95, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log  Out";
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
            // btnAdminHouse
            // 
            this.btnAdminHouse.Location = new System.Drawing.Point(132, 0);
            this.btnAdminHouse.Name = "btnAdminHouse";
            this.btnAdminHouse.Size = new System.Drawing.Size(123, 37);
            this.btnAdminHouse.TabIndex = 1;
            this.btnAdminHouse.Text = "House";
            this.btnAdminHouse.UseVisualStyleBackColor = true;
            this.btnAdminHouse.Click += new System.EventHandler(this.btnAdminHouse_Click);
            // 
            // btnAdminHome
            // 
            this.btnAdminHome.Location = new System.Drawing.Point(3, 0);
            this.btnAdminHome.Name = "btnAdminHome";
            this.btnAdminHome.Size = new System.Drawing.Size(123, 37);
            this.btnAdminHome.TabIndex = 0;
            this.btnAdminHome.Text = "Home";
            this.btnAdminHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSearchUser);
            this.panel2.Controls.Add(this.dgvHome);
            this.panel2.Location = new System.Drawing.Point(3, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 435);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search User:";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(211, 127);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(273, 20);
            this.txtSearchUser.TabIndex = 4;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // dgvHome
            // 
            this.dgvHome.AllowUserToAddRows = false;
            this.dgvHome.AllowUserToDeleteRows = false;
            this.dgvHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.phone,
            this.email,
            this.blood});
            this.dgvHome.Location = new System.Drawing.Point(3, 221);
            this.dgvHome.Name = "dgvHome";
            this.dgvHome.ReadOnly = true;
            this.dgvHome.Size = new System.Drawing.Size(1028, 204);
            this.dgvHome.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "UserId";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "UserRealName";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "UserPhone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "UserEmail";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // blood
            // 
            this.blood.DataPropertyName = "UserBlood";
            this.blood.HeaderText = "Blood Group";
            this.blood.Name = "blood";
            this.blood.ReadOnly = true;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnAdminBooking;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdminApart;
        private System.Windows.Forms.Button btnAdminHouse;
        private System.Windows.Forms.Button btnAdminHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn blood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchUser;
    }
}