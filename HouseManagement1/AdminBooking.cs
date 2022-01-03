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
    public partial class AdminBooking : Form
    {
        public AdminBooking()
        {
            InitializeComponent();
        }
        private void PopulateGridView()
        {
            // var dt = DataAccess.GetDataTable(sql);
            this.dgvBooking.AutoGenerateColumns = false;
            this.dgvBooking.DataSource = BookRepo.GetAllAdmin().ToList();
            this.dgvBooking.ClearSelection();
            this.dgvBooking.Refresh();
        }

        private void txtSearchBooking_TextChanged(object sender, EventArgs e)
        {
            var dt = this.txtSearchBooking.Text;
            this.dgvBooking.DataSource = BookRepo.GetSearchApartByAdmin(dt).ToList();
        }
        private void btnAdminHome_Click(object sender, EventArgs e)
        {
            AdminHome h1 = new AdminHome();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnAdminHouse_Click(object sender, EventArgs e)
        {
            AdminHome h1 = new AdminHome();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnAdminApartment_Click(object sender, EventArgs e)
        {
            AdminApart h1 = new AdminApart();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            AdminProfile h1 = new AdminProfile();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void AdminBooking_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
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
