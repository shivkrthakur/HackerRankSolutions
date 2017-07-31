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
    var arr = [];
    for(arr_i = 0; arr_i < 6; arr_i++){
       arr[arr_i] = readLine().split(' ');
       arr[arr_i] = arr[arr_i].map(Number);
    }

      var highestSum = Number.MIN_SAFE_INTEGER;
      for(var row = 0; row + 2 < arr.length; row++){
        for(var col = 0; col + 2 < arr[row].length; col++){
          var sum = 0;
          for(var r = row, d = 1; r <= row + 2 && r < arr.length; d++, r++){
            for(var c = col, e = 1; c <= col + 2 && c < arr[r].length; e++, c++){
              if((d % 2) == 0){
                if((e % 2) == 0){
                  sum += arr[r][c];
                }
              }
              else sum += arr[r][c];
            }
          }
          highestSum = Math.max(highestSum, sum);
        }
      }
      console.log(highestSum);
}
