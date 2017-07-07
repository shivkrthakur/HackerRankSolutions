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
    var a = readLine();
    var b = readLine();
    var charsA = [];
    var charsB = [];
    var aVal = 'a'.charCodeAt(0);
    for(var i = 0; i < a.length; i++){
        var rVal = a.charCodeAt(i);
        if(charsA[rVal - aVal]) charsA[rVal - aVal]++;
        else charsA[rVal - aVal] = 1;
    }
    for(var i = 0; i < b.length; i++){
        var rVal = b.charCodeAt(i);
        if(charsB[rVal - aVal]) charsB[rVal - aVal]++;
        else charsB[rVal - aVal] = 1;
    }

    var tSum = 0;
    for(var i = 0; i < 26; i++){
        tSum += Math.abs((charsA[i] || 0) - (charsB[i] || 0));
    }
    console.log(tSum);
}
