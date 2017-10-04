/*	author:@shivkrthakur  */
process.stdin.resume();
process.stdin.setEncoding("ascii");
var input = "";
process.stdin.on("data", function (chunk) {
    input += chunk;
});
process.stdin.on("end", function () {
    // now we can read/parse input
    var len = input.length;
    var dict = {};
    var flag = true;
    for(var i = 0; i < len; i++){
        var ascii = input.charCodeAt(i);
        var char = input[i].toUpperCase();
        if(!dict[char] && (ascii >= "a".charCodeAt(0) && ascii <= "z".charCodeAt(0)) || (ascii >= "A".charCodeAt(0) && ascii <= "Z".charCodeAt(0))){
           dict[char] = true;
           if(Object.keys(dict).length == 26){
                console.log("pangram");
                flag = false;
                break;
            }
        }
    }
    if(flag) console.log("not pangram");
});
