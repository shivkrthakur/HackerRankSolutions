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
    var t = parseInt(readLine());
    for(var a0 = 0; a0 < t; a0++){
        var n = parseInt(readLine());
        arr = readLine().split(' ');
        arr = arr.map(Number);
        var aux = arr.slice(0);
        console.log(mergeSort(0, n - 1, arr, aux));
    }
}

function mergeSort(l, r, arr, aux){
    var inv = 0;
    if(l < r){
        var m = parseInt((l + r)/2);
        inv += mergeSort(l, m, aux, arr);
        inv += mergeSort(m + 1, r, aux, arr);
        inv += merge(l, m, r, arr, aux);
    }
    return inv;
}

function merge(l, m, r, arr, aux){
    var inv = 0, i = l, j = m + 1, k = l;
    while(i <= m || j <= r)
    {
        if(i > m) arr[k++] = aux[j++];
        else if(j > r) arr[k++] = aux[i++];
        else if(aux[i] <= aux[j]) arr[k++] = aux[i++];
        else {
            arr[k++] = aux[j++];
            inv += j - k;
        }
    }
    return inv;
}
