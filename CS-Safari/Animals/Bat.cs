using CS_Safari.Interfaces;

namespace CS_Safari.Animals
{
    public class Bat : Mammal, IFly, IHunt
    {
        public Bat(float weight) : base(weight)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{this.GetType().Name} is flying at night! Spooky!");
        }

        //public void Hunt()
        //{
        //    Console.WriteLine($"{this.GetType().Name} is hunting at night! Run for your life!");


        //}

        public override void MakeSound()
        {
            Console.WriteLine($"{this.GetType().Name} is fluttering!");
        }
    }
}
