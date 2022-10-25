using LibraryManagement.Models;
using LibraryModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.ILibraryRepository
{
    public interface ILibraryBR
    {
        Author AddAuthor(AddAuthorResponse author);
        List<Author> GetAuthors();
        List<GetBooksList> GetBooksList();
        List<BooksReadByReader> GetBooksReadListByUserID(int Id);
        Category AddCategories(AddCategoryResponse categoryResponse);
        Publisher AddPublishers(AddPublisherResponse publisherResponse);
        Reader AddReaders(AddReader addReader);
        Book AddBooks(AddBookResponse bookResponse);
        Report AddReport(AddReportResponse reportResponse);
        List<GetReportsResponse> GetReports(int Id);
        Report UpdateReports(int Id, UpdateReports updateReports);
    }
}
