/*	author:@shivkrthakur  */
var index = 0;

function readLine(input){
    return input[index++];    
}

function processData(input) {
    //Enter your code here
    var n = parseInt(readLine(input));
    var stack = [], maxStack = [];
    for(var i = 0; i < n; i++){
      var arr = readLine(input).split(' ').map(Number);
      var x = arr[0];
      if(x === 1) {
        var val = arr[1];
        stack.push(val);
        if(maxStack.length > 0){
          if(maxStack[maxStack.length - 1] <= arr[1]) maxStack.push(val);
        }
        else maxStack.push(val);
      }
      else if(x == 2){
        var val = stack.pop();
        if(maxStack[maxStack.length - 1] == val) maxStack.pop();
      }
      else {
        console.log(maxStack[maxStack.length - 1]);
      }
    }
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input.split('\n'));
});
