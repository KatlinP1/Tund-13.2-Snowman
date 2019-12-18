using System;

namespace Lumemees
{
    public class Snowman
    {
        public string name;
        public double mass =10;
        
        public Snowman(string _name)
        {
            name = _name;

        }

        public string Name
        {
            get { return name; }
        }

        public double Mass
        {
            get { return mass; }
        }

        public void Melt(int temperature)
        {
            if (temperature >= 0)
            {
                mass -= mass * 0.2;
                Console.WriteLine("Help, im melting!");
            }
        }
    }
}