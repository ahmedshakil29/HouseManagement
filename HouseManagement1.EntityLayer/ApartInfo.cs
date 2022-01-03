using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManagement1.EntityLayer
{
    public class ApartInfo
    {
        public int ApartId { get; set; }
        public string ApartType { get; set; }
        public string ApartNo { get; set; }
        public string ApartSize { get; set; }
        public string ApartView { get; set; }
        public int ApartNoOfRoom { get; set; }
        public double ApartRentPrice { get; set; }
        public string ApartSpecification { get; set; }
        public string ApartStatus { get; set; }
        public int ApartfloorNo { get; set; }
        public int HouseId { get; set; }
        public string HouseName { get; set; }
        public int userId { get; set; }
        public HouseInfo HouseInfo { get; set; }
        public HomeUserInfo HomeUserInfo { get; set; }
    }
}
