#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
lenArr = int(raw_input().strip())
arr = map(int,raw_input().strip().split())
#print arr
arr.sort()
print arr[lenArr - 1 - arr.count(arr[lenArr -1])]
