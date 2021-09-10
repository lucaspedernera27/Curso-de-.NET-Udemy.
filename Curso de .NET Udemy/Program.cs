using System;

namespace Curso_de_.NET_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;

            int[] arreglo = new int[1];

            //Mostramos un mje y capturamos el dato ingresado desde la consola.

            Console.WriteLine("Escriba el numero de pisos deseado: ");

            pisos = Convert.ToInt32(Console.ReadLine());

            //Declaramos el ciclo for que va a recorrer dependiendo del dato que ingresemos

            for (int i = 1; i <= pisos; i++)
            {
                //Colocamos un arreglo y colocamos la variable i del ciclo  for que sera el tamaño que tendra el arreglo cada vez que el ciclo for se ejecute
                int[] pascal = new int[i];

                //Ciclo for que se decrementa para formar el triangulo
                for (int j = pisos; j < i; j--)
                {
                    Console.WriteLine(" ");
                }

                //Ciclo for que genera la suma de las cifras
                for (int k = 0; k < i; k++)
                {
                    //Condicion que evalua la variable del ciclo for
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        //Sumamos los numeros que estan en cada posicion del arreglo para formar el triangulo
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    //Para no generar saltos de linea
                    Console.Write("[" + pascal[k] + "]");
                }
                arreglo = pascal;
                Console.WriteLine(" ");

            }









            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Resultado: {0}", i+1);
            //}

            //string[] hermanos = { "Arthur", "Thomas", "Jhon", "Finn" };

            //int[] edad = { 18, 20, 24,34 };

            //foreach (var item in hermanos)
            //{
            //    Console.WriteLine("Resultado {0}",hermanos);
            //}

            ////////////////////
            //string[] nombre = { "Lucas", "Lucas2", "Lucas3", "Lucas4", "Lucas5" };

            //int[] age = { 24, 23, 25, 26, 27 };

            //Console.WriteLine("Resultado: {0} {1} {2}", nombre.Length, nombre[1], age[0]);

            //double[,] doble = new double[2, 2] { { 7, 4.5 }, { 5.5, 7.6 } };

            //Console.WriteLine("Array multidimensional: {0}",doble[1,0]); 


            /////////////////
            //int year = Convert.ToInt16("16");
            //double decimales = 11.11;
            //bool valor = true;
            //string mensaje;

            //mensaje = decimales <= 10 ? "The World is yours!" : "Hola mundo";

            //Console.WriteLine("{0} {1} {2}",mensaje , decimales, year);



            //Console.Write("Escriba el primer valor: ");
            //int valor1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Escriba el segundo valor: ");
            //int valor2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Escriba el operador deseado: ");
            //string operador = Console.ReadLine();

            //switch (operador)
            //{
            //    case "+":
            //        valor1 += valor2;
            //        Console.WriteLine("La suma de los dos numeros da: {0}", valor1);
            //        break;
            //    case "-":
            //        valor1 -= valor2;
            //        Console.WriteLine("La resta de los dos numeros da: {0}", valor1);
            //        break;
            //    case "*":
            //        valor1 *= valor2;
            //        Console.WriteLine("El producto de los dos numeros da: {0}", valor1);
            //        break;
            //    case "/":
            //        valor1 /= valor2;
            //        Console.WriteLine("La division entre los dos numeros da: {0}", valor1);
            //        break;

            //}


            




            //Console.Write("Escriba tu nombre: ");
            //String nombre = Console.ReadLine(); Se puede crear una clase String que es lo mismo que crear una variable de tipo string.
            //Decimal dec = 11.22M;
            //Boolean bo = false;

            //Console.WriteLine("Su nombre es {0}", nombre);


            Console.ReadKey();
        }
    }
}
