using System.ComponentModel;

int opcion;
do
{
    Console.Clear();
    Console.WriteLine("Menu de Operaciones");
    Console.WriteLine("1. SUMA");
    Console.WriteLine("2. RESTA");
    Console.WriteLine("3. MULTIPLICACION");
    Console.WriteLine("4. DIVISION");
    Console.WriteLine("5. salir");
    Console.WriteLine("Eliga una de las siguientes opciones");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                Console.Clear();
                Console.WriteLine("SUMA");
                double primerNumero = double.MaxValue;
                double segundoNumero= double.MaxValue;
                bool continuarSuma=true;
                while (continuarSuma)
                {
                    try
                    {
                        if (primerNumero == double.MaxValue)
                        {
                            Console.WriteLine("Ingrese el primer número.");
                            primerNumero= Convert.ToDouble(Console.ReadLine());
                        }
                        if (segundoNumero == double.MaxValue)
                        {
                            Console.WriteLine("Ingrese el segundo número.");
                            segundoNumero = Convert.ToDouble(Console.ReadLine());
                        }
                        double suma = segundoNumero + primerNumero;
                        Console.WriteLine($"{primerNumero} + {segundoNumero} = {suma}.");
                        continuarSuma= false; 
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe ingresar un número." + ex.Message);
                    }
                }
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Clear ();
                Console.WriteLine("RESTA");
                double primerNumero= double.MaxValue;
                double segundoNumero= double.MaxValue;
                bool continuarResta=true;
                while (continuarResta)
                {
                    try
                    {
                        if (primerNumero == double.MaxValue)
                        {
                            Console.WriteLine("Ingrese el primer número.");
                            primerNumero=Convert.ToDouble(Console.ReadLine());
                        }
                        if (segundoNumero == double.MaxValue)
                        {
                            Console.WriteLine("Ingrese el segundo número.");
                            segundoNumero=Convert.ToDouble (Console.ReadLine());
                        }
                        double resta= primerNumero-segundoNumero;
                        Console.WriteLine($"{primerNumero} - {segundoNumero} = {resta}");
                        continuarResta = false;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe ingresar un número." + ex.Message);
                    }
                }
                Console.ReadKey();
                break;
            }
        case 3:
            {
                Console.Clear();
                Console.WriteLine("MULTIPLICACION");
                break;
            }
        case 4:
            {
                Console.Clear();
                Console.WriteLine("DIVISION");
                break;
            }
        case 5:
            {
                Console.Clear();
                opcion = 0;
                break;
            }
    }
} while (opcion != 0);