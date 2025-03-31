/*
 *Justin Fussell ST10280758 Group 3
 */
// Program.cs
using System;
using BookKeeping;

class Program
{
    static void Main(string[] args)
    {
        // Create Library instance
        Library library = new Library();

        // Create and add 5 Book objects
        library.AddBook(new Book("Pride and Prejudice", "Jane Austen", 1813)); 
        library.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger", 1951));
        library.AddBook(new Book("Charlotte's Web", "E.B. White", 1952));
        library.AddBook(new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997));
        library.AddBook(new Book("The Hunger Games", "Suzanne Collins", 2008));

        // Display the initial list
        library.DisplayBooks();

        // Reverse the list
        library.ReverseBooks();

        // Sort by publication year
        library.SortByPublicationYear();

        // Find books after 2000 using lambda
        library.FindBooksAfterYear(2000);

        // Simulate returning a book (let's return the first book)
        Console.WriteLine("\nSimulating book return...");
        library.SimulateBookReturn(0);

        // Add this line to pause the program
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
//*******************************************************END OF FILE*****************************************************************