/*	author:@shivkrthakur  */
/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  
The Node class is defined as follows:
    class Node {
        int data;
        Node left;
        Node right;
     }
*/
    boolean checkBST(Node root) {
        return checkBST(root, Integer.MIN_VALUE, Integer.MAX_VALUE);
    }
    
    boolean checkBST(Node root, int minValue, int maxValue)
    {
        return ((root == null) || (root.data > minValue && root.data < maxValue && checkBST(root.left, minValue, root.data) && checkBST(root.right, root.data, maxValue)));
    }
