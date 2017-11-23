#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to ST
x, y, z, n = int(raw_input()), int(raw_input()), int(raw_input()), int(raw_input())
print [[a,b,c] for a in range(x+1) for b in range(y+1) for c in range(z+1) if a + b + c != n ]

