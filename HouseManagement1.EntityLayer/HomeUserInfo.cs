using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManagement1.EntityLayer
{
   public class HomeUserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRealName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public string UserBlood { get; set; }
        public int UserTypeId { get; set; }
        public UserTypeInfo UserType { get; set; }
    }
  
}
