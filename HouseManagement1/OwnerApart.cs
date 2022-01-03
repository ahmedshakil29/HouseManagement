using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using HouseManagement1.DataLayer;
using HouseManagement1.EntityLayer;
using HouseManagement1.RepositoryLayer;
using HouseManagement1.FrameWorkLayer;

namespace HouseManagement1
{
    public partial class OwnerApart : Form
    {
        private ApartInfo apart { get; set; }
        private HouseInfo house { get; set; }
        private DataTable Dt { get; set; }


        public OwnerApart()
        {
            InitializeComponent();
           // RefreshGrid = d;

        }
        private void PopulateGridView()
        {
            // var dt = DataAccess.GetDataTable(sql);
            this.dgvApart.AutoGenerateColumns = false;
            this.dgvApart.DataSource = ApartRepo.GetAll().ToList();
            this.dgvApart.ClearSelection();
            this.dgvApart.Refresh();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OwnerHome f1 = new OwnerHome();
            f1.Visible = true;
            this.Visible = false;
        }  
        private void btnApartSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.FillEntity();
                bool decision = ApartRepo.Save(apart);
                if (decision)
                {
                    MessageBox.Show("Data Entry Complete");
                    this.Refresh();
                    this.PopulateGridView();
                   
                }
                else
                    MessageBox.Show("Something went messing");

                this.PopulateGridView();

            }
            catch (Exception exc)
            {
                var msg = "Error: " + exc.Message;
                MessageBox.Show(msg,"Something went messing");

              //  MessageBox.Show(msg, "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
        private bool IsValidToSave()
        {
            if (Validation.IsTextNotNull(this.cmbView.Text) || Validation.IsTextNotNull(this.cmbApartType.Text) || Validation.IsTextNotNull(this.txtApartNo.Text) || Validation.IsTextNotNull(this.txtApartSize.Text) || Validation.IsTextNotNull(this.cmbNoOfRoom.Text) || Validation.IsTextNotNull(this.txtRentPrice.Text) || Validation.IsTextNotNull(this.txtSpecification.Text) || Validation.IsTextNotNull(this.cmbHouseid.Text) || Validation.IsTextNotNull(this.txtFloorNo.Text))
                return false;
            return true;
        }
        private void FillEntity()
        {
            if (this.IsValidToSave())
                  return;

            this.apart = new EntityLayer.ApartInfo();
            if (this.txtApartId.Text == "") { this.apart.ApartId = -1; }
            else { this.apart.ApartId = Convert.ToInt32(this.txtApartId.Text); }
            
            this.apart.ApartType = this.cmbApartType.Text ;
            this.apart.ApartNo = this.txtApartNo.Text ;
            this.apart.ApartSize = this.txtApartSize.Text ;
            this.apart.ApartNoOfRoom = Convert.ToInt32( this.cmbNoOfRoom.Text);
            this.apart.ApartRentPrice = Convert.ToDouble( this.txtRentPrice.Text);
            this.apart.ApartSpecification = this.txtSpecification.Text; 
            this.apart.ApartfloorNo = Convert.ToInt32(this.txtFloorNo.Text );
            this.apart.ApartView = this.cmbView.Text;
            this.apart.HouseId = Convert.ToInt32( this.cmbHouseid.SelectedValue.ToString());
           
            this.apart.userId = Session.UserId;
            if (rbActive.Checked==true)
            {
                this.apart.ApartStatus = "Äctive";
            }
            if (rbInactive.Checked==true)
            {
                this.apart.ApartStatus = "Inactive";
            }
            
        }
        private List<HouseInfo> getHouse()
        {
            List<HouseInfo> houselist=new List<HouseInfo>();
            houselist = ApartRepo.GetAllHouse().ToList();
            return houselist;
        }
        private void AddApart_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
            cmbHouseid.DataSource = this.getHouse();
            cmbHouseid.ValueMember ="houseid";
            cmbHouseid.DisplayMember = "housename";
            var a = cmbHouseid.SelectedValue.ToString();
            int s;
            if (Int32.TryParse(a, out s))
            {
                txthousetype.Text = ApartRepo.GetHouseByHouseId(s).HouseType;
            }

        }
        private void cmbHouseid_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = cmbHouseid.SelectedValue.ToString();
            int s;
            if(Int32.TryParse(a,out s)){
               txthousetype.Text=ApartRepo.GetHouseByHouseId(s).HouseType;
            }
            
