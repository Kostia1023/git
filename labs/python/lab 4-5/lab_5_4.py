from math import sqrt
n = int(input('n = '))
x0 = 1
# # Я присвоїв х0 = 1, а не 0, як за умовою, бо при i = 4, я маю ділити на корінь з х0 тобто на 0
x1 = x2 = x3 = 7
i = 3
if n == 0:
    total = x0
elif 0 < n < 4:
    total = x1
elif n > 3:
    while i <= n:
        i += 1
        x4 = ((x3+4*x2*(1+x2)+x1)/sqrt(x0)) + x0
        x0 = x1
        x1 = x2
        x2 = x3
        x3 = x4
    total = x4
else:
    total = 'не існує з даним номером'
print('x{0} = {1}'.format(n, total))

