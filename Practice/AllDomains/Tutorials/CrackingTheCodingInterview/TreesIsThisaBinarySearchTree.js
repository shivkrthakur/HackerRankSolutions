/*	author:@shivkrthakur  */
///* //TEST CASE 1
var tree = new BinaryTree();
tree.root = new Node(7);
tree.root.left = new Node(4);
tree.root.left.left = new Node(2);
tree.root.left.right = new Node(6);
tree.root.right = new Node(11);
tree.root.right.left = new Node(9);
tree.root.right.right = new Node(14);
//console.log(tree.root);
console.log(tree.IsBST(tree.root) ? "Yes" : "No");
console.log(tree.IsBSTUsingInOrderTraversal(tree.root) ? "Yes" : "No");
//*/

/* //TEST CASE 2
var tree = new BinaryTree();
tree.root = new Node(4);
tree.root.left = new Node(4);
tree.root.right = new Node(4);
console.log(tree.root);
console.log(tree.IsBST(tree.root) ? "Yes" : "No");
console.log(tree.IsBSTUsingInOrderTraversal(tree.root) ? "Yes" : "No");
//*/

function Node(data){
  this.data = data;
  this.left = null;
  this.right = null;
}

function BinaryTree(){
  this.root = null;
  this.prevNode = null;
  this.insert = function(root, data)
  {
    if(root){
      if(data < root.data){
        if(root.left) this.insert(root.left, data);
        else root.left = new Node(data);
      }
      else {
        if(root.right) this.insert(root.right, data);
        else root.right = new Node(data);
      }
    }
    else root = new Node(data);
    return root;
  };

  this.IsBST = function(root){
    return this.IsBSTRecursive( root, Number.MIN_VALUE, Number.MAX_VALUE );
  },

  this.IsBSTRecursive = function(root, min, max){
    if(root) return (min < root.data && root.data < max && this.IsBSTRecursive(root.left, min, root.data) && this.IsBSTRecursive(root.right, root.data, max));
    return true;
  },

  this.IsBSTUsingInOrderTraversal = function(root){
    if(root){
      if(!this.IsBSTUsingInOrderTraversal(root.left)) return false;
      if(this.prevNode && this.prevNode.data >= root.data) return false;
      this.prevNode = root;
      return this.IsBSTUsingInOrderTraversal(root.right);
    }
    return true;
  }
};
