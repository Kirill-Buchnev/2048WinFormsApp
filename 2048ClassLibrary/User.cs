namespace _2048ClassLibrary
{
    public class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
