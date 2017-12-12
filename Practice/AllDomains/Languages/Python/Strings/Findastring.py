#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
inputStr = raw_input()
subStr = raw_input()
#print inputStr
count = 0
index = -1

while True:
    index = inputStr.find(subStr, index + 1)
    if index == -1:
        break
    else:
        count += 1

print count