using System;
using static System.Console;

namespace RefDemos
{
  class Program
  {
    static void Main(string[] args)
    {
      String[] nomes = new String[]{
          "Antonio",
          "José",
          "Antônio",
          "Pedro",
          "Alice",
          };
      Write("Digite o nome que deseja buscar: ");
      String nome = ReadLine();
      Write("Digite o novo nome: ");
      String novoNome = ReadLine();

      // indica que a variável recebe uma referência
      ref String nomeAchado = ref localizaNomePorReferencia(nomes, nome);



      if (!string.IsNullOrWhiteSpace(nomeAchado))
      {
        nomeAchado = novoNome;
        WriteLine($@"Nome alterado com sucesso :)
        {String.Join(", \n", nomes)}");
      }
      else
      {
        WriteLine($@"Não foi possível alterar o nome :/ :)
            {String.Join(", \n", nomes)}
        ");
      }
    }

    static ref String localizaNomePorReferencia(String[] lista, String nome)
    {
      //Nesse caso não posso retornar a String diretamente 
      for (int i = 0; i < lista.Length; i++)
      {
        if (lista[i].Equals(nome))
        {
          return ref lista[i];
        }
      }
      throw new Exception("Nome não encotrado");
    }
    static int localizaNomePorValor(String[] lista, String nome)
    {
      //Nesse caso não posso retornar a String diretamente 
      for (int i = 0; i < lista.Length; i++)
      {
        if (lista[i].Equals(nome))
        {
          return i;
        }
      }
      return -1;
    }

    static bool alteraNome(String[] lista, int posi, String novoNome)
    {
      // Lembre-se que String são feitas por referência
      if (lista != null)
      {
        lista[posi] = novoNome;
        return true;
      }
      return false;

    }



    static void adiciona20(ref int a)
    {
      a = a + 20;
    }

    void demonstracao2()
    {
      // Demonstração Referência por valor
      String[] nomes = new String[]{
          "Antonio",
          "José",
          "Antônio",
          "Pedro",
          "Alice",
          };
      Write("Digite o nome que deseja buscar: ");
      String nome = ReadLine();
      Write("Digite o novo nome: ");
      String novoNome = ReadLine();

      int posi = localizaNomePorValor(nomes, nome);

      bool result = alteraNome(nomes, posi, novoNome);


      if (result)
      {
        WriteLine($@"Nome alterado com sucesso :)
        {String.Join(", \n", nomes)}");
      }
      else
      {
        WriteLine($@"Não foi possível alterar o nome :/ :)
            {String.Join(", \n", nomes)}
        ");
      }
    }

    void demonstracao1()
    {
      // Usando a keyword red na chamada do método para passar como referência
      int a = 5;
      adiciona20(ref a);
      WriteLine($"O número é: {a}");
    }
  }
}
