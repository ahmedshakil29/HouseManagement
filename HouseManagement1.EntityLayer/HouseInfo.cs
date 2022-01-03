using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseManagement1.DataLayer;

namespace HouseManagement1.EntityLayer
{
    public class HouseInfo
    {
        public int HouseId { get; set; }
        public string HouseName { get; set; }
        public string HouseNo { get; set; }
        public string HouseType { get; set; }
        public string HouseCity { get; set; }
        public string HouseRegion { get; set; }
        public string HouseArea { get; set; }
        public string HouseRoadNo { get; set; }
        public int UserId { get; set; }
        public HomeUserInfo HomeUser { get; set; }
    }
}
