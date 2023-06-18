class Calculadora
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion >= 1 && opcion <= 4)
            {
                Console.Write("Ingrese el primer número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine("El resultado de la suma es: " + resultado);
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine("El resultado de la resta es: " + resultado);
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                        break;
                    case 4:
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine("El resultado de la división es: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre cero.");
                        }
                        break;
                }
            }
            else if (opcion == 5)
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
