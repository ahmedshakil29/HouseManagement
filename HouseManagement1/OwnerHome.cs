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
using HouseManagement1.RepositoryLayer;
using HouseManagement1.FrameWorkLayer;

namespace HouseManagement1
{
    public partial class OwnerHome : Form
    {
        private HouseRepo HRepo { get; set; }
        private DataTable Dt { get; set; }
        public OwnerHome()
        {

            InitializeComponent();
            
            // this.PopulateGridView();
            this.HRepo = new HouseRepo();
        } 
        private void PopulateGridView()
        {
          // var dt = DataAccess.GetDataTable(sql);
            this.dgvHouse.AutoGenerateColumns = false;
            this.dgvHouse.DataSource = BookRepo.GetAllOwner().ToList();
            this.dgvHouse.ClearSelection();
            this.dgvHouse.Refresh();
        }
        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            OwnerHouse h1 = new OwnerHouse();
            h1.Visible = true;
            this.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
       
        private void PopulateGridView2(DataTable dt) // No needed
        {
            //this.dgvHouse.AutoGenerateColumns = false;
            //this.dgvHouse.DataSource = dt;
            //this.dgvHouse.DataSource = HouseRepo.SearchHouse().Tolist();

        }
        private void button3_Click(object sender, EventArgs e)//Add Apart go
        {
            OwnerApart h1 = new OwnerApart();
            //DelegateCollection.RefresshGridData dgvRefresh = this.PopulateGridView;
           // new AddApart(dgvRefresh).Show();
             h1.Visible = true;
            this.Visible = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OwnerProfile h1 = new OwnerProfile();
            h1.Visible = true;
            this.Visible = false;
        }
        private void btnbl_Click(object sender, EventArgs e)
        {
            OwnerBookLog h1 = new OwnerBookLog();
            h1.Visible = true;
            this.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Session.Destroy();
            LogIn h1 = new LogIn();
            h1.Visible = true;
            this.Visible = false;
        }
        private void txtSearchHouse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
