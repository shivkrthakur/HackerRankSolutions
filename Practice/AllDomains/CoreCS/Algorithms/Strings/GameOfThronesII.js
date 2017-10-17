/*	author:@shivkrthakur  */
function modularMultiplication(a, b, mod) {
    var radix = 31623; 
    var ra = a % radix;
    var rb = b % radix;
    var da = Math.floor(a / radix);
    var db = Math.floor(b / radix);
    var res = 0;
    var tmp = (((da * db) % mod) * ((radix * radix) % mod)) % mod;
    res += tmp;
    tmp = (((((da * rb) % mod) + ((db * ra) % mod)) % mod) * radix) % mod;
    res += tmp;
    res %= mod;
    tmp = (ra * rb) % mod;
    res += tmp;
    res %= mod;
    return res;
}

function modularDivision(a, b, m){
    
    return modularMultiplication(a,modularExponentiation(b, (m - 2), m), m);
}

function modularExponentiation(x, y, m){
    var result = 1;
    x = x % m;
    while(y > 0) {
        if((y & 1) > 0) result = modularMultiplication(result,x, m);
        y >>= 1;
        x = modularMultiplication(x,x, m);
    }
    return result;
}

function recursiveFactorial(val, mod){
    if(val == 0) return 1;
    var temp = factorial(val -1, mod) % mod;
    return ((val % mod) * (temp % mod)) % mod;
}

function factorial(val, mod){
    var result = 1;
    for(var i = val; i > 0; i--){
        result = modularMultiplication(result, i, mod);
    }
    return result;
}

function processData(str) {
    //Enter your code here
    var mod = 1000000007;
    var char = [];
    for(var k = 0; k < str.length; k++){
      var index = str.charCodeAt(k) - 'a'.charCodeAt(0);
      if(char[index]) char[index]++;
      else char[index] = 1;
    }
    var den = 1;
    for(var l = 0; l < char.length; l++){
      if(char[l]) 
      {
          var temp = parseInt(char[l]/2);
          var fact = factorial(temp, mod) % mod;
          den = modularMultiplication(den, fact, mod);
      }
    }
    var sum = parseInt(str.length/2);
    var sumFact = factorial(sum, mod);
    //console.log('sum: ' + sum + ' sumFact: ' + sumFact + ' den: ' + den);
    console.log((modularDivision(sumFact,den, mod)));
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
