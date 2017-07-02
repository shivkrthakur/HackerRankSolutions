/*	author:@shivkrthakur  */
using System;
class Node
{
    public Node left,right;
    public int data;
    public Node(int data)
	{
        this.data=data;
        left=right=null;
    }
}
class Solution{
	static int getHeight(Node root){
      //Write your code here
        return calcSubTreeHeight(root, 0);
    }

    static int calcSubTreeHeight(Node node, int height)
    {
        int ltH = 0, rtH =0;
        
        if(node.left == null && node.right == null) return height;
        
        if(node.left != null) ltH += calcSubTreeHeight(node.left, height + 1);
        if(node.right != null) rtH += calcSubTreeHeight(node.right, height + 1);
        
        return ltH > rtH ? ltH : rtH;
    }
  
  	static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    
	static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        int height=getHeight(root);
        Console.WriteLine(height);
        
    }
}