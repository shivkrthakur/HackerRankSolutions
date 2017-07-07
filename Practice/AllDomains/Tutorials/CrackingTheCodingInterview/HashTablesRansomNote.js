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
    var m_temp = readLine().split(' ');
    var m = parseInt(m_temp[0]);
    var n = parseInt(m_temp[1]);
    arrM = readLine().split(' ');
    arrN = readLine().split(' ');

    var dict = {};
    for(var i = 0; i < arrM.length; i++){
        if(dict[arrM[i]]) dict[arrM[i]]++;
        else dict[arrM[i]] = 1;
    }
    var flag = true;
    for(var i = 0; i < arrN.length; i++){
        if(dict[arrN[i]] && dict[arrN[i]] > 0) dict[arrN[i]]--;
        else {
            flag = false;
            break;
        }
    }
    console.log(flag ? "Yes" : "No");
}
