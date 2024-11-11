using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort__Cocktail_sort__Insertion_sort
{
    internal class Organization
    {
        public event Action<int[]> OnSwap;
        public bool swapped;


        public void BubbleSort(int[] array)
        {
            int size = array.Length;

            // Bucle externo para las pasadas sobre el arreglo
            for (int quantity = 0; quantity < size - 1; quantity++)
            {
                swapped = false;
                // Bucle interno para comparar e intercambiar elementos adyacentes
                for (int current = 0; current < size - quantity - 1; current++)
                {
                    if (array[current] > array[current + 1])
                    {
                        // Intercambiar elementos
                        int temporal = array[current];
                        array[current] = array[current + 1];
                        array[current + 1] = temporal;
                        swapped = true;
                        OnSwap?.Invoke(array);
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }



        public void Cocktail_Sort(int[] array)
        {
            swapped = true;
            int start = 0;
            int end = array.Length - 1;

            while (swapped)
            {
                swapped = false;

                // Recorrido de izquierda a derecha
                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Intercambiar elementos
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        OnSwap?.Invoke(array);
                        swapped = true;
                    }
                }

                // Si no hubo intercambio, el arreglo ya está ordenado
                if (!swapped)
                    break;

                // Decrementar el final, ya que el último elemento está en su posición correcta
                end--;

                swapped = false;

                // Recorrido de derecha a izquierda
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Intercambiar elementos
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        OnSwap?.Invoke(array);
                        swapped = true;
                    }
                }

                // Incrementar el inicio, ya que el primer elemento está en su posición correcta
                start++;
            }

        }
    }
}
