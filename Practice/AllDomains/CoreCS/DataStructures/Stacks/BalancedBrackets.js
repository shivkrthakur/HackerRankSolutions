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

function isBalanced(s) {
    // Complete this function
    var flag = true;
    var stack = [];
    for(var j = 0; j < s.length; j++){
      var val = s[j];
      if(val == '(' || val == '{' || val == '['){
        stack.push(val);
      }
      else if(stack.length == 0 || (val == ')' && stack[stack.length - 1] != '(') || ( val == '}' && stack[stack.length - 1] != '{') || ( val == ']' && stack[stack.length - 1] != '['))
      {
        flag = false;
        break;
      }
      else stack.pop();
    }
    if(flag && stack.length == 0) return "YES";
    else return "NO";
}

function main() {
    var t = parseInt(readLine());
    for(var a0 = 0; a0 < t; a0++){
        var s = readLine();
        var result = isBalanced(s);
        process.stdout.write("" + result + "\n");
    }

}
