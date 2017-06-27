/*	author:@shivkrthakur  */
'use strict';

var _input = '';
var _index = 0;
process.stdin.on('data', (data) => { _input += data; });
process.stdin.on('end', () => {
	_input = _input.split(new RegExp('[\n ]+'));
	main(+(_input[0]), +(_input[1]), +(_input[2]));
});

function main(mealCost, tipPercent, taxPercent) {
  //console.log([ mealCost, tipPercent, taxPercent ].join(' '));
  var tip = tipPercent/100 * mealCost;
  var tax = taxPercent/100 * mealCost;
  var totalCost = mealCost + tip + tax;
  totalCost = Math.round(totalCost);
  console.log("The total meal cost is %d dollars.", totalCost);
}
