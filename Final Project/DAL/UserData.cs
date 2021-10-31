using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserData
    {
        public int UserID { get; set; }

        public string Username { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        public int RoleID { get; set; }

    }
}
