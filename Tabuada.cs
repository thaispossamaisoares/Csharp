using System;
namespace Aula
{
	class Tabuada
	{
		public static void Main(string[] args)
		{

		   Console.WriteLine(" Digite um número ");
            int tabuad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(tabuad + " * " + x + " = " + tabuad * x);

                //Console.ReadLine();
            }
        }
	}
}
