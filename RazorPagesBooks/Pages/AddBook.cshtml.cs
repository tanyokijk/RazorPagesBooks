using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace RazorPagesBooks.Pages;

public class AddBookModel : PageModel
{
    public List<Style> AllStyles;
    public List<Publisher> AllPublishers;
    private readonly IDataService<Book> _bookService;

    public AddBookModel(IDataService<Book> bookService)
    {
        _bookService = bookService;
        AllStyles = SeedData.GetInitialStyles();
        AllPublishers = SeedData.GetInitialPublishers();
    }

    public void OnGet(string name, string author, int year, string? photo, string publisher)
    {
        string[] selectedStylesString = Request.Query["styles"].ToArray();
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(publisher) || selectedStylesString.Length == 0 || year == 0)
        {
            TempData["MessageAdd"] = "Заповніть всі поля.";
        }
        else
        {
            List<Style> selectedStyles = AllStyles.Where(style => selectedStylesString.Contains(style.Name)).ToList();
            Publisher selectedpublisher = AllPublishers.Where(p => p.Name == publisher).FirstOrDefault();
            OnGetAddBook(name, author, year, photo, selectedpublisher, selectedStyles);
        }
    }

    public void OnGetAddBook(string name, string author, int year, string? photo, Publisher publisher, List<Style> selectedStyles)
    {
        var book = new Book { Id = _bookService.GetAll().Last().Id + 1, Name = name, Author = author, Publisher = publisher, Year = year, Styles = selectedStyles };
        if (photo != null)
        {
            book.Photo = photo;
        }

        this._bookService.Add(book);
        TempData["MessageAdd"] = "Книжку додано";
    }
}
