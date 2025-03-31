# Book Management System

## Overview
This is a simple C# console application that simulates a basic library system. It allows users to manage a list of books, perform operations like sorting and filtering, and handle book return events.

## Features
- Create and store books with title, author, and publication year.
- Display, reverse, and sort the list of books by publication year.
- Filter books published after a specific year (e.g., 2000) using a lambda expression.
- Simulate a book return with event handling.

## Requirements
- .NET Framework or .NET Core (depending on your setup).
- A C# development environment (e.g., Visual Studio).

## How to Run
1. Clone or download the project files.
2. Open the solution in Visual Studio (or your preferred IDE).
3. Build and run the project (press `F5` in Visual Studio).
4. The program will display the book list, perform operations, and wait for user input to exit.

## Sample Books
The program includes the following books:
- *Pride and Prejudice* by Jane Austen (1813)
- *The Catcher in the Rye* by J.D. Salinger (1951)
- *Charlotte's Web* by E.B. White (1952)
- *Harry Potter and the Sorcerer's Stone* by J.K. Rowling (1997)
- *The Hunger Games* by Suzanne Collins (2008)

## Project Structure
- `Book.cs`: Defines the `Book` class with properties and event handling.
- `Library.cs`: Manages the list of books and operations.
- `Program.cs`: Contains the `Main` method to run the application.
