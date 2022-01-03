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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void PopulateGridView()
        {
            // var dt = DataAccess.GetDataTable(sql);
            this.dgvHome.AutoGenerateColumns = false;
            this.dgvHome.DataSource = HomeUserRepo.GetAllAdmin().ToList();
            this.dgvHome.ClearSelection();
            this.dgvHome.Refresh();
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

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
           AdminProfile h1 = new AdminProfile();
            h1.Visible = true;
            this.Visible = false;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            var dt = this.txtSearchUser.Text;
            this.dgvHome.DataSource = HomeUserRepo.GetSearchUserByAdmin(dt).ToList();
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
