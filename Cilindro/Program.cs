using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.WriteLine("Diz a Altura do cilindro");
          double Altura = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Diz o Raio do cilindro");
          double Raio = Convert.ToDouble(Console.ReadLine());

          double Volume = Math.PI * (Raio * Raio) * Altura;
          Console.WriteLine("Volume " + Volume);

          double Area = 2 * Math.PI * Raio * (Raio + Altura);

          Console.WriteLine("Área " + Area);

        }
    }
}
