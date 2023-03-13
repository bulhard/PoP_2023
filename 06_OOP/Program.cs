// See https://aka.ms/new-console-template for more information

using _06_OOP;
using _06_OOP.Humans;

Lion lion = new Lion();
lion.AnimalKind = AnimalKind.Mamal;

lion.AnimalKind = (AnimalKind)30;
//lion.Hunt();
//// Tiger tiger = new Tiger();
///

Student student = new Student();

student.Mark = 100;

student.Address = new Address();
student.Address.Street = "asda";
student.Address.City = "";

student.Address = new Address
{
    City = "Varna",
    Street = "S1",
    ZipCode = "123"
};