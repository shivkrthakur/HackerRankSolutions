/*	author:@shivkrthakur  */
var index = 0;
var inputArr = [];
function readLine(){
    return inputArr[index++];
}
function processData(input) {
    //Enter your code here
    inputArr = input.split('\n');
    var t = parseInt(readLine());
    for(var i = 0; i < t; i++){
        var ip = readLine();
        var evenArr = [];
        var oddArr = [];
        var flag = true;
        for(var j = 0; j < ip.length; j++){
            if(flag) evenArr.push(ip[j]);
            else oddArr.push(ip[j]);
            flag = !flag;
        }
        console.log(evenArr.join("") + " " + oddArr.join(""));
    }
}

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
