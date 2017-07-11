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
function BruteForceNSquare(money, inputArr){
  for(var i = 0; i < inputArr.length; i++){
    for(var j = i + 1; j < inputArr.length; j++){
      if(money == inputArr[i] + inputArr[j]){
        return [ i + 1, j + 1];
      }
    }
  }
}

function BruteForceON(money, inputArr){
  var dict = {};
  for(var i =0; i < inputArr.length; i++){
    var val = inputArr[i];
    var diff = money - val;
    if(dict[diff]) return [ dict[diff], i + 1 ];
    if(!dict[val]) dict[val] = i + 1;
  }
}

function BruteForceONSquare(money, inputArr){
  for(var i = 0; i < inputArr.length; i++){
    for(var j = i + 1; j < inputArr.length; j++){
      if(money == inputArr[i] + inputArr[j]){
        return [ i + 1, j + 1];
      }
    }
  }
}

function BinarySearchRecursive(left, right, inputArr, tgtVal){
    if(left > right) return;

    var mid = parseInt((left + right)/2);
    var val = inputArr[mid];
    if(tgtVal == val){
        return [];
    }
}

function BinarySearchIterative(money, inputArr){
  var len = inputArr.length;
  var temp = inputArr.slice();
  temp = temp.sort(function(x,y){ return x - y; }); //Binary Search doesn't work if the array is not Sorted.
  for(var i = 0; i < len; i++){
    var val = temp[i];
    var diff = money - val;
    var left = i + 1, right = len - 1;
    while(left <= right){
      var mid = parseInt((left + right)/2);
      var midVal = temp[mid];
      //console.log("left %d  right %d  mid %d, midVal %d", left, right, mid, midVal);
      if(midVal == diff){
        var j, k;
        for(var f = 0; f < len; f++){
          if(j == null && inputArr[f] == val) { j = f + 1; }
          if(inputArr[f] == diff) { k = f + 1; }
        }
          if(j > k) {
          var t = j;
          j = k;
          k = t;
        }
        return [ j, k ];
      }
      else if(diff < midVal) right = mid - 1;
      else if(diff > midVal) left = mid + 1;
    }
  }
}

function BinarySearchRecursive(left, right, searchVal, array){
  //console.log("%d %d  %d", left, right, searchVal);
  if(left > right) return -1;
  var mid = parseInt((left + right)/2);
  var midVal = array[mid];
  if(midVal == searchVal) return mid;
  else if(searchVal < midVal) return BinarySearchRecursive(left, mid - 1, searchVal, array);
  else return BinarySearchRecursive( mid + 1, right, searchVal, array);
}

function BinarySearchRecursion(searchVal, inputArr){
  var len = inputArr.length;
  var temp = inputArr.slice();
  temp = temp.sort(function(x,y){ return x - y; }); //Binary Search doesn't work if the array is not Sorted.
  for(var i = 0; i < len; i++){
      var ival = temp[i];
      if(searchVal < ival) continue;
      comp = searchVal - ival;
      var j = BinarySearchRecursive(i + 1, len - 1, comp, temp);
      if(j > -1){
        var jval = temp[j];
        var k, l;
        for(var f = 0; f < len; f++){
          if(k == null && inputArr[f] == ival) { k = f + 1; }
          if(inputArr[f] == jval) { l = f + 1; }
        }
        if(k > l) {
          var t = k;
          k = l;
          l = t;
        }
        return [ k, l ];
      }
  }
}

function main() {
    var t = parseInt(readLine());
    for(var a0 = 0; a0 < t; a0++){
        var m = parseInt(readLine());
        var n = parseInt(readLine());
        a = readLine().split(' ');
        a = a.map(Number);
        //console.log(BruteForceON(m,a).join(' '));
        //console.log(BruteForceONSquare(m,a).join(' '));
        //console.log(BinarySearchIterative(m, a).join(' '));
        console.log(BinarySearchRecursion(m, a).join(' '));
    }
}
