using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Response
{
    public class AddReportResponse
    {
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? Returndate { get; set; }
        public int? BookId { get; set; }
        public int? ReaderId { get; set; }
        public int? StaffId { get; set; }
        public int? StatusId { get; set; }

    }
}
