using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace RazorPagesBooks.Pages;

public class UpdateBookModel : PageModel
{
    public List<Style> AllStyles;
    public List<Publisher> AllPublishers;
    public List<Book> AllBooks;
    private readonly IDataService<Book> _bookService;

    public UpdateBookModel(IDataService<Book> bookService)
    {
        _bookService = bookService;
        AllStyles = SeedData.GetInitialStyles();
        AllPublishers = SeedData.GetInitialPublishers();
        AllBooks = _bookService.GetAll();
    }

    public void OnGet(int id, string? name, string? author, int year, string? photo, string publisher)
    {
        string[] selectedStylesString = Request.Query["styles"].ToArray();
        if (id == 0)
        {
            TempData["MessageUpdate"] = "Заповніть всі поля.";
        }
        else
        {
            List<Style> selectedStyles = AllStyles.Where(style => selectedStylesString.Contains(style.Name)).ToList();
            Publisher selectedpublisher = AllPublishers.Where(p => p.Name == publisher).FirstOrDefault();
            OnGetUpdateBook(id, name, author, year, photo, selectedpublisher, selectedStyles);
        }
    }

    public void OnGetUpdateBook(int id, string? name, string? author, int year, string? photo, Publisher publisher, List<Style> selectedStyles)
    {
        var book = _bookService.GetById(id);
        if (!string.IsNullOrEmpty(name))
            book.Name = name;
        if (!string.IsNullOrEmpty(author))
            book.Author = author;
        if (year != 0)
            book.Year = year;
        if (!string.IsNullOrEmpty(photo))
            book.Photo = photo;
        if (selectedStyles.Count != 0)
            book.Styles = selectedStyles;
        book.Publisher = publisher;

        _bookService.Update(book);
        TempData["MessageUpdate"] = "Книжку оновлено";
    }
}
