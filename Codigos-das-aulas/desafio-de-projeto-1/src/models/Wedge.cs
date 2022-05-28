namespace desafio_de_projeto_1.src.models
{
  public class Wedge : Hero
  {
    public Wedge(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
    {
    }

    public override string atack()
    {
      return this.Name + " Atacou com uma shuriken ";
    }

  }
}