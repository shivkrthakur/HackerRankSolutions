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

function super_reduced_string(s){
    // Complete this function
    for(var i = 1; i < s.length;){
        if(s[i] == s[i - 1]) {
            s = s.replace(s[i] + s[i], '');
            i = 1;
        }
        else i++;
    }
    return s != '' ? s : 'Empty String';
}

function main() {
    var s = readLine();
    var result = super_reduced_string(s);
    process.stdout.write("" + result + "\n");

}
