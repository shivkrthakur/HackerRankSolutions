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
    var s = readLine();
    var k = parseInt(readLine());
    var result = encrypt(s, k);
    console.log(result);
}

function encrypt(input, k){
    k = k % 26;
    var a = "a".charCodeAt(0);
    var z = "z".charCodeAt(0);
    var A = "A".charCodeAt(0);
    var Z = "Z".charCodeAt(0);
    var output = "";
    for(var c in input){
        var ascii = input.charCodeAt(c);
        if(ascii >= a && ascii <= z){
            var sum = ascii + k;
            if(sum > z) output += String.fromCharCode((a + sum - 1) % z);
            else output += String.fromCharCode(sum);
        }
        else if(ascii >= A && ascii <= Z){
            var sum = ascii + k;
            if(sum > Z) output += String.fromCharCode((A + sum - 1) % Z);
            else output += String.fromCharCode(sum);
        }
        else output += input[c];
    }
    return output;
}
