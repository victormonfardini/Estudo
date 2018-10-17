using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        private AutenticaHelper _autenticaHelper = new AutenticaHelper();

        public bool Autenticar(string senha)
        {
            return _autenticaHelper.CompararSenhas(Senha, senha);
        }
    }
}