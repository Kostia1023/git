from math import hypot
a = float(input('Більша основа:'))
b = float(input("Менша основа:"))
h = float(input("Висота:"))
S = ((a+b)/2)*h
c = hypot(h, (a-b)/2)
P = a + b + 2 * c
print('Площа = {0}'.format(S))
print('Периметр = {0}'.format(P))
