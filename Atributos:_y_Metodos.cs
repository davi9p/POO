using System;
namespace POO_Unidad1
{
    public class Automovil
    {
        public string Marca;
        public string Modelo;
        public string Color;
        public int Anio;
        public double VelocidadActual;

        public void Acelerar(double inc)    {VelocidadActual += inc;}

        public void Frenar(double dec)
        {
        if (VelocidadActual - dec >= 0) VelocidadActual -=dec;
        else VelocidadActual = 0;
        }

        public void MostrarInformación()
        {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Año: {Anio}");
        Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");

        }

        public static void Main(string[] args)
        {
        Automovil miAuto = new Automovil();
        miAuto.Marca = "Toyota";
        miAuto.Modelo = "XL";
        miAuto.Color = "Rojo";
        miAuto.Anio = 2020;
        miAuto.VelocidadActual = 0:
        miAuto.Acelerar(20.5);
        miAuto.Frenar(15.1);
        miAuto.MostrarInformación();

        
        Automovil miMoto = new Automovil();
        miMoto.Marca = "Toyota";
        miMoto.Modelo = "TK";
        miMoto.Color = "Azul";
        miMoto.Anio = 2009;
        miMoto.VelocidadActual = 0;
        miMoto.Acelerar(21.5);
        miMoto.Frenar(1.59);
        miMoto.MostrarInformación();
        }
    }
}
