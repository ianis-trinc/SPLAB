﻿namespace SPLAB
{
    public class Program
    {
        private static void Main()
        {
            var noapteBuna = new Book("Noapte buna, copii!");
            var rpGheo = new Author("Radu Pavel Gheo");
            noapteBuna.AddAuthor(rpGheo);

            var cap1 = new Section("Capitolul 1");
            var cap11 = new Section("Capitolul 1.1");
            var cap111 = new Section("Capitolul 1.1.1");
            var cap1111 = new Section("Capitolul 1.1.1.1");
            noapteBuna.AddContent(new Paragraph("Multumesc celor care ..."));
            noapteBuna.AddContent(cap1);
            cap1.Add(new Paragraph("Moto capitol"));
            cap1.Add(cap11);
            cap11.Add(new Paragraph("Text from subchapter 1.1"));
            cap11.Add(cap111);
            cap111.Add(new Paragraph("Text from subchapter 1.1.1"));
            cap111.Add(cap1111);
            cap1111.Add(new Image("Image subchapter 1.1.1.1"));

            noapteBuna.Print();
        }
    }
}
