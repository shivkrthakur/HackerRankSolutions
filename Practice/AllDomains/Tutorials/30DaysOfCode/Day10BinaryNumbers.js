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
    var n = parseInt(readLine());
    var rem = [];
    do{
        rem.push(n % 2);
        n = parseInt(n / 2);
    }while(n > 0);
    var onesCount = 0, high = 0;
    for(var i = 0; i < rem.length; i++){
        if(rem[i] == 0) onesCount = 0;
        else onesCount++;
        high = Math.max(high, onesCount);
    }
    console.log(high);
}
