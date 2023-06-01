namespace EspacioCalculadora;

public class Calculadora
{
    private double valor;

    public Calculadora()
    {
        valor = 0;
    }

    public double Resultado { get => valor; }

    public void Suma(double sumando)
    {
        valor += sumando;
    }

    public void Resta(double restando)
    {
        valor -= restando;
    }

    public void Multiplicar(double multiplicador)
    {
        valor = valor * multiplicador;
    }

    public void Dividir(double divisor)
    {
        if (divisor != 0)
        {
            valor = valor / divisor;
        }

    }

    public void Limpiar()
    {
        valor = 0;
    }
}