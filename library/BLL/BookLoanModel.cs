using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.BLL
{
    class BookLoanModel
    {
        public int id { get; set; }
        public int issued_book_id { get; set; }
        public int issued_to_user_id { get; set; }
        public DateTime issued_date { get; set; }
        public DateTime return_date { get; set; }

        public string issued_book_name { get; set; }

        public string issued_user_name { get; set; }

        public int return_status { get; set; }
    }
}
