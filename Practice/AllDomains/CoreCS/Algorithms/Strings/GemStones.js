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

function gemstones(input){
    // Complete this function
    var n = input.length;
    var dict = {};
    var count = 0;
    for(var i = 0; i < n; i++){
        for(var j = 0; j < input[i].length; j++){
            if((!dict[input[i][j]] && i == 0) | dict[input[i][j]] == i) {
               dict[input[i][j]] = i + 1;
               if(dict[input[i][j]] == n) count++;
            }
        }
    }
    return count;
}

function main() {
    var n = parseInt(readLine());
    var arr = [];
    for(var arr_i = 0; arr_i < n; arr_i++){
       arr[arr_i] = readLine();
    }
    var result = gemstones(arr);
    process.stdout.write("" + result + "\n");
}
