/*	author:@shivkrthakur	*/
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
    var a = [];
    for(a_i = 0; a_i < n; a_i++){
       a[a_i] = readLine().split(' ');
       a[a_i] = a[a_i].map(Number);
    }
    var dia1Sum = 0, dia2Sum = 0;
	for(let row = 0, col1 = 0, col2 = n - 1; row < n; row++, col1++, col2--){
	  dia1Sum += a[row][col1];
	  dia2Sum += a[row][col2];
	}
    console.log(Math.abs(dia1Sum - dia2Sum));
}
