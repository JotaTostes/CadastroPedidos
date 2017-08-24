using CadastroPedidos.Core.Services.Usuario;
using CadastroPedidos.Core.Services.Usuario.Dto;

namespace CadastroPedidos.Repository
{
    public class UsuarioRepository : ConnectBD, IUsuarioRepository
    {
        private enum Procedures
        {
            GKSSP_InsUsuario,
            GKSSP_SelUsuario,
            GKSSP_SelUsuaSenha,
            GKSSP_UpdEmailValido

        }

        public void InserirUsuario(UsuarioDto usuario)
        {
            ExecuteProcedure(Procedures.GKSSP_InsUsuario);
            AddParameter("Email", usuario.Email);
            AddParameter("Senha", usuario.Senha);
            AddParameter("Nome", usuario.Nome);

            ExecuteNonQuery();
        }

        public bool VerificaEmailCadastrado(string email)
        {
            ExecuteProcedure(Procedures.GKSSP_SelUsuario);
            AddParameter("Email", email);

            using (var retornobd = ExecuteReader())
                // Se o read ler alguma coisa significa que tem email cadastrado entao ele retorna TRUE
                return retornobd.Read();
        }

        public bool VerificaEmailSenha(string email, string senha)
        {
            ExecuteProcedure(Procedures.GKSSP_SelUsuaSenha);
            AddParameter("Email", email);
            AddParameter("Senha", senha);
            var retornobd = ExecuteReader();
            return retornobd.Read();
        }

        public void ValidaEmail(int numchaveusua)
        {
            ExecuteProcedure(Procedures.GKSSP_UpdEmailValido);
            AddParameter("Num_ChaveUsua", numchaveusua);
            ExecuteNonQuery();
        }


    }
}
