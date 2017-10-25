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

function sherlockAndAnagrams(input){
    // Complete this function
    var count = 0;
    var map = {};
    for(var j = 0; j < input.length; j++)
    {
        for(var k = j + 1; k <= input.length; k++)
        {
            var str = input.substring(j, k).split('').sort().join('');
            if(map[str] != undefined) {
               count += map[str];
               map[str]++;
            }
            else map[str] = 1;
        }
    }
    return count;
}

function sherlockAndAnagramsTimesOut(input){
    // Complete this function
      var count = 0;
      for(var i = 0; i < input.length; i++)
      {
        for(var j = 1; j <= input.length - i; j++)
        {
            var str1 = input.substring(i,i + j);
            for(var k = i + 1; k <= input.length - str1.length; k++)
            {
                var str2 = input.substring(k,k + str1.length);
                if(str1.split('').sort().join('') == str2.split('').sort().join('')) count++;
            }
        }
      }
      return count;
}

function main() {
    var q = parseInt(readLine());
    for(var a0 = 0; a0 < q; a0++){
        var s = readLine();
        var result = sherlockAndAnagrams(s);
        process.stdout.write("" + result + "\n");
    }
}
