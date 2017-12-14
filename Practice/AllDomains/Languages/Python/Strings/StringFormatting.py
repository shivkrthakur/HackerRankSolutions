#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
input = int(raw_input().strip())
binValLen = len(bin(input).lstrip('0b'))
for i in range(1,input+1):
    print str(i).rjust(binValLen), oct(i).lstrip('0').rjust(binValLen), hex(i).lstrip('0x').upper().rjust(binValLen), bin(i).lstrip('0b').rjust(binValLen)