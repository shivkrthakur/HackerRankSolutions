#/*	author:@shivkrthakur  */
inputNumber = int(input().strip())
list = []
while inputNumber != 0:
    inputList = input().split(' ');
    if inputList[0] == 'insert':
        list.insert(int(inputList[1]),int(inputList[2]))
    elif inputList[0] == 'print':
        print(list)
    elif inputList[0] == 'remove':
        list.remove(int(inputList[1]))
    elif inputList[0] == 'append':
        list.append(int(inputList[1]))
    elif inputList[0] == 'sort':
        list.sort()
    elif inputList[0] == 'pop':
        list.pop()
    elif inputList[0] == 'reverse':
        list.reverse()
    inputNumber -= 1