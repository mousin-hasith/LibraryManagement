using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class staff
    {
        public staff()
        {
            Reports = new HashSet<Report>();
        }

        public int StaffId { get; set; }
        public string StaffName { get; set; } = null!;

        public virtual ICollection<Report> Reports { get; set; }
    }
}
