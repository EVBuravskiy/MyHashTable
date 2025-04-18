namespace MyHashTable.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        public string PersonName { get; set; }

        public int PersonAge { get; set; }

        public Person(string personName, int personAge)
        {
            PersonName = personName;
            PersonAge = personAge;
        }

        public override string ToString()
        {
            return $"{PersonName}: {PersonAge}";
        }

        public override int GetHashCode()
        {
            return PersonName.Length + PersonAge + (int)PersonName[0];
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            Person inputPerson = obj as Person;
            return PersonName.Equals(inputPerson.PersonName) && PersonAge.Equals(inputPerson.PersonAge);
        }
    }
}
