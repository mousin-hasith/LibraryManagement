using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Response
{
    public class GetReportsResponse
    {
        public int ReportId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? Returndate { get; set; }
        public string BookName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string StaffName { get; set; } = null!;
        public string Status1 { get; set; } = null!;
    }
}
