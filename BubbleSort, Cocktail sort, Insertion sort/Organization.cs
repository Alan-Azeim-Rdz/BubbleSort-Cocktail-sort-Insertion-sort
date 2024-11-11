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

            // Bucle externo que sigue ejecutándose mientras se hagan intercambios
            for (int start = 0; start < end && swapped; start++, end--)
            {
                swapped = false;

                // Bucle para la pasada de izquierda a derecha
                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temporal = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temporal;
                        swapped = true;
                        OnSwap?.Invoke(array); // Llamada al evento después de cada intercambio
                    }
                }

                // Si no hubo intercambios en la pasada, el arreglo ya está ordenado
                if (!swapped) break;

                swapped = false;

                // Bucle para la pasada de derecha a izquierda
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temporal = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temporal;
                        swapped = true;
                        OnSwap?.Invoke(array); // Llamada al evento después de cada intercambio
                    }
                }
            }

                // Incrementar el inicio, ya que el primer elemento está en su posición correcta
                start++;
            }

        }
    }
}
