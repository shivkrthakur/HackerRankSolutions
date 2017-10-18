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

function twoStrings(str1, str2){
    // Complete this function
    for(var j = "a".charCodeAt(0); j <= "z".charCodeAt(0); j++){
      var char = String.fromCharCode(j);
      if(str1.indexOf(char) > -1 && str2.indexOf(char) > -1) {
        return "YES";
      }
    }
    return "NO";
}

function main() {
    var q = parseInt(readLine());
    for(var a0 = 0; a0 < q; a0++){
        var s1 = readLine();
        var s2 = readLine();
        var result = twoStrings(s1, s2);
        process.stdout.write("" + result + "\n");
    }
}
