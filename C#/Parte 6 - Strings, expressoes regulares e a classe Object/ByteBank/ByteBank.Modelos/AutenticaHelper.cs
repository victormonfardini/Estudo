using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class AutenticaHelper
    {
        public bool CompararSenhas(String SenhaVerdadeira,String SenhaTentativa)
        {
            return SenhaVerdadeira == SenhaTentativa;
        }
    }
}
