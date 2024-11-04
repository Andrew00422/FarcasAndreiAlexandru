using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Library

{
 class Program
 {
    static void Main(string[]args)
    {

        Book book1 = new Book ("White Nights","Fyodor Dostoviesky");
        book1.CheckOut();
        Book book2 = new Book ("Luceafarul","Mihai Eminescu",720);
        book2.ReturnBook();

        Console.WriteLine(book1.ToString());
        Console.WriteLine(book2.ToString());
    }

}
}