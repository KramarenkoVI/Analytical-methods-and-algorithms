using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class BinarySearchTree<TKey, TValue> where TKey : IComparable<TKey>
    {
        public class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(TKey key, TValue value)
            {
                Key = key;
                Value = value;
                Left = null;
                Right = null;
            }
        }

        private Node root;

        public BinarySearchTree()
        {
            root = null;
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

        private Node InsertRec(Node root, TKey key, TValue value)
        {
            try
            {
                if (root == null)
                {
                    root = new Node(key, value);
                    return root;
                }

                if (key.CompareTo(root.Key) < 0)
                {
                    root.Left = InsertRec(root.Left, key, value);
                }
                else if (key.CompareTo(root.Key) > 0)
                {
                    root.Right = InsertRec(root.Right, key, value);
                }
                else
                {
                    root.Value = value;
                }

                return root;
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
                Node result = SearchRec(root, key);
                if (result != null)
                {
                    return result.Value;
                }
                throw new KeyNotFoundException("Ключ не найден.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        private Node SearchRec(Node root, TKey key)
        {
            try
            {
                if (root == null || root.Key.CompareTo(key) == 0)
                {
                    return root;
                }

                if (key.CompareTo(root.Key) < 0)
                {
                    return SearchRec(root.Left, key);
                }

                return SearchRec(root.Right, key);
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

        private Node DeleteRec(Node root, TKey key)
        {
            try
            {
                if (root == null) return root;

                if (key.CompareTo(root.Key) < 0)
                {
                    root.Left = DeleteRec(root.Left, key);
                }
                else if (key.CompareTo(root.Key) > 0)
                {
                    root.Right = DeleteRec(root.Right, key);
                }
                else
                {
                    if (root.Left == null) return root.Right;
                    else if (root.Right == null) return root.Left;

                    root.Key = MinValue(root.Right).Key;
                    root.Right = DeleteRec(root.Right, root.Key);
                }

                return root;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        private Node MinValue(Node root)
        {
            try
            {
                Node current = root;
                while (current.Left != null)
                {
                    current = current.Left;
                }
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
                {
                    throw new InvalidOperationException("Дерево пусто.");
                }
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
                {
                    throw new InvalidOperationException("Дерево пусто.");
                }
                Node current = root;
                while (current.Right != null)
                {
                    current = current.Right;
                }
                return current.Key;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        public void InOrderTraversal()
        {
            try
            {
                InOrderRec(root);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void InOrderRec(Node root)
        {
            try
            {
                if (root != null)
                {
                    InOrderRec(root.Left);
                    Console.WriteLine($"Ключ: {root.Key}, Значение: {root.Value}");
                    InOrderRec(root.Right);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void PreOrderTraversal()
        {
            try
            {
                PreOrderRec(root);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void PreOrderRec(Node root)
        {
            try
            {
                if (root != null)
                {
                    Console.WriteLine($"Ключ: {root.Key}, Значение: {root.Value}");
                    PreOrderRec(root.Left);
                    PreOrderRec(root.Right);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void PostOrderTraversal()
        {
            try
            {
                PostOrderRec(root);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void PostOrderRec(Node root)
        {
            try
            {
                if (root != null)
                {
                    PostOrderRec(root.Left);
                    PostOrderRec(root.Right);
                    Console.WriteLine($"Ключ: {root.Key}, Значение: {root.Value}");
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
                if (root == null) return;

                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    Node node = queue.Dequeue();
                    Console.WriteLine($"Ключ: {node.Key}, Значение: {node.Value}");

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
