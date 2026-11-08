using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasNoLineales
{
    internal class BinarySearchTree
    {
        public Node? Root;
        public string LastCaseMessage = "";

        public BinarySearchTree()
        {
            Root = null;
        }

        public bool Add(int id)
        {
            Node newNode = new Node(id);

            if (Root == null)
            {
                Root = newNode;
                LastCaseMessage = $"[Case 1: Empty Tree] Assigned Root = newNode ({id})";
                return true;
            }

            Node current = Root;

            while (true)
            {
                if (newNode.Id < current.Id)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        LastCaseMessage = $"[Case 2: Less than {current.Id}] Inserted {id} at current.Left";
                        return true;
                    }
                    current = current.Left;
                }
                else if (newNode.Id > current.Id)
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        LastCaseMessage = $"[Case 3: Greater than {current.Id}] Inserted {id} at current.Right";
                        return true;
                    }
                    current = current.Right;
                }
                else
                {
                    LastCaseMessage = $"[Case 4: Duplicate Key] Id {id} already exists in the tree.";
                    return false;
                }
            }
        }

        public bool Search(int id)
        {
            if (Root == null)
            {
                LastCaseMessage = "[Case 1: Search] Tree is empty (Root == null).";
                return false;
            }

            Node? current = Root;

            while (current != null)
            {
                if (current.Id == id)
                {
                    LastCaseMessage = $"[Case 2: Search] Found! current.Id == {id}";
                    return true;
                }

                if (id < current.Id)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            LastCaseMessage = $"[Case 5: Search] Id {id} not found in the tree.";
            return false;
        }

        public bool Remove(int id)
        {
            if (!Search(id))
            {
                LastCaseMessage = $"Cannot remove: Id {id} does not exist.";
                return false;
            }

            Root = RemoveRecursive(Root, id);
            return true;
        }

        private Node? RemoveRecursive(Node? current, int id)
        {
            if (current == null) return null;

            if (id < current.Id)
            {
                current.Left = RemoveRecursive(current.Left, id);
            }
            else if (id > current.Id)
            {
                current.Right = RemoveRecursive(current.Right, id);
            }
            else
            {
                if (current.Left == null && current.Right == null)
                {
                    LastCaseMessage = $"[Case 1: Delete Leaf] Removed leaf node ({id})";
                    return null;
                }

                if (current.Left == null)
                {
                    LastCaseMessage = $"[Case 2: Delete with 1 Child] Node ({id}) replaced by right child ({current.Right!.Id})";
                    return current.Right;
                }
                if (current.Right == null)
                {
                    LastCaseMessage = $"[Case 2: Delete with 1 Child] Node ({id}) replaced by left child ({current.Left!.Id})";
                    return current.Left;
                }

                Node successor = current.Right!;
                while (successor.Left != null)
                {
                    successor = successor.Left;
                }

                LastCaseMessage = $"[Case 3: Delete with 2 Children] Node ({id}) replaced by inorder successor ({successor.Id})";

                current.Id = successor.Id;
                current.Right = RemoveRecursive(current.Right, successor.Id);
            }

            return current;
        }

        public int Count()
        {
            return CountRecursive(Root);
        }

        private int CountRecursive(Node? current)
        {
            if (current == null) return 0;
            return 1 + CountRecursive(current.Left) + CountRecursive(current.Right);
        }

        public int GetHeight()
        {
            return HeightRecursive(Root);
        }

        private int HeightRecursive(Node? current)
        {
            if (current == null) return 0;
            int leftHeight = HeightRecursive(current.Left);
            int rightHeight = HeightRecursive(current.Right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }

    }
}
