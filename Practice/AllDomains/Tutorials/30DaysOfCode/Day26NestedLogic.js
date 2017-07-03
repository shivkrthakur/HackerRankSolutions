/*	author:@shivkrthakur  */
function processData(input) {
    //Enter your code here
    input = input.split('\n');
    var aD = input[0].split(' ').map(Number);
    var eD = input[1].split(' ').map(Number);

    var ad = aD[0];
    var am = aD[1];
    var ay = aD[2];

    var ed = eD[0];
    var em = eD[1];
    var ey = eD[2];

    var fine = 0;
    if(ad > ed && am <= em && ay == ey){
        fine += 15 * (ad - ed);
    }
    else if(am > em && ay == ey){
        fine += 500 * (am - em);
    }
    else if(ay > ey){
        fine += 10000;
    }
    console.log(fine);
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
