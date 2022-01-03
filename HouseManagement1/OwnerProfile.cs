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
    public partial class OwnerProfile : Form
    {
        private HomeUserInfo user { get; set; }
        public OwnerProfile()
        {
            InitializeComponent();
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
            if (Validation.IsTextNotNull(this.txtUserName.Text) || Validation.IsTextNotNull(this.txtPassword.Text) || Validation.IsTextNotNull(txtPhone.Text) || Validation.IsTextNotNull(txtName.Text) || Validation.IsTextNotNull(cmbBlood.Text))
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

        private void OwnerProfile_Load(object sender, EventArgs e)
        {
            this.RefreshUser();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           OwnerHome h1 = new OwnerHome();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
           OwnerHouse h1 = new OwnerHouse();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnAddApart_Click(object sender, EventArgs e)
        {
           OwnerApart h1 = new OwnerApart();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnOwnerBook_Click(object sender, EventArgs e)
        {
            OwnerBookLog h1 = new OwnerBookLog();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Destroy();
            LogIn h1 = new LogIn();
            h1.Visible = true;
            this.Visible = false;
        }
    }
}
