using LibraryLogics.ILibraryLogics;
using LibraryManagement.Models;
using LibraryModels.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryBL _ilibraryBL;

        public LibraryController(ILibraryBL ilibraryBL)
        {
            _ilibraryBL = ilibraryBL;
        }

        [HttpPost("AddAuthor")]
        public IActionResult AddAuthor([FromBody] AddAuthorResponse author)
        {
            _ilibraryBL.AddAuthor(author);
            return Ok();
        }

        [HttpGet("GetAuthorsList")]
        public IEnumerable GetAuthors()
        {
            return _ilibraryBL.GetAuthors();
        }

        [HttpGet("GetBooksList")]
        public IEnumerable GetBooksList()
        {
            return _ilibraryBL.GetBooksList();
        }

        [HttpGet("GetBooksListByUserID")]
        public IEnumerable GetBooksReadListByUserID(int Id)
        {
            return _ilibraryBL.GetBooksReadListByUserID(Id);
        }

        [HttpPost("addcategories")]
        public IActionResult AddCategories([FromBody] AddCategoryResponse categoryResponse)
        {
            _ilibraryBL.AddCategories(categoryResponse);
            return Ok();
        }

        [HttpPost("addpublishers")]
        public IActionResult AddPublishers([FromBody] AddPublisherResponse publisherResponse)
        {
            _ilibraryBL.AddPublishers(publisherResponse);
            return Ok();
        }

        [HttpPost("addReaders")]
        public IActionResult AddReaders([FromBody] AddReader addReader)
        {
            _ilibraryBL.AddReaders(addReader);
            return Ok();
        }

        [HttpPost("addbooks")]
        public IActionResult AddBooks([FromBody] AddBookResponse bookResponse)
        {
            _ilibraryBL.AddBooks(bookResponse);
            return Ok();
        }

        [HttpPost("addreports")]
        public IActionResult AddReports([FromBody] AddReportResponse reportResponse)
        {
            _ilibraryBL.AddReport(reportResponse);
            return Ok();
        }

        [HttpGet("GetReports")]
        public IActionResult GetReports(int Id)
        {
            try
            {
                var Result = _ilibraryBL.GetReports(Id);
                if (Result.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("updateReports")]
        public IActionResult UpdateReports(int Id, UpdateReports updateReports)
        {
            try
            {
                var Results = _ilibraryBL.UpdateReports(Id, updateReports);
                if (Results == null)
                {
                    return NotFound();
                }
                return this.Ok(Results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    



    }
}
