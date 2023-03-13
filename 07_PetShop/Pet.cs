namespace _07_PetShop
{
    public class Pet : Animal, IStock
    {
        public double Price { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public AgeStage AgeStage
        {
            get
            {
                double aging = (double)Age / (double)MaxAge * 100;

                if (aging < 20)
                {
                    return AgeStage.Young;
                }
                else if (aging > 70)
                {
                    return AgeStage.Old;
                }
                return AgeStage.Midage;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age}/{MaxAge} ({AgeStage}) Kind: {AnimalKind} Price: {Price} Quantity: {Quantity}";
        }
    }
}