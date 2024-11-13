namespace Clases
{
    public class Persona 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Clothes { get; set; }

        public override bool EqualsInPerson (object obj)
        {
            Person? person = obj as Person;

            return person != null &&  Name == person.Name && Age == person.Age
        }
    }
}