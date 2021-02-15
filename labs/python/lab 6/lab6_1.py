n = int(input('n = '))
a = input('(елементи вектора через пробіл) R^{0} = '.format(n)).split()
a = [float(el) for el in a]
k = 0
i2 = 0
for i1 in range(len(a)):
    if k == 1 and a[i1] < 0:
        i2 += 1
    if a[i1] > 0:
        k = 1
print(i2)


