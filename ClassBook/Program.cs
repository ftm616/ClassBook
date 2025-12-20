using System;
class Book
{
    // فیلدها
    string Title;
    string Author;
    decimal Price;

    // سازنده پیش‌فرض
    public Book()
    {
        Title = "Untitled";
        Author = "unknown";
        Price = 0.0m;
    }

    // سازنده پارامتردار
    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // متد نمایش اطلاعات
    public void DisplayInfo()
    {
        Console.WriteLine("title: " + Title);
        Console.WriteLine("the author: " + Author);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("----------------");
    }
}

namespace ClassBook
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book book1 = new Book();
            Book book2 = new Book("C# programming", "Deitel", 320000);
            book1.DisplayInfo();
            book2.DisplayInfo();
            Console.ReadKey();
        }
    }
}
