from math import log
from math import cos
from math import sin
from math import e
x = float(input('x = '))
if x < 2:
    t = cos(x)
else:
    t = log(x)
if t < 0:
    total = e**t * sin(t)
else:
    total = e**t * cos(t)
print('Результат обчислень: {0}'.format(total))

