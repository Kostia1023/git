n = float(input('n = '))
i = 0
a = []
z1 = -1
z2 = 1
while i < n:
    z2 *= z1
    a.append(z2 / (i+1))
    i += 1
    z1 = ((-1) ** (i + 1)) * (i + 1)
a = [el for el in a if el > 0]
print(sum(a))
