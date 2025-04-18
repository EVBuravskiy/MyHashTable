namespace MyHashTable.SimpleHashTable
{
    public class SimpleHashTable<T>
    {
        private Item<T>[] items;

        public SimpleHashTable(int size)
        {
            items = new Item<T>[size];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }

        public void Add(T item)
        {
            int key = GetHash(item);
            items[key].Items.Add(item);
        }

        public bool Find(T item)
        {
            int key = GetHash(item);
            return items[key].Items.Contains(item);
        }

        public void Remove(T item)
        {
            int key = GetHash(item);
            items[key].Items.Remove(item);
        }

        private int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}
