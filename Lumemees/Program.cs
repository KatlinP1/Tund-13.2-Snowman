using System;

namespace Lumemees
//tal on nimi, mass (int mass=10)
//ja ta sulab, kui temepratuur on kõrgem kui 0 ja kaotab 20% oma massist
//lumemees seisab 3 päeva, temperatuur väljas on  -5 kuni +10
//kolme päeva pärast kuva lumemehe lõplik mass 

{
    class Program
    {
        
        static void Main(string[] args)
        {
            Snowman snowman=new Snowman("Olaf");
            Console.WriteLine($"Hello! i´m {snowman.Name}");
            Random rnd= new Random();

            for (int i = 0; i < 3; i++)
            {
                int temperature = rnd.Next(-5, 11);
                Console.WriteLine($"It's {temperature} degree today.'");
                snowman.Melt(temperature);
            }

            Console.WriteLine($"The mass of the snowman after three days: {snowman.Mass}");
        }
    }
}