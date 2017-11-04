/*	author:@shivkrthakur  */
var bearAndSteadyGene = function(input){
	var len = input.length;
	var limit = len/4;
	var overSize = 0;
	var overChars = { 'A': 0, 'C': 0, 'G': 0, 'T': 0 };
	var curChars = { 'A': 0, 'C': 0, 'G': 0, 'T': 0 };
	for(var i = 0; i < len; i++){
	  overChars[input[i]]++;
	  if(overChars[input[i]] > limit) overSize++;
	}

	Object.keys(overChars).forEach(function(key){
	   overChars[key] = Math.max(overChars[key] - limit, 0);  
	});

	var left = 0;
	while(left < overSize) curChars[input[left++]]++;

	var right = left;
	var output = Infinity;
	for(left = 0; left <= len - overSize && right < len;){
		if(curChars['A'] >= overChars['A'] && curChars['C'] >= overChars['C'] && curChars['G'] >= overChars['G'] && curChars['T'] >= overChars['T']){
			output = Math.min(output, (curChars['A'] + curChars['C'] + curChars['G'] + curChars['T']));
			curChars[input[left++]]--;
		} 
		else curChars[input[right++]]++;
	}          
	console.log(output);
}

function processData(input) {
    var arr = input.split('\n');
    bearAndSteadyGene(arr[1]);
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
