n = int(input('n = '))
a = [list(map(float, input().split())) for i in range(n)]
a = a[::2]
a = [el[::2] for el in a]
a = [[el1 for el1 in el if el1 < 0] for el in a]
s = 0
for i in range(len(a)):
    s += len(a[i])
print('Кількість таких елементів = {0}'.format(s))
