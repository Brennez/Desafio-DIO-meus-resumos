namespace Desafio_de_projeto_2
{
  public class Serie : BaseEntity
  {
    //my atributtes 
    private Genre Genre { get; set; }
    private string Title { get; set; }
    private string Description { get; set; }
    private int Year { get; set; }

    public bool isDelete { get; set; }

    public Serie(int ID, Genre Genre, string Title, string Description, int Year)
    {
      this.ID = ID;
      this.Genre = Genre;
      this.Title = Title;
      this.Description = Description;
      this.Year = Year;
      this.isDelete = false;

    }

    public override string ToString()
    {
      String print = "";
      print += "Gênero: " + this.Genre + Environment.NewLine;
      print += "Título: " + this.Title + Environment.NewLine;
      print += "Descrição: " + this.Description + Environment.NewLine;
      print += "Ano de início: " + this.Year + Environment.NewLine;
      print += "Excluído: " + this.isDelete;
      return print;
    }

    public string GetTitle()
    {
      return this.Title;
    }

    public int GetId()
    {
      return this.ID;
    }

    public bool GetDeleted()
    {
      return this.isDelete;
    }

    public void MarkDeleted()
    {
      this.isDelete = true;
    }




  }
}