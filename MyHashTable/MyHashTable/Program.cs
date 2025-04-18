using MyHashTable.DictHashTable;
using MyHashTable.SimpleHashTable;
using MyHashTable.Models;

namespace MyHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========DictHashTable===========");
            DictHashTable<int, string> dictHashTable = new DictHashTable<int, string>(10);
            dictHashTable.Add(5, "Пять");
            dictHashTable.Add(18, "Восемнадцать");
            dictHashTable.Add(121, "Сто двадцать один");
            dictHashTable.Add(5, "Десять");

            Console.WriteLine(dictHashTable.FindKey(5));
            Console.WriteLine(dictHashTable.FindKey(121));

            Console.WriteLine(dictHashTable.FindElement(5, "Пять"));
            Console.WriteLine(dictHashTable.FindElement(5, "Десять"));
            Console.WriteLine(dictHashTable.FindElement(5, "Восемь"));

            dictHashTable.RemoveKey(5);

            dictHashTable.RemoveElement(18, "Восемнадцать");

            Console.WriteLine(dictHashTable.FindElement(18, "Восемнадцать"));


            Console.WriteLine("=========SimpleHashTable===========");

            SimpleHashTable<Person> simpleHashTable = new SimpleHashTable<Person>(10);
            Person person = new Person("Nik", 20);
            simpleHashTable.Add(new Person("Alex", 19));
            simpleHashTable.Add(new Person("Peter", 20));
            simpleHashTable.Add(new Person("Oleg", 25));
            simpleHashTable.Add(person);
            simpleHashTable.Add(new Person("Maria", 18));
            simpleHashTable.Add(new Person("Nastya", 20));

            Console.WriteLine(simpleHashTable.Find(person));
            Console.WriteLine(simpleHashTable.Find(new Person("Maria", 18)));
            simpleHashTable.Remove(new Person("Oleg", 25));
            Console.WriteLine(simpleHashTable.Find(new Person("Oleg", 25)));

        }
    }
}