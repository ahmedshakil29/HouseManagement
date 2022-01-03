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
    public partial class RenterBookingHistory : Form
    {
        public RenterBookingHistory()
        {
            InitializeComponent();
        }
        private void PopulateGridView(int id)
        {
            // var dt = DataAccess.GetDataTable(sql);
            this.dgvBookingHistory.AutoGenerateColumns = false;
            this.dgvBookingHistory.DataSource = BookRepo.GetAllBookingLog(id).ToList();
            this.dgvBookingHistory.ClearSelection();
            this.dgvBookingHistory.Refresh();
        }
        private void RenterBookingHistory_Load(object sender, EventArgs e)
        {
            this.PopulateGridView(1);
        }
        private void rbPending_CheckedChanged(object sender, EventArgs e)
        {
            this.PopulateGridView(0);
        }
        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            this.PopulateGridView(1);
        }
        private void btnBookingHistoey_Click(object sender, EventArgs e)
        {

        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            RenterHome f1 = new RenterHome();
            f1.Visible = true;
            this.Visible = false;
        }
        public void loaddetail(int id)
        {
            var booking = BookRepo.GetBook2(id);
            this.txtBid.Text = booking.BookId.ToString();


        }
        private void dgvBookingHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvBookingHistory.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.txtBid.Text=="")
            {
                MessageBox.Show("Please select a row first");
            }
            else
            {
               
                try
                {
                    int id = Int32.Parse(this.txtBid.Text);
                    
                    bool decision = BookRepo.Delete(id);
                    if (decision)
                    {
                        MessageBox.Show("Data Entry Complete");
                        this.Refresh();
                        this.PopulateGridView(0);

                    }
                    else
                        MessageBox.Show("Something went messing");

                    this.PopulateGridView(0);

                }
                catch (Exception exc)
                {
                    var msg = "Error: " + exc.Message;
                    MessageBox.Show(msg, "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Session.Destroy();
            LogIn h1 = new LogIn();
            h1.Visible = true;
            this.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            RenterProfile h1 = new RenterProfile();
            h1.Visible = true;
            this.Visible = false;
        }
    }
}
