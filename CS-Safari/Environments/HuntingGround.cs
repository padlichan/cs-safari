using CS_Safari.Interfaces;

namespace CS_Safari.Environments
{
    public class HuntingGround : SafariEnvironment<IHunt>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is IHunt huntingAnimal)
                {
                    huntingAnimal.Hunt();
                }
            }
        }

    }
}

