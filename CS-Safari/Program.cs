using CS_Safari.Animals;
using CS_Safari.Environments;
using CS_Safari.Interfaces;

namespace CS_Safari
{
    internal class Program
    {
        public static void Main()
        {
            Tiger fluffy = new Tiger(80);
            Penguin penny = new Penguin(20.4f);
            Goose jeff = new Goose(3);
            Bat betty = new Bat(0.7f);

            Sky sky = new Sky();
            sky.AddAnimalInEnvironment(betty);
            sky.AddAnimalInEnvironment(jeff);
            

            sky.CheckAnimalsInEnvironment();

            Water water = new Water();
            water.AddAnimalInEnvironment(jeff);
            water.AddAnimalInEnvironment(penny);
            water.AddAnimalInEnvironment(betty);

            water.CheckAnimalsInEnvironment();

            HuntingGround hunting = new HuntingGround();
            hunting.AddAnimalInEnvironment(betty);
            hunting.AddAnimalInEnvironment(fluffy);
            hunting.AddAnimalInEnvironment(penny);

            hunting.CheckAnimalsInEnvironment();


            List<Animal> animalsToSee = new List<Animal>
                {
                  new Tiger(70),
                  new Goose(5.2f),
                  new Bat(0.9f),
                  new Goose(4),
                  new Tiger(90),
                  new Penguin(15.8f)
                };

            CompareWeight comparer = new CompareWeight(false);
            animalsToSee.Sort(comparer);

            animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.Weight}kg"));



        }
    }
}

