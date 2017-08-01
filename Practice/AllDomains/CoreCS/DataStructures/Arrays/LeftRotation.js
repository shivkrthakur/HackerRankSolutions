/*	author:@shivkrthakur  */
var index = 0;

function readLine(input){
    return input[index++];
}

function processData(input) {
    //Enter your code here
    var ns = readLine(input).split(' ').map(Number);
    var arr = readLine(input).split(' ').map(Number);
    var n = ns[0], s = ns[1];

    var opArr = [];
    for(var i = 0; i < n; i++){
        opArr[i] = arr[(i + s) % n];
    }
    console.log(opArr.join(' '));
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
