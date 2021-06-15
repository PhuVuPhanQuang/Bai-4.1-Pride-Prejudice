using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai_4._1_Pride_Prejudice.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicYear { get; set; }
        public double Price { get; set; }
        public string Cover { get; set; }

    }
}