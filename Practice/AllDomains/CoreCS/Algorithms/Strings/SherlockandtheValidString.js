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

function isValid(str){
    // Complete this function
      var dict = {};
      for(var j = 0; j < str.length; j++){
        if(dict[str[j]]) dict[str[j]]++;
        else dict[str[j]] = 1;
      }

      var dict2 = {};
      for(var item in dict){
          if(dict2[dict[item]])dict2[dict[item]]++;
          else dict2[dict[item]] = 1;
      }

      var flag = false;
      if(Object.keys(dict2).length <= 2){
        var keys = Object.keys(dict2);
        if(keys.length == 2){
          if((dict2[keys[0]] == 1 && (Math.abs(keys[0] - keys[1]) == 1 || keys[0] == 1)) || (dict2[keys[1]] == 1 && (Math.abs(keys[0] - keys[1]) == 1 || keys[1] == 1))){
            flag = true;
          }
          else flag = false;
        }
        else flag = true;
      }
      if(flag) return 'YES';
      else return 'NO';
}

function main() {
    var s = readLine();
    var result = isValid(s);
    process.stdout.write(""+result+"\n");

}
