namespace Desafio_de_projeto_2
{
  public interface IRepository<T>
  {
    List<T> ListSerie();
    T ReturnById(int ID);

    void Add(T Entity);
    void Delete(int ID);
    void Update(int ID, T Entity);
    int NextId();

  }
}