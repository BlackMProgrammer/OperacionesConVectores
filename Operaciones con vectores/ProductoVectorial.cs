using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones_con_vectores
{
    class ProductoVectorial
    {
        static int n = 3;
        int[] a = new int[3] { 2, 4, 6 };
        int[] b = new int[3] { 1, 3, 5 };
        int[] cross_product = new int[3];
        //Co Product
        public int dotProduct(int[] a, int[] b)
        {
            int product = 0;
            for (int i = 0; i < n; i++)
            {
                product = product + a[i] * b[i];

                Console.WriteLine("Co Producto :", product);
            }
            return product;
        }

        //Producto Crusado
        public void crossProduct(int[] a, int[] b)
        {
            cross_product[0] = a[1] * b[2] -
                               a[2] * b[1];

            cross_product[1] = a[2] * b[0] -
                               a[0] * b[2];

            cross_product[2] = a[0] * b[1] -
                               a[1] * b[0];

            for (int i = 0; i < cross_product.Length; i++)
            {
                Console.Write("Producto {0}  "+ cross_product[i] + " "+ "\n",i+1);
            }
           
        }

    }
}
