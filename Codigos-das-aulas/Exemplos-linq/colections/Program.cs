using colections;
using colections.helper;

class Program
{
  public static void Main(string[] args)
  {

  }

  public void ExemploArray()
  {
    int[] array = new int[] { 20, 30, 40 };

    for (int i = 0; i < array.Length; i++)
    {
      Console.WriteLine(array[i]);
    }

    foreach (var item in array)
    {

      Console.WriteLine(item);
    }
  }

  public void ExemploMatriz()
  {
    int[,] matriz = new int[4, 2]
    {
      {2,2},
      {3,3},
      {4,4},
      {5,5},
    };

    for (int linha = 0; linha < matriz.GetLength(0); linha++)
    {
      for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
      {
        Console.WriteLine(matriz[linha, coluna]);
      }
    }
  }

  public void ExemploOrdenacao()
  {
    int[] array = new int[90];

    Random s = new Random();

    ArrayOperations ap = new ArrayOperations();
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = s.Next(90);
    }

    Console.WriteLine("ARRAY NÃO ORDENADO");

    ap.PrintArray(array);

    ap.BubbleSort(ref array);

    Console.WriteLine("\nARRAY ORDENADO");

    ap.PrintArray(array);
  }

  void ExemploOrdenaPorArray()
  {
    const int tamanho = 10;
    int[] array = new int[tamanho];

    Random s = new Random();

    ArrayOperations ap = new ArrayOperations();
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = s.Next(tamanho);
    }

    Console.WriteLine("ARRAY NÃO ORDENADO");

    ap.PrintArray(array);

    // ap.BubbleSort(ref array);
    ap.SortByArray(ref array);
    Console.WriteLine("\nARRAY ORDENADO");

    ap.PrintArray(array);

  }

  public void ExemploVerificaElemento()
  {
    int[] array = new int[5];

    int[] copia = new int[10];

    ArrayOperations ap = new ArrayOperations();

    ap.FillArray(ref array);
    Console.WriteLine("ARRAY ANTES DA CÓPIA");
    ap.PrintArray(copia);
    Console.WriteLine("\nARRAY DEPOIS DA CÓPIA");
    ap.CopyArray(ref array, ref copia);
    ap.PrintArray(copia);
  }

  public void ExemploExisteNoArray()
  {
    int[] array = new int[] { 5, 4, 3, 2, 1 };


    ArrayOperations ap = new ArrayOperations();
    int valor = 1;
    bool valorExiste = ap.VerifyElement(array, valor);

    if (valorExiste)
    {
      Console.WriteLine($"O número {valor} existe :)");
    }
    else
    {
      Console.WriteLine($"O número {valor} não existe :/");

    }

  }

  public void ExemploVerificaTodosElementos()
  {
    int[] array = new int[] { 5, 4, 3, 2, 1 };


    ArrayOperations ap = new ArrayOperations();
    int valor = 0;

    bool valorExiste = ap.VerifyAllElements(array, valor);

    if (valorExiste)
    {
      Console.WriteLine($"Todos os números são maiores do que {valor} :)");
    }
    else
    {
      Console.WriteLine($"Nem todos os números são maiores do que {valor} :/");

    }
  }

  public void ExemploRetornaValor()
  {
    int[] array = new int[] { 5, 4, 3, 2, 1 };


    ArrayOperations ap = new ArrayOperations();
    int valor = 0;

    int valorExiste = ap.GetValueIfExists(array, valor);

    if (valorExiste > 0)
    {
      Console.WriteLine($"O número {valor} existe :)");
    }
    else
    {
      Console.WriteLine($"O número {valor} não existe :/");

    }

  }

  public void ExemploRetornaPosicao()
  {
    int[] array = new int[] { 5, 4, 3, 2, 1 };


    ArrayOperations ap = new ArrayOperations();
    int valor = 1;

    int position = ap.GetPositionIfExists(array, valor);

    if (position > -1)
    {
      Console.WriteLine($"O número {valor} existe, sua posição é: {position}");
    }
    else
    {
      Console.WriteLine($"O número {valor} não existe :/");

    }

  }

  public void ExemploRedimensionaArray()
  {
    int[] array = new int[] { 5, 4, 3, 2, 1 };


    ArrayOperations ap = new ArrayOperations();

    Console.WriteLine($"Posição atual do vetor: {array.Length}");
    ap.ResizeArray(ref array, array.Length * 2);

    Console.WriteLine($"Posição após redimensionar do vetor: {array.Length}");
  }

  public void ExemploConverteArray()
  {
    int[] array = new int[] { 5, 4, 3, 2, 1 };


    ArrayOperations ap = new ArrayOperations();

    string[] Novoarray = ap.ConvertArrayToString(array);

    Console.WriteLine("Array de inteiros");
    ap.PrintArray(array);
    Console.WriteLine("\nArray de strings");
    foreach (var item in Novoarray)
    {
      Console.Write(item + " ");

    }

  }

  public void ExemploRemoveElementoLista()
  {
    List<string> notas = new List<string>();
    ListOperations lp = new ListOperations();

    notas.Add("Do");
    notas.Add("Re");
    notas.Add("Mi");
    notas.Add("Fa");
    notas.Add("So");
    notas.Add("La");
    notas.Add("Si");

    Console.WriteLine($"Quantidade de elementos na lista: {notas.Count}");
    Console.WriteLine("Lista original");
    lp.PrintList(notas);

    Console.WriteLine("Lista com elemento removido");

    lp.DeleteItemFromList(notas, "La");
    lp.PrintList(notas);
  }

  void ExemploColocandoColecoesNaLista()
  {
    ListOperations lp = new ListOperations();

    List<string> notas = new List<string> { "Fa", "So", "La", "Si" };
    string[] notasIniciais = new string[] { "Do", "Re", "Mi" };

    notas.AddRange(notasIniciais);

    lp.PrintList(notas);
  }

  void AdicionandoItemPorPosicao()
  {
    ListOperations lp = new ListOperations();

    List<string> notas = new List<string> { "Fa", "So", "La", "Si" };

    lp.InsertByIndex(notas, "Do", 3);

    lp.PrintList(notas);
  }

  public void ExemploComFila()
  {
    Queue<string> fila = new Queue<string>();

    fila.Enqueue("Pedro");
    fila.Enqueue("Paulo");
    fila.Enqueue("Amanda");

    while (fila.Count > 0)
    {
      Console.WriteLine($"Vez de {fila.Peek()}"); //retorna o primeiro item da fila
      Console.WriteLine($"{fila.Dequeue()} foi atendido"); //remove o primeiro item fila
    }

    Console.WriteLine($"\n Todos foram atendidos. Quantidade de Pessoas na fila: {fila.Count}");
  }

  public void ExemploComPilha()
  {
    Stack<string> pilhaLivros = new Stack<string>();

    pilhaLivros.Push("Clean code"); //Adiciona um elemento na pilha
    pilhaLivros.Push("Harry Potter");
    pilhaLivros.Push("Minecraft a lenda");

    Console.WriteLine($"Total de livros para a leitura: {pilhaLivros.Count}");

    while (pilhaLivros.Count > 0)
    {
      Console.WriteLine($"Livro que estou lendo {pilhaLivros.Peek()}"); //retorna o elemento do topo
      Console.WriteLine($"Terminei o livro {pilhaLivros.Pop()}");
    }

    Console.WriteLine($"Total de livros para a leitura: {pilhaLivros.Count}");
  }

  public void ExemploComDicionario()
  {
    Dictionary<string, string> estados = new Dictionary<string, string>();

    estados.Add("PI", "Piauí");
    estados.Add("BA", "Bahia");
    estados.Add("CE", "Ceará ");
    estados.Add("PE", "Pernambuco");

    foreach (KeyValuePair<string, string> item in estados)
    {
      Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
    }
  }

  public void Exemplo2ComDicionario()
  {
    Dictionary<string, List<string>> frutas = new Dictionary<string, List<string>>();

    List<string> Minhasfrutas = new List<string>() { "Pera", "Uva", "Maçã", "salada mista" };

    frutas.Add("Fruta", Minhasfrutas);

    foreach (var item in frutas)
    {
      Console.WriteLine($"Chave: {item.Key}");
      foreach (var valores in item.Value)
      {
        Console.WriteLine($"Valor: {valores}");
      }
    }
  }

  public void ExemploRetornaUmValorPorChave()
  {
    Dictionary<string, string> estados = new Dictionary<string, string>();

    estados.Add("PI", "Piauí");
    estados.Add("BA", "Bahia");
    estados.Add("CE", "Ceará ");
    estados.Add("PE", "Pernambuco");

    string chaveProcurada = "PI";

    Console.WriteLine($"Valor retornado: {estados[chaveProcurada]}");
  }

  public void ExemploRemovendoValor()
  {
    Dictionary<string, string> estados = new Dictionary<string, string>();

    estados.Add("PI", "Piauí");
    estados.Add("BA", "Bahia");
    estados.Add("CE", "Ceará ");
    estados.Add("PE", "Pernambuco");

    string chaveProcurada = "CE";

    Console.WriteLine("Antes da remoção");
    foreach (var item in estados)
    {
      Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
    }

    Console.WriteLine($"O valor deletado foi {chaveProcurada}");
    estados.Remove(chaveProcurada);

    Console.WriteLine("Depois da remoção");
    foreach (var item in estados)
    {
      Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
    }
  }

  public void ExemploBuscaSegura()
  {
    Dictionary<string, string> estados = new Dictionary<string, string>();

    estados.Add("PI", "Piauí");
    estados.Add("BA", "Bahia");
    estados.Add("CE", "Ceará ");
    estados.Add("PE", "Pernambuco");

    string chaveProcurada = "PI";

    if (estados.TryGetValue(chaveProcurada, out var estadoEcontrado))
    {
      Console.WriteLine($"O estado encontrado foi: {estadoEcontrado}");
    }
    else
    {
      Console.WriteLine($"O estado [{chaveProcurada}] não existe na base de dados");

    }
  }
}
