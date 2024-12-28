

//args=>expression
using LambaExpressions;

Func<int, int> square = (number) => number * number;
Console.WriteLine(square(5));

const int factor = 3;
Func<int, int> multiplier = (number) => number * factor;
Console.WriteLine(multiplier(10));

//get list of books
var books = new BookRepository().GetBooks();
var cheapbooks = books.FindAll(IsBookLessThan50Dollars);

    foreach(var book in cheapbooks)
    Console.WriteLine(book.Title);

    static bool IsBookLessThan50Dollars(Book book)
{
    return book.Price < 50;
}

//use lamba expressions
Console.WriteLine("---use lamba expressions---");
var result = books.FindAll((b)=>b.Price < 50);
foreach(var book in result)
    Console.WriteLine(book.Title);