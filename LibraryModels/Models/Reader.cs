using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Reader
    {
        public Reader()
        {
            Reports = new HashSet<Report>();
        }

        public int ReaderId { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string ContactNo { get; set; } = null!;

        public virtual ICollection<Report> Reports { get; set; }
    }
}
