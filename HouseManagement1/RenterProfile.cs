using HouseManagement1.EntityLayer;
using HouseManagement1.FrameWorkLayer;
using HouseManagement1.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseManagement1
{
    public partial class RenterProfile : Form
    {
        private HomeUserInfo user { get; set; }
        public RenterProfile()
        {
            InitializeComponent();
        }
        private bool IsValidToSave()
        {
            if (Validation.IsTextNotNull(this.txtUserName.Text) || Validation.IsTextNotNull(this.txtPassword.Text))
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
            this.user.UserRealName= txtName.Text;
            this.user.UserEmail = txtEmail.Text;
            this.user.UserRealName = txtName.Text;
            this.user.UserBlood = cmbBlood.Text;
            this.user.UserTypeId = Session.UserTypeId;



        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            RenterHome h1 = new RenterHome();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnBookingHistoey_Click(object sender, EventArgs e)
        {
            RenterBookingHistory r1 = new RenterBookingHistory();
            r1.Visible = true;
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
        private void RefreshUser()
        {
            HomeUserInfo user1 = HomeUserRepo.GetUser(Session.UserId);

           
           this.txtUserName.Text= user1.UserName;
           this.txtPassword.Text = user1.UserPassword;
           this.txtPhone.Text = user1.UserPhone;
           this.txtName.Text = user1.UserRealName;
           this.txtEmail.Text=user1.UserEmail ;
           this.txtName.Text=user1.UserRealName;
            this.cmbBlood.Text=user1.UserBlood;
           



        }

        private void RenterProfile_Load(object sender, EventArgs e)
        {
            this.RefreshUser();
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
