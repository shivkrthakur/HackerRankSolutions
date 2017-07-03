/*	author:@shivkrthakur  */
function processData(input) {
    //Enter your code here
    var inputArr = input.split('\n').map(Number);
    for(var i = 1; i < inputArr.length; i++){
      if(isPrime(inputArr[i])) console.log('Prime');
      else console.log('Not prime');
    }
}

function isPrime(n){
    if(n > 1 && n % 2 > 0){
        var sqrt = Math.floor(Math.sqrt(n));
        for(var i = 3; i <= sqrt; i += 2){
            if(n % i == 0) return false;
        }
        return true;
    }
    else return (n === 2);
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
