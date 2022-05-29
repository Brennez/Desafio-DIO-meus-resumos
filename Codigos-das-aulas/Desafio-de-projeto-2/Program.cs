using Desafio_de_projeto_2;
using static System.Console;
public class Program
{
  static SerieRepository repository = new SerieRepository();

  static void Main()
  {
    string userOption = GetUserOption();
    while (userOption.ToUpper() != "X")
    {
      switch (userOption)
      {
        case "1":
          ListSeries();
          break;
        case "2":
          AddSerie();
          break;
        case "3":
          UpdateSerie();
          break;
        case "4":
          deleteSerie();
          break;
        case "5":
          viewSerie();
          break;
        case "C":
          Clear();
          break;
        default:
          throw new ArgumentException("Opção não registrada");
      }
      userOption = GetUserOption();

    }
    WriteLine("Obrigado por usar :)");
  }

  public static void ListSeries()
  {
    List<Serie> SeriesList = repository.ListSerie();

    if (SeriesList.Count == 0)
    {
      WriteLine("Lista vazia :/");
      return;
    }
    else
    {
      foreach (var item in SeriesList)
      {
        var deleted = item.GetDeleted();

        Console.WriteLine("ID: {0} Nome: N{1} Excluído: {2}", item.GetId(), item.GetTitle(), (deleted ? "*Excluído*" : ""));
      }
    }

  }

  public static string GetUserOption()
  {
    WriteLine("\nSeja Bem vindo ao DIO Séries :)");
    WriteLine("1 - Listar séries");
    WriteLine("2 - Inserir nova série");
    WriteLine("3 - Atualizar série");
    WriteLine("4 - Remover série");
    WriteLine("5 - Visualizar série");
    WriteLine("C - Limpar tela");
    WriteLine("X - Sair");
    WriteLine();
    string userOption = ReadLine().ToUpper();
    WriteLine("Informe a opção desejada: ");
    return userOption;
  }

  public static void AddSerie()
  {
    WriteLine("Inserir nova série");
    foreach (int item in Enum.GetValues(typeof(Genre)))
    {
      WriteLine($"{item} . {Enum.GetName(typeof(Genre), item)}");
    }

    Write("Digite o gênero entre as opções acima: ");
    int genreType = int.Parse(ReadLine());

    Write("Digite o Título da Série: ");
    string title = ReadLine();

    Write("Digite o Ano de Início da Série: ");
    int year = int.Parse(ReadLine());

    Write("Digite a Descrição da Série: ");
    string description = ReadLine();

    Serie newSerie = new Serie(repository.NextId(), (Genre)genreType, title, description, year);


    repository.Add(newSerie);
  }

  public static void UpdateSerie()
  {
    Write("Digite o id da série: ");
    int idSerie = int.Parse(ReadLine());

    foreach (int i in Enum.GetValues(typeof(Genre)))
    {
      WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
    }
    Write("Digite o gênero entre as opções acima: ");
    int genreType = int.Parse(ReadLine());

    Write("Digite o Título da Série: ");
    string title = ReadLine();

    Write("Digite o Ano de Início da Série: ");
    int year = int.Parse(ReadLine());

    Write("Digite a Descrição da Série: ");
    string description = ReadLine();

    Serie serieUpdated = new Serie(idSerie, (Genre)genreType, title, description, year);
  }

  public static void deleteSerie()
  {
    Write("Digite o id da série: ");
    int serieIndex = int.Parse(ReadLine());

    repository.Delete(serieIndex);
  }

  public static void viewSerie()
  {
    Console.Write("Digite o id da série: ");
    int serieIndex = int.Parse(Console.ReadLine());

    var serie = repository.ReturnById(serieIndex);

    Console.WriteLine(serie);
  }
}
