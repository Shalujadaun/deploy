using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeTie
{
    public class BusinessObject
    {
        private string UserID;
        private string Password;

      
        public string userID
        {
            get
            {
                return UserID;
            }
            set
            {
                UserID = value;
            }
        }
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
    }
}