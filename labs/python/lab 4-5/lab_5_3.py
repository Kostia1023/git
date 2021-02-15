from math import pi, cos, fabs
epsilon = float(input('Задана точність:'))
x = float(input('x = '))
n = 1
i = 1 - (4 * (x ** 2)) / (((2 * n - 1) ** 2) * pi ** 2)
total = i
while fabs(i) > epsilon:
    total *= i
    n += 1
total_cos = cos(x)
print('cos({0}) = {1}'.format(x, total_cos))
print('total = {0}'.format(total))
