using System.Collections;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Настройка консоли
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            var hashTable = new HashTable<int, string>();

            try
            {
                hashTable.Add(1, "One");
                hashTable.Add(2, "Two");
                hashTable.Add(3, "Three");
                hashTable.Add(4, "Four");
                hashTable.Add(5, "Five");
                hashTable.Add(6, "Six");

                Console.WriteLine("Хеш-таблица:");
                hashTable.PrintTable();

                Console.WriteLine("Ключ 1: " + hashTable.Get(1));
                Console.WriteLine("Ключ 2: " + hashTable.Get(2));
                Console.WriteLine("Содержит ключ 3: " + hashTable.ContainsKey(3));

                hashTable.Remove(2);
                Console.WriteLine("Удалён ключ 2.");

                try
                {
                    Console.WriteLine("Ключ 2: " + hashTable.Get(2));
                }
                catch (KeyNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Хеш-таблица после перехеширования:");
                hashTable.PrintTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
