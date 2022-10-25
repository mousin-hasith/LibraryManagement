using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Response
{
    public class AddPublisherResponse
    {
        public string PublisherName { get; set; } = null!;
        public int YearOfPublication { get; set; }
    }
}
