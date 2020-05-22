using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Personagem soi = new Personagem();
           soi.arma = "Suzumebachi";

           Console.WriteLine(soi.nome);

           Console.WriteLine(soi.arma);

           Console.WriteLine(soi.Atacar(30,80));

           Console.WriteLine(soi.Defender());}


    }
}
