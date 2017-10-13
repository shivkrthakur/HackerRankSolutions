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

function palindromeIndex(str){
    // Complete this function
    var lflag = false;
      var rflag = false;
      var left = -1;
      var right = -1;
      for(var i = 0, j = str.length - 1; i < str.length/2;){
        //console.log('i: ' + str[i] + ' j: ' + str[j]);
        if(str[i] != str[j]){
          if(left == -1 && right == -1){
            left = i;
            right = j;
            i++;
            lflag = true;
            rflag = false;
            //console.log('Break  ' + 'i: ' + i + ' j:  ' + j);
          }
          else{
            j = right - 1;
            i = left;
            lflag = false;
            rflag = true;
          }
        }
        else {
          i++;
          j--;
        }
      }
      if(lflag) return left;
      else if(rflag) return right;
      else return -1;
}

function main() {
    var q = parseInt(readLine());
    for(var a0 = 0; a0 < q; a0++){
        var s = readLine();
        var result = palindromeIndex(s);
        process.stdout.write("" + result + "\n");
    }
}
