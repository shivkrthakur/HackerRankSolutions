#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
nOfElements = int(raw_input().strip())
elements = raw_input().strip().split()
elements = map(int,elements)
#for i in range(0,nOfElements):
#    elements[i] = int(elements[i])
tup = tuple(elements)
print hash(tup)