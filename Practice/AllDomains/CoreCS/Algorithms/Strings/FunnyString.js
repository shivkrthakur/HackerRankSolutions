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

function funnyString(str){
    // Complete this function
    for(var j = 1, k = str.length - 2; j < str.length; j++, k--){
      if(Math.abs(str.charCodeAt(j) - str.charCodeAt(j-1)) != Math.abs(str.charCodeAt(k) - str.charCodeAt(k+1))){
        return "Not Funny";
      }
    }
    return "Funny";
}

function main() {
    var q = parseInt(readLine());
    for(var a0 = 0; a0 < q; a0++){
        var s = readLine();
        var result = funnyString(s);
        process.stdout.write("" + result + "\n");
    }

}
