/*	author:@shivkrthakur  */
def array_left_rotation(a, n, k):
    b = []
    for i in range(0,n):
        index = (n + k + i) % n
        b.append(a[index])
    return b

n, k = map(int, input().strip().split(' '))
a = list(map(int, input().strip().split(' ')))
answer = array_left_rotation(a, n, k);
print(*answer, sep=' ')
