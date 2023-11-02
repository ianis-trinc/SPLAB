﻿using System;
using System.Collections.Generic;

namespace SPLAB
{
    public class Book
    {
        private string title;
        private List<Author> authors = new List<Author>();
        private TableOfContent tableOfContent;
        private List<Chapter> chapters = new List<Chapter>();

        public Book(string title) { this.title = title; }
        public Book(string title, Author author)
        {
            this.title = title;
            AddAuthor(author);
        }

        public Book(string title, Author author, TableOfContent tableOfContent)
        {
            this.title = title;
            AddAuthor(author);
            this.tableOfContent = tableOfContent;
        }

        public string GetTitle() { return this.title; }

        public void Print()
        {
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Authors:");
            foreach (Author author in authors)
            {
                Console.WriteLine("- " + author.GetName());
            }

            if (tableOfContent != null)
            {
                Console.WriteLine("Table of Contents:");
                tableOfContent.Print();
            }
        }

        public void AddAuthor(Author author)
        {
            this.authors.Add(author);
        }

        public int CreateChapter(string chapterName)
        {
            this.chapters.Add(new Chapter(chapterName));
            return this.chapters.Count;
        }
        public Chapter GetChapter(int index) { return chapters[index - 1]; }
    }
}
