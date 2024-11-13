using CS_Safari.Interfaces;

namespace CS_Safari.Environments
{
    public class Water : SafariEnvironment<ISwim>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is ISwim swimAnimal)
                {
                    swimAnimal.Swim();
                }
            }
        }

    }
}

