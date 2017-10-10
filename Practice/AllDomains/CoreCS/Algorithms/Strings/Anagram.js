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

function anagram(str){
    // Complete this function
    var strLen = str.length;
    if(strLen % 2 > 0) return -1;
    else{
      var dict = {};
      var count = 0;
      for(var j = 0; j < strLen; j++){
        var char = str[j];
        //console.log('char: ' + char + ' j:' + j);
        //console.log('char: ' + char + ' j:' + j + ' strLen/2: ' + strLen/2);
        if(j >= (strLen/2)){
          if(!dict[char] || dict[char] <= 0) count++;
          else dict[char]--;
        }
        else {
          if(dict[char])dict[char]++;
          else dict[char] = 1;
        }
      }
      return count;
    }
}

function main() {
    var q = parseInt(readLine());
    for(var a0 = 0; a0 < q; a0++){
        var s = readLine();
        var result = anagram(s);
        process.stdout.write("" + result + "\n");
    }

}
