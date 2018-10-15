using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Construtor de DIRETOR");
        }


        //override = sempre para  dizer que está reescrevendo o metódo
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        
        public override double GetBonificacao()
        {
            //base = fazendo referência a base (tudo que foi declarado)
            //return Salario = base.GetBonificacao();

            return Salario * 0.5;
        }

      
       

    }
}
