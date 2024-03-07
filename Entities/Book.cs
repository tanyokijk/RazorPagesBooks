using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Book
{
    public int Id { get; set; } 

    public string Name { get; set; }

    public string Author { get; set; }

    public Publisher Publisher { get; set; }

    public int Year { get; set; }

    public List<Style> Styles { get; set; }

    public string? Photo { get; set; }
}
