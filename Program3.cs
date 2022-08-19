using System;

namespace Aula03
{
    class Program3
    {

      static double calculaMedia(double[] numeros ){
        //mediana
    
                /*forma vagabunda
                //Array.Sort(numeros);
                //int meio = numeros.Length / 2;
                //return numeros[meio];*/

            //forma correta
            Array.Sort(numeros);
            int meio = numeros.Length / 2;
            if((numeros.Length %2) == 0){
                return (numeros[meio] + numeros[meio] -1) /2;
            }
            return numeros[meio];


        }
     /*   static double calculaMedia(double[] numeros ){
        //media
            double soma = 0.0;
            for(int i = 0; i < numeros.Length; i++){
                soma += numeros[i];
            }
            double media = soma / numeros.Length;
            return media;
        }*/

        static void Main(string[] args){
            double[] numeros = {2,4,6,8};
            double media = calculaMedia(numeros);
            Console.WriteLine(media);
        }
    }
}
