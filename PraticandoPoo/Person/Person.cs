namespace PraticandoPoo.Person
{
    public class Person
    {      
        public string Name { get; set; }
        public byte Age { get; set; }

        public bool Adulthood()
        {
            if (this.Age >= 18) return true;

            return false;
        }
    }
}