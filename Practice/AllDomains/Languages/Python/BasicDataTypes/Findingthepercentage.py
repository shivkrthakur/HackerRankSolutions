#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
dict = {}
for i in range(int(raw_input().strip())):
    arr = raw_input().strip().split()
    name = arr[0]
    arr = [float(i) for i in arr[1:len(arr)]]
    #print arr
    dict[name] = sum(arr)/len(arr) 
    #print dict

print "%.2f" % round(dict[raw_input().strip()],2)
    


