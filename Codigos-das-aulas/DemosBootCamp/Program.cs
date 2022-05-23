using System;
using System.Collections.Generic;
using static System.Console;
namespace DemosBootCamp
{
  class Program
  {
    static void Main(string[] args)
    {
      List<StructPessoa> pessoas = new List<StructPessoa>(){
        new StructPessoa(){ Nome = "Cebolinha"},
        new StructPessoa(){ Nome = "Cascão"},
        new StructPessoa(){ Nome = "Mônica"},
        new StructPessoa(){ Nome = "Magali"},
      };

      WriteLine("Digite o nome da pessoa que deseja buscar: ");
      string nomeBusca = ReadLine();
      StructPessoa p = new StructPessoa() { Nome = nomeBusca };
      bool resultadoBusca = buscaNome(pessoas, p);

      if (resultadoBusca)
      {
        WriteLine("Pessoa econtrada :)");
      }
      else
      {
        WriteLine("Pessoa não encontrada :/");
      }


    }

    static bool buscaNome(List<Pessoa> pessoas, Pessoa pessoa)
    // Busca por um objeto de Pessoa em uma lista de pessoas 
    {
      foreach (var item in pessoas)
      {
        if (item == pessoa)
        {
          return true;
        }
      }
      return false;
    }
    static bool buscaNome(List<StructPessoa> pessoas, StructPessoa pessoa)
    // Busca por uma Struct de Pessoa em uma lista de Struct de pessoas 

    {
      foreach (var item in pessoas)
      {
        if (item.Nome == pessoa.Nome)
        {
          return true;
        }
      }
      return false;
    }

    void demonstracao7()
    {
      // Lembre-se: A comparação entre objetos é feito por referência 
      List<Pessoa> pessoas = new List<Pessoa>(){
        new Pessoa(){ Nome = "Cebolinha"},
        new Pessoa(){ Nome = "Cascão"},
        new Pessoa(){ Nome = "Mônica"},
        new Pessoa(){ Nome = "Magali"},
      };

      WriteLine("Digite o nome da pessoa que deseja buscar: ");
      string nomeBusca = ReadLine();
      Pessoa p = new Pessoa() { Nome = nomeBusca };
      bool resultadoBusca = buscaNome(pessoas, p);

      if (resultadoBusca)
      {
        WriteLine("Pessoa econtrada :)");
      }
      else
      {
        WriteLine("Pessoa não encontrada :/");
      }
    }
    void demonstracao6()
    {
      int[] numeros = new int[] { 0, 2, 4, 6, 8 };
      WriteLine("Digite o número que gostaria de buscar: ");

      int num = int.Parse(ReadLine());
      int numEcontrado = buscaNumero(num, numeros);

      if (numEcontrado == -1)
      {
        WriteLine("Número não encontrado :/");
      }
      else
      {
        WriteLine($"Número buscado foi: {numEcontrado}");
      }

    }
    static int buscaNumero(int num, int[] lista)
    {
      foreach (var item in lista)
      {
        if (item == num)
        {
          return item;
        }
      }
      return -1;
    }

    static void transformaImpar(int[] pares)
    {
      for (var i = 0; i < pares.Length; i++)
      {
        pares[i] = pares[i] + 1;
      }
    }

    void demonstracao5()
    {
      int[] pares = new int[] { 0, 2, 4, 6, 8 };

      //preenche par
      transformaImpar(pares);

      WriteLine($"Os ímpares são: {string.Join(" | ", pares)}");
    }

    void demonstracao4()
    {
      String nome = "Armandinho";

      nome = mudaNome(nome);

      WriteLine(nome);
    }

    static string mudaNome(string nome)
    {
      return nome = "Novo nome";
    }

    void demonstracao3()
    {

      StructPessoa p1 = new StructPessoa();

      p1.Documento = "123";
      p1.Nome = "Clodovaldo";
      p1.Idade = 30;

      p1 = trocaNome(p1, "Balbiano");

      WriteLine(p1.Nome);
    }

    void demonstracao2()
    {
      Pessoa p1 = new Pessoa();

      p1.Nome = "Zeca Pagodinho";
      p1.Idade = 20;
      p1.Documento = "1234";

      Pessoa p2 = p1.Clone();

      trocaNome(p1, "Afonso");

      WriteLine($@"
      O nome de p1: {p1.Nome}
      O nome de p2: {p2.Nome}");

    }

    void demonstracao1()
    {
      int a = 3;
      adiciona20(a);

      WriteLine($"O valor de a é: {a}");
    }

    static StructPessoa trocaNome(StructPessoa pessoa, string novoNome)
    {
      pessoa.Nome = novoNome;
      return pessoa;
    }

    static void trocaNome(Pessoa p, string novoNome)
    {
      p.Nome = novoNome;
    }
    static void adiciona20(int x)
    {
      x = x + 20;
    }
  }
}


