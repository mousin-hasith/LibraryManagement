using LibraryManagement.Models;
using LibraryModels.Response;
using LibraryRepository.ILibraryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.LibraryRepository
{
    public class LibraryBR : ILibraryBR
    {
        private readonly LibraryContext _libraryContext;

        public LibraryBR(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public Author AddAuthor(AddAuthorResponse author)
        {
            var _author = new Author()
            {
                AuthorName = author.AuthorName
            };
            _libraryContext.Authors.Add(_author);
            _libraryContext.SaveChanges();
            return _author;
        }

        public List<Author> GetAuthors()
        {
            return _libraryContext.Authors.ToList();
        }

        public List<GetBooksList> GetBooksList()
        {
            var list = (from b in _libraryContext.Books
                        join a in _libraryContext.Authors on b.AuthorId equals a.AuthorId
                        join c in _libraryContext.Categories on b.Categoryid equals c.CategoryId
                        join p in _libraryContext.Publishers on b.PublisherId equals p.PublisherId
                        select new GetBooksList
                        {
                            BookName = b.BookName,
                            AuthorName = a.AuthorName,
                            CategoryName = c.CategoryName,
                            PublisherName = p.PublisherName,
                            YearOfPublication = p.YearOfPublication,
                        }).ToList();
            return list;
        }

        public List<BooksReadByReader> GetBooksReadListByUserID(int Id)
        {
            var List = (from re in _libraryContext.Reports
                        join b in _libraryContext.Books on re.BookId equals b.BookId
                        join r in _libraryContext.Readers on re.ReaderId equals r.ReaderId
                        where r.ReaderId == Id && re.StatusId == 1
                        select new BooksReadByReader
                        {
                            Name = r.Name,
                            BookName = b.BookName

                        }).ToList();
            return List;
        }

        public Category AddCategories(AddCategoryResponse categoryResponse)
        {
            var _categoryResponse = new Category()
            {
                CategoryName = categoryResponse.CategoryName
            };
            _libraryContext.Categories.Add(_categoryResponse);
            _libraryContext.SaveChanges();
            return _categoryResponse;
        }
        public Publisher AddPublishers(AddPublisherResponse publisherResponse)
        {
            var _publisherResponse = new Publisher()
            {
                PublisherName = publisherResponse.PublisherName,
                YearOfPublication = publisherResponse.YearOfPublication
            };
            _libraryContext.Publishers.Add(_publisherResponse);
            _libraryContext.SaveChanges();
            return _publisherResponse;
        }
        public Reader AddReaders(AddReader addReader)
        {
            var _addReader = new Reader()
            {
                Name = addReader.Name,
                Age = addReader.Age,
                ContactNo = addReader.ContactNo
            };
            _libraryContext.Readers.Add(_addReader);
            _libraryContext.SaveChanges();
            return _addReader;
        }
        public Book AddBooks(AddBookResponse bookResponse)
        {
            var _bookResponse = new Book()
            {
                IsbnNo = bookResponse.IsbnNo,
                BookName = bookResponse.BookName,
                AuthorId = bookResponse.AuthorId,
                Categoryid = bookResponse.Categoryid,
                PublisherId = bookResponse.PublisherId
            };
            _libraryContext.Books.Add(_bookResponse);
            _libraryContext.SaveChanges();
            return _bookResponse;
        }
        public Report AddReport(AddReportResponse reportResponse)
        {
            var _reportResponse = new Report()
            {
                IssueDate = reportResponse.IssueDate,
                DueDate = reportResponse.DueDate,
                Returndate = reportResponse.Returndate,
                BookId = reportResponse.BookId,
                ReaderId = reportResponse.ReaderId,
                StaffId = reportResponse.StaffId,
                StatusId = reportResponse.StatusId
            };
            _libraryContext.Reports.Add(_reportResponse);
            _libraryContext.SaveChanges();
            return _reportResponse;
        }
        public List<GetReportsResponse> GetReports(int Id)
        {
            var list = (from re in _libraryContext.Reports
                        join b in _libraryContext.Books on re.BookId equals b.BookId
                        join r in _libraryContext.Readers on re.ReaderId equals r.ReaderId
                        join s in _libraryContext.Staff on re.StaffId equals s.StaffId
                        join st in _libraryContext.Statuses on re.StatusId equals st.StatusId
                        where re.ReportId == Id
                        select new GetReportsResponse
                        {
                            ReportId = re.ReportId,
                            IssueDate = re.IssueDate,
                            DueDate = re.DueDate,
                            Returndate = re.Returndate,
                            BookName = b.BookName,
                            Name = r.Name,
                            StaffName = s.StaffName,
                            Status1 = st.Status1
                        }).ToList();

            return list;
        }
        public Report UpdateReports(int Id, UpdateReports updateReports)
        {
            var _report = _libraryContext.Reports.FirstOrDefault(n => n.ReportId == Id);
            if (_report != null)
            {
                _report.Returndate = updateReports.Returndate;
                _report.StatusId = updateReports.StatusId;
                _libraryContext.SaveChanges();
            }
            return _report;
        }



    }
}