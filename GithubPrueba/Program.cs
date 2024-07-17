int opcion;
do
{
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
                break;
            }
        case 2:
            {
                Console.Clear ();
                Console.WriteLine("RESTA");
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