#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
sAndM = [ [raw_input(), float(raw_input().strip())] for a in range((int(raw_input().strip()) ))]
snm = [a[1] for a in sAndM]
snm.sort()
firstCount = snm.count(snm[0])
secLow = snm[firstCount]
snm = [ a for a in sAndM if a[1] == secLow]
snm.sort()
for x in snm:
    print x[0]
         
                             
