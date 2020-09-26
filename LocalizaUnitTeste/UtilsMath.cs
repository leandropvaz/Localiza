using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UtilsMath;

namespace LocalizaUnitTeste
{
    [TestClass]
    public class UtilsMath
    {
        [TestMethod]
        public void GetDivisores_Retorna_Todos_Divisores()
        {
            Math math = new Math();
            List<int> resultado = math.GetDivisores(10);
            List<int> resultadoEsperado = new List<int>();
            resultadoEsperado.Add(1);
            resultadoEsperado.Add(2);
            resultadoEsperado.Add(5);
            resultadoEsperado.Add(10);

            foreach (var item in resultadoEsperado)
            {
                Assert.IsTrue(resultado.Contains(item));
            }            
        }


        [TestMethod]
        public void GetDivisoresPrimos_Retorna_Todos_DivisoresPrimos()
        {
            Math math = new Math();
            List<int> resultado = math.GetDivisoresPrimo(10);
            List<int> resultadoEsperado = new List<int>();
            resultadoEsperado.Add(1);
            resultadoEsperado.Add(2);
            resultadoEsperado.Add(5);
            foreach (var item in resultadoEsperado)
            {
                Assert.IsTrue(resultado.Contains(item));
            }
        }


        [TestMethod]
        public void VerificaNumeroPrimo_Retorna_se_o_numero_eh_primo()
        {
            Math math = new Math();
            bool resultado = math.VerificaNumeroPrimo(10);
            bool resultadoEsperado = false;
            Assert.AreEqual(resultadoEsperado, resultado);
           
        }
    }
}
