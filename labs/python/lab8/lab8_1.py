import math


def square(a, b, c):
    d = b ** 2 - 4 * a * c
    if d >= 0:
        x = [((-b + math.sqrt(d)) / (2 * a)),
             ((-b - math.sqrt(d)) / (2 * a))]
    else:
        x = None
    return x
    pass


a1 = float(input('a = '))
b1 = float(input('b = '))
x1_2 = square(a1, 2, 7) if a1 != 0 else [-3.5] * 2
x3_4 = square(b1, -5, 2) if b1 != 0 else [-2.5] * 2
if x3_4 is None or x1_2 is None:
    total = 'Коренів рівняння нема'
else:
    x1 = x1_2[0] in x3_4
    x2 = x1_2[1] in x3_4
    if x1 and x2:
        total = 'Корені рівняння: {0} та {1}'.format(x1_2[0], x1_2[1])
    elif x1:
        total = 'Корінь рівняння: {0}'.format(x1_2[0])
    elif x2:
        total = 'Корінь рівняння: {0}'.format(x1_2[1])
    else:
        total = 'Коренів рівняння нема'
print(total)
