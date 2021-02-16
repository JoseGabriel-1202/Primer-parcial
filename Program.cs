using System;

namespace Primer_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int bancos, retiro, mil, quinientos, docientos, cien;
            string nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine(" el cajero tiene una disponibilidad de:\n" +
                "\n 18 billetes de 1,000 " +
                "\n 19 billetes de 500 " +
                "\n 23 billetes de 200 " +
                "\n 50 billetes de 100 ");

            Console.WriteLine("\n" +
                "Hola Bienvenido a FDP INVERSMENTS ");
            Console.WriteLine(" ¿Cuál es su Banco?\n" +
              "\nIngrse 1 si es FDP" +
              "\nIngrese 2 si es otroBanco");
            bancos = int.Parse(Console.ReadLine());
            if (bancos > 0 && bancos != 2)
            {
                Console.WriteLine("Hola " + nombre, "Bienvenido a FDP INVERSMENTS\n" +
                    "\nTiene un limite de retiro de 20,000");
                Console.WriteLine("cuanto desea retirar: ");
                retiro = int.Parse(Console.ReadLine());
                if (retiro < 20001)
                {
                    Console.WriteLine("usted ha retirado " + retiro);
                    if (retiro % 5 == 0)
                    {
                        mil = retiro / 1000;
                        retiro = retiro % 1000;
                        quinientos = retiro / 500;
                        retiro = retiro % 500;
                        docientos = retiro / 200;
                        retiro = retiro % 200;
                        cien = retiro / 100;
                        retiro = retiro % 100;

                        Console.WriteLine("el monto en billetes de mil es:" + mil);

                        Console.WriteLine("el monto en billetes de quinientos es:" + quinientos);

                        Console.WriteLine("el monto en billetes de docientos es:" + docientos);

                        Console.WriteLine("el monto en billetes de cien es:" + cien);
                    }

                }
                else
                {
                    Console.WriteLine("usted ha superado el limite de retiro");
                }

            }
            if (bancos > 1 && bancos != 3)
            {
                Console.WriteLine("Bienvenido a FDP INVERSMENTS\n" +
                    "\nTiene un limite de retiro de 10,000");
                Console.WriteLine("cuanto desea retirar: ");
                retiro = int.Parse(Console.ReadLine());

                if (retiro < 10000)
                {
                    Console.WriteLine("usted ha retirado: " + retiro);


                    if (retiro % 5 == 0)
                    {
                        mil = retiro / 1000;
                        retiro = retiro % 1000;
                        quinientos = retiro / 500;
                        retiro = retiro % 500;
                        docientos = retiro / 200;
                        retiro = retiro % 200;
                        cien = retiro / 100;
                        retiro = retiro % 100;
                        Console.WriteLine("el monto en billetes de mil es:" + mil);

                        Console.WriteLine("el monto en billetes de quinientos es:" + quinientos);

                        Console.WriteLine("el monto en billetes de docientos es:" + docientos);

                        Console.WriteLine("el monto en billetes de cien es:" + cien);
                    }
                   
                }
                else
                {
                    Console.WriteLine("usted ha superado el limite de retiro");
                }
            }
        }

    }
}
