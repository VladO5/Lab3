/*
class DRomb
{
    protected int d1 = 3;
    protected int d2 = 5;
    protected string color = "Red";

    public void Printd1()
    {
        Console.WriteLine($"d1 = {d1}");
    }

    public void Printd2()
    {
        Console.WriteLine($"d2 = {d2}");
    }
    public DRomb()
    {
        Console.WriteLine("Ромб = " + d1 + "," + d2 + "," + color);
    }

    public void Perimeter()
    {
        double p = 2 * Math.Sqrt(d1 ^ 2 + d2 ^ 2);
        Console.WriteLine($"Perimeter ={p}");
    }
    public void Area()
    {
        double scube = (d1 ^ 2)/2;
        double s = (d1 * d2) / 2;
        if(s == scube)
        {
            Console.WriteLine("Квадрат");
        }
        else
        {
            Console.WriteLine("Ромб");
        }
        Console.WriteLine(s);
    }
    public int diag1
    {
        get
        {
            return d1;
        }
        set
        {
            d1 = value;
        }
    }
    public int diag2
    {
        get
        {
            return d2;
        }
        set
        {
            d2 = value;
        }
    }
    public string colors
    {
        get
        {
            return color;
        }
    }

}


class Program
{
    static void Main(string[] args)
    {
        DRomb romb = new DRomb();
        romb.Printd1();
        romb.Printd2();
        romb.Perimeter();
        romb.Area();
        romb.diag1 = 4;
        int d1 = romb.diag1;
        Console.WriteLine("Нова діагональ 1 =" + d1);
        romb.diag2 = 4;
        int d2 = romb.diag2;
        Console.WriteLine("Нова діагональ 2 =" + d2);
        string color = romb.colors;
        Console.WriteLine("Колір ромба=" + color);
    }
}
*/

class bookshop
{

    public virtual bool availability { get; set; }
    public virtual int price { get; set; }
    public virtual string name { get; set; }
    public virtual string author { get; set; }



    public void show()
    {
        Console.WriteLine(name + " " + author + " " + price + " " + availability);
    }


    public bookshop(string name, string author)
    {
        this.name = name;
        this.author = author;
    }


}

class Journal : bookshop
{
    public Journal(string name, string author, int price, bool availability) : base(name, author)
    {
        this.name = name;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

}

class Book : Journal
{
    public Book(string name, string author, int price, bool availability) : base(name, author, price, availability)
    {
        this.name = name;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

}

class Textbook : Book
{
    public Textbook(string name, string author, int price, bool availability) : base(name, author, price, availability)
    {
        this.name = name;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

}
class Program
{
    static void Main(string[] args)
    {
        bookshop bookshop = new bookshop("Tom", "Johnson");
        Journal journal = new Journal("Klaus", "Huten", 80, true);
        Book book = new Book("Valentine", "Smith", 110, true);
        Textbook textbook = new Textbook("Jack", "Cooper", 140, false);
        Console.WriteLine();
        bookshop.show();
        Console.WriteLine();
        journal.show();
        Console.WriteLine();
        book.show();
        Console.WriteLine();
        textbook.show();
    }
}