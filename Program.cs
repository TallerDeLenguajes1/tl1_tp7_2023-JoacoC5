// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

Calculadora cal = new Calculadora();
int seguir = 1;

do
{
    Console.WriteLine("-----Calculadora Basica-----\n");
    Console.WriteLine("1.Suma\n2.Resta\n3.Multiplicacion\n4.Division\n5.Limpiar");
    int operacion;
    int.TryParse(Console.ReadLine(), out operacion);

    Console.WriteLine("\nIngrese un numero: ");
    double x;
    bool control = double.TryParse(Console.ReadLine(), out x);

    if (control)
    {
        switch (operacion)
        {
            case 1:
                cal.Suma(x);
                break;
            case 2:
                cal.Resta(x);
                break;
            case 3:
                cal.Multiplicar(x);
                break;
            case 4:
                cal.Dividir(x);
                break;
            case 5:
                cal.Limpiar();
                break;
            default:
                Console.WriteLine("\nOperacioon no valida\n");
                break;
        }

        Console.WriteLine("Resultado: " + cal.Resultado);
    }
    else
    {
        Console.WriteLine("\nNo se ingreso un numero");
    }

    Console.WriteLine("¿Desea realizar otra operacion? //1 = si //");
    int.TryParse(Console.ReadLine(), out seguir);

} while (seguir == 1);
