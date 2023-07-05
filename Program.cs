using System;
using System.Globalization;

namespace segundoDesafio{
class Retangulo{
    public static void Main(string[] args){

        retangulo retangulo = new retangulo();

        Console.WriteLine(" Entre com a altura e largura do retangulo :");
        retangulo.altura = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
        retangulo.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Area : "      + retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine("Perimetro : " + retangulo.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine("Diagonal :"   + retangulo.Diagonal().ToString("F2",CultureInfo.InvariantCulture));




    }
}
}