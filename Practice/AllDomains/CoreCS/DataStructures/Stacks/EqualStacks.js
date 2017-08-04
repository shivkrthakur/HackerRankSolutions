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
    var n1_temp = readLine().split(' ');
    var n1 = parseInt(n1_temp[0]);
    var n2 = parseInt(n1_temp[1]);
    var n3 = parseInt(n1_temp[2]);
    stack1 = readLine().split(' ').reverse();
    stack1 = stack1.map(Number);
    stack2 = readLine().split(' ').reverse();
    stack2 = stack2.map(Number);
    stack3 = readLine().split(' ').reverse();
    stack3 = stack3.map(Number);

    var sum1 = stack1.reduce((x,y) => x + y, 0);
    var sum2 = stack2.reduce((x,y) => x + y, 0);
    var sum3 = stack3.reduce((x,y) => x + y, 0);
    while(sum1 != sum2 || sum2 != sum3 || sum3 != sum1){
          if(sum1 > sum2 && sum1 > sum3){
            sum1 -= stack1.pop();
          }
          else if(sum2 > sum1 && sum2 > sum3){
            sum2 -= stack2.pop();
          }
          else if(sum3 > sum1 && sum3 > sum2){
            sum3 -= stack3.pop();
          }
          else if(sum1 == sum2 && sum1 > sum3){
            if(stack1[stack1.length - 1] < stack2[stack2.length - 1]) sum1 -= stack1.pop();
            else if(stack1[stack1.length - 1] > stack2[stack2.length - 1]) sum2 -= stack2.pop();
            else {
              sum1 -= stack1.pop();
              sum2 -= stack2.pop();
            }
          }
          else if(sum1 == sum3 && sum1 > sum2){
            if(stack1[stack1.length - 1] < stack3[stack3.length - 1]) sum1 -= stack1.pop();
            else if(stack1[stack1.length - 1] > stack3[stack3.length - 1]) sum3 -= stack3.pop();
            else {
              sum1 -= stack1.pop();
              sum3 -= stack3.pop();
            }
          }
          else if(sum2 == sum3 && sum2 > sum1){
            if(stack2[stack2.length - 1] < stack3[stack3.length - 1]) sum2 -= stack2.pop();
            else if(stack2[stack2.length - 1] > stack3[stack3.length - 1]) sum3 -= stack3.pop();
            else {
              sum2 -= stack2.pop();
              sum3 -= stack3.pop();
            }
          }
    }
    console.log(sum1);
}
