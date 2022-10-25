using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Response
{
    public class GetBooksList
    {
        public string BookName { get; set; } = null!;

        public string AuthorName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public string PublisherName { get; set; } = null!;
        public int YearOfPublication { get; set; }
    }
}
