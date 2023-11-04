using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SPLAB
{
    internal class Book : Section
    {
        private List<Author> authors = new List<Author>();
        private TableOfContent tableOfContent;
        //private List<Chapter> chapters = new List<Chapter>();
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
            this.tableOfContent = tableOfContent;
        }

        //public string GetTitle() { return this.Title; }

        public override void Print()
        {
            Console.WriteLine("Book Title: " + Title);
            Console.WriteLine("Authors:");

            foreach (Author author in authors)
            {
                Console.WriteLine("Author: " + author.Name);
            }

            if (tableOfContent != null)
            {
                Console.WriteLine("Table of Contents:");
                tableOfContent.Print();
            }

            foreach (var element in elements)
            {
                element.Print();
            }
        }

        public void AddAuthor(Author author)
        {
            this.authors.Add(author);
        }

        public void AddContent(Element element)
        {
            elements.Add(element);
        }

        /*public int CreateChapter(string chapterName)
        {
            this.chapters.Add(new Chapter(chapterName));
            return this.chapters.Count;
        }
        public Chapter GetChapter(int index) { return chapters[index - 1]; }*/
    }
}
