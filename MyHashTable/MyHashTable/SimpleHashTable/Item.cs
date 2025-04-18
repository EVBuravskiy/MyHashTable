namespace MyHashTable.SimpleHashTable
{
    public class Item<T>
    {
        public int Key { get; set; }
        public List<T> Items { get; set; }

        public Item(int key)
        {
            Items = new List<T>();
            Key = key;
        }
    }
}
