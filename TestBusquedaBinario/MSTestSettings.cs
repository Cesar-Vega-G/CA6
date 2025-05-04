using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinarySearchTests
{
    [TestClass]
    public class SearchAlgorithmsTests 
    {
        [TestMethod]
        public void BinarySearch_TargetFoundInMiddle_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 }; // Array ordenado
            int target = 23;
            int expectedIndex = 5; // El índice de 23 es 5

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "El índice del objetivo en el medio no es correcto.");
        }

        [TestMethod]
        public void BinarySearch_TargetFoundAtBeginning_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 }; // Array ordenado
            int target = 2;
            int expectedIndex = 0; // El índice de 2 es 0

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "El índice del objetivo al principio no es correcto.");
        }

        [TestMethod]
        public void BinarySearch_TargetFoundAtEnd_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 }; // Array ordenado
            int target = 91;
            int expectedIndex = 9; // El índice de 91 es 9

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "El índice del objetivo al final no es correcto.");
        }

        [TestMethod]
        public void BinarySearch_TargetNotFound_BetweenElements_ReturnsNegativeOne()
        {
            // Arrange
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 }; // Array ordenado
            int target = 25; // No está en el array, entre 23 y 38
            int expectedIndex = -1;

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "Debería retornar -1 cuando el objetivo no se encuentra entre elementos.");
        }

        [TestMethod]
        public void BinarySearch_TargetNotFound_BeforeFirstElement_ReturnsNegativeOne()
        {
            // Arrange
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 }; // Array ordenado
            int target = 1; // No está en el array, antes del primer elemento
            int expectedIndex = -1;

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "Debería retornar -1 cuando el objetivo no se encuentra antes del primer elemento.");
        }

        [TestMethod]
        public void BinarySearch_TargetNotFound_AfterLastElement_ReturnsNegativeOne()
        {
            // Arrange
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 }; // Array ordenado
            int target = 100; // No está en el array, después del último elemento
            int expectedIndex = -1;

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "Debería retornar -1 cuando el objetivo no se encuentra después del último elemento.");
        }


        [TestMethod]
        public void BinarySearch_EmptyArray_ReturnsNegativeOne()
        {
            // Arrange
            int[] arr = { }; // Array vacío y (trivialmente) ordenado
            int target = 5;
            int expectedIndex = -1;

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "Debería retornar -1 al buscar en un array vacío.");
        }

        [TestMethod]
        public void BinarySearch_SingleElementArray_TargetFound_ReturnsZero()
        {
            // Arrange
            int[] arr = { 42 }; // Array de un solo elemento ordenado
            int target = 42;
            int expectedIndex = 0;

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "Debería retornar 0 al encontrar el objetivo en un array de un solo elemento.");
        }

        [TestMethod]
        public void BinarySearch_SingleElementArray_TargetNotFound_ReturnsNegativeOne()
        {
            // Arrange
            int[] arr = { 42 }; // Array de un solo elemento ordenado
            int target = 99;
            int expectedIndex = -1;

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "Debería retornar -1 al no encontrar el objetivo en un array de un solo elemento.");
        }

        [TestMethod]
        public void BinarySearch_ArrayWithDuplicates_ReturnsAnIndex()
        {
            // Arrange
            int[] arr = { 2, 5, 8, 8, 8, 12, 16 }; // Array ordenado con duplicados
            int target = 8;

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.IsTrue(actualIndex >= 2 && actualIndex <= 4, $"El índice retornado ({actualIndex}) para duplicados no está en el rango esperado (2-4).");
            Assert.AreEqual(target, arr[actualIndex], $"El valor en el índice retornado ({actualIndex}) no coincide con el objetivo ({target}).");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void BinarySearch_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] arr = null; // Array nulo
            int target = 5;

            // Act
            SearchAlgorithms.binarySearch(arr, target);

            // Assert
        }

        [TestMethod]
        public void BinarySearch_EvenLengthArray_TargetFound()
        {
            // Arrange
            int[] arr = { 10, 20, 30, 40, 50, 60 }; // Longitud par
            int target = 40;
            int expectedIndex = 3;

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "Error en array de longitud par.");
        }

        [TestMethod]
        public void BinarySearch_OddLengthArray_TargetFound()
        {
            // Arrange
            int[] arr = { 10, 20, 30, 40, 50, 60, 70 }; // Longitud impar
            int target = 40;
            int expectedIndex = 3;

            // Act
            int actualIndex = SearchAlgorithms.binarySearch(arr, target);

            // Assert
            Assert.AreEqual(expectedIndex, actualIndex, "Error en array de longitud impar.");
        }
    }
}