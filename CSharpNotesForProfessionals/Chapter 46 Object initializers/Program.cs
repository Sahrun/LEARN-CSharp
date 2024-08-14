
Console.WriteLine("Chapter 46: Object initializers");
Console.WriteLine("Section 46.1: Simple usage");

Book theBook = new Book { Title = "Don Quixote", Author = "Miguel de Cervantes" };

Book theBook1 = new Book();

theBook1.Title = "Don Quixote";
theBook1.Author = "Miguel de Cervantes";


Console.WriteLine("Section 46.2: Usage with non-default constructors");

var sameBook = new Book1(16) { Title = "Don Quixote", Author = "Miguel Cervantes " };

var sameBook1 = new Book1(16);
sameBook1.Title = "Do Quoxote";
sameBook1.Author = "Miugel de Cervantes";

Console.WriteLine("Section 46.3: Usage with anonymous types");
var album = new { Band = "Beatles", Title = "Abbey Road" };

//var albumTitels = from a in album
//                  select new
//                  {
//                      Title = a.ToTitle,
//                      Artist = a.Band
//                  };
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}


public class Book1
{
    public string Title { get; set; }
    public string Author { get; set; }
    public Book1(int id)
    {

    }
}