using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class HashTable<TKey, TValue> where TKey : IEquatable<TKey>
    {
        private const double LoadFactorThreshold = 0.75;
        private const int InitialCapacity = 16;

        private int count;
        private int capacity;
        private LinkedList<KeyValuePair<TKey, TValue>>[] table;

        public HashTable()
        {
            capacity = InitialCapacity;
            table = new LinkedList<KeyValuePair<TKey, TValue>>[capacity];
            count = 0;
        }

        private int Hash(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % capacity;
        }

        private void Rehash()
        {
            Console.WriteLine("Перехеширование...");
            int oldCapacity = capacity;
            var oldTable = table;

            capacity *= 2;
            table = new LinkedList<KeyValuePair<TKey, TValue>>[capacity];
            count = 0;

            foreach (var bucket in oldTable)
            {
                if (bucket != null)
                {
                    foreach (var kvp in bucket)
                    {
                        Add(kvp.Key, kvp.Value);
                    }
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (LoadFactor() >= LoadFactorThreshold)
            {
                Rehash();
            }

            int index = Hash(key);
            if (table[index] == null)
            {
                table[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }

            foreach (var kvp in table[index])
            {
                if (kvp.Key.Equals(key))
                {
                    var node = table[index].Find(kvp);
                    node.Value = new KeyValuePair<TKey, TValue>(key, value);
                    return;
                }
            }

            table[index].AddLast(new KeyValuePair<TKey, TValue>(key, value));
            count++;
        }

        public TValue Get(TKey key)
        {
            int index = Hash(key);
            if (table[index] != null)
            {
                foreach (var kvp in table[index])
                {
                    if (kvp.Key.Equals(key))
                    {
                        return kvp.Value;
                    }
                }
            }

            throw new KeyNotFoundException($"Ключ {key} не найден.");
        }

        public void Remove(TKey key)
        {
            int index = Hash(key);
            if (table[index] != null)
            {
                var bucket = table[index];
                foreach (var kvp in bucket)
                {
                    if (kvp.Key.Equals(key))
                    {
                        bucket.Remove(kvp);
                        count--;
                        Console.WriteLine($"Удален ключ: {key}");
                        return;
                    }
                }
            }

            throw new KeyNotFoundException($"Ключ {key} не найден.");
        }

        private double LoadFactor()
        {
            return (double)count / capacity;
        }

        public bool ContainsKey(TKey key)
        {
            int index = Hash(key);
            if (table[index] != null)
            {
                foreach (var kvp in table[index])
                {
                    if (kvp.Key.Equals(key))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void PrintTable()
        {
            for (int i = 0; i < capacity; i++)
            {
                if (table[i] != null)
                {
                    Console.WriteLine($"Индекс {i}:");
                    foreach (var kvp in table[i])
                    {
                        Console.WriteLine($"  Ключ: {kvp.Key}, Значение: {kvp.Value}");
                    }
                }
            }
        }
    }
}
