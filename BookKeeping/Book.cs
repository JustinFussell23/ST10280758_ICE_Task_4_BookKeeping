/*
 *Justin Fussell ST10280758 Group 3
 */
namespace BookKeeping //BookKeeping
{
    public class Book //Book
    {

        public string Title { get; set; } //Title
        public string Author { get; set; } //Author
        public int PublicationYear { get; set; } //PublicationYear

        public delegate void BookReturnedHandler(Book book); //BookReturnedHandler
        public event BookReturnedHandler BookReturned; //BookReturned

        public Book(string title, string author, int publicationYear) //Book
        {
            Title = title; //Title  
            Author = author; //Author
            PublicationYear = publicationYear; //PublicationYear
        }
        
        public void ReturnBook() //ReturnBook
        {
            BookReturned?.Invoke(this); //BookReturned
        }

        public override string ToString() //ToString
        {
            return $"Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}"; //Title, Author, Publication Year
        }
    }
}
//*******************************************************END OF FILE*****************************************************************