            //var ss = cmbHouseid.SelectedValue.ToString();
            //int sss;
            //if (Int32.TryParse(ss, out sss))
            //{
            //    txthousetype.Text = ApartRepo.GetHouseTypeByHouseId(sss);
            //}
                
        }
        private void txthousetype_TextChanged(object sender, EventArgs e)
        {
            var s = txthousetype.Text;
            if (s.Equals("Residential"))
            {
                cmbApartType.Items.Clear();
                cmbApartType.Items.Add("Apartment ");
                cmbApartType.Items.Add("Penthouse");
                cmbApartType.Items.Add("plaza");
                cmbApartType.Items.Add("Duplex");
            }
            else if (s.Equals("Commercial"))
            {
                cmbApartType.Items.Clear();
                cmbApartType.Items.Add("Warehouse");
                cmbApartType.Items.Add("Shop");
                cmbApartType.Items.Add("Factory");
            }
        }
        public void loaddetail(int id)
        {
            var apartment = ApartRepo.GetApart(id);
            if (apartment.ApartId == null)
            {
                this.txtApartId.Text = "";
            }
            this.txtApartId.Text = apartment.ApartId.ToString();
            this.cmbApartType.Text=apartment.ApartType;
            this.txtApartNo.Text=apartment.ApartNo;
            this.txtApartSize.Text=apartment.ApartSize;
            this.cmbNoOfRoom.Text=apartment.ApartNoOfRoom.ToString();
            this.txtRentPrice.Text=apartment.ApartRentPrice.ToString();
            this.txtSpecification.Text=apartment.ApartSpecification;
            this.txtFloorNo.Text=apartment.ApartfloorNo.ToString();
            this.cmbView.Text=apartment.ApartView;
            var house = ApartRepo.GetHouseByHouseId(apartment.HouseId);
            if (house != null) {
                this.cmbHouseid.SelectedIndex = cmbHouseid.FindStringExact(apartment.HouseName); 
            }
            
            //cbbDesignation.SelectedIndex = cbbDesignation.FindStringExact(employee.desigName.ToString());

            
            if (apartment.ApartStatus=="Active")
            {
               // this.apart.ApartStatus = "Äctive";
                this.rbActive.Checked=true;
            }
            if (apartment.ApartStatus=="Inactive")
            {
                //this.apart.ApartStatus = "Inactive";
                this.rbInactive.Checked=true;
            }

        }
        private void dgvApart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvApart.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
        }
        private void txtSearchApart_TextChanged(object sender, EventArgs e)
        {
            var dt = this.txtSearchApart.Text;
            this.dgvApart.DataSource = ApartRepo.GetSearchApart(dt).ToList();
        }
        private void btnBookingLog_Click(object sender, EventArgs e)
        {
            OwnerBookLog f1 = new OwnerBookLog();
            f1.Visible = true;
            this.Visible = false;
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            OwnerHouse f1 = new OwnerHouse();
            f1.Visible = true;
            this.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OwnerProfile f1 = new OwnerProfile();
            f1.Visible = true;
            this.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Destroy();
            LogIn h1 = new LogIn();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnApartClear_Click(object sender, EventArgs e)
        {
            this.txtApartNo.Text = "";
            this.txtApartSize.Text = "";
            this.txtFloorNo.Text = "";
            this.txtRentPrice.Text = "";
        }
       
    }
}
