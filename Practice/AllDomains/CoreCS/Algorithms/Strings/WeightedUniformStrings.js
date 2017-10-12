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
    var input = readLine();
    var n = parseInt(readLine());
    var arr = [];
    var dict = {};
    for(var i = 0; i < input.length;)
    {
        var char = input[i];
        var weight = input.charCodeAt(i) - "a".charCodeAt(0) + 1;
        arr.push(weight);
        dict[weight] = char;
        var str = char;
        var j = i + 1;
        for(var k = 2; j < input.length; j++, k++)
        {
            if(input[i] != input[j]) break;
            arr.push(weight * k);
            str += input[j];
            dict[weight * k] = str;
        }
        i = j;
    }
    //console.log(dict);
    for(var a0 = 0; a0 < n; a0++){
        var x = parseInt(readLine());
        // your code goes here
        if(dict[x]) console.log('Yes');
        else console.log('No');
    }
}
