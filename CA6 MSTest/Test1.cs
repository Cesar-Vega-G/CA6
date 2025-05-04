namespace CA6_MSTest

{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValorExiste_EnMitad_RetornaIndiceCorrecto()
        {
            int[] arr = { 5, 3, 8, 6, 2, 7, 1, 4, 9 };
            int resultado = Program.LinearSearch(arr, 7);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void ValorExiste_AlInicio_RetornaCero()
        {
            int[] arr = { 10, 20, 30 };
            int resultado = Program.LinearSearch(arr, 10);
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void ValorExiste_AlFinal_RetornaUltimoIndice()
        {
            int[] arr = { 1, 2, 3, 4 };
            int resultado = Program.LinearSearch(arr, 4);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void ValorNoExiste_RetornaMenosUno()
        {
            int[] arr = { 1, 2, 3 };
            int resultado = Program.LinearSearch(arr, 99);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void ArregloVacio_RetornaMenosUno()
        {
            int[] arr = { };
            int resultado = Program.LinearSearch(arr, 1);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void UnSoloElemento_Existe_RetornaCero()
        {
            int[] arr = { 42 };
            int resultado = Program.LinearSearch(arr, 42);
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void UnSoloElemento_NoExiste_RetornaMenosUno()
        {
            int[] arr = { 42 };
            int resultado = Program.LinearSearch(arr, 99);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Duplicados_RetornaPrimerIndice()
        {
            int[] arr = { 1, 2, 3, 2, 4 };
            int resultado = Program.LinearSearch(arr, 2);
            Assert.AreEqual(1, resultado);
        }
    }
}

