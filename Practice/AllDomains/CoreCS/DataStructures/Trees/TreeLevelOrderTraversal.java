/*	author:@shivkrthakur  */
/* 
class Node 
   int data;
   Node left;
   Node right;
*/
void levelOrder(Node root) {
  Queue<Node> queue = new LinkedList<Node>();
   queue.add(root);
   while(queue.size() > 0)
   {
	   Node node = queue.remove();
	   System.out.print(node.data + " ");
	   if(node.left != null) queue.add(node.left);
	   if(node.right != null) queue.add(node.right);
   }
}
