#/*	author:@shivkrthakur  */
inputStr = input().strip()
outputStr = ""
for i in inputStr:
    if i.islower():
        outputStr += i.upper();
    else:
        outputStr += i.lower();

print(outputStr)
