/*	author:@shivkrthakur  */
void Main()
{
	BinaryTree tree = new BinaryTree();
	tree.root = new Node(7);
	tree.root.left = new Node(4);
	tree.root.left.left = new Node(4);
	tree.root.left.right = new Node(6);
	tree.root.right = new Node(11);
	tree.root.right.left = new Node(9);
	tree.root.right.right = new Node(14);
	var root = tree.root;
	Console.WriteLine(tree.IsBST(root) ? "Yes" : "No");
	Console.WriteLine(tree.IsBSTUsingInOrderTraversal(root) ? "Yes" : "No");
}

class BinaryTree
{
	Node prevNode = null;
	public Node root = null;

	public Node Insert(Node root, int data)
	{
		if(root == null) root = new Node(data);
		else
		{
			if(data < root.data)
			{
				if(root.left == null) root.left = new Node(data);
				else Insert(root.left, data);
			}
			else if(data > root.data)
			{
				if(root.right == null) root.right = new Node(data);
				else Insert(root.right, data);
			}
		}
		return root;
	}

	public bool IsBST(Node root)
	{
		return CheckBST(root, Int32.MinValue, Int32.MaxValue);
	}

	bool CheckBST(Node root, int min, int max)
	{
		return ((root == null) || (min < root.data && root.data < max && CheckBST(root.left, min, root.data) && CheckBST(root.right, root.data, max)));
	}

	public bool IsBSTUsingInOrderTraversal(Node root)
	{
		if(root == null) return true;
		if(!IsBSTUsingInOrderTraversal(root.left)) return false;
		if(prevNode != null && prevNode.data >= root.data) return false;
		prevNode = root;
		return IsBSTUsingInOrderTraversal(root.right);
	}
}

class Node
{
	public int data;
	public Node left, right;

	public Node(int data)
	{
		this.data = data;
		this.left = this.right = null;
	}
}
