namespace _04.DeleteAlbumsHavingPriceBiggerThen20
{
    using Loger;
    using System;

    internal class Program
    {
        private static string PathToXml = "../../Catalog.xml";
        private static string ItemToRemove = "price";
        private static double Price = 20d;

        private static void Main()
        {
            // 4. Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.

            ILoger consoleLoger = new ConsoleLoger();

            DOMRemover remover = new DOMRemover(PathToXml, ItemToRemove);
            Console.WriteLine("Before removing:");
            consoleLoger.Log(remover.ExtractItemsByArtist());
            Console.WriteLine("----------------------------");
            Console.WriteLine("After removing:");
            remover.RemoveAlbumByPrice(Price);
            consoleLoger.Log(remover.ExtractItemsByArtist());
        }
    }
}