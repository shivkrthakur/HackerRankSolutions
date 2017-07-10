/*	author:@shivkrthakur  */
var inputArr = [];
var index = 0;

function readLine(){
    return inputArr[index++];
}

function processData(input) {
    //Enter your code here
    inputArr = input.split('\n');
    var q = parseInt(readLine());
    var stack1 = [], stack2 = [];
    for(var i = 0; i < q; i++){
        var ip = readLine().split(' ').map(Number);
        //console.log(ip);
        if(ip[0] == 1){
            stack1.push(ip[1]);
        }
        if(ip[0] == 2){
            while(stack1.length > 0){
                stack2.push(stack1.pop())
            }
            stack2.pop();
            while(stack2.length > 0){
                stack1.push(stack2.pop())
            }
        }
        if(ip[0] == 3){
            console.log(stack1[0]);
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
   processData(_input);
});
