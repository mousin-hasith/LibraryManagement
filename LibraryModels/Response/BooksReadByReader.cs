using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Response
{
    public class BooksReadByReader
    {
        public string BookName { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
