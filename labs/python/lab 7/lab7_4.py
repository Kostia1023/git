n = int(input('n = '))
a = [list(map(float, input().split())) for i in range(n)]
b = [a[i][i] for i in range(n)]
b.sort()
for i in range(n):
    a[i][i] = b[i]
    print(a[i])

