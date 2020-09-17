using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
namespace Operaciones_con_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3] { 2, 4, 6 };
            int[] b = new int[3] { 1, 3, 5 };

            MultiplicacionDeVectores multvect = new MultiplicacionDeVectores();
            multvect.multiplicacionDeVectores();

            ProductoVectorial prodVec = new ProductoVectorial();
            prodVec.crossProduct(a,b);


        }
    }
}
