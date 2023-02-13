using _04_Generics.AnimalShelter;


AnimalShelter<Dog> shelter1 = new AnimalShelter<Dog>(10);

Dog dog1 = new Dog();

shelter1.AddNew(dog1);


AnimalShelter<Cat> shelter2 = new AnimalShelter<Cat>(20);

Cat cat1 = new Cat();

shelter2.AddNew(cat1);

