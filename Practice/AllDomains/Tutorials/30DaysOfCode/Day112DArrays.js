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
    var max = Number.MIN_SAFE_INTEGER;
    for(var i = 0; i < arr.length - 2; i++){
      for(var j = 0; j < arr.length - 2; j++){
          var sum = 0;
          var flag = true;
          for(var row = 0; row < 3; row++){
            if(flag){
              for(var col = 0; col < 3; col++){
                sum += arr[i + row][j + col];
              }
            }
            else sum += arr[i + row][j + 1]
            flag = !flag;
          }
          max = Math.max(sum, max);
      }
    }
    console.log(max);
}
