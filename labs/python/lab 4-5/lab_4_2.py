a = float(input('Введіть а:'))
b = float(input('Введіть b:'))
c = float(input('Ведіть с:'))
if a > b:
    maximum_a_b = a
else:
    maximum_a_b = b
if b < c:
    minimum_b_c = b
else:
    minimum_b_c = c
Sum = maximum_a_b + (minimum_b_c + maximum_a_b) ** 2
print('Результат обчислень: {0}'.format(Sum))
