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
    var t = parseInt(readLine());
    for(var a0 = 0; a0 < t; a0++){
        var expression = readLine();
        if(areBalancedBrackets(expression)) console.log("YES");
        else console.log("NO");
    }
}

var areBalancedBrackets = function(input){
    var flag = true;
    var stack = [];
    var len = input.length;
    for(var i = 0; i < len; i++)
    {
        var char = input[i];
        if(char === '(' || char === '{' || char === '['){
            stack.push(char);
        }
        else {
            if(stack.length > 0){
                if(   (char === ')' && stack[stack.length - 1] !== '(') 
                   || (char === '}' && stack[stack.length - 1] !== '{') 
                   || (char === ']' && stack[stack.length - 1] !== '[')){
                    flag = false;
                }
                var pop = stack.pop();
            }
            else flag = false;
        }
    }
    if(flag && stack.length > 0) flag = !flag;
    return flag;
}

