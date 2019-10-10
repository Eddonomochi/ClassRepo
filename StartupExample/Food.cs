namespace StartupExample
{
    public class Food
    {
        public Food(string name)
        {
            this.Name = name;
        }

        public decimal Price { get; set; }

        public string Name{ get; set; }
    }
}