using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Report
    {
        public int ReportId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? Returndate { get; set; }
        public int? BookId { get; set; }
        public int? ReaderId { get; set; }
        public int? StaffId { get; set; }
        public int? StatusId { get; set; }

        public virtual Book? Book { get; set; }
        public virtual Reader? Reader { get; set; }
        public virtual staff? Staff { get; set; }
        public virtual Status? Status { get; set; }
    }
}
