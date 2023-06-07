namespace EspacioEmpleado;

public class Empleado
{
    private string nombre = String.Empty;
    private string apellido = String.Empty;
    private DateTime fechaNacimineto;
    private char estadoCivil;
    private char genero;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimineto { get => fechaNacimineto; set => fechaNacimineto = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public cargos Cargo { get => cargo; set => cargo = value; }

    public enum cargos
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5,
    }
    public Empleado()
    {

    }
    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, char genero,
                        DateTime fechaIngreso, double sueldoBasico, cargos cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimineto = fechaNacimiento;
        EstadoCivil = estadoCivil;
        Genero = genero;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }

    public int antiguedad;
    public int Antiguedad
    {
        get { return fechaIngreso.Year; }
        set { antiguedad = DateTime.Now.Year - fechaIngreso.Year; }
    }

    public int Edad(DateTime Today)
    {
        return (Today.Subtract(FechaNacimineto).Days / 365);
    }

    public int Jubilacion()
    {
        int faltante;
        if (genero == 'M' || genero == 'm')
        {
            faltante = 65 - Edad(DateTime.Today);
            if (Edad(DateTime.Today) < 65)
            {
                return faltante;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            faltante = 60 - Edad(DateTime.Today);
            if (faltante < 60)
            {
                return faltante;
            }
            else
            {
                return 0;
            }
        }
    }

    public double Salario()
    {
        double adicional = 0;
        double ant, car, cas;

        if (antiguedad < 20)
        {
            ant = (sueldoBasico * (antiguedad / 100));

        }
        else
        {
            ant = (sueldoBasico * 0.25);
        }

        switch (cargo)
        {
            case Empleado.cargos.Especialista:
                car = (sueldoBasico * 0.50);
                break;
            case Empleado.cargos.Ingeniero:
                car = (sueldoBasico * 0.50);
                break;
            default:
                car = 0;
                break;
        }

        if (estadoCivil == 'c' || estadoCivil == 'C')
        {
            cas = 15000;
        }
        else
        {
            cas = 0;
        }

        adicional = ant + car + cas;
        return (sueldoBasico + adicional);
    }

    public string MostrarDatos()
    {
        return ("\nEMPLEADO PRONTO A JUBILARSE\n\nNombre: " + Nombre + "\nApellido: " + Apellido +
                "\nFecha de Nacimiento: " + FechaNacimineto.ToShortDateString() + "\nEstado Civil: " +
                EstadoCivil + "\nGenero: " + Genero + "\nFecha de Ingreso: " + FechaIngreso.ToShortDateString() +
                "\nCargo: " + Cargo + "\nSueldo Basico: $" + SueldoBasico + "\nSalario Total: $" + Salario());
    }

}

