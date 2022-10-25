using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Book
    {
        public Book()
        {
            Reports = new HashSet<Report>();
        }

        public int BookId { get; set; }
        public string IsbnNo { get; set; } = null!;
        public string BookName { get; set; } = null!;
        public int? AuthorId { get; set; }
        public int? Categoryid { get; set; }
        public int? PublisherId { get; set; }

        public virtual Author? Author { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Publisher? Publisher { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
