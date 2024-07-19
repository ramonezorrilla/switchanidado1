using System;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        do
        {
            //menú principal
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1. Captura de nombre");
            Console.WriteLine("2. Operaciones matemáticas");
            Console.WriteLine("3. Cerrar el programa");
            Console.Write("Ingrese la opción deseada: ");

            // opción del usuario
            string opcionPrincipal = Console.ReadLine();

            switch (opcionPrincipal)
            {
                case "1":

                    bool volvercaptura = false;
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("MENU DE PARA CAPTURA DE NOMBRE");
                        Console.WriteLine("a. Capturar el nombre");
                        Console.WriteLine("b. Volver al menú principal");
                        Console.Write("Ingrese la opción deseada: ");

                        string opcionCadenas = Console.ReadLine();

                        switch (opcionCadenas)
                        {
                            case "a":
                                Console.Write("Ingrese Su nombre: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine($"Su nombre es: {nombre}");
                                break;

                            case "b":
                                volvercaptura = true;
                                break;

                            default:
                                Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                                break;
                        }

                    } while (!volvercaptura);
                    break;

                case "2":

                    bool volverMatematicas = false;
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("MENU DE OPERACIONES MATEMÁTICAS");
                        Console.WriteLine("1. Sumar dos números");
                        Console.WriteLine("2. Volver al menú principal");
                        Console.Write("Ingrese la opción deseada: ");

                        string opcionMatematicas = Console.ReadLine();

                        switch (opcionMatematicas)
                        {
                            case "1":
                                Console.Write("Ingrese el primer número: ");
                                double numero1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese el segundo número: ");
                                double numero2 = Convert.ToDouble(Console.ReadLine());
                                double suma = numero1 + numero2;
                                Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");
                                break;

                            case "2":
                                volverMatematicas = true;
                                break;

                            default:
                                Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                                break;
                        }

                    } while (!volverMatematicas);
                    break;

                case "3":

                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese una opción del 1 al 3.");
                    break;
            }

        } while (!salir);

        Console.WriteLine("¡Gracias por usar el programa!");
    }
}