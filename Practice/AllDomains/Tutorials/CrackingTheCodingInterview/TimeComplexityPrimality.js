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

/////////////// ignore above this line ////////////////////

function main() {
    var p = parseInt(readLine());
    for(var a0 = 0; a0 < p; a0++){
        var n = parseInt(readLine());
        console.log(isPrime(n) ? "Prime" : "Not prime");
    }
}

function isPrime(n){
    if(n > 1 && (n % 2) > 0){
        for(var i = 3; i <= Math.sqrt(n); i += 2){
            if((n % i) == 0) return false;
        }
        return true;
    }else return n === 2;
}
