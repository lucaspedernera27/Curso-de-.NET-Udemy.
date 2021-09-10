using System;

namespace Curso_de_.NET_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = 3;

            var result = data switch {

                1 => "Alex",
                2 => "Jhon",
                3 => "Arthur"

            };
            Console.WriteLine("{0}", result);

            Console.ReadKey();
        }
    }
}
