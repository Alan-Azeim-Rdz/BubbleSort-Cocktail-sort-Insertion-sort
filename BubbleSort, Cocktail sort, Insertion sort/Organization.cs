using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort__Cocktail_sort__Insertion_sort
{
    internal class Organization
    {
        public event Action<int[]> OnSwap;

        public void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;


            // Bucle externo para las pasadas sobre el arreglo
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                // Bucle interno para comparar e intercambiar elementos adyacentes
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Intercambiar elementos
                        int temporal = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temporal;
                        swapped = true;
                        OnSwap?.Invoke(array);
                    }
                }

                // Si no hubo intercambio en una pasada, el arreglo ya está ordenado
                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
