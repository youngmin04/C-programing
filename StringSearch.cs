using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class StringSearch
    {
        static void Main()
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            //IndexOf()
            Console.WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            Console.WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            //LastIndexOf()
            Console.WriteLine("LastIndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            Console.WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

            //StartsWith()
            Console.WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            Console.WriteLine("StartsWith  'Morning': {0}", greeting.StartsWith("Morning"));

            //EndsWith()
            Console.WriteLine("EndWith 'Good' : {0}", greeting.EndsWith("Good"));
            Console.WriteLine("EndWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            //Contains()
            Console.WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            Console.WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            //Replace
            Console.WriteLine("Replace 'Morning' with 'Evening':{0}",
                greeting.Replace("Morning","Evening"));




            
        }
    }
}
