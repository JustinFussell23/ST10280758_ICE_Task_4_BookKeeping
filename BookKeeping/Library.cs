/*
 *Justin Fussell ST10280758 Group 3
 */
// Library.cs
using System;
using System.Collections.Generic;
using System.Linq;
using BookKeeping;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    // Add a book to the list
    public void AddBook(Book book)
    {
        books.Add(book);
        // Subscribe to the book's return event
        book.BookReturned += BookReturnedHandler;
    }

    // Event handler method
    private void BookReturnedHandler(Book book)
    {
        Console.WriteLine($"Book has been returned: {book.Title}");
    }

    // Display all books
    public void DisplayBooks()
    {
        Console.WriteLine("\nCurrent Book List:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    // Reverse the list
    public void ReverseBooks()
    {
        books.Reverse();
        Console.WriteLine("\nReversed Book List:");
        DisplayBooks();
    }

    // Sort by publication year
    public void SortByPublicationYear()
    {
        books = books.OrderBy(b => b.PublicationYear).ToList();
        Console.WriteLine("\nSorted Book List by Publication Year:");
        DisplayBooks();
    }

    // Lambda expression to find books after a specific year
    public void FindBooksAfterYear(int year)
    {
        var recentBooks = books.FindAll(b => b.PublicationYear > year);
        Console.WriteLine($"\nBooks published after {year}:");
        foreach (var book in recentBooks)
        {
            Console.WriteLine(book);
        }
    }

    // Method to simulate returning a book
    public void SimulateBookReturn(int bookIndex)
    {
        if (bookIndex >= 0 && bookIndex < books.Count)
        {
            books[bookIndex].ReturnBook();
        }
        else
        {
            Console.WriteLine("Invalid book index!");
        }
    }
}
//*******************************************************END OF FILE*****************************************************************