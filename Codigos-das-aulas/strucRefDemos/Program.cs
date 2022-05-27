using System;

namespace strucRefDemos
{
  class Program
  {
    static void Main(string[] args)
    {
      Pessoa p1 = new Pessoa();

      p1.Nome = "Clodovaldo";
      p1.Idade = 20;
      p1.EnderecoPessoa = new Endereco()
      {
        Numero = 123,
        CEP = "999-99999",
        Logradouro = "Rua dos bobos",
      };

    }
  }
}
