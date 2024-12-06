namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Настройка консоли
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            var tree = new AVLTree<int, string>();

            tree.Insert(10, "Ten");
            tree.Insert(20, "Twenty");
            tree.Insert(5, "Five");
            tree.Insert(15, "Fifteen");

            Console.WriteLine("Значение для ключа 10: " + tree.Search(10));

            Console.WriteLine("Минимальный ключ: " + tree.MinKey());
            Console.WriteLine("Максимальный ключ: " + tree.MaxKey());

            tree.Delete(10);
            Console.WriteLine("Удаление ключа 10.");

            Console.WriteLine("\nInOrder:");
            tree.InOrderTraversal();

            Console.WriteLine("\nLevelOrder:");
            tree.LevelOrderTraversal();
        }
    }
}
