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
    public partial class SignUp : Form
    {
        private HomeUserInfo signup { get; set; }
      //  private DataTable Dt { get; set; }
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == this.txtConfirmPassword.Text)
            {
                try
                {
                    this.FillEntity();
                    bool decision = HomeUserRepo.Save(signup);
                    if (decision)
                    {
                        MessageBox.Show("Data Entry Complete");
                        LogIn f1 = new LogIn();
                        f1.Visible = true;
                        this.Visible = false;
                    }
                    else
                        MessageBox.Show("Something went messing");

                    // this.PopulateGridView();

                }
                catch (Exception exc)
                {
                    var msg = "Error: " + exc.Message;
                  // MessageBox.Show(msg, "Fill All the Field Properly.");

                //    // MessageBox.Show(msg, "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }

            else 
            {
                MessageBox.Show("Password do not match ");


            }

        }
        private bool IsValidToSave()
        {
            if (Validation.IsTextNotNull(this.txtUserName.Text) || Validation.IsTextNotNull(this.txtPassword.Text) || Validation.IsTextNotNull(this.txtName.Text) || Validation.IsTextNotNull(this.txtPhone.Text) || Validation.IsTextNotNull(this.txtEmail.Text) || Validation.IsTextNotNull(this.cmbBlood.Text) )
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        private void FillEntity()
        {

            if (this.IsValidToSave())
            { return; }


            this.signup = new EntityLayer.HomeUserInfo();
            
            this.signup.UserName = this.txtUserName.Text;
            this.signup.UserPassword = this.txtPassword.Text;
            
            this.signup.UserRealName = this.txtName.Text;
            this.signup.UserPhone = this.txtPhone.Text;
            this.signup.UserEmail = this.txtEmail.Text;
            this.signup.UserBlood = this.cmbBlood.Text;
            if (this.rbSignUpOwner.Checked == true)
            {
                this.signup.UserTypeId = 2;
            }
            if (this.rbSignUpRenter.Checked== true)
            {
                this.signup.UserTypeId = 3;
            }
           // this.signup.UserTypeId = Convert.ToInt32( this.txtUserTypeId.Text);
           // this.signup.
        }
    }
}
