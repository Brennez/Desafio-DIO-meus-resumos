namespace colections
{
  public class ArrayOperations
  {

    public void FillArray(ref int[] array)
    {
      Random s = new Random();

      for (int i = 0; i < array.Length; i++)
      {
        array[i] = s.Next(10);
      }
    }
    public void BubbleSort(ref int[] array)
    {
      int temp;
      for (int i = 0; i < array.Length; i++)
      {
        for (int j = 0; j < array.Length - 1; j++)
        {
          if (array[j] > array[j + 1])
          {
            temp = array[j + 1];
            array[j + 1] = array[j];
            array[j] = temp;
          }
        }
      }
    }
    public void PrintArray(int[] array)
    {
      string linha = string.Join("| ", array);
      Console.Write(linha);
    }

    public void SortByArray(ref int[] array)
    {
      Array.Sort(array);
    }

    public void CopyArray(ref int[] array, ref int[] arrayCopy)
    {
      Array.Copy(array, arrayCopy, array.Length);
    }

    public bool VerifyElement(int[] array, int value)
    {
      return Array.Exists(array, element => element == value);
    }

    public bool VerifyAllElements(int[] array, int value)
    {
      // Vai retornar true se todos os elementos passarem na condição
      return Array.TrueForAll(array, element => element > value);
    }

    public int GetValueIfExists(int[] array, int value)
    {
      return Array.Find(array, element => element == value);
    }

    public int GetPositionIfExists(int[] array, int value)
    {
      return Array.IndexOf(array, value);
    }

    public void ResizeArray(ref int[] array, int value)
    {
      Array.Resize(ref array, value);
    }

    public string[] ConvertArrayToString(int[] array)
    {
      return Array.ConvertAll(array, element => element.ToString());
    }
  }
}