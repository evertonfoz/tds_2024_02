using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueResidencial.Modelo.Basicas;

    public class UnidadeMedidaModelo
{
    public int UnidadeMedidaID { get; set; }

    public string? Nome { get; set; }

    public int Quantidade { get; set; }

    public UnidadeMedidaModelo(int unidadeMedidaID, string nome, int quantidade)
    {
        UnidadeMedidaID = unidadeMedidaID;
        Nome = nome;
        Quantidade = quantidade;
    }

    public UnidadeMedidaModelo()
    {
    }

    public override string ToString()
    {
        return $"[{UnidadeMedidaID}, {Nome}, {Quantidade}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is UnidadeMedidaModelo other)
        {
            return other.UnidadeMedidaID == UnidadeMedidaID;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return UnidadeMedidaID.GetHashCode();
    }
}
