using System;

namespace Ejercicio_08_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Funcion intercambiar
            int num1, num2;

            Console.Write("Inserte el núm 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte el núm 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El primer número es \'" +num1+ "\', y el segundo número es \'" +num2+ "\'");
            intercambiarNumeros(ref num1, ref num2);
            Console.WriteLine("Intercambio. El primer número es \'" + num1 + "\', y el segundo número es \'" + num2 + "\'");*/

            int[] resultados = { 0, 0, 0, 0, 0, 0};

            contadorNumeroTirosDados(resultados);
            //verNumeroTiradas(resultados);
            Console.Write("Inserte un número entre el \'1\' y el \'6\', para saber cuantas veces ha salido = " );
            int numRes = Convert.ToInt32(Console.ReadLine());
            int numapariciones = conocerNumApariciones(numRes, resultados);
            Double porcentajeResultado = conocerPorcentaje(numapariciones);
            //Resultado
            Console.WriteLine("El número \'" + numRes + "\' ha aparecido \'" + numapariciones 
                + "\' veces, es decir el \'" + porcentajeResultado + "%\'");

        
        }

        //nos permite conocer el porcentaje de tiradas de ese número
        private static Double conocerPorcentaje(int num)
        {
            return (num * 100) / 50000;
        }

        //Nos devuelve el número de apariciones, de un un determinado número
        private static int conocerNumApariciones(int numRes, int[] resultados)
        {
            int result = 0;
            for (int i = 0; i < resultados.Length; i++)
            {
                if (i == (numRes - 1))
                    result = resultados[i];
            }
            return result;
        }

        private static void verNumeroTiradas(int[] resultados)
        {
            for (int i=0; i < resultados.Length; i++)
            {
                Console.WriteLine("Resultado núm\'" +(i+1) + "\' = " + resultados[i]);
            }
        }

        //Nos rellenará nuestro array con los resultados de nuestras tiradas
        private static void contadorNumeroTirosDados(int[] resultados)
        {
            Random generador = new Random();
            for (int i=0; i < 50000; i++)
            {
                int aleatorio = generador.Next(1, 7);
                switch (aleatorio)
                {
                    case 1:
                        resultados[0] += 1;
                        break;

                    case 2:
                        resultados[1] += 1;
                        break;

                    case 3:
                        resultados[2] += 1;
                        break;

                    case 4:
                        resultados[3] += 1;
                        break;

                    case 5:
                        resultados[4] += 1;
                        break;

                    case 6:
                        resultados[5] += 1;
                        break;
                }
            }
        }

        public static void intercambiarNumeros(ref int num1, ref int num2)
        {
            int numAux = num1;
            num1 = num2;
            num2 = numAux;
        }

        /// <summary>
        /// Ejemplo alvaro
        /// </summary>
        /// <param name="parametro1"></param>
        /// <param name="parametro2"></param>
        public static void assignaValor(out int parametro1, out int parametro2)
        {
            parametro1 = 14 * 2;
            parametro2 = 23 * 2;
        }
    }
}
