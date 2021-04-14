using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppBookOnline.Interface;
using WebAppBookOnline.Models;

namespace WebAppBookOnline.Pages
{
    public class BookModel : PageModel
    {
        public enum Action { Detail, Delete, Update, Create }
        private readonly IRepository _repository;
        public BookModel(IRepository repository) => _repository = repository;
        public Action Job { get; private set; }
        public book Book { get; private set; }

        public void OnGet(int id)
        {
            Job = Action.Detail;
            Book = _repository.Get(id);
            ViewData["Title"] = Book == null ? "Book not found!" : $"Detail - {Book.Title}";
        }
        public void OnGetDelete(int id)
        {
            Job = Action.Delete;
            Book = _repository.Get(id);
            ViewData["Title"] = Book == null ? "Book not found!" : $"Confim deleting: {Book.Title}";
        }
        public IActionResult OnGetConfirm(int id)
        {
            _repository.Delete(id);
            return new RedirectToPageResult("index");
        }
    }
}