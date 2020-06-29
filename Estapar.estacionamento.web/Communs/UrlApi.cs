using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estapar.estacionamento.web.Communs
{
    public static class UrlApi
    {
        #region ManobraCarro
        public static string urlManobraCarroCadastrar = "manobraCarro/v1/inserir";
        public static string urlManobraCarroAtualizar = "manobraCarro/v1/atualizar";
        public static string urlManobraCarroDeletar = "manobraCarro/v1/deletar";
        public static string urlManobraCarroObter = "manobraCarro/v1/obterlista";
        public static string urlManobraCarroObterPorId = "manobraCarro/v1/obter";

        #endregion

        #region Pessoa 
        public static string urlPessoaCadastrar = "pessoa/v1/inserir";
        public static string urlPessoaAtualizar = "pessoa/v1/atualizar";
        public static string urlPessoaDeletar = "pessoa/v1/deletar";
        public static string urlPessoaObter = "pessoa/v1/obterlista";
        public static string urlPessoaObterPorId = "pessoa/v1/obter";

        #endregion


        #region ModeloCarro
        public static string urlModeloCarroObter = "modeloCarro/v1/obterlista";

        #endregion

        #region MarcaCarro
        public static string urlMarcaCarroObter = "marcaCarro/v1/obterlista";

        #endregion
    }
}