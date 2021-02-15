a = float(input('a='))
n = float(input('n='))
i1 = 1
total = 0
i2 = 0
denominator = a
while i1 < 2*n:
    i1 *= 2
    i2 += 1
    denominator *= (a+i2)
    total += i1 / denominator
print('Сума = {0}'.format(total))
