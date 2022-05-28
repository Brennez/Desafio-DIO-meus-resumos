namespace desafio_de_projeto_1.src.models
{
  public abstract class Hero
  {
    public Hero(string Name, int Level, string HeroType, int HP, int MP)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.MP = MP;
      this.HP = HP;
    }
    public string Name;
    public int Level;
    public int HP;
    public int MP;
    public string HeroType;


    public override string ToString()
    {
      return "Nome: " + this.Name + " Level: " + this.Level + " Tipo: " + this.HeroType + " HP: " + this.HP + " MP: " + this.MP;
    }

    public virtual string atack()
    {
      return this.Name + " Atacou com uma espada ";
    }

  }
}