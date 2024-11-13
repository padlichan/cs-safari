using CS_Safari.Interfaces;

namespace CS_Safari.Environments
{
    public class Sky : SafariEnvironment<IFly>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is IFly flyingAnimal)
                {
                    flyingAnimal.Fly();
                }
            }
        }

    }
}

