/*	author:@shivkrthakur  */
var index = 0;

function readLine(input){
    return input[index++];
}

function processData(input) {
    //Enter your code here
    input = input.split('\n');
    var ip = readLine(input).split(' ').map(Number);
    var N = ip[0], Q = ip[1];
    var op = [];
    for(var k = 0; k < N; k++) op[k] = new Array();
    var lastAnswer = 0;
    for(var i = 0; i < Q; i++){
        var arr = readLine(input).split(' ').map(Number);
        var x = arr[1];
        var y = arr[2];
        x = (x ^ lastAnswer) % N;
        if(arr[0] == 1){
            op[x].push(y);
        }
        else{
            var seq = op[x];
            lastAnswer = seq[y % seq.length];
            console.log(lastAnswer);
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
