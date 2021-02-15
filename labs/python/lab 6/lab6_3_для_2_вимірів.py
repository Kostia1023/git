a = input('Координати векторів a,b,c через пробіл ( спочатку координати вектора а, потім b і відповідно с: ').split(' ')
b = []
a = [int(el) for el in a]
for i in range(2, 4):
    a[i] = int(a[i]) * 3
for i in range(4, 6):
    a[i] = int(a[i]) * 2
for i in range(2):
    b.append(a[i] - a[i + 2] + a[i + 4])
print(b)
