using System;

public class Program
{
    // Implementación de búsqueda lineal
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        // Vacío para pruebas
    }
}



