#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
inputStr = raw_input().strip()
hasAlNum = False
hasAlpha = hasDigit = hasLow = hasUpp = False
for i in inputStr:
    if i.isalnum():
        hasAlNum = i.isalnum()
    if i.isalpha():
        hasAlpha = i.isalpha()
    if i.isdigit():
        hasDigit = i.isdigit()
    if i.islower():
        hasLow = i.islower()
    if i.isupper():
        hasUpp = i.isupper()

print hasAlNum
print hasAlpha
print hasDigit
print hasLow
print hasUpp
