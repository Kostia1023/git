n = int(input('n = '))
a = [list(map(float, input().split())) for i in range(n)]
for i1 in range(1, n):
    for i in range(i1, n):
        k = a[i][i1 - 1] / a[i1 - 1][i1 - 1]
        for j in range(n):
            a[i][j] = a[i][j] - k * a[i1 - 1][j]
for i in range(n):
    print(a[i])
