using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejer08;

namespace Ejercicio08Test
{
    [TestClass]
    public class CalculadoraConFicheroTest
    {
        [TestMethod]
        public void TestSumarGuardando()
        {
            CalculadoraConFichero sut = new CalculadoraConFichero();
            sut.calculadora = new CalculadoraDel9();
            sut.fichero = new FicheroServiceDeMentira();
            sut.SumarGuardando(4, 5);
        }
    }

    public class CalculadoraDel9 : ICalculadora
    {
            public int Sumar(int a, int b)
            {
                return 9;
            }
   }

    public class FicheroServiceDeMentira : IFicheroService
    {
        public void GuardarNumero(int c)
        {
            
        }
    }


}
