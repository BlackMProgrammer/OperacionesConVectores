using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones_con_vectores
{
    class MultiplicacionDeVectores
    {
        public void multiplicacionDeVectores() {
            int productoEscalar = 0;

            int[] a = new int[3] { 2, 4, 6 };
            int[] b = new int[3] { 1, 3, 5 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "\t");
            }

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i] + "\t");
            }

            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                productoEscalar = productoEscalar + a[i] * b[i];

                Console.WriteLine("\n El producto escalar entre los dos vectores es de: {0}", productoEscalar);
            }
        }

    }
}
