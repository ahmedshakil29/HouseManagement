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
    public partial class OwnerHouse : Form
    {
        private HouseInfo house { get; set; }
        private HouseRepo HRepo { get; set; }
      //  private DataTable Dt { get; set; }
      //  private DelegateCollection.RefresshGridData RefreshGrid { get; set; }
        public OwnerHouse()
        {
            InitializeComponent();
            //  RefreshGrid = d;DelegateCollection.RefresshGridData d;
        } 
        private void btnHome_Click(object sender, EventArgs e)
        {
            OwnerHome f1 = new OwnerHome();
            f1.Visible = true;
            this.Visible = false;
        }
        private void btnAddApart_Click(object sender, EventArgs e)
        {
            OwnerApart a1 = new OwnerApart();
            a1.Visible = true;
            this.Visible = false;
        }
        private void PopulateGridView()
        {
            this.dgvHouse.AutoGenerateColumns = false;
            this.dgvHouse.DataSource = HouseRepo.GetAll().ToList();
            this.dgvHouse.ClearSelection();
            this.dgvHouse.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)//save button
        {
            try
            {
                this.FillEntity();
                bool decision = HouseRepo.Save(house);
                if (decision)
                {
                    MessageBox.Show("Data Entry Complete");
                    this.Refresh();
                    this.PopulateGridView();
                    //this.RefreshGrid();
                    // new From1(RefreshGrid).Show();
                    // new AddHouse(dgvRefresh).Show();
                    //new Form1().Show();
                   // this.Visible = false;
                }
                else
                    MessageBox.Show("Something went messing");
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                var msg = "Error: " + exc.Message;
                MessageBox.Show(msg, "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
        private bool IsValidToSave()
        {
            if (Validation.IsTextNotNull(this.txtHouseName.Text) || Validation.IsTextNotNull(this.txtHouseNo.Text) || Validation.IsTextNotNull(this.cmbArea.Text) || Validation.IsTextNotNull(this.cmbRegion.Text) || Validation.IsTextNotNull(this.txtRoadNo.Text))
                return false;
            return true;
        }
        private void FillEntity()
        {
            if (this.IsValidToSave())
                return;

            this.house = new EntityLayer.HouseInfo();
            if (this.txtHouseId.Text == "") { this.house.HouseId = -1; }
            else { this.house.HouseId = Convert.ToInt32(this.txtHouseId.Text); }
            
            this.house.HouseName = this.txtHouseName.Text;
            this.house.HouseNo = this.txtHouseNo.Text;
          //this.house.HouseType = this.cmbHouseType.Text;                //this.txtHouseType.Text;
            this.house.HouseCity = this.txtCityName.Text;
            this.house.HouseRegion = this.cmbRegion.Text;                //this.txtRegion.Text;
            this.house.HouseArea = this.cmbArea.Text;                   //this.txtArea.Text;
            this.house.HouseRoadNo = this.txtRoadNo.Text;
           
            if (rbCommercial.Checked == true)
            {
                this.house.HouseType = "Commercial";
            }
            if (rbResidential.Checked == true)
            {
                this.house.HouseType = "Residential";
            }
          //  this.house.UserId = Convert.ToInt32( this.txtUserId.Text);
        }
        private void cmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegion.SelectedItem.Equals("Banani"))
            {
                cmbArea.Items.Clear();
                cmbArea.Items.Add("Banani 10");
                cmbArea.Items.Add("Banani 11");
                cmbArea.Items.Add("Banani 12");
            }
            if (cmbRegion.SelectedItem.Equals("Bashundhara"))
            {
                cmbArea.Items.Clear();
                cmbArea.Items.Add("Bashundhara R/A");
                cmbArea.Items.Add("Norda");
                cmbArea.Items.Add("Kalachatpur");
            }
            if (cmbRegion.SelectedItem.Equals("Khilkhet"))
            {
                cmbArea.Items.Clear();
                cmbArea.Items.Add("Nikunjho 1");
                cmbArea.Items.Add("Nikunjho 2");
                cmbArea.Items.Add("Vatara");
            }
            if (cmbRegion.SelectedItem.Equals("Mirpur"))
            {
                cmbArea.Items.Clear();
                cmbArea.Items.Add("Mirpur 10");
                cmbArea.Items.Add("Mirpur 11");
                cmbArea.Items.Add("Dohs");
            }
            if (cmbRegion.SelectedItem.Equals("Uttara"))
            {
                cmbArea.Items.Clear();
                cmbArea.Items.Add("Sector 1");
                cmbArea.Items.Add("Sector 2");
                cmbArea.Items.Add("Sector 3");
            }
        }
        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        { 
        
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
           // this.txtHouseId.Text = "";
            this.txtHouseName.Text = "";
            this.txtHouseNo.Text = "";
          //this.cmbHouseType.SelectedItem = null;
          //this.txtCityName.Text = "";
          //this.cmbRegion.SelectedItem = null;
            this.txtRoadNo.Text = "";
           // this.txtUserId.Text = "";
        }
        private void AddHouse_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        private void label6_Click(object sender, EventArgs e)
        {
 
        }

        private void dgvHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvHouse.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
        }
        public void loaddetail(int id)
        {
            var house = HouseRepo.GetHouseByHouseId(id);
            if (house.HouseId == null)
            {
                this.txtHouseId.Text = "";
            }
            this.txtHouseId.Text = house.HouseId.ToString();
            this.txtHouseName.Text = house.HouseName;
            this.txtHouseNo.Text = house.HouseType;
            this.txtRoadNo.Text = house.HouseRoadNo;
            this.cmbRegion.Text = house.HouseRegion;
            this.cmbArea.Text = house.HouseArea;

          if (house.HouseType=="Commercial" )
            {
                this.rbCommercial.Checked= true;
            }
          if (house.HouseType == "Residential")
          {
              this.rbCommercial.Checked = true;
          }
          
            
            }

        private void btnBookingLog_Click(object sender, EventArgs e)
        {
            OwnerBookLog a1 = new OwnerBookLog();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OwnerProfile a1 = new OwnerProfile();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Destroy();
            LogIn h1 = new LogIn();
            h1.Visible = true;
            this.Visible = false;
        }

        private void txtSearchHouse_TextChanged(object sender, EventArgs e)
        {
            var dt = this.txtSearchHouse.Text;
            this.dgvHouse.DataSource = HouseRepo.GetSearch(dt).ToList();
        }

        }

    }

