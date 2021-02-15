def element_neighbors(i, j):
    d = []
    if i+1 < n:
        d.append(a[i+1][j])
    if i-1 > -1:
        d.append(a[i-1][j])
    if j+1 < n:
        d.append(a[i][j+1])
    if j-1 > -1:
        d.append(a[i][j-1])
    return sum(d)/len(d)


n = int(input('n = '))
a = [list(map(float, input().split())) for i in range(n)]
b = [[element_neighbors(i, j) for j in range(n)]for i in range(n)]
for k in range(n):
    print(b[k])
