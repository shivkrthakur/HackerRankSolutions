/*	author:@shivkrthakur  */
var inputArr = [];
var inputIndex = 0;

function readLine(){
    return inputArr[inputIndex++];
}
function processData(input) {
    //Enter your code here
    inputArr = input.split('\n');
    //console.log(inputArr);
    var c = parseInt(readLine());
    var dict = {};
    for(var i = 0; i < c; i++){
        var keyValue = readLine().split(' ');
        dict[keyValue[0]] = keyValue[1];
    }
    var inputString;
    do{
        if(inputString){
            if(dict[inputString]) console.log(inputString + "=" + dict[inputString]);
            else console.log("Not found");
        }
        inputString = readLine();
    }while(inputString)
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
