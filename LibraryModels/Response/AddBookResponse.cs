using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Response
{
    public class AddBookResponse
    {
        public string IsbnNo { get; set; } = null!;
        public string BookName { get; set; } = null!;
        public int? AuthorId { get; set; }
        public int? Categoryid { get; set; }
        public int? PublisherId { get; set; }
    }
}
