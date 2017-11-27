/*	author:@shivkrthakur  */
'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

function getLetter(s) {
    let letter;
    // Write your code here
    switch(s.charAt(0)){
       case 'a':
       case 'e':
       case 'i':
       case 'o':
       case 'u':
            letter = 'A';
            break;
       case 'b':
       case 'c':
       case 'd':
       case 'f':
       case 'g':
            letter = 'B';
            break;
       case 'h':
       case 'j':
       case 'k':
       case 'l':
       case 'm':
            letter = 'C';
            break;
       case 'n':
       case 'p':
       case 'q':
       case 'r':
       case 's':
       case 't':
       case 'v':
       case 'w':
       case 'x':
       case 'y':
       case 'z':
            letter = 'D';
            break;
           
    }
    return letter;
}

function main() {
    const s = readLine();
    console.log(getLetter(s));
}