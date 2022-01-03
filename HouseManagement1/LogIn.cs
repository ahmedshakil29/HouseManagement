using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseManagement1.DataLayer;
using HouseManagement1.EntityLayer;
using HouseManagement1.RepositoryLayer;
using HouseManagement1.FrameWorkLayer;

namespace HouseManagement1
{
    public partial class LogIn : Form
    {
        private HomeUserInfo user { get; set; }
        private DataTable Dt { get; set; }
        public LogIn()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                this.FillEntity();
                bool homeuser = HomeUserRepo.LogIn(user);
                if (homeuser)
                {
                    if (Session.UserTypeId == 2)
                    {
                        MessageBox.Show(Session.UserName + ": Login" + " Susscgfully");
                        OwnerHome f1 = new OwnerHome();
                        f1.Visible = true;
                        this.Visible = false;
                    }
                    else if (Session.UserTypeId == 1)
                    {
                        MessageBox.Show(Session.UserName + ": Login" + " Susscgfully");
                        AdminHome f1 = new AdminHome();
                        f1.Visible = true;
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(Session.UserName + ": Login" + " Susscgfully");
                        RenterHome f1 = new RenterHome();
                        f1.Visible = true;
                        this.Visible = false;
                    }
                    
                    
                }
                else
                    MessageBox.Show("Something went messing");
            
            
            
          }
            catch (Exception exc)
            {
                 var msg = "Error: " + exc.Message;
                MessageBox.Show(msg,"Fill all the form");
              
               // MessageBox.Show(msg, "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
        private bool IsValidToSave()
        {
            if (Validation.IsTextNotNull(this.txtUserName.Text) || Validation.IsTextNotNull(this.txtPassWord.Text))
                return false;
            return true;
        }
        private void FillEntity()
        {
            if (this.IsValidToSave())
                return;

            this.user = new EntityLayer.HomeUserInfo();
            this.user.UserName = this.txtUserName.Text;
            this.user.UserPassword = this.txtPassWord.Text;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp f1 = new SignUp();
            f1.Visible = true;
            this.Visible = false;
        }
    }
}
