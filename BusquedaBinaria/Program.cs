using System;

public static class SearchAlgorithms
{

    public static int binarySearch(int[] arr, int target)
    {

        if (arr == null)
        {
            throw new ArgumentNullException(nameof(arr), "El array de entrada no puede ser nulo.");
        }

        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {

            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid; // Objetivo encontrado, retorna el índice
            }
            else if (arr[mid] < target)
            {
                // El objetivo está en la mitad derecha
                left = mid + 1;
            }
            else
            {
                // El objetivo está en la mitad izquierda
                right = mid - 1;
            }
        }

        return -1; // Objetivo no encontrado en el array
    }
    public static void Main()
    {

    }
}