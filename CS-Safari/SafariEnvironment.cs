namespace CS_Safari
{
    public abstract class SafariEnvironment<IEnvironment>
    {
        protected List<Animal> animalsInEnvironment = new List<Animal>();

        public abstract void CheckAnimalsInEnvironment();

        public void AddAnimalInEnvironment(Animal animal)
        {
            this.animalsInEnvironment.Add(animal);
        }
    }
}

