namespace Loger
{
    using System.Collections.Generic;

    public interface ILoger
    {
        void Log(IDictionary<string, int> albums);
    }
}