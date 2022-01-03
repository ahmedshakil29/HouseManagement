namespace HouseManagement1
{
    partial class OwnerBookLog
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
            this.btnAddApart = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbfalse = new System.Windows.Forms.RadioButton();
            this.rbtrue = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtapid = new System.Windows.Forms.TextBox();
            this.txtbid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnAddApart);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnAddHouse);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 39);
            this.panel1.TabIndex = 11;
            // 
            // btnAddApart
            // 
            this.btnAddApart.Location = new System.Drawing.Point(252, 3);
            this.btnAddApart.Name = "btnAddApart";
            this.btnAddApart.Size = new System.Drawing.Size(125, 33);
            this.btnAddApart.TabIndex = 4;
            this.btnAddApart.Text = "Add Apartment";
            this.btnAddApart.UseVisualStyleBackColor = true;
            this.btnAddApart.Click += new System.EventHandler(this.btnAddApart_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Location = new System.Drawing.Point(842, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 39);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(724, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(112, 33);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Location = new System.Drawing.Point(118, 3);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(128, 33);
            this.btnAddHouse.TabIndex = 1;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 33);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbfalse);
            this.panel2.Controls.Add(this.rbtrue);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtapid);
            this.panel2.Controls.Add(this.txtbid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 438);
            this.panel2.TabIndex = 13;
            // 
            // rbfalse
            // 
            this.rbfalse.AutoSize = true;
            this.rbfalse.Location = new System.Drawing.Point(210, 119);
            this.rbfalse.Name = "rbfalse";
            this.rbfalse.Size = new System.Drawing.Size(89, 24);
            this.rbfalse.TabIndex = 9;
            this.rbfalse.TabStop = true;
            this.rbfalse.Text = "Ignored";
            this.rbfalse.UseVisualStyleBackColor = true;
            // 
            // rbtrue
            // 
            this.rbtrue.AutoSize = true;
            this.rbtrue.Location = new System.Drawing.Point(59, 119);
            this.rbtrue.Name = "rbtrue";
            this.rbtrue.Size = new System.Drawing.Size(103, 24);
            this.rbtrue.TabIndex = 8;
            this.rbtrue.TabStop = true;
            this.rbtrue.Text = "Accepted";
            this.rbtrue.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtapid
            // 
            this.txtapid.Location = new System.Drawing.Point(118, 70);
            this.txtapid.Name = "txtapid";
            this.txtapid.ReadOnly = true;
            this.txtapid.Size = new System.Drawing.Size(223, 26);
            this.txtapid.TabIndex = 5;
            // 
            // txtbid
            // 
            this.txtbid.Location = new System.Drawing.Point(118, 38);
            this.txtbid.Name = "txtbid";
            this.txtbid.ReadOnly = true;
            this.txtbid.Size = new System.Drawing.Size(223, 26);
            this.txtbid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bid";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bid,
            this.apid,
            this.rentername,
            this.isactive});
            this.dataGridView1.Location = new System.Drawing.Point(0, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bid
            // 
            this.bid.DataPropertyName = "BookId";
            this.bid.HeaderText = "Bid";
            this.bid.Name = "bid";
            // 
            // apid
            // 
            this.apid.DataPropertyName = "BookApartId";
            this.apid.HeaderText = "Ap Id";
            this.apid.Name = "apid";
            // 
            // rentername
            // 
            this.rentername.DataPropertyName = "BookRenterName";
            this.rentername.HeaderText = "Renter Name";
            this.rentername.Name = "rentername";
            // 
            // isactive
            // 
            this.isactive.DataPropertyName = "BookIsAvtive";
            this.isactive.HeaderText = "Is Active";
            this.isactive.Name = "isactive";
            // 
            // OwnerBookLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "OwnerBookLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerBookLog";
            this.Load += new System.EventHandler(this.OwnerBookLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddApart;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtapid;
        private System.Windows.Forms.TextBox txtbid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbfalse;
        private System.Windows.Forms.RadioButton rbtrue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn apid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentername;
        private System.Windows.Forms.DataGridViewTextBoxColumn isactive;
    }
}