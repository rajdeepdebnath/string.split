using System;

namespace stringsplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            var result = str.Split("");

            foreach(var s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
