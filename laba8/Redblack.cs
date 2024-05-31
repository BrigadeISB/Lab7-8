using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public enum Colors
    {
        Red,
        Black
    }

    public class Node
    {
        public int data;
        public Colors color;
        public Node left, right, parent;

        public Node(int data)
        {
            this.data = data;
            color = Colors.Red;
            left = right = parent = null;
        }
    }

    public class RedBlackTree
    {
        public Node root;

        public RedBlackTree()
        {
            root = null;
        }

        private void RotateLeft(Node x)
        {
            Node y = x.right;
            x.right = y.left;
            if (y.left != null)
                y.left.parent = x;
            if (y != null)
                y.parent = x.parent;
            if (x.parent == null)
                root = y;
            else if (x == x.parent.left)
                x.parent.left = y;
            else
                x.parent.right = y;
            y.left = x;
            if (x != null)
                x.parent = y;
        }

        private void RotateRight(Node x)
        {
            Node y = x.left;
            x.left = y.right;
            if (y.right != null)
                y.right.parent = x;
            if (y != null)
                y.parent = x.parent;
            if (x.parent == null)
                root = y;
            else if (x == x.parent.right)
                x.parent.right = y;
            else
                x.parent.left = y;
            y.right = x;
            if (x != null)
                x.parent = y;
        }

        private void FixViolation(Node newNode)
        {
            Node parent = null;
            Node grandParent = null;

            while (newNode != root && newNode.color != Colors.Black && newNode.parent.color == Colors.Red)
            {
                parent = newNode.parent;
                grandParent = newNode.parent.parent;

                if (parent == grandParent.left)
                {
                    Node uncle = grandParent.right;
                    if (uncle != null && uncle.color == Colors.Red)
                    {
                        grandParent.color = Colors.Red;
                        parent.color = Colors.Black;
                        uncle.color = Colors.Black;
                        newNode = grandParent;
                    }
                    else
                    {
                        if (newNode == parent.right)
                        {
                            RotateLeft(parent);
                            newNode = parent;
                            parent = newNode.parent;
                        }
                        RotateRight(grandParent);
                        SwapColors(parent, grandParent);
                        newNode = parent;
                    }
                }
                else
                {
                    Node uncle = grandParent.left;
                    if (uncle != null && uncle.color == Colors.Red)
                    {
                        grandParent.color = Colors.Red;
                        parent.color = Colors.Black;
                        uncle.color = Colors.Black;
                        newNode = grandParent;
                    }
                    else
                    {
                        if (newNode == parent.left)
                        {
                            RotateRight(parent);
                            newNode = parent;
                            parent = newNode.parent;
                        }
                        RotateLeft(grandParent);
                        SwapColors(parent, grandParent);
                        newNode = parent;
                    }
                }
            }

            root.color = Colors.Black;
        }

        private void SwapColors(Node x, Node y)
        {
            Colors temp = x.color;
            x.color = y.color;
            y.color = temp;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);
            root = InsertHelper(root, newNode);
            FixViolation(newNode);
        }

        private Node InsertHelper(Node root, Node newNode)
        {
            if (root == null)
                return newNode;

            if (newNode.data < root.data)
            {
                root.left = InsertHelper(root.left, newNode);
                root.left.parent = root;
            }
            else if (newNode.data > root.data)
            {
                root.right = InsertHelper(root.right, newNode);
                root.right.parent = root;
            }

            return root;
        }

        public int? FindMinGreaterOrEqual(int value)
        {
            return FindMinGreaterOrEqualHelper(root, value);
        }

        private int? FindMinGreaterOrEqualHelper(Node root, int value)
        {
            if (root == null)
                return null;

            if (root.data >= value)
            {
                int? leftResult = FindMinGreaterOrEqualHelper(root.left, value);
                return leftResult ?? root.data;
            }
            else
            {
                return FindMinGreaterOrEqualHelper(root.right, value);
            }
        }
        public List<int> FindPathToLeaf(int sailorsCount)
        {
            List<int> path = new List<int>();
            FindPathToLeaf(root, sailorsCount, path);
            return path;
        }

        private bool FindPathToLeaf(Node node, int sailorsCount, List<int> path)
        {
            if (node == null)
            {
                return false;
            }

            path.Add(node.data);

            if (node.data == sailorsCount || FindPathToLeaf(node.left, sailorsCount, path) || FindPathToLeaf(node.right, sailorsCount, path))
            {
                return true;
            }

            path.RemoveAt(path.Count - 1);
            return false;
        }
        public void Delete(int data)
        {
            root = DeleteHelper(root, data);
        }

        private Node DeleteHelper(Node root, int data)
        {
            if (root == null)
                return root;

            if (data < root.data)
            {
                root.left = DeleteHelper(root.left, data);
            }
            else if (data > root.data)
            {
                root.right = DeleteHelper(root.right, data);
            }
            else
            {
                if (root.left == null || root.right == null)
                {
                    Node temp = root.left != null ? root.left : root.right;
                    if (temp == null)
                    {
                        temp = root;
                        root = null;
                    }
                    else
                    {
                        root = temp;
                    }
                    temp = null;
                }
                else
                {
                    Node temp = MinValueNode(root.right);
                    root.data = temp.data;
                    root.right = DeleteHelper(root.right, temp.data);
                }
            }

            if (root == null)
                return root;

            FixViolation(root);

            return root;
        }

        private Node MinValueNode(Node node)
        {
            Node current = node;
            while (current.left != null)
            {
                current = current.left;
            }
            return current;
        }
    } 
}
