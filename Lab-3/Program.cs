using Lab_3.Deque;
using Lab_3.Queue;
using Lab_3.Set;
using Lab_3.Stack;

namespace Lab_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Настройка консоли
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            //Готовый к использованию экземпляр стека
            AbstractStack<int> stack = new Lab_3.Stack.Stack<int>();

            //Готовый к использованию экземпляр очереди
            AbstractQueue<int> queue = new Lab_3.Queue.Queue<int>();

            //Готовый к использованию экземпляр дека
            AbstractDeque<int> deque = new Lab_3.Deque.Deque<int>();

            //Готовый к использованию экземпляр множества
            AbstractSet<int> set = new Lab_3.Set.Set<int>();

            //Реализация решения задачи открывающих и закрывающих фигурных скобок с применением стека
            string correctInput = "{ { } { { } } }";
            string incorrectInput = "{ { } { { } } } }";

            bool isValid = ValidateBrackets(correctInput);

            Console.WriteLine($"Строка \"{correctInput}\" {(isValid ? "- корректна" : "- некорректна")}.\n\n");

            isValid = ValidateBrackets(incorrectInput);

            Console.WriteLine($"Строка \"{incorrectInput}\" {(isValid ? "- корректна" : "- некорректна")}.\n\n");

        }

        static bool ValidateBrackets(string input)
        {
            AbstractStack<char> stack = new Lab_3.Stack.Stack<char>();

            foreach (char c in input)
            {
                if (c == '{')
                {
                    stack.Push(c);
                }
                else if (c == '}')
                {
                    if (stack.IsEmpty())
                        return false;

                    stack.Pop();
                }
            }
            return stack.IsEmpty();
        }
    }
}
