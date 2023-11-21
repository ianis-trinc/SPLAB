using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SPLAB
{
    internal class Book : Section
    {
        private readonly List<Author> _authors = new List<Author>();
        private TableOfContent _tableOfContent;
        
        public Book(string title) { this.Title = title; }
        public Book(string title, Author author)
        {
            this.Title = title;
            AddAuthor(author);
        }

        public Book(string title, Author author, TableOfContent tableOfContent)
        {
            this.Title = title;
            AddAuthor(author);
            this._tableOfContent = tableOfContent;
        }

        //public string GetTitle() { return this.Title; }

        public override void Print()
        {
            Console.WriteLine("Book Title: " + Title);
            Console.WriteLine("Authors:");

            foreach (var author in _authors)
            {
                Console.WriteLine("Author: " + author.Name);
            }

            if (_tableOfContent != null)
            {
                Console.WriteLine("Table of Contents:");
                _tableOfContent.Print();
            }

            foreach (var element in Elements)
            {
                element.Print();
            }
        }

        public void AddAuthor(Author author)
        {
            this._authors.Add(author);
        }

        public void AddContent(Element element)
        {
            Elements.Add(element);
        }
        
    }
}
