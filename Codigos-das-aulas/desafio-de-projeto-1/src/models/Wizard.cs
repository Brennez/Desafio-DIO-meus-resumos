namespace desafio_de_projeto_1.src.models
{
  public class Wizard : Hero
  {
    public Wizard(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
    {

    }

    public override string atack()
    {
      return this.Name + " Atacou lançou a magia ";
    }

    public string atack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + " Atacou lançou uma magia forte com bônus de ataque " + Bonus;
      }
      else
      {
        return this.Name + " Atacou lançou uma magia fraca com bônus de ataque " + Bonus;

      }

    }
  }
}