using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.BLL
{
    class UserModel
    {
        public int user_id { get; set; }
        public string username { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public string mobile { get; set; }

        public string gender { get; set; }

        public DateTime enrolled_date { get; set; }

        public DateTime membership_expiry_date { get; set; }

        public int num_books_borrowed { get; set; }
    }
}
