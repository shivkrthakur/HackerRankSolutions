/*	author:@shivkrthakur  */
var index = 0;

function readLine(input){
    return input[index++];
}

function processData(input) {
    //Enter your code here
    var q = parseInt(readLine(input));
    var sb = '';
    var stack = [];
    for(var i = 0; i < q; i++){
        var val = readLine(input).split(' ');
        var op = parseInt(val[0]);
        switch(op){
          case 1:
            var str = val[1];
            sb += str;
            stack.push(val);
            break;
          case 2:
            var c = parseInt(val[1]);
            stack.push([op, sb.substring(sb.length - c, sb.length)]);
            sb = sb.substring(0,sb.length - c);
            break;
          case 3:
            var index = parseInt(val[1]);
            console.log(sb[index - 1]);
            break;
          case 4:
            var p = stack.pop();
            if(p[0] == '1'){
              var s1 = p[1];
              sb = sb.substring(0, sb.length - s1.length);
            }
            if(p[0] == '2'){
              sb += p[1];
            }
            break;
        }
    }
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input.split('\n'));
});
