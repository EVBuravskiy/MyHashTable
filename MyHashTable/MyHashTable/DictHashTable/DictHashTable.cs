namespace MyHashTable.DictHashTable
{
    public class DictHashTable<TKey, TValue>
    {
        private List<TValue>[] items;
        public DictHashTable(int size)
        {
            items = new List<TValue>[size];
        }

        public void Add(TKey key, TValue value)
        {
            int hash = GetHash(key);
            if (items[hash] == null)
            {
                items[hash] = new List<TValue>() { value };
                return;
            }
            items[hash].Add(value);

        }

        public bool FindKey(TKey key)
        {
            int hash = GetHash(key);
            if (items[hash] != null && !items[hash].Equals(default(TValue)))
            {
                return true;
            }
            return false;
        }

        public bool FindElement(TKey key, TValue value)
        {
            int hash = GetHash(key);
            return items[hash]?.Contains(value) ?? false;
        }

        public void RemoveKey(TKey key)
        {
            int hash = GetHash(key);
            items[hash] = null;
        }

        public void RemoveElement(TKey key, TValue value)
        {
            int hash = GetHash(key);
            if (items[hash].Contains(value))
            {
                items[hash].Remove(value);
            }
        }


        private int GetHash(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));
        }
    }
}
