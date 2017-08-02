/*	author:@shivkrthakur  */
var index = 0;

function readLine(input){
    return input[index++];
}

function processData(input) {
    //Enter your code here
    var n = parseInt(readLine(input));
    var inputArr = [];
    for(var i = 0; i < n; i++){
        inputArr[i] = readLine(input);
    }
    var q = parseInt(readLine(input));
    for(var j = 0; j < q; j++){
        var src = readLine(input);
        var count = 0;
        for(var p = 0; p < n; p++){
            if(inputArr[p] === src) count++;
        }
        console.log(count);
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
