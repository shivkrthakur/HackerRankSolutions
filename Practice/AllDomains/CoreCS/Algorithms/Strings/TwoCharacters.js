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

function maxLen(n, s){
    // Complete this function
    var chars = {};
    var map = {};
    var oLen = 0;
    for(var c in s) chars[s[c]] = true;
    for(var i in chars){
        for(var j in chars){
            if(i == j | map[i + j] | map[j + i]) continue;
            map[i + j] = true;
            map[j + i] = true;
            var str = '';
            for(var c in s) if(s[c] == i | s[c] == j) str += s[c];
            if(str.indexOf(i + i) == -1 && str.indexOf(j + j) == -1) oLen = Math.max(oLen, str.length);                        
        }
    }
    return oLen;
}

function main() {
    var n = parseInt(readLine());
    var s = readLine();
    var result = maxLen(n, s);
    process.stdout.write(""+result+"\n");
}
