using System;

namespace Americas.Api.Assertions
{
    public class FapaccadAssertion : BaseAssertion
    {
        public FapaccadAssertion(Models.Fapaccad fapaccad, bool canIdNull = false) : base()
        {
            if (fapaccad == null)
            {
                throw new Exception("O parâmetro conexao não pode ser nulo [classe ConexaoAssertion]");
            }

            if (!canIdNull)
            {
                if (string.IsNullOrEmpty(fapaccad.COD_PAC))
                    SetNofication("500", "O ID não pode ser nulo");
            }

            if (string.IsNullOrEmpty(fapaccad.NOME_SEGU))
                SetNofication("500", "Informe o Nome do Paciente");

            /*if (!conexao.DataNascimento.HasValue)
                SetNofication("500", "Informe a Data de Nascimento");
                */
        }
    }
}
