using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Entities;

namespace RazorPagesBooks.Pages;

public class BooksModel : PageModel
{
    private readonly IDataService<Book> _bookService;

    public BooksModel(IDataService<Book> bookService)
    {
        this._bookService = bookService;
        Books = _bookService.GetAll();
    }

    public List<Book> Books = new List<Book>();

    public void OnGet(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            Books = _bookService.GetAll();
            RedirectToPage();
        }
        else
        {
            OnGetSearch(text);
        }
    }

    public void OnGetSearch(string text)
    {
        text = text.ToLower();

        List<Book> searchResults = new List<Book>();

        foreach (var book in Books)
        {
            string nameLower = book.Name.ToLower();
            string authorLower = book.Author.ToLower();
            string publisherLower = book.Publisher.Name.ToLower();

            if (nameLower == text || nameLower.Contains(text) ||
                authorLower == text || authorLower.Contains(text) ||
                publisherLower == text || publisherLower.Contains(text) ||
                book.Year.ToString() == text)
            {
                searchResults.Add(book);
            }

            foreach (var style in book.Styles)
            {
                string styleLower = style.Name.ToLower();

                if (styleLower == text || styleLower.Contains(text))
                {
                    searchResults.Add(book);
                    break;
                }
            }
        }

        if (searchResults.Count > 0)
        {
            Books = searchResults;
        }
        else
        {
            Books = new List<Book>();
            TempData["Message"] = "Результатів пошуку не знайдено.";
        }

        RedirectToPage();
    }
}
