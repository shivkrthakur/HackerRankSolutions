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
    var n_temp = readLine().split(' ');
    var n = parseInt(n_temp[0]);
    var m = parseInt(n_temp[1]);
    var arr = [];
    for(var a0 = 0; a0 < m; a0++){
        var a_temp = readLine().split(' ');
        var a = parseInt(a_temp[0]);
        var b = parseInt(a_temp[1]);
        var k = parseInt(a_temp[2]);
        if(typeof arr[a] === "undefined") arr[a] = 0;
        if(typeof arr[b + 1] === "undefined") arr[b + 1] = 0;
        arr[a] += k;
        if(b < n) arr[b + 1] -= k;
    }
    var runningSum = 0;
    var output = 0;
    for(var i = 1; i <= n; i++){
        if(typeof arr[i] === "undefined") arr[i] = 0;
        runningSum += arr[i];
        output = Math.max(output, runningSum);
    }
    console.log(output);
}
