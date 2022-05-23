using System;
using System.Collections.Generic;
using System.Linq;

namespace meusExemplosBootcamp
{
  class Program
  {
    static void Main(string[] args)
    {
      String texto = Console.ReadLine();

      int[] novo = texto.Split(" ").Select(x => int.Parse(x)).ToArray();

      int A = novo[0];
      int B = novo[1];
      int C = novo[2];
      int D = novo[3];

      if (B > C)
      {
        if (D > A)
        {
          if ((C + D) > (A + B))
          {
            if (C > 0 && D > 0)
            {
              if (A % 2 == 0)
              {
                Console.WriteLine("Valores aceitos");
              }
            }
          }
        }
      }
      else
      {
        Console.WriteLine("Valores nao aceitos");
      }



    }

    // void copiaListas()
    // {
    //   String[] compras = { "maçã", "uva", "pera", "salada mista", "Uma arma" };
    //   List<String> minhaLista = new List<String>();

    //   for (int i = 0; i < compras.Length; i++)
    //   {
    //     minhaLista.Add(compras[i]);
    //   }

    //   foreach (String item in minhaLista)
    //   {
    //     Console.WriteLine(item);

    //   }
    // }
  }
}
