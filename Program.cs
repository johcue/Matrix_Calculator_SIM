using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoMatricesyVectores1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i, j, fil1, col1, fil2, col2, opc = 0;

            Console.WriteLine("\t CAPTURA MATRIZ A \n");
 
            Console.Write("Cantidad de filas:"); 
            fil1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de Columnas:"); 
            col1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("\n");
            
            int [,] IngresoA = new int[fil1, col1];

            for (i = 0; i < fil1; i++)
            {
                for (j = 0; j < col1; j++)
                {

                    Console.Write("\t Elemento [" + i + "][" + j + "] : ");
                    IngresoA[i, j] = Convert.ToInt32(Console.ReadLine());
 
                }
 
            }
            Console.Write("\n");
            Console.Write("La matriz A es \n");
            for (i = 0; i < fil1; i++)
            {
                for (j = 0; j < col1; j++)
                {

                    Console.Write("\t " + IngresoA[i, j] + " ");
 
                }
                Console.Write("\n");
 
            }
            
            Console.ReadKey();

            Console.Clear();
            
            /////
            Console.Write("\n");
            Console.WriteLine("\t CAPTURA MATRIZ B \n");

            Console.Write("Cantidad de filas:");
            fil2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de Columnas:");
            col2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");
            int [,] IngresoB = new int[fil2, col2];

            for (i = 0; i < fil2; i++)
            {
                for (j = 0; j < col2; j++)
                {

                    Console.Write("\t Elemento [" + i + "][" + j + "] : ");
                    IngresoB[i, j] =Convert.ToInt32(Console.ReadLine());

                }

            }
            Console.Write("\n");
            Console.Write("La Matriz B es \n");
            for (i = 0; i < fil2; i++)
            {
                for (j = 0; j < col2; j++)
                {

                    Console.Write("\t " + IngresoB[i, j] + " ");

                }
                Console.Write("\n");

            }
            Console.ReadKey();
            Console.Clear();
            
            ////

            Console.WriteLine("\t OPERACIONES CON MATRICES \n \t 1. Suma \n \t 2. Resta \n \t 3. Multiplicacion \n \t 4. Multiplicar por Escalar\n \t 5. Salir\n");
            Console.Write("Por favor, escoja una opcion: ");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1: Console.WriteLine("\n\t SUMA (A+B) \n");
                    if ((fil1==fil2)&&(col1==col2))
                    {
                        int[,] IngresoSU = new int[fil1, col1];
                        for (i = 0; i < fil1; i++)
                        {
                            for (j = 0; j < col1; j++)
                            {
                                
                                IngresoSU[i, j] = IngresoA[i, j] + IngresoB[i, j];
                                Console.Write("\t " + IngresoSU[i, j] + " ");
                            }
                            Console.Write("\n");
                        }
                        
                    }
                    else 
                    {
                        Console.WriteLine("No se puede realizar la operacion");
                    }
                    
                    break;
                case 2: Console.WriteLine("\n\t RESTA (A-B)\n");
                    if ((fil1 == fil2) && (col1 == col2))
                    {
                        int[,] IngresoRES = new int[fil1, col1];
                        for (i = 0; i < fil1; i++)
                        {
                            for (j = 0; j < col1; j++)
                            {
                                //string[,] IngresoC = new string[fil1, col1];
                                
                                IngresoRES[i, j] = IngresoA[i, j] - IngresoB[i, j];

                                Console.Write("\t " + IngresoRES[i, j] + " ");
                            }
                            Console.Write("\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No se puede realizar la operacion");
                    }
                    
                    break;
                case 3: Console.WriteLine("\n\t MULTIPLICACION (A*B) \n");
                    if (col1 == fil2)
                    {
                        int[,] IngresoMU = new int[fil1, col1];
                        for (i = 0; i < fil1; i++)
                        {
                            for (j = 0; j < col1; j++)
                            {
                                IngresoMU[i, j] = 0;
                            }
                        }

                        for (i = 0; i < fil1; i++)
                        {
                            for (j = 0; j < col2; j++)
                            {
                                for (int k = 0; k < col1; k++)
                                {
                                    IngresoMU[i, j] = IngresoA[i, k] * IngresoB[k, j] + IngresoMU[i, j];
                                }
                                Console.Write("\t " + IngresoMU[i, j] + " ");
                            }
                            Console.Write("\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No se puede realizar la operacion");
                    }
                    
                    break;
                case 4: Console.WriteLine("\n \t MULTIPLICAR POR UN ESCALAR (a*A o a*B) \n");
                    int p = 0, mat=0;
                    Console.Write("\tDigite el el escalar:");
                    p = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\t 1. Matriz A \n\t 2. Matriz B ");
                    Console.Write("\n Por favor escoja la matriz por la cual desea multiplicar un escalar:");
                    mat = Convert.ToInt32(Console.ReadLine());
                    switch (mat)
                    {
                        case 1:

                            Console.WriteLine("El resultado de la operación es: \n");
                            for (i = 0; i < fil1; i++)
                            {
                                for (j = 0; j < col1; j++)
                                {
                                    IngresoA[i, j] = IngresoA[i, j] * p;
                                    Console.Write("\t " + IngresoA[i, j] + " ");
                                }
                                Console.Write("\n");
                            }
                            Console.ReadKey();
                            break;
                        case 2:

                            Console.WriteLine("El resultado de la operación es: \n");
                            for (i = 0; i < fil2; i++)
                            {
                                for (j = 0; j < col2; j++)
                                {
                                    IngresoB[i, j] = IngresoB[i, j] * p;
                                    Console.Write("\t " + IngresoB[i, j] + " ");
                                }
                                Console.Write("\n");
                            }
                            Console.ReadKey();

                            break;

                        default:
                            Console.WriteLine("La opción ingresada no es valida");
                            Console.ReadKey();
                            break;
                    }
                    break;
                default: Console.Write("\t SALIR");
                    break;

            }
                
            
            Console.ReadKey();
        
        }//
    }
}
