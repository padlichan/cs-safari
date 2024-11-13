using CS_Safari.Environments;

namespace CS_Safari.Interfaces
{
    public interface IHunt
    {
        public void Hunt()
        {
            if(this is IFly flyingAnimal)
            {
                Console.WriteLine($"{this.GetType().Name} is hunting in the skies above the hunting ground!");
            }
            else if (this is ISwim swimmingAnimal)
            {
                Console.WriteLine($"{this.GetType().Name} is hunting in the waters of the hunting ground!");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} is hunting on land in the hunting ground!");
            }
        }
    }
}
