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
    var n = parseInt(readLine());
    a = readLine().split(' ');
    a = a.map(Number);

    var swaps = 0;
    for(var i = 0; i < n; i++)
    {
        for(var j = 0; j < n - 1; j++)
        {
            if(a[j] > a[j + 1]){
                var temp = a[j];
                a[j] = a[j+1];
                a[j+1] = temp;
                swaps++;
            }
        }
    }
    console.log("Array is sorted in %d swaps.", swaps);
    console.log("First Element: %d", a[0]);
    console.log("Last Element: %d", a[n-1]);
}
