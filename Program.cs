using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {

            cobrar c = new cobrar();
            carro car = new carro();
            moto Moto = new moto();
            caminhao Cam = new caminhao();
            onibus bus = new onibus();


            
            Console.WriteLine(c.Cobrar(car));


            Console.ReadKey();


            // Console.WriteLine("o numero de eixos do carro é " + car.eixos);
            //  Console.WriteLine("o numero de eixos da moto é " +  Moto.eixos);
            //  Console.WriteLine("o numero de eixos do caminhão é " +  Cam.eixos);
            //  Console.WriteLine("o numero de eixos do onibus é " +  bus.eixos);

        }
    }
}
