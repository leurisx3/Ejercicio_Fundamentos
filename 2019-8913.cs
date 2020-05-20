using System;

class Leuris
{
    static void Main(string[] args)
    {
        //Crear un programa que pida al usuario un numero entero y diga si es par.

        string dato = "";
        int num = 0;

        Console.Write("Introduzca un numero entero: ");
        dato = Console.ReadLine();

        num = Convert.ToInt32(dato);

        if (num % 2 == 0)
        {
            Console.WriteLine("El numero es par.");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }

        //Crear un programa que pida al usuario dos numeros enteriso y diga cual  es mayor de ellos y si son iguales muestra en pantalla.

        string Dato = "";
        int num1 = 0;
        int num2 = 0;

        Console.Write("Introduzca el primer numero: ");
        dato = Console.ReadLine();

        num1 = Convert.ToInt32(dato);

        Console.Write("Introduzca el segundo numero: ");
        dato = Console.ReadLine();

        num2 = Convert.ToInt32(dato);

        if (num1 > num2)
        {
            Console.WriteLine("El {0} es mayor", num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("El {0} es mayor", num2);
        }
        else
        {
            Console.WriteLine("Los numeros son iguales.");
        }







    }
}