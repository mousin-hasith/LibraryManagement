using LibraryLogics.ILibraryLogics;
using LibraryManagement.Models;
using LibraryModels.Response;
using LibraryRepository.ILibraryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogics.LibraryLogics
{
    public class LibraryBL:ILibraryBL
    {
        private readonly ILibraryBR _ilibraryBR;

        public LibraryBL(ILibraryBR ilibraryBR)
        {
            _ilibraryBR = ilibraryBR;
        }

        public Author AddAuthor(AddAuthorResponse author)
        {
            return _ilibraryBR.AddAuthor(author);
        }

        public List<Author> GetAuthors()
        {
            return _ilibraryBR.GetAuthors();    
        }
        public List<GetBooksList> GetBooksList()
        {
            return _ilibraryBR.GetBooksList();
        }
        public List<BooksReadByReader> GetBooksReadListByUserID(int Id)
        {
            return _ilibraryBR.GetBooksReadListByUserID(Id);
        }
        public Category AddCategories(AddCategoryResponse categoryResponse)
        {
            return _ilibraryBR.AddCategories(categoryResponse);
        }
        public Publisher AddPublishers(AddPublisherResponse publisherResponse)
        {
            return _ilibraryBR.AddPublishers(publisherResponse);
        }
        public Reader AddReaders(AddReader addReader)
        {
            return _ilibraryBR.AddReaders(addReader);
        }
        public Book AddBooks(AddBookResponse bookResponse)
        {
            return _ilibraryBR.AddBooks(bookResponse);
        }
        public Report AddReport(AddReportResponse reportResponse)
        {
            return _ilibraryBR.AddReport(reportResponse);
        }
        public List<GetReportsResponse> GetReports(int Id)
        {
            return _ilibraryBR.GetReports(Id);
        }
        public Report UpdateReports(int Id, UpdateReports updateReports)
        {
            return _ilibraryBR.UpdateReports(Id, updateReports);
        }

    }
}
