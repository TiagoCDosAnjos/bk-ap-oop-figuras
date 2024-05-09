namespace OopFiguras;

class Program
{
    static void Main(string[] args)
    {
        Triangulo triangulo;
        Console.Write("Diagite o valor de X: ");
        int x= int.Parse(Console.ReadLine());

        Console.Write("Diagite o valor de Y: ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("Diagite o valor de Z: ");
        int z = int.Parse(Console.ReadLine());

        triangulo = new Triangulo(x, y, z);

        triangulo.TipoDeTriangulo();
        Console.WriteLine();

        Console.WriteLine(triangulo.ToString());
    }
}
