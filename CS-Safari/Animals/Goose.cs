using CS_Safari.Interfaces;

namespace CS_Safari.Animals
{
    public class Goose : Bird, IFly, ISwim
    {
        public Goose(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.GetType().Name} is honking!");
        }

        public void Fly()
        {
            Console.WriteLine($"{this.GetType().Name} is flying! Majestic!");
        }
        public void Swim()
        {
            Console.WriteLine($"{this.GetType().Name} is swimming! Adorable!!");
        }
    }
}
