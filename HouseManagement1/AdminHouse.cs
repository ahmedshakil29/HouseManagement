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
    public partial class AdminHouse : Form
    {
        public AdminHouse()
        {
            InitializeComponent();
        }
        private void PopulateGridView()
        {
            // var dt = DataAccess.GetDataTable(sql);
            this.dgvHouse.AutoGenerateColumns = false;
            this.dgvHouse.DataSource = HouseRepo.GetAllAdmin().ToList();
            this.dgvHouse.ClearSelection();
            this.dgvHouse.Refresh();
        }
        private void btnAdminHome_Click(object sender, EventArgs e)
        {
           AdminHome h1 = new AdminHome();
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

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void AdminHouse_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtSearchHome_TextChanged(object sender, EventArgs e)
        {
            var dt = this.txtSearchHome.Text;
            this.dgvHouse.DataSource = HouseRepo.GetSearchouseByAdmin(dt).ToList();
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
