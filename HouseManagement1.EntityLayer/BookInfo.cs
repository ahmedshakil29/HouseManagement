using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManagement1.EntityLayer
{
  public  class BookInfo
    {

        public int BookId { get; set; }
        public DateTime BookDate { get; set; }
        public string BookRenterName { get; set; }
       
        public int BookAprtId{ get; set; }
        public string BookAprtNo { get; set; }
        public int Bookfloor { get; set; }
        public double Bookrentprice { get; set; }
        public string Bookapartspecification { get; set; }
        public string Bookapartstatus { get; set; }
        public string Bookapartsize { get; set; }
        public string Bookaparttype { get; set; }


        public int BookHouseId { get; set; }
        public string BookHouseName { get; set; }
        public string BookHouseNo { get; set; }
        public string BookHouseType { get; set; }
        public string BookHouseCity { get; set; }
        public string BookHouseRegion { get; set; }
        public string BookHouseArea { get; set; }
        public string BookHouseRoadNo { get; set; }
        public int BookUserId { get; set; }


        public bool BookIsAvtive { get; set; }
        public ApartInfo HouseInfo { get; set; }
        public HomeUserInfo HomeUserInfo { get; set; }
    }
}
