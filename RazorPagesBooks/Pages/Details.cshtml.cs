using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Entities;

namespace RazorPagesBooks.Pages;

public class DetailsModel : PageModel
{
    private readonly IDataService<Book> _booksService;

    public Book Book { get; set; }

    public DetailsModel(IDataService<Book> booksService)
    {
        this._booksService = booksService;
    }

    public void OnGet(int id)
    {
        Book = _booksService.GetById(id);
    }
}
