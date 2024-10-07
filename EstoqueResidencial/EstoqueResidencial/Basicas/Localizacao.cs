using System.Collections.Generic;

namespace EstoqueResidencial.Modelo.Basicas
{
    public class LocalizacaoArmazenamento
    {
        public int LocalizacaoID { get; set; }

        public string? NomeLocal { get; set; }


        public LocalizacaoArmazenamento(int localizacaoID, string nomeLocal)
        {
            LocalizacaoID = localizacaoID;
            NomeLocal = nomeLocal;
        }

        public LocalizacaoArmazenamento()
        {

        }

        public override string ToString()
        {
            return $"[{LocalizacaoID}, {NomeLocal}]";
        }

        public override bool Equals(object? obj)
        {
            if (obj is LocalizacaoArmazenamento other)
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
