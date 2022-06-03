namespace colections.helper
{
  public class ListOperations
  {
    public void PrintList(List<string> list)
    {
      for (int i = 0; i < list.Count; i++)
      {
        Console.WriteLine($"Índice: {i} Valor: {list[i]}");
      }
    }

    public bool DeleteItemFromList(List<string> list, string item)
    {
      return list.Remove(item);
    }

    public void InsertByIndex(List<string> list, string item, int index)
    {
      list.Insert(index, item);
    }
  }
}