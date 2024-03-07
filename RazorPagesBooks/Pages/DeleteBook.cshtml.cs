using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Entities;

namespace RazorPagesBooks.Pages;

public class DeleteBookModel : PageModel
{
    private readonly IDataService<Book> _bookService;
    public readonly List<Book> AllBooks;

    public DeleteBookModel(IDataService<Book> bookService)
    {
        _bookService = bookService;
        AllBooks = _bookService.GetAll();
    }

    public void OnGet(string id)
    {
        if (System.Convert.ToInt32(id) != 0)
        {
            OnGetDeleteBook(System.Convert.ToInt32(id));
        }
    }

    public void OnGetDeleteBook(int id)
    {
        this._bookService.Delete(id);
        TempData["MessageDelete"] = "Книжку видалено";
    }
}
