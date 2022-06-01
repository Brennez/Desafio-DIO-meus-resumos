using colections;

class Program
{
  public static void Main(string[] args)
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
}
