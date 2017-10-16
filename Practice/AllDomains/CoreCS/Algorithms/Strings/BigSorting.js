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
    var unsorted = [];
    for(var unsorted_i = 0; unsorted_i < n; unsorted_i++){
       unsorted[unsorted_i] = readLine();
    }
    // your code goes here
    unsorted.sort(function(a,b){ 
        if(a.length == b.length){
            for(var i = 0; i < a.length; i++){
                if(parseInt(a[i]) > parseInt(b[i])) return 1;
                if(parseInt(a[i]) < parseInt(b[i])) return -1;
            }
        }
        else return a.length - b.length;
    });
    console.log(unsorted.join('\n'));
}
