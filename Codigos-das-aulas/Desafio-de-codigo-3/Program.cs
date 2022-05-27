using System;
using static System.Console;

namespace Desafio_de_codigo_3
{
  class Program
  {
    static void Main(string[] args)
    {
        int suavariavel = int.Parse(Console.ReadLine());
        string[] n = Console.ReadLine().Split(' ');

        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 
//TODO: Complete os espaços em branco com uma possível solução para o desafio
        for (int iContador = 0; iContador < suavariavel; iContador++)
        {
            if ((int.Parse(n[iContador]) % 2 == 0)){
              multiplo2+=1;
            }
            if ((int.Parse(n[iContador]) % 3 == 0)){
              multiplo3+=1;
            };
            if ((int.Parse(n[iContador]) % 4 == 0)){
              multiplo4+=1;
            };
            if ((int.Parse(n[iContador]) % 5 == 0)){
              multiplo5+=1;
            };
        }

        Console.WriteLine(multiplo2 + " Multiplo(s) de 2");
        Console.WriteLine(multiplo3 + " Multiplo(s) de 3");
        Console.WriteLine(multiplo4 + " Multiplo(s) de 4");
        Console.WriteLine(multiplo5 + " Multiplo(s) de 5");
    }

    // void desafio5(){
    //    double A, B, C;
    //     A = double.Parse(Console.ReadLine() * 2);
    //         B = double.Parse(Console.ReadLine() * 3);
    //         C = double.Parse(Console.ReadLine() * 5);
    //         double media = ((A + B + C) / 10);
    //         Console.WriteLine();
    //         Console.ReadKey();
    // }

    // void desafio4(){
    //   double a, b, c, d, avg;
    //   string[] values = Console.ReadLine().Split(' ');
    //   //TODO: Complete os espaços em branco com uma possível solução para o desafio
    //   a = double.Parse(values[0]) * 2;
    //   b = double.Parse(values[1]) * 3;
    //   c = double.Parse(values[2]) * 4;
    //   d = double.Parse(values[3]) * 1;

    //   avg = ((a + b + c + d) / 10);

    //   Console.WriteLine("Media: " + avg.ToString("0.0"));
    //   if (avg >= 7.0)
    //   {
    //     Console.WriteLine("Aluno aprovado.");
    //   }
    //   if (avg < 5.0)
    //   {
    //     Console.WriteLine("Aluno reprovado.");
    //   }
    //   if (avg >= 5.0 || avg <= 6.9)
    //   {
    //     Console.WriteLine("Aluno em exame.");
    //     Console.Write("Nota do exame: ");
    //     double e = double.Parse(Console.ReadLine());
    //     avg = (e + avg) / 2;
    //     if (avg >= 5.0)
    //     {
    //       Console.WriteLine("Aluno aprovado.");
    //     }
    //     if (avg <= 4.9)
    //     {
    //       Console.WriteLine("Aluno reprovado.");
    //     }
    //     Console.WriteLine("Media final: " + avg.ToString("0.0"));
    //   }

    //   Console.ReadKey();
    // }

    // void desafio3()
    // {
    //   String[] line = Console.ReadLine().Split(" ");

    //   float A = Int32.Parse(line[0]);

    //   float B = Int32.Parse(line[1]);
    //   //TODO: Complete os espaços em branco com uma possível solução para o desafio        
    //   float total = (A / B);
    //   if (A % B != 0)
    //     Console.WriteLine(Math.Round(total, 2).ToString("0.00"));
    //   else
    //     Console.WriteLine(total.ToString("0.00"));
    // }
  }
}
