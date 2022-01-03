using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManagement1.FrameWorkLayer
{
    public static class Session
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static int UserTypeId { get; set; }
        public static void Destroy()
        {
            UserId = -1;
            UserName = "";
            UserTypeId = -1;
        }
    }
}
