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

function richieRich(s, n, counter){
    // Complete this function
    var str = s.split('');
    for(var j = 0, k = str.length - 1; j < str.length/2; j++, k--){
      var charL = str[j]; var charR = str[k];
      if(charL != charR){
          if(counter > 0){
            if(charL < charR){
              str[j] = charR;
            }
            else{
                str[k] = charL;
            } 
            counter--;
          }
          else{
            str = "-1";
            break;
          }
      }
    }
    //console.log(str);
    //console.log(counter);
    if(str != "-1"){
        for(var l = 0, r = str.length - 1; counter > 0 && l < str.length/2; l++, r--){
        if(s[l] == s[r]){
          if(counter > 1 && s[l] != '9'){
            str[l] = 9;
            str[r] = 9;
            counter -= 2;
          }
        }
        else {
          if(str[l] != 9){
            str[l] = 9;
            str[r] = 9;
            counter--;
          }
        }
      }
        
      if(counter > 0 && (str.length % 2) > 0 && (str[parseInt(str.length/2)] != 9)){
           str[parseInt(str.length/2)] = 9;
           counter--;
      }
    }

    if(Array.isArray(str)) str = str.join('');
    return str;
}

function main() {
    var input = readLine().split(' ');
    var n = parseInt(input[0]);
    var k = parseInt(input[1]);
    var s = readLine();
    var result = richieRich(s, n, k);
    process.stdout.write("" + result + "\n");

}
