using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.BLL
{
    public class BookModel
    {
        public int book_id { get; set; }

        public string book_name { get; set; }

        public string book_image { get; set; }

        public int availability { get; set; }

        public string author { get; set; }

        public string edition { get; set; }

        public float price { get; set; }

        public string rack_number { get; set; }
 
        public string category_name { get; set; }
    }
}
