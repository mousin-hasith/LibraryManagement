using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Response
{
    public class AddReader
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string ContactNo { get; set; } = null!;
    }
}
