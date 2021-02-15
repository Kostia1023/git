def arithmetic_progression(b, j):
    d1 = b[j] - b[j - 1]
    d2 = b[j - 1] - b[j - 2]
    d3 = b[j - 2] - b[j - 3]
    return d1 == d2 == d3


n = int(input('n = '))
a = list(map(float, input().split()))
total = 0
for i in range(3, n):
    total += arithmetic_progression(a, i)
print('Кількість послідовно розміщених четвірок чисел,'
      ' які утворюють арифметичну прогресію: {0}'.format(total))
