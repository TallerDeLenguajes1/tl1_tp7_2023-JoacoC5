// See https://aka.ms/new-console-template for more information

using EspacioEmpleado;

internal class Program
{
    private static void Main(string[] args)
    {
        CargaEmpleados();
    }
    private static void CargaEmpleados()
    {
        Empleado futbolista = new Empleado();
        futbolista.Nombre = "Lionel Andres";
        futbolista.Apellido = "Messi";
        futbolista.FechaNacimineto = new DateTime(1987, 6, 24);
        futbolista.EstadoCivil = 'C';
        futbolista.Genero = 'M';
        futbolista.FechaIngreso = new DateTime(2005, 8, 17);
        futbolista.SueldoBasico = 100000;
        futbolista.Cargo = Empleado.cargos.Especialista;
        double sueldoTotalF = futbolista.Salario();

        Empleado basquetbolista = new Empleado();
        basquetbolista.Nombre = "Emanuel Daviv";
        basquetbolista.Apellido = "Ginobili";
        basquetbolista.FechaNacimineto = new DateTime(1977, 7, 28);
        basquetbolista.EstadoCivil = 'C';
        basquetbolista.Genero = 'M';
        basquetbolista.FechaIngreso = new DateTime(1998, 6, 30);
        basquetbolista.SueldoBasico = 60000;
        basquetbolista.Cargo = Empleado.cargos.Ingeniero;
        double sueldoTotalB = basquetbolista.Salario(); ;

        Empleado hockista = new Empleado();
        hockista.Nombre = "Luciana Paula";
        hockista.Apellido = "Aymar";
        hockista.FechaNacimineto = new DateTime(1977, 8, 10);
        hockista.EstadoCivil = 'C';
        hockista.Genero = 'F';
        hockista.FechaIngreso = new DateTime(1998, 5, 20);
        hockista.SueldoBasico = 75000;
        hockista.Cargo = Empleado.cargos.Administrativo;
        double sueldoTotalH = hockista.Salario();

        double TotalSalarios = sueldoTotalF + sueldoTotalB + sueldoTotalH;


        if (futbolista.Jubilacion() < basquetbolista.Jubilacion())
        {
            if (futbolista.Jubilacion() < hockista.Jubilacion())
            {
                Console.WriteLine(futbolista.MostrarDatos());

            }
            else
            {
                Console.WriteLine(hockista.MostrarDatos());
            }
        }
        else
        {
            if (basquetbolista.Jubilacion() < hockista.Jubilacion())
            {
                Console.WriteLine(basquetbolista.MostrarDatos());

            }
            else
            {
                Console.WriteLine(hockista.MostrarDatos());
            }
        }


        Console.WriteLine("\n\nMonto Total en concepto de Salarios: $" + TotalSalarios);

    }



}

