namespace Binary_Data_Structure
{
    public class Node
    {
        public int Data;

        public Node Left;

        public Node Right;

        public void DisplayNode()
        {
            Console.WriteLine(Data + " ");
        }
    }

    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int i)
        {
            Node newNode = new();
            newNode.Data = i;

            if (root == null) root = newNode;
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;

                    if (i < current.Data)
                    {
                        current = current.Left;

                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                        else
                        {
                            parent = current;
                            current = current.Left;

                            if (current == null)
                            {
                                parent.Left = newNode;
                                break;
                            }
                            else
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                    else
                    {
                        current = current.Right;

                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                        else
                        {
                            parent.Right = current;
                        }
                    }
                }
            }
        }

        public void InOrder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }

        public void PreOrder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                theRoot.DisplayNode();
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
            }
        }

        public void PostOrder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                theRoot.DisplayNode();
            }
        }

        public int FindMin()
        {
            Node current = root;

            while (!(current.Left == null))
            {
                current = current.Left;
            }

            return current.Data;
        }

        public int FindMax()
        {
            Node current = root;

            while (!(current.Right == null))
            {
                current = current.Right;
            }

            return current.Data;
        }

        public Node Find(int key)
        {
            Node current = root;

            while (current.Data != key)
            {
                if (key < current.Data)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }

                if (current == null)
                {
                    return null;
                }
            }

            return current;
        }

        private Node Delete(Node root, Node deleteNode)
        {
            if (root == null) 
            {
                return root;
            }

            if (deleteNode.Data < root.Data)
            {
                root.Left = Delete(root.Left, deleteNode);
            }

            if (deleteNode.Data > root.Data)
            {
                root.Right = Delete(root.Right, deleteNode);
            }

            if (deleteNode.Data == root.Data)
            {
                // No child nodes
                if (root.Left == null && root.Right == null)
                {
                    root = null;

                    return root;
                }
                // No left child
                else if (root.Left == null)
                {
                    Node temp = root;
                    root = root.Right;
                    temp = null;
                }
                // No right child
                else if (root.Right == null)
                {
                    Node temp = root;
                    root = root.Left;
                    temp = null;
                }
                // Has both child nodes
                else
                {
                    Node min = Find(root.Right.Data);
                    root.Data = min.Data;
                    root.Right = Delete(root.Right, min);
                }
            }

            return root;
        }

        public void DeleteNode(int x)
        {
            Node deleteNode = new()
            {
                Data = x
            };

            Delete(root, deleteNode);
        }
    }
}
