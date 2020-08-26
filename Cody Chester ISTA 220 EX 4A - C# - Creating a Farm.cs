using System;

namespace CreatingAFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Squirtle pokemonOne = new Squirtle();
            Pikachu pokemonTwo = new Pikachu();
            Charmander pokemonThree = new Charmander();
            Bulbasaur pokemonFour = new Bulbasaur();
            
            pokemonOne.WaterGun();
            pokemonTwo.ElectricShock();
            pokemonThree.Flamethrower();
            pokemonFour.Solarbeam();

        }
    }
    class Squirtle
    {
        public void WaterGun()
        {
            Console.WriteLine("Squirtle uses Water Gun");
        }
        public void Bite()
        {
            Console.WriteLine("Squirtle uses Bite");
        }
        public void Withdraw()
        {
            Console.WriteLine("Squirtle uses Withdraw");
        }
        public void Surf()
        {
            Console.WriteLine("Squirtle uses Surf");
        }
    }
    class Pikachu
    {
        public void ElectricShock()
        {
            Console.WriteLine("Pikachu uses Electric Shock");
        }
        public void Tackle()
        {
            Console.WriteLine("Pikachu uses Tackle");
        }
        public void TailWhip()
        {
            Console.WriteLine("Pikachu uses Tail Whip");
        }
        public void Thunderbolt()
        {
            Console.WriteLine("Pikachu uses Thunderbolt");
        }
    }
    class Charmander
    {
        public void Flamethrower()
        {
            Console.WriteLine("Charmander uses Flamethorwer");
        }
        public void Tackle()
        {
            Console.WriteLine("Charmander uses Tackle");
        }
        public void Scratch()
        {
            Console.WriteLine("Charmander uses Scratch");
        }
        public void FireSpin()
        {
            Console.WriteLine("Charmander uses Fire Spin");
        }
    }
    class Bulbasaur
    {
        public void VineWhip()
        {
            Console.WriteLine("Bulbasaur uses Vine Whip");
        }
        public void LeafSpin()
        {
            Console.WriteLine("Bulbasaur uses Leaf Spin");
        }
        public void Scratch()
        {
            Console.WriteLine("Bulbasaur uses Scratch");
        }
        public void Solarbeam()
        {
            Console.WriteLine("Bulbasaur uses Solarbeam");
        }
    }
}
