using HouseManagement1.FrameWorkLayer;
using HouseManagement1.RepositoryLayer;
using HouseManagement1.EntityLayer;
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
    public partial class RenterHome : Form
    {
        private BookInfo book { get; set; }
        
        public RenterHome()
        {
            InitializeComponent(); 
          txtRenterName.Text=Session.UserName;
        }
        private void PopulateGridView()
        {
            // var dt = DataAccess.GetDataTable(sql);
            this.dgvBooking.AutoGenerateColumns = false;
            this.dgvBooking.DataSource = BookRepo.GetAll().ToList();
            this.dgvBooking.ClearSelection();
            this.dgvBooking.Refresh();
        }
        public void loaddetail(int id)
        {
            var booking = BookRepo.GetBook(id);
            if (booking.BookAprtId == null)
            {
                this.txtapid.Text = "";
            }
            else
            {
                this.txtapid.Text = booking.BookAprtId.ToString();
            }
            //this.dtpBookingDate.Value = booking.BookDate;
            this.txtRenterName.Text = Session.UserName;
            

         

        }
        private bool IsValidToSave()
        {
            if (Validation.IsTextNotNull(this.txtapid.Text)  || Validation.IsTextNotNull(this.txtRenterName.Text))
                return false;
            return true;
        }
        private void FillEntity()
        {
            if (this.IsValidToSave())
                return;

            this.book = new EntityLayer.BookInfo();
            book.BookAprtId = Convert.ToInt32(txtapid.Text);
            book.BookDate = Convert.ToDateTime(dtpBookingDate.Text);
 

        }
        private void btnAddHouse_Click(object sender, EventArgs e)// go to booking
        {
            RenterBookingHistory r1 = new RenterBookingHistory();
            r1.Visible = true;
            this.Visible = false;
        }
        private void Home_Load(object sender, EventArgs e)// Booking Page Load
        {
            this.PopulateGridView();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            RenterProfile p1 = new RenterProfile();
            p1.Visible = true;
            this.Visible = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                this.FillEntity();
                bool decision = BookRepo.Save(book);
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
                MessageBox.Show(msg, "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvBooking.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtapid.Text = "";
        }
        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Session.Destroy();
            LogIn h1 = new LogIn();
            h1.Visible = true;
            this.Visible = false;
        }

    }
  
}
