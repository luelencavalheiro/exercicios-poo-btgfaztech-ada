using System;

public abstract class Figura
{
    public string cor;
    public abstract double area();
}

public class Retangulo : Figura
{
    public double lado1;
    public double lado2;

    public override double area()
    {
        return (lado1 * lado2);
    }
}

public class Triangulo : Figura
{
    public double baseTriangulo;
    public double altura;

    public override double area()
    {
        return (baseTriangulo * altura);
    }
}

public static class Teste
{
    public static string DetalhesFigura(Figura figura)
    {
        return ($"Cor da figura: {figura.cor} - Área da figura: {figura.area()}");
    }
}