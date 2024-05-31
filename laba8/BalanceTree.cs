using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class BalancedTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public int Height { get; set; }
        public BalancedTreeNode<T> Left { get; set; }
        public BalancedTreeNode<T> Right { get; set; }

        public BalancedTreeNode(T value)
        {
            Value = value;
            Height = 1;
        }
    }

    public class balancedTree<T> where T : IComparable<T>
    {
        public BalancedTreeNode<T> root;

        public void Insert(T value)
        {
            root = Insert(root, value);
        }

        private BalancedTreeNode<T> Insert(BalancedTreeNode<T> node, T value)
        {
            if (node == null)
            {
                return new BalancedTreeNode<T>(value);
            }

            int compareResult = value.CompareTo(node.Value);

            if (compareResult < 0)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (compareResult > 0)
            {
                node.Right = Insert(node.Right, value);
            }
            else
            {
                return node;
            }

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalance(node);

            if (balance > 1 && value.CompareTo(node.Left.Value) < 0)
            {
                return RotateRight(node);
            }

            if (balance < -1 && value.CompareTo(node.Right.Value) > 0)
            {
                return RotateLeft(node);
            }

            if (balance > 1 && value.CompareTo(node.Left.Value) > 0)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            if (balance < -1 && value.CompareTo(node.Right.Value) < 0)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        private int GetHeight(BalancedTreeNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            return node.Height;
        }

        private int GetBalance(BalancedTreeNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        private BalancedTreeNode<T> RotateLeft(BalancedTreeNode<T> x)
        {
            BalancedTreeNode<T> y = x.Right;
            BalancedTreeNode<T> T2 = y.Left;

            y.Left = x;
            x.Right = T2;


            x.Height = 1 + Math.Max(GetHeight(x.Left), GetHeight(x.Right));
            y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));

            return y;
        }

        private BalancedTreeNode<T> RotateRight(BalancedTreeNode<T> y)
        {
            BalancedTreeNode<T> x = y.Left;
            BalancedTreeNode<T> T2 = x.Right;
            x.Right = y;
            y.Left = T2;

            y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));
            x.Height = 1 + Math.Max(GetHeight(x.Left), GetHeight(x.Right));

            return x;
        }
        public T FindClosestValue(T target)
        {
            return FindClosestValue(root, target);
        }

        private T FindClosestValue(BalancedTreeNode<T> node, T target)
        {
            T closest = default(T);
            double minDifference = double.MaxValue;

            while (node != null)
            {
                double difference = Math.Abs(Convert.ToDouble(node.Value) - Convert.ToDouble(target));
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closest = node.Value;
                }

                if (difference == 0)
                    return node.Value;
                else if (Convert.ToDouble(node.Value) < Convert.ToDouble(target))
                    node = node.Right;
                else
                    node = node.Left;
            }

            return closest;
        }

        public List<T> ValuesFromRootToTarget(T target)
        {
            List<T> values = new List<T>();
            ValuesFromRootToTarget(root, target, values);
            return values;
        }

        private bool ValuesFromRootToTarget(BalancedTreeNode<T> node, T target, List<T> values)
        {
            if (node == null)
                return false;

            values.Add(node.Value);

            if (node.Value.Equals(target))
                return true;

            if (node.Value.CompareTo(target) > 0)
            {
                if (ValuesFromRootToTarget(node.Left, target, values))
                    return true;
            }
            else
            {
                if (ValuesFromRootToTarget(node.Right, target, values))
                    return true;
            }

            values.RemoveAt(values.Count - 1); 
            return false;
        }

        public void Delete(T value)
        {
            root = Delete(root, value);
        }

        private BalancedTreeNode<T> Delete(BalancedTreeNode<T> node, T value)
        {
            if (node == null)
                return node;

            int compareResult = value.CompareTo(node.Value);

            if (compareResult < 0)
            {
                node.Left = Delete(node.Left, value);
            }
            else if (compareResult > 0)
            {
                node.Right = Delete(node.Right, value);
            }
            else
            {
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                node.Value = FindMinValue(node.Right);

                node.Right = Delete(node.Right, node.Value);
            }

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalance(node);

            if (balance > 1 && GetBalance(node.Left) >= 0)
            {
                return RotateRight(node);
            }
            if (balance < -1 && GetBalance(node.Right) <= 0)
            {
                return RotateLeft(node);
            }
            if (balance > 1 && GetBalance(node.Left) < 0)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }
            if (balance < -1 && GetBalance(node.Right) > 0)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        private T FindMinValue(BalancedTreeNode<T> node)
        {
            T minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }
    }
}

