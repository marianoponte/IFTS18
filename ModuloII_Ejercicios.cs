using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloII
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tarea 2: Crea un programa que diga el resultado de sumar 200 y 56. */
            Console.WriteLine("Tarea 2");
            int suma = 200 + 56;
            Console.WriteLine(suma);

            /* Tarea 3: Haz un programa que calcule el producto de los n�meros 13 y 12. */
            Console.WriteLine("Tarea 3");
            int multiplicacion = 13 * 12;
            Console.WriteLine(multiplicacion);

            /* Tarea 4: Un programa que calcule la diferencia(resta) entre 321 y 213 */
            Console.WriteLine("Tarea 4");
            int resta = 321 - 213;
            Console.WriteLine(resta);

            /* Tarea 5: Calcular el resultado de (20 + 5) % 6 */
            Console.WriteLine("Tarea 5");
            resultado = (20 + 5) / 6;
            Console.WriteLine(resultado);

            /* Tarea 6: Crea un programa que calcule el producto de los n�meros 12 y 102, usando variables. */
            Console.WriteLine("Tarea 6");
            int variable1 = 12;
            int variable2 = 102;
            resultado = var1 * var2;
            Console.WriteLine("El resultado es " + resultado);

            /* Tarea 7: Crea un programa que calcule la suma de 200 y 1111, usando variables. */
            Console.WriteLine("Tarea 7");
            int num1 = 200;
            int num2 = 1111;
            int resultado = num1 + num2;
            Console.WriteLine("El resultado es " + resultado);

            /* Tarea 8: Crea un programa que calcule el producto de los n�meros 10 y 25, usando variables 
             * llamadas "numero1" y "numero2".  */
            Console.WriteLine("Tarea 8");
            int numero1 = 10;
            int numero2 = 25;
            int resultado = numero1 * numero2;
           Console.WriteLine("La multiplicaci�n es " + resultado);

            /* Tarea 9: Crea un programa que calcule el producto de dos n�meros introducidos por el usuario. */
            Console.WriteLine("Tarea 9");
            Console.Write("Introduzca Primer N�mero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca Segundo N�mero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La multiplicaci�n da " + num1 * num2);

            /* Tarea 10: Crea un programa que pida al usuario un n�mero entero y diga si es par
             * (pista: habr� que comprobar si el resto que se obtiene al dividir entre dos 
             * es cero: if (x % 2 == 0) �). */
            Console.WriteLine("Tarea 10 - Par / Impar");
            Console.Write("Ingrese un n�mero: ");
            int par = Convert.ToInt32(Console.ReadLine());
            if (par % 2 == 0)
                Console.WriteLine("El n�mero es par.");
            else
                Console.WriteLine("El n�mero es impar.");

            /* Tarea 11: Crea un programa que pida al usuario dos n�meros enteros y diga cu�l es el mayor de ellos. */
            Console.WriteLine("Tarea 11 - Qu� n�mero es mayor?");

            Console.WriteLine("Ingrese primer n�mero (Mayor/Menor)");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo n�mero (Mayor/Menor)");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("El n�mero " + num1 + " es mayor.");
            else if (num2 > num1)
                Console.WriteLine("El n�mero " + num2 + " es mayor.");
            else
                Console.WriteLine("Los n�meros son iguales.");

            /* Tarea 12: Crea un programa que pida al usuario dos n�meros enteros. Si el segundo no es cero, mostrar� 
             * el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo n�mero es cero, 
             * escribir� "Error: No se puede dividir entre cero". */
            Console.WriteLine("Tarea 12 - Divisi�n por cero");

            Console.WriteLine("Ingrese primer n�mero (Divisi�n por cero)");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo n�mero (Divisi�n por cero)");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 != 0)
                Console.WriteLine("La divisi�n da " + num1 / num2);
            else if (num2 == 0)
                Console.WriteLine("No se puede dividir por 0.");

            /* Tarea 13: Crea un programa que pida un n�mero del 1 al 5 al usuario, y escriba el nombre de 
             * ese n�mero, usando "switch"(por ejemplo, si introduce "1", el programa escribir� "uno"). */
            Console.WriteLine("Tarea 13");

            /* Tarea 14: Crea un programa que escriba en pantalla los n�meros del 1 al 10, usando "while" */
            Console.WriteLine("Tarea 14");
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine("While usado tipo For: " + i);
                i++;
            }

            /* Tarea 15: Crea un programa que escriba en pantalla los n�meros del 1 al 10, usando "do..while". */
            Console.WriteLine("Tarea 15");
            i = 1;
            do
            {
                Console.WriteLine("Do While usado tipo For: " + i);
                i++;
            }
            while (i < 11);

            /* Tarea 16: Crea un programa que muestre los n�meros del 10 al 20, ambos incluidos, 
             * usando �for� */
            Console.WriteLine("Tarea 16");
            for (i = 10; i < 21; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}