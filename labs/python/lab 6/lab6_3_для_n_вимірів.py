n = int(input('n = '))
a = input('Координати векторів a,b,c через пробіл ( спочатку координати вектора а, потім b і відповідно с: ').split(' ')
b = []
a = [int(el) for el in a]
for i in range(n, 2*n):
    a[i] = int(a[i]) * 3
for i in range(2*n, 3*n):
    a[i] = int(a[i]) * 2
for i in range(n):
    b.append(a[i] - a[i + n] + a[i + 2 * n])
print(b)
