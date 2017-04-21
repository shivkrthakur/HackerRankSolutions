using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution 
{
	/*	author:@shivkrthakur  */
	public static Node insert(Node head,int data)
	{
        Node start = head;
        if(start == null) return new Node(data);
        while(start != null)
        {
            if(start.next == null)
            {
                start.next = new Node(data);
                start = start.next;
            }
            start = start.next;
        }
        return head;
    }
	
	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}
	
	