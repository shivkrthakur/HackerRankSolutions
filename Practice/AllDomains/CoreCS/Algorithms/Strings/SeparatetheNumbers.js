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
    var q = parseInt(readLine());
    for(var a0 = 0; a0 < q; a0++){
        var num = readLine();
        // your code goes here
        var str = '';
        for(var k = 0; k < num.length; k++){
          str += num[k];
          //console.log(str);
          var len = str.length;
          var n = len < 16 ? parseInt(str) : str;
          var flag;
          for(var l = len - 1; l < num.length;){
            n = incrementNum(n.toString());
            //console.log('n: '  + n + '  n.length:' + n.toString().length + ' index:' + num.indexOf(n, l));
            var index = num.indexOf(n, l);
            if(index == -1 || index > l + 1) {
              flag = false;
              break;
            }
            else {  l += n.toString().length;
              flag = true;
              if(l == num.length - 1) break;
            }
          }
          if(flag) {
            console.log('YES ' + str);
            break;
          }
        }
        if(!flag) console.log('NO');
    }
}

function incrementNum(num){
    var arr = num.split('');
    var i = arr.length - 1;
    var digit = parseInt(arr[i]);
    while(i > 0 && (digit + 1) > 9){
      arr[i] = '0';
      i--;
      digit = parseInt(arr[i]);
    }
    arr[i] = (digit + 1).toString();
    //console.log(arr.join(''));
    return arr.join('');
};
