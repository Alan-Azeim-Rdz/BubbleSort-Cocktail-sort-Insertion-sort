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
            int size = array.Length;

            // Bucle externo para las pasadas sobre el arreglo
            for (int quantity = 0; quantity < size - 1; quantity++)
            {
                // Bucle interno para comparar e intercambiar elementos adyacentes
                for (int current = 0; current < size - quantity - 1; current++)
                {
                    if (array[current] > array[current + 1])
                    {
                        // Intercambiar elementos
                        int temporal = array[current];
                        array[current] = array[current + 1];
                        array[current + 1] = temporal;
                        OnSwap?.Invoke(array);
                    }
                }
            }
        }
    }
}
