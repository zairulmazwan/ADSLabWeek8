// See https://aka.ms/new-console-template for more information

//Part 1 - Binary Tree

BinaryTree bt = new BinaryTree();
	
int [] data = {57,20,68,15,21,65,80,60,67,70,85};

bt = BinaryTree.createBinaryTree(data);
Console.WriteLine("==Pre-order==");
bt.traversePreOrder(bt.root);
Console.WriteLine("\n==Level Order==");
bt.traverseLevelOrder();
Console.WriteLine("\n==Post Order==");
bt.traversePostOrder(bt.root);


//---------------------------------------------

//Part 2 - Binary Heap

// Heap bh = new Heap();
		
// bh.insert(47);
// bh.insert(57);
// bh.insert(23);
// bh.insert(42);
// bh.insert(31);
// bh.insert(29);
// bh.insert(17);

// System.out.println("Binary Heap : ");
// bh.printHeap();
// System.out.println("Size : ");
// System.out.println("Maximum value from the tree : ");

// System.out.println("Elements in descending order : ");