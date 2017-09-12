/*	author:@shivkrthakur  */
/*  
   class Node
	public  int frequency; // the frequency of this tree
	public  char data;
	public  Node left, right;
*/ 
void decode(String input, Node node)
{
    int len = input.length();
	Node root = node;
	StringBuilder sb = new StringBuilder();
	int i = 0;
	while(i < len)
	{
		if(input.charAt(i) == '1')  node = node.right;
		else node = node.left;
        
		if(node.right == null && node.left == null)
		{
			sb.append(node.data); 
			node = root;
		}
		i++;
	}
	System.out.println(sb);
}
