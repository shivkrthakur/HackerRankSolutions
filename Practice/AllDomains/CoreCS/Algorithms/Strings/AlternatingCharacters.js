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

function alternatingCharacters(s){
    // Complete this function
    var deletions = 0;
    for(var i = 1; i < s.length;){
        if(s[i] == s[i - 1]){
            s = s.slice(0,i) + s.slice(i + 1);
            deletions++;
        }
        else i++;
    }
    return deletions;
}

function main() {
    var q = parseInt(readLine());
    for(var a0 = 0; a0 < q; a0++){
        var s = readLine();
        var result = alternatingCharacters(s);
        process.stdout.write("" + result + "\n");
    }
}
