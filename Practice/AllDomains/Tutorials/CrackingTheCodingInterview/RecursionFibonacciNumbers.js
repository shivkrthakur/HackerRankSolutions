/*	author:@shivkrthakur  */
function processData(input) {
    var n = parseInt(input);
    console.log(fibonacci(n));
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

function fibonacci(input) {
    if(input <= 1) return input;
    return fibonacci(input - 1) + fibonacci(input - 2);
}
