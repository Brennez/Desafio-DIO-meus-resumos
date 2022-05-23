using System;

namespace revisaoCsharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Aluno[] alunos = new Aluno[5];
      string opcaoUsuario = retornaOpcaoUsuario();
      int indiceAluno = 0;

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            Console.WriteLine("Digite o nome do aluno: ");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a nota do aluno: ");
            // tenta fazer o parse, se conseguir ele retorna o valor na variável nota. 
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
              aluno.Nota = nota;
            }
            else
            {
              throw new ArgumentException("O valor da nota deve ser um decimal :/");
            }
            alunos[indiceAluno] = aluno;
            indiceAluno++;

            break;
          case "2":
            foreach (var item in alunos)
            {
              if (!string.IsNullOrEmpty(item.Nome))
              {
                Console.WriteLine($"Nome: {item.Nome}\nNota: {item.Nota}");

              }
            }
            break;
          case "3":
            decimal notaTotal = 0;
            decimal mediaGeral = 0;
            for (int i = 0; i < alunos.Length; i++)
            {
              notaTotal = notaTotal + alunos[i].Nota;
            }
            EConceito conceitoGeral;
            mediaGeral = notaTotal / 5;

            if (mediaGeral < 2)
            {
              conceitoGeral = EConceito.E;
            }
            else if (mediaGeral < 4)
            {
              conceitoGeral = EConceito.D;
            }
            else if (mediaGeral < 6)
            {
              conceitoGeral = EConceito.C;
            }
            else if (mediaGeral < 8)
            {
              conceitoGeral = EConceito.B;
            }
            else
            {
              conceitoGeral = EConceito.A;
            }
            Console.WriteLine($"Média geral: {mediaGeral}\nConceito: {conceitoGeral}");
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }


        opcaoUsuario = retornaOpcaoUsuario();

      }

    }

    private static string retornaOpcaoUsuario()
    {
      Console.WriteLine("Informe a opção desejada: ");
      Console.WriteLine("1 - Inserir novo aluno ");
      Console.WriteLine("2 - Listar alunos ");
      Console.WriteLine("3 - Calcular média geral ");
      Console.WriteLine("X - Sair ");
      Console.WriteLine();

      String opcaoUsuario = Console.ReadLine();
      return opcaoUsuario;
    }
  }
}
