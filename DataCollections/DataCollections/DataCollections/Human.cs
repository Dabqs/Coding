namespace DataCollections
{
    internal class Human
    {
        private string name;
        public Human(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}