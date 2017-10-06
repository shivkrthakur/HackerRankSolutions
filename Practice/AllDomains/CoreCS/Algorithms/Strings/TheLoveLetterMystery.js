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

function theLoveLetterMystery(s){
    // Complete this function
    var count = 0;
    var len = s.length;
    for(var i = 0, j = len - 1; i < len/2; i++, j--){
        if(s[i] != s[j]){
            var asciiI = s.charCodeAt(i);
            var asciiJ = s.charCodeAt(j);
            var diff = Math.abs(asciiI - asciiJ);
            count += diff;
        }
    }
    return count;
}

function main() {
    var q = parseInt(readLine());
    for(var a0 = 0; a0 < q; a0++){
        var s = readLine();
        var result = theLoveLetterMystery(s);
        process.stdout.write("" + result + "\n");
    }

}
