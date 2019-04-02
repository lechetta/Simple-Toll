using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class cobrar
    {
        public double c;
        public double preco;
        public double Cobrar(Iveiculo v)
        {
            preco = 4;


                c = preco * (v.mult * v.eixos);
                    


            return c;
        }
       
    }
}
