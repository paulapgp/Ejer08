using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer08
{
    public class CalculadoraConFichero
    {

        public ICalculadora calculadora
        {
            get;
            set;
        }

        public IFicheroService fichero
        {
            get;
            set;
        }

        public void SumarGuardando(int a, int b)
        {
            int c = calculadora.Sumar(a, b);

            fichero.GuardarNumero(c);
        }        
    }
}
