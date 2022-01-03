using HouseManagement1.EntityLayer;
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
    public partial class OwnerBookLog : Form
    {
        private BookInfo book { get; set; }
        public OwnerBookLog()
        {
            InitializeComponent();
        }
        private void PopulateGridView()
        {
            // var dt = DataAccess.GetDataTable(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = BookRepo.GetAllBookingLogForOwner().ToList();
            this.dataGridView1.ClearSelection();
            this.dataGridView1.Refresh();
        }
        public void loaddetail(int id)
        {
            var booking = BookRepo.GetBook2(id);
            this.txtbid.Text = booking.BookId.ToString();
                this.txtapid.Text = booking.BookAprtId.ToString();
            if(booking.BookIsAvtive==true)
            {
                this.rbtrue.Checked = true;
            }
            if (booking.BookIsAvtive == false)
            {
                this.rbfalse.Checked = true;
            }
            




        }
        private bool IsValidToSave()
        {
            if (Validation.IsTextNotNull(this.txtapid.Text) || Validation.IsTextNotNull(this.txtbid.Text))
                return false;
            return true;
        }
        private void FillEntity()
        {
            if (this.IsValidToSave())
                return;

            this.book = new EntityLayer.BookInfo();
            this.book.BookId = Convert.ToInt32(this.txtbid.Text);

              this.book.BookAprtId = Convert.ToInt32(this.txtapid.Text);
            if ( this.rbtrue.Checked == true)
            {
                this.book.BookIsAvtive = true;
            }
            if (this.rbfalse.Checked == true)
            {
                this.book.BookIsAvtive = false;
            }
            


        }
        private void btnHome_Click(object sender, EventArgs e)
        {
           OwnerHome f1 = new OwnerHome();
            f1.Visible = true;
            this.Visible = false;
        }
        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            OwnerHouse f1 = new OwnerHouse();
            f1.Visible = true;
            this.Visible = false;
        }
        private void btnAddApart_Click(object sender, EventArgs e)
        {
            OwnerApart f1 = new OwnerApart();
            f1.Visible = true;
            this.Visible = false;
        }
        private void OwnerBookLog_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                this.FillEntity();
                bool decision = BookRepo.Update(book);
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loaddetail(Int32.Parse(id));
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OwnerProfile f1 = new OwnerProfile();
            f1.Visible = true;
            this.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Destroy();
            LogIn h1 = new LogIn();
            h1.Visible = true;
            this.Visible = false;
        }
    }
}
