using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseManagement1.EntityLayer;
using HouseManagement1.RepositoryLayer;
using HouseManagement1.FrameWorkLayer;

namespace HouseManagement1
{
    public partial class AdminProfile : Form
    {
        private HomeUserInfo user { get; set; }
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
           this.btnAdminProfile.Text = Session.UserName;
        }

        private void btnAdminHome_Click(object sender, EventArgs e)
        {
            AdminHome h1 = new AdminHome();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnAdminHouse_Click(object sender, EventArgs e)
        {
            AdminHouse h1 = new AdminHouse();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnAdminApart_Click(object sender, EventArgs e)
        {
            AdminApart h1 = new AdminApart();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnAdminBooking_Click(object sender, EventArgs e)
        {
            AdminBooking h1 = new AdminBooking();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            try
            {

                this.FillEntity();
                bool decision = HomeUserRepo.Update(user);
                if (decision)
                {
                    MessageBox.Show("Data Entry Complete");

                    this.RefreshUser();

                }
                else
                    MessageBox.Show("Something went messing");

                this.RefreshUser();

            }
            catch (Exception exc)
            {
                var msg = "Error: " + exc.Message;
                MessageBox.Show(msg, "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
        private bool IsValidToSave()
        {
            if (Validation.IsTextNotNull(this.txtUserName.Text) || Validation.IsTextNotNull(this.txtPassword.Text) || Validation.IsTextNotNull(txtPhone.Text) || Validation.IsTextNotNull(txtName.Text) || Validation.IsTextNotNull(  cmbBlood.Text))
                return false;
            return true;
        }
        private void FillEntity()
        {
            if (this.IsValidToSave())
                return;

            this.user = new EntityLayer.HomeUserInfo();

            this.user.UserName = txtUserName.Text;
            this.user.UserPassword = txtPassword.Text;
            this.user.UserPhone = txtPhone.Text;
            this.user.UserRealName = txtName.Text;
            this.user.UserEmail = txtEmail.Text;
            this.user.UserRealName = txtName.Text;
            this.user.UserBlood = cmbBlood.Text;
            this.user.UserTypeId = Session.UserTypeId;



        }
        private void RefreshUser()
        {
            HomeUserInfo user1 = HomeUserRepo.GetUser(Session.UserId);


            this.txtUserName.Text = user1.UserName;
            this.txtPassword.Text = user1.UserPassword;
            this.txtPhone.Text = user1.UserPhone;
            this.txtName.Text = user1.UserRealName;
            this.txtEmail.Text = user1.UserEmail;
            this.txtName.Text = user1.UserRealName;
            this.cmbBlood.Text = user1.UserBlood;




        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            this.RefreshUser();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Destroy();
            LogIn h1 = new LogIn();
            h1.Visible = true;
            this.Visible = false;
        }
    }
}
