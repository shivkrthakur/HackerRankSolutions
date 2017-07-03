/*	author:@shivkrthakur  */
process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {
    input_stdin += data;
});

process.stdin.on('end', function () {
    input_stdin_array = input_stdin.split("\n");
    main();
});
function readLine() {
    return input_stdin_array[input_currentline++];
}
function Node(data){
    this.data=data;
    this.next=null;
}
function Solution(){
this.removeDuplicates=function(head){
  //Write your code here
    var start = head;
    while(start){
        if(start.next)
        {
            if(start.data === start.next.data){
                start.next = start.next.next;
                continue;
            }
        }
        start = start.next;
    }
    return head;
}
this.insert=function(head,data){
      var p=new Node(data);
      if(head==null){
          head=p;
      }
      else if(head.next==null){
          head.next=p;
      }
      else{
          var start=head;
          while(start.next!=null){
              start=start.next;
          }
          start.next=p;
      }
      return head;

  };

this.display=function(head){
      var start=head;
          while(start){
              process.stdout.write(start.data+" ");
              start=start.next;
          }
  };
}

function main(){
  var T=parseInt(readLine());
  var head=null;
  var mylist=new Solution();
  for(i=0;i<T;i++){
      var data=parseInt(readLine());
      head=mylist.insert(head,data);
  }
  head=mylist.removeDuplicates(head);
  mylist.display(head);
}
