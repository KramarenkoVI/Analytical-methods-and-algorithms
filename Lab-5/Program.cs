namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Настройка консоли
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();

            tree.Insert(10, "Ten");
            tree.Insert(20, "Twenty");
            tree.Insert(5, "Five");
            tree.Insert(15, "Fifteen");
            tree.Insert(25, "Twenty Five");

            Console.WriteLine("Поиск значения по ключу 15: " + tree.Search(15));

            Console.WriteLine("Минимальный ключ: " + tree.MinKey());
            Console.WriteLine("Максимальный ключ: " + tree.MaxKey());

            tree.Delete(15);
            Console.WriteLine("Удаление ключа 15");

            Console.WriteLine("\nОбход дерева в глубину (InOrder):");
            tree.InOrderTraversal();

            Console.WriteLine("\nОбход дерева в глубину (PreOrder):");
            tree.PreOrderTraversal();

            Console.WriteLine("\nОбход дерева в глубину (PostOrder):");
            tree.PostOrderTraversal();

            Console.WriteLine("\nОбход дерева в ширину (LevelOrder):");
            tree.LevelOrderTraversal();
        }
    }
}
