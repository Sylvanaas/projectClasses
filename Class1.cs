using System;
using System.Collections.Generic;
using System.Text;


class Bycycle
{
    public string brandname;
    public string countryProd;
    public int NumOfWheel;
    public string color;
    public int size;
    public int price;
    public double getSellPrice()
    {
        return price * 0.5;
    }
}
    static void Main(string[] args)
    {
        Console.WriteLine("введіть назву бренду ");

        string sbrandname = Console.ReadLine();

        Console.WriteLine("введіть країну походженя ");

        string scountryProd = Console.ReadLine();

        Console.Write("введіть кількість коліс ");

        int sNumOfWheel = Console.ReadLine();

        Console.Write("введіть колір");

        string scolor = Console.ReadLine();

        Console.Write("введіть розмір ");

        int ssize = Console.ReadLine();

        Console.Write("введіть ціну ");

        int sprize = Console.ReadLine();

    Bycycle ABycecle = new Bycycle();

    ABycecle.brandname = sbrandname;
    ABycecle.countryProd = scountryProd;
    ABycecle.NumOfWheel = sNumOfWheel;
    ABycecle.color = scolor;
    ABycecle.size = ssize;
    ABycecle.price = sprize;
    double AgetSellPrice = ABycecle.getSellPrice();


        int sprice = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("Дані про обьект:");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("назва бренду: " + ABycecle.brandname);
        Console.WriteLine("країна походження:" + ABycecle.countryProd);
        Console.WriteLine("кількість коліс: " + ABycecle.NumOfWheel);
        Console.WriteLine("колір: "  + ABycecle.color);
        Console.WriteLine("розмір:" + ABycecle.size = ssize);
        Console.WriteLine("ціна:" + ABycecle.price);
        Console.WriteLine("ціна зі знижкою:" + AgetSellPrice);
    Console.ReadKey();
}




