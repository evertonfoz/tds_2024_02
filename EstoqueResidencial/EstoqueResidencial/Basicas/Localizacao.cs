using System.Collections.Generic;

namespace EstoqueResidencial.Modelo.Basicas
{
    public class Localizacao
    {
        public int LocalizacaoID { get; set; }

        public string? Nome { get; set; }


        public Localizacao(int localizacaoID, string nome)
        {
            LocalizacaoID = localizacaoID;
            Nome = nome;
        }

        public Localizacao()
        {

        }

        public override string ToString()
        {
            return $"[{LocalizacaoID}, {Nome}]";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Localizacao other)
            {
                return other.LocalizacaoID == LocalizacaoID;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return LocalizacaoID.GetHashCode();
        }
    }
}
