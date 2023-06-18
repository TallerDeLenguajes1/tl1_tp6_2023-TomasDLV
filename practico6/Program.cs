using System;

class Calculadora
{

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("1. Valor absoluto");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Raiz Cuadrada");
            Console.WriteLine("4. Seno");
            Console.WriteLine("5. Coseno");
            Console.WriteLine("6. Parte entera de un float");
            Console.WriteLine("7. Maximo entre 2 numeros");
            Console.WriteLine("8. Minimo entre 2 numeros");
            Console.WriteLine("9. Salir");

            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion >= 1 && opcion <= 8)
            {
                float numero;
                float numero1;
                float numero2;
                float resultado;
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un número: ");
                        numero = Convert.ToSingle(Console.ReadLine());
                        resultado = Math.Abs(numero);
                        Console.WriteLine("El resultado del Valor absoluto es: " + resultado);
                        break;
                    case 2:
                        Console.Write("Ingrese un número: ");
                        numero = Convert.ToSingle(Console.ReadLine());
                        resultado = (float)Math.Pow(numero,2);
                        Console.WriteLine("El resultado del Cuadrado es: " + resultado);
                        break;
                    case 3:
                        Console.Write("Ingrese un número: ");
                        numero = Convert.ToSingle(Console.ReadLine());
                        resultado = (float)Math.Sqrt(numero);
                        Console.WriteLine("El resultado de la Raiz cuadrada es: " + resultado);
                        break;
                    case 4:
                        Console.Write("Ingrese un número: ");
                        numero = Convert.ToSingle(Console.ReadLine());
                        resultado = (float)Math.Sin(numero);
                        Console.WriteLine("El resultado del Seno es: " + resultado);
                        break;
                    case 5:
                        Console.Write("Ingrese un número: ");
                        numero = Convert.ToSingle(Console.ReadLine());
                        resultado = (float)Math.Cos(numero);
                        Console.WriteLine("El resultado del Coseno es: " + resultado);
                        break;
                    case 6:
                        Console.Write("Ingrese un número: ");
                        numero = Convert.ToSingle(Console.ReadLine());
                        resultado = (float)Math.Truncate(numero);
                        Console.WriteLine("El resultado de la parte entera es: " + resultado);
                        break;
                    case 7:
                        Console.Write("Ingrese el primer número: ");
                        numero1 = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        numero2 = Convert.ToSingle(Console.ReadLine());
                        resultado = (numero1 > numero2) ? numero1 : numero2;
                        Console.WriteLine("El resultado de la parte entera es: " + resultado);
                        break;
                    case 8:
                        Console.Write("Ingrese el primer número: ");
                        numero1 = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        numero2 = Convert.ToSingle(Console.ReadLine());
                        resultado = (numero1 < numero2) ? numero1 : numero2;
                        Console.WriteLine("El resultado de la parte entera es: " + resultado);
                        break;
                }
            }
            else if (opcion == 9)
            {
                continuar = false;
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
            }

            if (continuar)
            {
                Console.Write("¿Desea realizar otro cálculo? Si(1) | No(0): ");
                string respuesta = Console.ReadLine();
                continuar = respuesta == "1";
            }

            Console.WriteLine();
        }

        Console.WriteLine("Saliendo del programa...");
    }
}
