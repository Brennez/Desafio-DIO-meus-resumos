namespace desafio_de_projeto_1.src.models
{
  public abstract class Hero
  {
    public Hero(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
    public string Name;
    public int Level;
    public string HeroType;

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.HeroType;
    }

    public virtual string atack()
    {
      return this.Name + " Atacou com uma espada ";
    }
  }
}