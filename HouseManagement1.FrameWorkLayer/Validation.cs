using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

using System.Text.RegularExpressions;

namespace HouseManagement1.FrameWorkLayer
{
    public static class Validation
    {
        public static bool IsTextNotNull(string value)
        {

            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                return false;

            }
            else
            {
                return true;
            }
            
        }
        public static bool IsValidEmail(string emaiil)
        {
            ////if(String)

            //if (String.Mail.MailAddress(email))
            //{
            //    return false;

            //}
            //else
            //{
              return true;
            //}

        }
        public static bool IsValidPassword(string plainText)
        {
            Regex regex = new Regex(@"^(.{0,7}|[^0-9]*|[^A-Z])$");
            Match match = regex.Match(plainText);
            return match.Success;
            
        }
    }
}
