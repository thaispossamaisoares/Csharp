using System;

namespace projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe a largura!");
                double largura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a altura!");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = CalculaArea(largura,altura);
                Console.WriteLine("A area equivale a:");
                Console.WriteLine(area);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                throw;
            }

        }

        static double CalculaArea(double largura, double altura)
        {
            return largura * altura;
        }

    }
}

