using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IWPTFB.Models
{
    public class UserModel
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Fullname
        {
            get
            {
                return Firstname + " " + Surname;
            }
        }
        public string FacebookId { get; set; }
    }
}