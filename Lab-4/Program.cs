namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Настройка консоли
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            //Готовый к использованию экзмепляр очереди с приоритетом
            PriorityQueue<int> queue = new PriorityQueue<int>();

            //Готовый к использованию экземпляр пирамидальной сортировки
            HeapSort sort = new HeapSort();

            //sort.HeapSorting(array: arr); Ready to work :-)
        }
    }
}
