namespace _06_OOP
{
    public class Felidae
    {
        public Felidae(int paws)
        {
            Paws = new List<string>();
        }

        public List<string> Paws { get; set; }

        public virtual void Hunt()
        {
            throw new NotImplementedException();
        }
    }
}