/*	author:@shivkrthakur  */
/*
Detect a cycle in a linked list. Note that the head pointer may be 'null' if the list is empty.

A Node is defined as: 
    class Node {
        int data;
        Node next;
    }
*/

boolean hasCycle(Node head) {
    if(head == null) return false;
    List dataList = new ArrayList();
    while(head != null)
    {
        if(dataList.contains(head))
            return true;
        
        dataList.add(head);
        head = head.next;   
    }
    return false;
}
