namespace Loger
{
    using System;
    using System.Collections.Generic;

    public class ConsoleLoger : ILoger
    {
        public void Log(IDictionary<string, int> albums)
        {
            foreach (var album in albums)
            {
                Console.WriteLine("Author: {0}\nAlbums:{1}", album.Key, album.Value);
            }
        }
    }
}