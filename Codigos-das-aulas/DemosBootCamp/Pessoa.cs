namespace DemosBootCamp
{
  public class Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Documento { get; set; }

    public Pessoa Clone()
    {
      return new Pessoa()
      {
        Documento = this.Documento,
        Idade = this.Idade,
        Nome = this.Nome

      };
    }



  }
}