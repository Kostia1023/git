from math import log10
from math import floor
n = float(input('n = '))
total = floor(log10(n))
#Порядок величини — це наближена міра величини числа, що дорівнює десятковому логарифму, округленому до цілого числа.
print('Порядок числа {0} = {1}'.format(n, total))
