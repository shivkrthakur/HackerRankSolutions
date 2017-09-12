/*	author:@shivkrthakur  */
/* 
class Node 
   int data;
   Node left;
   Node right;
*/
void topView(Node root) {
	topLeftView(root.left);
	System.out.print(root.data + " ");
	topRightView(root.right);
}

void topLeftView(Node root)
{
	if(root == null) return;
	topLeftView(root.left);
	System.out.print(root.data + " ");
}

void topRightView(Node root)
{
	if(root == null) return;
	System.out.print(root.data + " ");
	topRightView(root.right);
}
