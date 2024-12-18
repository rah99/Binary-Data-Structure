using Binary_Data_Structure;

// Course @ https://youtu.be/Hb0ROzKywW4

#region Binary Tree

BinarySearchTree nums = new();
nums.Insert(23);
nums.Insert(45);
nums.Insert(16);
nums.Insert(37);
nums.Insert(3);
nums.Insert(99);
nums.Insert(22);

Console.WriteLine("InOrder traversal: ");
nums.InOrder(nums.root);
Console.WriteLine();

Console.WriteLine("PreOrder traversal: ");
nums.PreOrder(nums.root);
Console.WriteLine();

Console.WriteLine("PostOrder traversal: ");
nums.PostOrder(nums.root);
Console.WriteLine();

Console.WriteLine("Max: " + nums.FindMax());

Console.WriteLine("Min: " + nums.FindMin());

Console.WriteLine("Find ninety nine: " + nums.Find(99).Data);

// Delete a node from a binary search tree
Console.WriteLine("Delete a node with children: node 23");
nums.DeleteNode(23);
Console.WriteLine("InOrder traversal: ");
nums.InOrder(nums.root);
Console.WriteLine();

// Stop app from closing after running above
Console.ReadLine();

#endregion
