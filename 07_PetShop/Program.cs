using _07_PetShop;

PetShop petShop = new PetShop();
petShop.Init();

string? chosenMenu = "";
do
{
    ShowMenu();
    chosenMenu = Console.ReadLine();

    switch (chosenMenu)
    {
        case "1":
            petShop.AddNewPet();
            break;

        case "2":
            petShop.SellPet();
            break;

        case "3":
            petShop.ShowPets();
            break;

        case "4":
            petShop.SearchPet();
            break;
    }
} while (chosenMenu != "5");

static void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("-------------------");
    Console.WriteLine("| 1. Add new pet  |");
    Console.WriteLine("| 2. Sell pet     |");
    Console.WriteLine("| 3. View pets    |");
    Console.WriteLine("| 4. Search pets  |");
    Console.WriteLine("| 5. Exit         |");
    Console.WriteLine("-------------------");
    Console.Write("Please enter your choice: ");
}