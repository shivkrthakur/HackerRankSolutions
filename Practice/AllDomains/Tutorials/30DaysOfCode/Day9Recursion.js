/*	author:@shivkrthakur  */
function processData(input) {
    //Enter your code here
    var n = parseInt(input);
    console.log(factorial(n));
}

function factorial(input){
   if(input == 1) return 1;
   return input * factorial(input - 1);
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
