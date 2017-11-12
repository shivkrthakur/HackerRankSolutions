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

function commonChild(str1, str2){
   var len = str1.length;
   var arr = new Array(len + 1);
   for(var i = 0; i < len + 1; i++){
       arr[i] = new Array(len + 1);
       for(var j = 0; j < len + 1; j++)
       {
           arr[i][j] = 0;
       }
   }

   for(var i = 1; i <= len; i++){
        for(var j = 1; j <= len; j++){
            if(str1[i-1] == str2[j-1]) arr[i][j] = arr[i - 1][j - 1] + 1;
            else arr[i][j] = Math.max(arr[i][j - 1], arr[i - 1][j]);
        }
    }
    return arr[len][len];
	
	/*
	//FAILS : solution.js:45
	//function longestCommonSubsequence(str1, str2, len1, len2, arr){
	//RangeError: Maximum call stack size exceeded
    return longestCommonSubsequence(str1, str2, len - 1, len - 1, arr);  
	*/
};

function longestCommonSubsequence(str1, str2, len1, len2, arr){
    if(len1 < 0 || len2 < 0) return 0;
    if(!arr[len1][len2]){
        if(str1[len1] == str2[len2]) arr[len1][len2] = 1 + longestCommonSubsequence(str1, str2, len1 - 1, len2 - 1, arr);
        else arr[len1][len2] = Math.max(longestCommonSubsequence(str1, str2, len1, len2 - 1, arr), longestCommonSubsequence(str1, str2, len1 - 1, len2, arr));
    }
    return arr[len1][len2];
}

function main() {
    var s1 = readLine();
    var s2 = readLine();
    var result = commonChild(s1, s2);
    process.stdout.write("" + result + "\n");

}
