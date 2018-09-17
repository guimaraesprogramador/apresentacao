using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using aplicativo01;
namespace teste_unitario
{
    [TestClass]
    public class UnitTest1
    {
        formulario formulario;
        [TestInitialize]
        public void inicial()
        {
            formulario = new formulario();
        }
        [TestMethod]
        public void criar_zero()
        {
            formulario.criartheard(0);
            formulario.texto[0] = "kevin";
            formulario.lancar(0);
        }
        [TestMethod]
        public void criar_um()
        {
            formulario.criartheard(1);
            formulario.texto[1] = "hebert";
            formulario.lancar(1);
        } 
        [TestMethod]
        public void criar_dois()
        {
            formulario.criartheard(2);
            formulario.texto[2] = "hebert";
            formulario.lancar(2);
        }
         
        [TestMethod]

        public void parar_zero()
        {
            formulario.parar(0);
           formulario.exclur(0);
        }
        [TestMethod]
        public void parar_um()
        {
            formulario.parar(1);
            formulario.exclur(1);
        }
        [TestMethod]
        public void parar_dois()
        {
            formulario.parar(2);
            formulario.exclur(2);
        }
    }
}
