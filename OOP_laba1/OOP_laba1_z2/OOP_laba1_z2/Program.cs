using System;
using System.Globalization;
using System.Text;

using System;
using OOP_laba1_z2;

class Program
{
    static void Main(string[] args)
    {
        IDateTimePrinter europeanPrinter = new EuropeanDateTimePrinter();
        IDateTimePrinter americanPrinter = new AmericanDateTimePrinter();

        IDateTimePrinter decoratedEuropeanPrinter = new SymbolDecorator(europeanPrinter, " (Europa) ");
        IDateTimePrinter decoratedAmericanPrinter = new SymbolDecorator(americanPrinter, " (US) ");

        Console.WriteLine("Eu: " + decoratedEuropeanPrinter.GetFormattedDateTime());
        Console.WriteLine("US: " + decoratedAmericanPrinter.GetFormattedDateTime());

        Console.WriteLine("Eu: " + europeanPrinter.GetFormattedDateTime());
        Console.WriteLine("Us: " + americanPrinter.GetFormattedDateTime());
    }
}