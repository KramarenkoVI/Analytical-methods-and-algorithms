using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class AVLTree<TKey, TValue> where TKey : IComparable<TKey>
    {
        public class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Height { get; set; }

            public Node(TKey key, TValue value)
            {
                Key = key;
                Value = value;
                Height = 1;
            }
        }

        private Node root;

        private int Height(Node node) => node?.Height ?? 0;

        private int GetBalance(Node node) => Height(node.Left) - Height(node.Right);

        private Node RotateRight(Node y)
        {
            try
            {
                Node x = y.Left;
                Node T = x.Right;

                x.Right = y;
                y.Left = T;

                y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
                x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

                return x;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        private Node RotateLeft(Node x)
        {
            try
            {
                Node y = x.Right;
                Node T = y.Left;

                y.Left = x;
                x.Right = T;

                x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
                y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

                return y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        public void Insert(TKey key, TValue value)
        {
            try
            {
                root = InsertRec(root, key, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private Node InsertRec(Node node, TKey key, TValue value)
        {
            try
            {
                if (node == null)
                    return new Node(key, value);

                if (key.CompareTo(node.Key) < 0)
                    node.Left = InsertRec(node.Left, key, value);
                else if (key.CompareTo(node.Key) > 0)
                    node.Right = InsertRec(node.Right, key, value);
                else
                {
                    node.Value = value;
                    return node;
                }

                node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
                int balance = GetBalance(node);

                if (balance > 1 && key.CompareTo(node.Left.Key) < 0)
                    return RotateRight(node);

                if (balance < -1 && key.CompareTo(node.Right.Key) > 0)
                    return RotateLeft(node);

                if (balance > 1 && key.CompareTo(node.Left.Key) > 0)
                {
                    node.Left = RotateLeft(node.Left);
                    return RotateRight(node);
                }

                if (balance < -1 && key.CompareTo(node.Right.Key) < 0)
                {
                    node.Right = RotateRight(node.Right);
                    return RotateLeft(node);
                }

                return node;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        public TValue Search(TKey key)
        {
            try
            {
                Node node = SearchRec(root, key);
                if (node == null)
                    throw new KeyNotFoundException("Ключ не найден.");
                return node.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        private Node SearchRec(Node node, TKey key)
        {
            try
            {
                if (node == null || key.CompareTo(node.Key) == 0)
                    return node;

                if (key.CompareTo(node.Key) < 0)
                    return SearchRec(node.Left, key);

                return SearchRec(node.Right, key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        public void Delete(TKey key)
        {
            try
            {
                root = DeleteRec(root, key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private Node DeleteRec(Node node, TKey key)
        {
            try
            {
                if (node == null)
                    return node;

                if (key.CompareTo(node.Key) < 0)
                    node.Left = DeleteRec(node.Left, key);
                else if (key.CompareTo(node.Key) > 0)
                    node.Right = DeleteRec(node.Right, key);
                else
                {
                    if (node.Left == null || node.Right == null)
                    {
                        Node temp = node.Left ?? node.Right;
                        node = temp;
                    }
                    else
                    {
                        Node temp = MinValue(node.Right);
                        node.Key = temp.Key;
                        node.Value = temp.Value;
                        node.Right = DeleteRec(node.Right, temp.Key);
                    }
                }

                if (node == null)
                    return node;

                node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
                int balance = GetBalance(node);

                if (balance > 1 && GetBalance(node.Left) >= 0)
                    return RotateRight(node);

                if (balance > 1 && GetBalance(node.Left) < 0)
                {
                    node.Left = RotateLeft(node.Left);
                    return RotateRight(node);
                }

                if (balance < -1 && GetBalance(node.Right) <= 0)
                    return RotateLeft(node);

                if (balance < -1 && GetBalance(node.Right) > 0)
                {
                    node.Right = RotateRight(node.Right);
                    return RotateLeft(node);
                }

                return node;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        private Node MinValue(Node node)
        {
            try
            {
                Node current = node;
                while (current.Left != null)
                    current = current.Left;
                return current;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        public TKey MinKey()
        {
            try
            {
                if (root == null)
                    throw new InvalidOperationException("Дерево пустое.");
                return MinValue(root).Key;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        public TKey MaxKey()
        {
            try
            {
                if (root == null)
                    throw new InvalidOperationException("Дерево пустое.");
                Node current = root;
                while (current.Right != null)
                    current = current.Right;
                return current.Key;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        public void InOrderTraversal() => InOrderRec(root);
        private void InOrderRec(Node node)
        {
            try
            {
                if (node != null)
                {
                    InOrderRec(node.Left);
                    Console.WriteLine($"Ключ: {node.Key}, Значение: {node.Value}");
                    InOrderRec(node.Right);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void LevelOrderTraversal()
        {
            try
            {
                if (root == null)
                    return;

                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    Node node = queue.Dequeue();
                    Console.WriteLine($"Ключ: {node.Key}, Значение: {node.Value}");

                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
