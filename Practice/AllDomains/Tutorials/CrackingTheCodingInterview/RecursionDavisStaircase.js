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
    var s = parseInt(readLine());
    for(var a0 = 0; a0 < s; a0++){
        var n = parseInt(readLine());
        var arr = [];
        console.log(countStairs(n, arr));
    }
}

function countStairs(n, arr){
    if(n == 0) return 1;
    if(n < 0) return 0;
    if(arr[n]) return arr[n];
    arr[n] = countStairs(n - 1, arr) + countStairs(n - 2, arr) + countStairs(n - 3, arr);
    return arr[n];
}
