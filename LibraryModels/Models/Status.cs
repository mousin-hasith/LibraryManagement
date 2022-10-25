using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Status
    {
        public Status()
        {
            Reports = new HashSet<Report>();
        }

        public int StatusId { get; set; }
        public string Status1 { get; set; } = null!;

        public virtual ICollection<Report> Reports { get; set; }
    }
}
