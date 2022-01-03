namespace HouseManagement1
{
    partial class OwnerHome
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
            this.btnbl = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddApart = new System.Windows.Forms.Button();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHouse = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnbl);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnAddApart);
            this.panel1.Controls.Add(this.btnAddHouse);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnbl
            // 
            this.btnbl.Location = new System.Drawing.Point(251, 3);
            this.btnbl.Name = "btnbl";
            this.btnbl.Size = new System.Drawing.Size(110, 29);
            this.btnbl.TabIndex = 4;
            this.btnbl.Text = "Booking Log";
            this.btnbl.UseVisualStyleBackColor = true;
            this.btnbl.Click += new System.EventHandler(this.btnbl_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogOut.Location = new System.Drawing.Point(863, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(98, 31);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddApart
            // 
            this.btnAddApart.Location = new System.Drawing.Point(121, 3);
            this.btnAddApart.Name = "btnAddApart";
            this.btnAddApart.Size = new System.Drawing.Size(124, 29);
            this.btnAddApart.TabIndex = 2;
            this.btnAddApart.Text = "Add Apartment";
            this.btnAddApart.UseVisualStyleBackColor = true;
            this.btnAddApart.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Location = new System.Drawing.Point(3, 3);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(112, 31);
            this.btnAddHouse.TabIndex = 1;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(753, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(104, 29);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHouse);
            this.panel2.Location = new System.Drawing.Point(2, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 442);
            this.panel2.TabIndex = 1;
            // 
            // dgvHouse
            // 
            this.dgvHouse.AllowUserToAddRows = false;
            this.dgvHouse.AllowUserToDeleteRows = false;
            this.dgvHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.bookdate,
            this.aid,
            this.Active,
            this.rentername});
            this.dgvHouse.Location = new System.Drawing.Point(3, 154);
            this.dgvHouse.Name = "dgvHouse";
            this.dgvHouse.ReadOnly = true;
            this.dgvHouse.Size = new System.Drawing.Size(958, 255);
            this.dgvHouse.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "BookId";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // bookdate
            // 
            this.bookdate.DataPropertyName = "BookDate";
            this.bookdate.HeaderText = "Date";
            this.bookdate.Name = "bookdate";
            this.bookdate.ReadOnly = true;
            // 
            // aid
            // 
            this.aid.DataPropertyName = "BookAprtId";
            this.aid.HeaderText = "A.ID";
            this.aid.Name = "aid";
            this.aid.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "BookIsAvtive";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // rentername
            // 
            this.rentername.DataPropertyName = "BookRenterName";
            this.rentername.HeaderText = "RenterName";
            this.rentername.Name = "rentername";
            this.rentername.ReadOnly = true;
            // 
            // OwnerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "OwnerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddApart;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHouse;
        private System.Windows.Forms.Button btnbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentername;
    }
}

