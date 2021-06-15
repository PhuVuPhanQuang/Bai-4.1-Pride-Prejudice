using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai_4._1_Pride_Prejudice.Models;

namespace Bai_4._1_Pride_Prejudice.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }
        private List<Book> listBooks;
        public BooksController()
        {
            listBooks = new List<Book>();
            listBooks.Add(new Book()
            {
                Id = 1,
                Title = "Sach 1",
                Author = " Tac gia sach 1 ",
                PublicYear = 2017,
                Price = 40000,
                Cover = "Content/images/Book1.jpg"
            });
            listBooks.Add(new Book()
            {
                Id = 2,
                Title = "Sach 2",
                Author = " Tac gia sach 2 ",
                PublicYear = 2018,
                Price = 50000,
                Cover = "Content/images/Book2.jpg"
            });
            listBooks.Add(new Book()
            {
                Id = 3,
                Title = "Sach 2",
                Author = " Tac gia sach 3 ",
                PublicYear = 2019,
                Price = 100000,
                Cover = "Content/images/Book3.jpg"
            });
        }

        public ActionResult ListBooks()
        {
            ViewBag.TitlePageName = "Book view page";
            return View(listBooks);
        }

    }
}