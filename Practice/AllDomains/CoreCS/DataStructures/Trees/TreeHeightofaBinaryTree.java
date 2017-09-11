/*	author:@shivkrthakur  */
import java.util.*;
import java.io.*;
class Node {
    Node left;
    Node right;
    int data;
    
    Node(int data) {
        this.data = data;
        left = null;
        right = null;
    }
}

class Solution {
	/*
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	static int height(Node root) {
        if(root == null) return 0;
        Queue<Node> queue = new LinkedList<Node>();
        queue.add(root);
        int height = 0, nc = 1;
        while(queue.size() > 0)
        {
            int nodeCount = 0;
            while(nc-- > 0)
            {
                Node node = queue.remove();
                if(node.left != null){
                    queue.add(node.left);
                    nodeCount++;
                }
                if(node.right != null)
                {
                    queue.add(node.right);
                    nodeCount++;
                }
            }
            nc = nodeCount;
            height++;
        }
        return height - 1;
    }
    
    static int maxDepth(Node root)
    {
        if(root == null) return 0;
        int lH = maxDepth(root.left);
        int rH = maxDepth(root.right);
        return Math.max(lH, rH) + 1;
    }

	public static Node insert(Node root, int data) 
	{
        if(root == null){
            return new Node(data);
        }
        else {
            Node cur;
            if(data <= root.data){
                cur = insert(root.left, data);
                root.left = cur;
            }
            else{
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }
	
    public static void main(String[] args) 
	{
        Scanner scan = new Scanner(System.in);
        int t = scan.nextInt();
        Node root = null;
        while(t-- > 0)
		{
            int data = scan.nextInt();
            root = insert(root, data);
        }
        scan.close();
        int height = height(root);
        System.out.println(height);
    }	
}