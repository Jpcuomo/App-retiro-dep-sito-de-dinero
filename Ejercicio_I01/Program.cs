using Biblioteca;

namespace Ejercicio_I01
{
    internal class Program
    {
        static string respuesta = "s";


        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Juan Pérez", 1500000);

            while (respuesta.ToLower() == "s")
            {
                cuenta1.Mostrar(); //Muestro saldo
                Console.WriteLine(@"Ingrese monto a operar (monto positivo para ingresar/ negativo para extraer)");
                try
                {
                    decimal? monto = decimal.Parse(Console.ReadLine());
                    if (monto.HasValue)
                    {
                        if (monto >= 0)
                        {
                            cuenta1.Ingresar(monto.Value);
                            Console.WriteLine($"Ingresó {monto.Value:C2}");
                        }
                        else
                        {
                            cuenta1.Retirar(monto.Value);
                            Console.WriteLine($"Retiró {(-1 * monto.Value):C2}");
                        }
                        cuenta1.Mostrar();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Monto inválido");
                }

                Console.WriteLine("Desea Realizar otra operación: (s/n)");
                respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "n" && respuesta.ToLower() != "s")
                {
                    Console.WriteLine("Opción incorrecta");
                    respuesta = "s";
                }
                else if (respuesta.ToLower() == "n")
                {
                    Console.WriteLine("Gracias por elegirnos. Hasta la próxima!");
                    break;
                }
            }

        }
    }
}