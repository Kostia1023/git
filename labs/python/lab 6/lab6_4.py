a = input('елементи масива через пробіл: ').split()
a1 = len(a)
a = [int(el) for el in a]
a = [el for el in a if el != 0]
a2 = len(a)
for i in range(a1-a2):
    a.append(0)
print(a)
