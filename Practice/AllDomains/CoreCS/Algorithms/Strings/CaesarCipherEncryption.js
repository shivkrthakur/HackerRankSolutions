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
    var input = readLine();
    var k = parseInt(readLine());
    var output = "";
    var a = "a".charCodeAt(0);
    var z = "z".charCodeAt(0);
    var A = "A".charCodeAt(0);
    var Z = "Z".charCodeAt(0);
    k = k % 26;
    for(var i = 0; i < input.length; i++){
        var ascii = input.charCodeAt(i);
        var char = input[i];

        if(ascii >= a && ascii <= z)
        {
            var sum = ascii + (k % z);
            if(sum > z) char = String.fromCharCode((a + sum - 1) % z);
            else char = String.fromCharCode(sum);
        }
        else if (ascii >= "A".charCodeAt(0) && ascii <= "Z".charCodeAt(0))
        {
            var sum = ascii + (k % Z);
            if(sum > Z) char = String.fromCharCode((A + sum - 1) % Z);
            else char = String.fromCharCode(sum);
        }
        output += char;
    }
    console.log(output);
}
