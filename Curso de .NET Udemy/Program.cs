using System;

namespace Curso_de_.NET_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = 8;

            switch (data)
            {
                case 5:
                    Console.WriteLine("{0}", data);
                    break;
                case 6:
                    Console.WriteLine("{0}", data);
                    break;
                case 8:
                    Console.WriteLine("{0}", data);
                    break;

                default:
                    Console.WriteLine("No se encontro la variable");
                    break;
            }

            Console.ReadKey();
        }
    }
}
