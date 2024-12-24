// See https://aka.ms/new-console-template for more information
using Fundamentals;

Console.WriteLine("Hello, World!");

//Generics - avoids boxing and unboxing
var book = new Book(1111, "C# Advanced");

var numbers = new GenericList<int>();
numbers.Add(12);

var books = new GenericList<Book>();
books.Add(book);

var dictionary = new GenericDictionary<string, Book>();
dictionary.Add("1212",book);


//var number = new Fundamentals.Nullable<int>(5);
var number = new Fundamentals.Nullable<int>(); ;
Console.WriteLine("Has Value ? " + number.HasValue);
Console.WriteLine("Value: " + number.GetValueOrDefault());