namespace strucRefDemos
{
  public ref struct Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Endereco EnderecoPessoa { get; set; }
  }

  public struct Endereco
  {
    public int Numero { get; set; }
    public string CEP { get; set; }
    public string Logradouro { get; set; }


  }
}