using System.ComponentModel.DataAnnotations;

namespace EstoqueResidencial.Modelo.Basicas
{
  public class FornecedorModelo
  {
    public int FornecedorID { get; set; }
    public string? Nome { get; set; }
    public string? Telefone { get; set; }
    public string? Endereco { get; set; }

    public FornecedorModelo(int fornecedorID, string nome, string telefone, string endereco)
    {
      FornecedorID = fornecedorID;
      Nome = nome;
      Telefone = telefone;
      Endereco = endereco;
    }

    public FornecedorModelo()
    {
    }

    public override string ToString()
    {
      return $"[{FornecedorID}, {Nome}, {Telefone}, {Endereco}]";
    }

    public override bool Equals(object? obj)
    {
      if (obj is FornecedorModelo other)
      {
        return other.FornecedorID == FornecedorID;
      }

      return false;
    }

    public override int GetHashCode()
    {
      return FornecedorID.GetHashCode();
    }
  }
}
