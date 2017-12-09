#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
inputStr = raw_input().strip()
outputStr = ""
for i in inputStr:
    if i.islower():
        outputStr += i.upper();
    else:
        outputStr += i.lower();

print outputStr
