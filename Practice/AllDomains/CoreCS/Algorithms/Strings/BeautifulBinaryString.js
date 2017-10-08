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

function minSteps(n, B){
    // Complete this function
    var str = B.split("010").join("");
    var len = str.length;
    return (n - len)/3;
}

function main() {
    var n = parseInt(readLine());
    var B = readLine();
    var result = minSteps(n, B);
    process.stdout.write(""+result+"\n");

}
