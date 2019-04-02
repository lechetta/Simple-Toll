using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    abstract class veiculo : Iveiculo
    {
        public virtual int eixos { get => 2;  set { } }

        public virtual double mult { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool ligar()
        {
            throw new NotImplementedException();
        }

        motor Motor = new motor();

    }

}
