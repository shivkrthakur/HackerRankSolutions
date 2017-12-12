#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT
inputstr1 = raw_input().strip();
inputstr2 = raw_input().strip().split();
index = int(inputstr2[0])
outputstr = inputstr1[0:index] + inputstr2[1] + inputstr1[index+1:len(inputstr1)]
print outputstr
#print inputstr1[index+1:len(inputstr1)]
#print("".join(strlist))
