namespace Desafio_de_projeto_2
{
  public class SerieRepository : IRepository<Serie>
  {
    List<Serie> SerieList = new List<Serie>();
    public void Add(Serie Entity)
    {
      SerieList.Add(Entity);
    }

    public void Delete(int ID)
    {
      SerieList[ID].MarkDeleted();
    }

    public int NextId()
    {
      return SerieList.Count;
    }

    public Serie ReturnById(int ID)
    {
      return SerieList[ID];
    }

    public List<Serie> ListSerie()
    {
      return SerieList;
    }

    public void Update(int ID, Serie Entity)
    {
      SerieList[ID] = Entity;
    }
  }
}