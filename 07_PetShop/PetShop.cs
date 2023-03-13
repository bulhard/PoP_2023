namespace _07_PetShop
{
    public class PetShop
    {
        public PetShop()
        {
            Pets = new List<Pet>();
        }

        public List<Pet> Pets { get; set; }

        public void Init()
        {
            Pets.Add(new Pet { Name = "Pet 1", AnimalKind = AnimalKind.Bird, Age = 11, MaxAge = 20 });
            Pets.Add(new Pet { Name = "Pet 2", AnimalKind = AnimalKind.Bird, Age = 12, MaxAge = 20 });
            Pets.Add(new Pet { Name = "Pet 3", AnimalKind = AnimalKind.Bird, Age = 13, MaxAge = 20 });
            Pets.Add(new Pet { Name = "Pet 4", AnimalKind = AnimalKind.Bird, Age = 14, MaxAge = 20 });
            Pets.Add(new Pet { Name = "Pet 5", AnimalKind = AnimalKind.Amphibian, Age = 15, MaxAge = 20 });
            Pets.Add(new Pet { Name = "Pet 6", AnimalKind = AnimalKind.Amphibian, Age = 16, MaxAge = 20 });
            Pets.Add(new Pet { Name = "Pet 7", AnimalKind = AnimalKind.Amphibian, Age = 17, MaxAge = 20 });
            Pets.Add(new Pet { Name = "Pet 8", AnimalKind = AnimalKind.Amphibian, Age = 18, MaxAge = 20 });
            Pets.Add(new Pet { Name = "Pet 9", AnimalKind = AnimalKind.Amphibian, Age = 19, MaxAge = 20 });
            Pets.Add(new Pet { Name = "Pet 10", AnimalKind = AnimalKind.Mamal, Age = 20, MaxAge = 60 });
            Pets.Add(new Pet { Name = "Pet 11", AnimalKind = AnimalKind.Mamal, Age = 21, MaxAge = 60 });
            Pets.Add(new Pet { Name = "Pet 12", AnimalKind = AnimalKind.Mamal, Age = 22, MaxAge = 80 });
            Pets.Add(new Pet { Name = "Pet 13", AnimalKind = AnimalKind.Mamal, Age = 23, MaxAge = 80 });
            Pets.Add(new Pet { Name = "Pet 14", AnimalKind = AnimalKind.Reptile, Age = 24, MaxAge = 80 });
            Pets.Add(new Pet { Name = "Pet 15", AnimalKind = AnimalKind.Reptile, Age = 25, MaxAge = 80 });
            Pets.Add(new Pet { Name = "Pet 16", AnimalKind = AnimalKind.Reptile, Age = 26, MaxAge = 30 });
            Pets.Add(new Pet { Name = "Pet 17", AnimalKind = AnimalKind.Reptile, Age = 27, MaxAge = 90 });
            Pets.Add(new Pet { Name = "Pet 18", AnimalKind = AnimalKind.Invertebrate, Age = 28, MaxAge = 320 });
            Pets.Add(new Pet { Name = "Pet 19", AnimalKind = AnimalKind.Invertebrate, Age = 29, MaxAge = 120 });
            Pets.Add(new Pet { Name = "Pet 20", AnimalKind = AnimalKind.Invertebrate, Age = 30, MaxAge = 220 });
        }

        public void AddNewPet()
        {
            Pet newPet = new Pet();
            Console.Clear();

            Console.WriteLine("0 = Mamal");
            Console.WriteLine("1 = Fish");
            Console.WriteLine("2 = Amphibian");
            Console.WriteLine("3 = Reptile");
            Console.WriteLine("4 = Bird");
            Console.WriteLine("5 = Invertebrate");

            Console.Write("Kind: ");
            newPet.AnimalKind = (AnimalKind)int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            newPet.Name = Console.ReadLine();

            Console.Write("Age: ");
            newPet.Age = int.Parse(Console.ReadLine());

            Console.Write("Max Age: ");
            newPet.MaxAge = int.Parse(Console.ReadLine());

            Pets.Add(newPet);
        }

        public void ShowPets()
        {
            Console.Clear();
            foreach (var pet in Pets)
            {
                Console.WriteLine(pet);
            }
            Console.ReadKey();
        }

        public void SellPet()
        {
            Console.Clear();
            Console.Write("Name: ");
            string petName = Console.ReadLine();

            var pet = Pets.Where(p => p.Name == petName).FirstOrDefault();
            if (pet != null)
            {
                if (pet.Quantity > 1)
                {
                    pet.Quantity--;

                    Console.Write($"Pet '{petName}' quantity reduced.");
                }
                else
                {
                    Pets.Remove(pet);

                    Console.Write($"Pet '{petName}' removed.");
                }
            }
            else
            {
                Console.Write($"Pet '{petName}' not found.");
            }

            Console.ReadKey();
        }

        public void SearchPet()
        {
            Console.Clear();
            Console.Write("Name: ");
            string petName = Console.ReadLine();

            var pet = Pets.Where(p => p.Name == petName).FirstOrDefault();

            if (pet != null)
            {
                Console.Write($"Pet found. Details: {pet}");
            }
            else
            {
                Console.Write($"Pet '{petName}' not found.");
            }

            Console.ReadKey();
        }
    }
}