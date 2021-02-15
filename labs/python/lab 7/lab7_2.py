ni = int(input('i = '))
nj = int(input('j = '))
a = [[1/(i+j) for j in range(1, nj+1)] for i in range(1, ni+1)]
s = 0
for i in range(ni):
    for j in range(nj):
        if (i+j) % 2 == 1:
            s += a[i][j]
print('Сума таких елементів = {0}'.format(s))
