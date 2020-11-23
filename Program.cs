using System;

namespace Analise_de_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            float[] valores = new float[10];
            float maior;
            float menor;
            Console.WriteLine("Digite o 1º número");
            valores[0]=float.Parse(Console.ReadLine());
            maior = valores[0];
            menor = valores[0];
            for (var i = 1; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número");
                valores[i] = float.Parse(Console.ReadLine());
                if(maior<valores[i]){
                    maior = valores[i];
                }
                else if(menor>valores[i]){
                    menor = valores[i];
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"O maior valor é {maior}");
            Console.WriteLine($"O menor valor é {menor}");
            Console.ResetColor();
        }
    }
}
