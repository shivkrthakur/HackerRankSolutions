#/*	author:@shivkrthakur  */
inputstr = input().strip();
index = input().strip().split();
#print(index)
strlist = [x for x in inputstr]
strlist[int(index[0])] = index[1]
print("".join(strlist))
