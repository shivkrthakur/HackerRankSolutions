#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
input, vowels = raw_input().strip(), 'AEIOU'
inputLen = len(input)
kevinSum = 0
stuartSum = 0

for x in xrange(inputLen):
    if input[x] in vowels:
        kevinSum += inputLen - x
    else:
        stuartSum += inputLen - x

if stuartSum == kevinSum:
    print "Draw"
elif stuartSum > kevinSum:
    print "Stuart", stuartSum
elif stuartSum < kevinSum:
    print "Kevin", kevinSum
