namespace _06_OOP
{
    public class Lion : Felidae
    {
        public Lion() : base(1)
        {
            Color = "red";
        }

        public string Color { get; set; }

        public override void Hunt()
        {
            var s = "";

            base.Hunt();
        }
    }
}