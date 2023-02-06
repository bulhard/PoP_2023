using Animals;

var c1 = Dog.Count;

Dog dog1 = new Dog(12, "Unnamed dog");

c1 = Dog.Count;

dog1.Name = "Harry";
dog1.Bark();

dog1.Name = "";

dog1.Name = "Maria";
dog1.Bark();

var dog2 = new Dog();

c1 = Dog.Count;

Cat cat = new Cat();

cat.Age = 11;