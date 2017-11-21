#/*	author:@shivkrthakur  */
# Enter your code here. Read input from STDIN. Print output to STDOUT

inputNumber = int(raw_input().strip())
list = []
while inputNumber != 0:
    input = raw_input().split(' ');
    if input[0] == 'insert':
        list.insert(int(input[1]),int(input[2]))
    elif input[0] == 'print':
        print list
    elif input[0] == 'remove':
        list.remove(int(input[1]))
    elif input[0] == 'append':
        list.append(int(input[1]))
    elif input[0] == 'sort':
        list.sort()
    elif input[0] == 'pop':
        list.pop()
    elif input[0] == 'reverse':
        list.reverse()
    inputNumber -= 1
    